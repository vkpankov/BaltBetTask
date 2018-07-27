using BaltBetService.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Web.UserServiceReference;

namespace BaltBetWeb
{
    public class UserStore : IUserStore<User, int>,
        IUserPasswordStore<User, int>
    {
        public UserServiceClient userClient;
        public UserStore()
        {
            userClient = new UserServiceClient();
        }
        public static UserStore Create()
        {
            return new UserStore();
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
        public Task<string> GetPasswordHashAsync(User user)
        {
            return Task.FromResult(user.Password);
        }

        public Task<bool> GetTwoFactorEnabledAsync(User user)
        {
            return Task.FromResult(false);
        }
        public Task<bool> HasPasswordAsync(User user)
        {
            return Task.FromResult(user.Password != null);
        }
        public Task SetPasswordHashAsync(User user, string passwordHash)
        {
            user.Password = passwordHash;
            return userClient.UpdateAsync(user);
        }
        public Task UpdateAsync(User user)
        {
            return userClient.UpdateAsync(user);
        }
    }
}