using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BaltBetService.Models
{
    public enum Sex { Male,Female};
    public class User : IUser<int>
    {
        [Key]
        public int ID { get; set; }
        public string UserName { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public Sex Sex { get; set; }
        public UInt64 Passport { get; set; }
        public string Password { get; set; }

    }
}