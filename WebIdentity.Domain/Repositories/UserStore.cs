using WebIdentity.Domain.Models;
using IdentityEF = Microsoft.AspNet.Identity.EntityFramework;

namespace WebIdentity.Domain.Repositories
{
    public class UserStore : IdentityEF.UserStore<User, Role, int, UserLogin, UserRole, UserClaim>
    {
        public UserStore(ApplicationDbContext context) : base(context)
        {

        }
    }

}
