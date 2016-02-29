namespace Accedia.Web.ViewModels.Account
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Web;
    using Validators;
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Паролата {0} трябва да е най-малко {2} символа.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Парола")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Потвърди паролата")]
        [Compare("Password", ErrorMessage = "Паролите не съвпадат.")]
        public string ConfirmPassword { get; set; }

        public bool IsCompany { get; set; }

        [Required]
        [Display(Name = "Име(Фирма)")]
        public string Company { get; set; }

        public HttpPostedFileBase UploadImage { get; set; }

        [Display(Name = "ИН(булстат)")]
        public string INNumber { get; set; }

        [Display(Name = "ИН по ДДС")]
        public string TaxNo { get; set; }

        [Display(Name = "М.О.Л.")]
        public string MOL { get; set; }

        [Display(Name = "Населено място")]
        public int TownID { get; set; }

        [Display(Name = "Адрес")]
        public string Address { get; set; }

        [Display(Name = "Телефон")]
        [DataType(DataType.PhoneNumber)]
        //[RegularExpression(@"^(\d{10})$", ErrorMessage = "Моля въведете коректен телефонен номер!")]
        public string Phone { get; set; }

        [EmailAddress]
        [Display(Name = "Допълнителен Email")]
        public string Email2 { get; set; }

        [Display(Name = "Skype")]
        public string Skype { get; set; }

        [DisplayName("Разрешавам посочените от мен данни, да бъдат достъпни до контрагенти при изпращане или получаване на пратки от или до мен.")]
        [MustBeTrue(ErrorMessage = "Моля отбележете, че посочените от мен данни, да бъдат достъпни!")]
        public bool PrivateDataConditions { get; set; }

        [DisplayName("Съгласен съм с условията за ползване.")]
        [MustBeTrue(ErrorMessage = "Моля съгласете се с условията за ползване!")]
        public bool TermsAndConditions { get; set; }
    }
}
