using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Authorisation.Data
{
    public class Datacontext : IdentityDbContext<UserRegistration>
    {
        public Datacontext(DbContextOptions options) : base(options)
        {

        }
    }
}
