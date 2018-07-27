using BaltBetService.DAL;
using BaltBetService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace BaltBetService
{
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
