using System.ComponentModel.DataAnnotations;

namespace Portal.Infra.CrossCutting.Identity.Model
{
    public class SetPasswordViewModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "A {0} deve ter {2} caracteres longos", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Nova Senha")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirme nova senha")]
        [Compare("NewPassword", ErrorMessage = "A nova senha não corresponde com a confirmação!")]
        public string ConfirmPassword { get; set; }
    }
}