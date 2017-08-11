using System.ComponentModel.DataAnnotations;

namespace Portal.Infra.CrossCutting.Identity.Model
{
    public class RoleViewModel
    {
        public string Id { get; set; }
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Nome da Regra")]
        public string Name { get; set; }
    }
}