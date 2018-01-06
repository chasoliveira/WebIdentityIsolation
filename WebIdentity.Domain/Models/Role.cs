using IdentityEF = Microsoft.AspNet.Identity.EntityFramework;

namespace WebIdentity.Domain.Models
{
    public class Role : IdentityEF.IdentityRole<int, UserRole>
    {
        public Role() { }
        public Role(string name) { Name = name; }
    }

}
