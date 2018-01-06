using IdentityEF = Microsoft.AspNet.Identity.EntityFramework;

namespace WebIdentity.Domain.Models
{
    public class UserLogin : IdentityEF.IdentityUserLogin<int> { }

}
