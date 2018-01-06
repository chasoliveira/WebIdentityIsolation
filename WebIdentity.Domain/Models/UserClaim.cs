using IdentityEF = Microsoft.AspNet.Identity.EntityFramework;

namespace WebIdentity.Domain.Models
{
    public class UserClaim : IdentityEF.IdentityUserClaim<int> { }

}
