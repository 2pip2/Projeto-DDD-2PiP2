using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDD2PiP2.MVC.ViewModels
{
    public class SoluctionViewModel
    {
        [Key]
        public string SoluctionId { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(150, ErrorMessage = "Máximo de {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} caracteres")]
        public string Soluciton { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(350, ErrorMessage = "Máximo de {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} caracteres")]
        public string Scope { get; set; }
        [DataType(DataType.Currency)]
        [Range(typeof(decimal),"0","99999999999")]
        [Required(ErrorMessage = "Preencha um valor")]        
        public decimal Price { get; set; }
        [DisplayName("Disponível")]
        public bool Activate { get; set; }
        [DisplayName("URL")]
        public string url { get; set; }
        [DisplayName("Logo")]
        public byte[] Image { get; set; }
        //public int DeveloperId { get; set; }
        //public int PersonaId { get; set; }
        //public int EntidadeId { get; set; }
        //public virtual IEnumerable<Developers> Developers { get; set; }
        //public virtual PersonaViewModel Persona { get; set; }
        //public virtual EntidadeViewModel Entidade { get; set; }
    }
}
