using BaltBetService.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using BaltBetWeb.UserServiceReference;

namespace BaltBetWeb
{
    public class UserStore : IUserStore<User, int>
    {
        public UserServiceClient userClient;
        public static UserStore Create()
        {
            return new UserStore();
        }
        public UserStore()
        {
            userClient = new UserServiceClient();
        }
        public Task CreateAsync(User user)
        {
            return userClient.CreateAsync(user);
        }

        public Task DeleteAsync(User user)
        {
            return userClient.DeleteAsync(user);
        }

        public void Dispose()
        {
            userClient.Close();
        }

        public Task<User> FindByIdAsync(int userId)
        {
            return userClient.FindByUserIdAsync(userId);
        }

        public Task<User> FindByNameAsync(string userName)
        {
            return userClient.FindByNameAsync(userName);
        }

        public Task UpdateAsync(User user)
        {
            return userClient.UpdateAsync(user);
        }
        
    }
}