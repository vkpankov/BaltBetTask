using ServiceContracts.DAL;
using ServiceContracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace ServiceContracts
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class UserService : IUserService
    {
        private UsersContext db = new UsersContext();
        public List<User> GetUsers(int pageNumber, int pageSize)
        {
            IQueryable<User> users = db.Users;
            return users.OrderBy(x=>x.Id)
                .Skip(pageSize*(pageNumber-1))
                .Take(pageSize).ToList();
        }
        public void Create(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }        
        public User FindByName(string userName)
        {
            var user = db.Users.Where(
                x => (x.UserName == userName))
                .SingleOrDefault();
            return user;
        }

        public void Delete(User user)
        {
            db.Users.Remove(user);
            db.SaveChanges();
        }

        public User FindByUserId(int id)
        {
            return db.Users.Find(id);
        }

        public void Update(User user)
        {
            var updateUser = db.Users.Find(user.Id);
            if (updateUser != null)
            {
                updateUser = user;
                db.SaveChanges();
            }
        }
    }
}
