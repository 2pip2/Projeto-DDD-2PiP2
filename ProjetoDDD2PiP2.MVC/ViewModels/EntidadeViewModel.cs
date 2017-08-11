using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoDDD2PiP2.MVC.ViewModels
{
    public class EntidadeViewModel
    {
        [Key]
        public string EntidadeId { get; set; }
        [Required(ErrorMessage ="Preencha o campo Nome")]
        [MaxLength(150,ErrorMessage ="Máximo de {0} caracteres")]
        [MinLength(2,ErrorMessage ="Mínimo de {0} caracteres")]
        public string PalavraChave { get; set; }        
        
    }
}
