using BaltBetService.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Логин")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Display(Name = "Запомнить?")]
        public bool RememberMe { get; set; }
    }
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Пол")]
        public Sex Sex { get; set; }

        [Required]
        [Range(minimum:18,maximum:200, ErrorMessage ="Недопустимый возраст")]
        [Display(Name = "Возраст")]
        public int Age { get; set; }

        [Required]
        [StringLength(maximumLength: 8, MinimumLength =1,ErrorMessage ="Логин должен быть длиной 1-8 символов")]
        [RegularExpression(@"^[0-8a-zA-Z]+$", ErrorMessage = "Логин должен состоять только из латинских букв и цифр")]
        [Display(Name = "Логин")]
        public string UserName { get; set; }

        [Required]
        [StringLength(maximumLength: 30,ErrorMessage = "Фамилия не должна содержать более 30 символов")]
        [RegularExpression(@"^[а-яА-Я]+$", ErrorMessage = "Фамилия должна состоять только из русских букв")]
        [Display(Name = "Фамилия")]
        public string LastName { get; set; }

        [Required]
        [StringLength(maximumLength: 30, ErrorMessage = "Имя не должно содержать более 30 символов")]
        [RegularExpression(@"^[а-яА-Я]+$", ErrorMessage = "Имя должно состоять только из русских букв")]
        [Display(Name = "Имя")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Серия и номер паспорта (слитно)")]
        [Range(1000000000, 9999999999)]
        public System.UInt64 Passport { get; set; }

        [Required]
        [StringLength(maximumLength: 8,MinimumLength = 4, ErrorMessage = "Пароль должен состоять из 4-8 символов")]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Подтверждение пароля")]
        [Compare("Password", ErrorMessage = "Введенные пароли не совпадают")]
        public string ConfirmPassword { get; set; }
    }
}
