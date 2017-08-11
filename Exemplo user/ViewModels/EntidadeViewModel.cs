using System.ComponentModel.DataAnnotations;

namespace Portal2pip2.MVC.ViewModels
{
    public class EntidadeViewModel
    {
        [Key]
        public int EntidadeId { get; set; }
        [Required(ErrorMessage ="Preencha o campo Nome")]
        [MaxLength(150,ErrorMessage ="Máximo de {0} caracteres")]
        [MinLength(2,ErrorMessage ="Mínimo de {0} caracteres")]
        public string PalavraChave { get; set; }        
        
    }
}
