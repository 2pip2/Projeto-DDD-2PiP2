using System.ComponentModel.DataAnnotations;

namespace Portal.Infra.CrossCutting.Identity.Model
{
    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Lembrar este browser!?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }
}