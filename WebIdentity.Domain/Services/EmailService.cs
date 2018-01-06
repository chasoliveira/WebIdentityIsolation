using System.Threading.Tasks;
using Identity = Microsoft.AspNet.Identity;

namespace WebIdentity.Domain.Services
{
    public class EmailService : Identity.IIdentityMessageService
    {
        public Task SendAsync(Identity.IdentityMessage message)
        {
            // Plug in your email service here to send an email.
            return Task.FromResult(0);
        }
    }
}
