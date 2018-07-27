using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;



namespace BaltBetService.Models
{
    public enum Sex {
        [Description("М")]
        Male,
        [Description("Ж")]
        Female };
    public class User : IUser<int>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public Sex Sex { get; set; }
        public UInt64 Passport { get; set; }
        public string Password { get; set; }

    }
}