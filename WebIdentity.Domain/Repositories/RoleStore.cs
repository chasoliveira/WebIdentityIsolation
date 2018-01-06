using WebIdentity.Domain.Models;
using IdentityEF = Microsoft.AspNet.Identity.EntityFramework;
namespace WebIdentity.Domain.Repositories
{
    public class RoleStore : IdentityEF.RoleStore<Role, int, UserRole>
    {
        public RoleStore(ApplicationDbContext context) : base(context)
        {
        }
    }
}
