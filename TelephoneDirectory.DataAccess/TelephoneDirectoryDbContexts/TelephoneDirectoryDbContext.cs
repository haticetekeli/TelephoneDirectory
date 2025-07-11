using Microsoft.EntityFrameworkCore;
using TelephoneDirectory.DataAccess.Entities;

namespace TelephoneDirectory.DataAccess.TelephoneDirectoryDbContexts
{
    public class TelephoneDirectoryDbContext : DbContext
    {
        public TelephoneDirectoryDbContext(DbContextOptions<TelephoneDirectoryDbContext> options) : base(options)
        {
            AppContext.SetSwitch("Npsql.EnableLegacyTimestampBehavior", true);
        }



        DbSet<User> Users { get; set; }
        DbSet<TelephoneDirectory.DataAccess.Entities.Directory> Directories { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
