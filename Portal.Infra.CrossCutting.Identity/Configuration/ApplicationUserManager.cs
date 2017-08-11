using Microsoft.AspNet.Identity;
using Portal.Infra.CrossCutting.Identity.Model;

namespace Portal.Infra.CrossCutting.Identity.Configuration
{
    public class ApplicationUserManager : UserManager<ApplicationUser>
    {
        public ApplicationUserManager(IUserStore<ApplicationUser> store):base(store)
        {
            //Configurand validador para o nome do usuário
            UserValidator = new UserValidator<ApplicationUser>(this)
            {
                AllowOnlyAlphanumericUserNames = false,
                RequireUniqueEmail =true
            };
            //Logica de validação e complexidade da senha
            PasswordValidator = new PasswordValidator
            {
                RequiredLength = 6,
                RequireNonLetterOrDigit=false,
                RequireDigit=false,
                RequireLowercase=false,
                RequireUppercase=false
            };

        }
    }
}
