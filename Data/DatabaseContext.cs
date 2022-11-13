using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Webshop.Data
{
    public class DatabaseContext : DbContext
    {
        public IHttpContextAccessor _httpContextAccessor;


        public DatabaseContext() : base()
        {

        }

        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options, IHttpContextAccessor httpContextAccessor)
           : base(options)
        {
            _httpContextAccessor = httpContextAccessor;
        }

    }
}
