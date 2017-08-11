using System.ComponentModel.DataAnnotations;

namespace Portal.Infra.CrossCutting.Identity.Model
{
    public class AddPhoneNumberViewModel
    {
        [Required]
        [Phone]
        [Display(Name = "Número de telefone")]
        public string Number { get; set; }
    }
}