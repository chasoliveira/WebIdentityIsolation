using System.Threading.Tasks;
using Identity = Microsoft.AspNet.Identity;

namespace WebIdentity.Domain.Services
{
    public class SmsService : Identity.IIdentityMessageService
    {
        public Task SendAsync(Identity.IdentityMessage message)
        {
            // Plug in your SMS service here to send a text message.
            return Task.FromResult(0);
        }
    }
}
