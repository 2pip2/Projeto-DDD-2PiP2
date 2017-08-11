using System.ComponentModel.DataAnnotations;

namespace Portal.Infra.CrossCutting.Identity.Model
{
    public class VerifyPhoneNumberViewModel
    {
        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Número do telefone")]
        public string PhoneNumber { get; set; }
    }
}