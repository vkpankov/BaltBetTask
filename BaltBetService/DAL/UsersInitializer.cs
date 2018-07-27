using BaltBetService.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BaltBetService.DAL
{
    public class UsersInitializer : DropCreateDatabaseIfModelChanges<UsersContext>
    {
        protected override void Seed(UsersContext context)
        {
            var testUsers = new List<User>
            {
                new User{ Age = 20, FirstName = "Ivan", LastName = "Ivanov",
                    Sex = Sex.Male, Password="test", UserName="test", Passport =4511223344}
            };
            testUsers.ForEach(user => context.Users.Add(user));
            context.SaveChanges();
        }
    }
}