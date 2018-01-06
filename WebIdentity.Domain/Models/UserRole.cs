using IdentityEF = Microsoft.AspNet.Identity.EntityFramework;

namespace WebIdentity.Domain.Models
{
    public class UserRole : IdentityEF.IdentityUserRole<int> { }
}
