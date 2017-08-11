using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDD2PiP2.MVC.ViewModels
{
    public class DeveloperViewModel
    {
        [Key]
        public string DeveloperId { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(150, ErrorMessage = "Máximo de {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} caracteres")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(150, ErrorMessage = "Máximo de {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} caracteres")]
        public string LastName { get; set; }
        [DisplayName("Inativo")]
        public bool Activated { get; set; }
        [ScaffoldColumn(false)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [EmailAddress(ErrorMessage = "Preencha com um email válido")]
        [DisplayName("E-mail")]
        public string email { get; set; }
        [ScaffoldColumn(false)]
        public DateTime CreateDate { get; set; }

    }
}
