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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUserService" in both code and config file together.
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        List<User> GetUsers(int pageNumber, int pageSize);
        [OperationContract]
        void Create(User user);
        [OperationContract]
        void Delete(User user);
        [OperationContract]
        User FindByName(string userName);
        [OperationContract]
        User FindByUserId(int id);
        [OperationContract]
        void Update(User user);

    }
}
