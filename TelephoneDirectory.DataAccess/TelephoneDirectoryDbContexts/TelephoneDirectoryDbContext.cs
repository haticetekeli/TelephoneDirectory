using Microsoft.EntityFrameworkCore;

namespace TelephoneDirectory.DataAccess.TelephoneDirectoryDbContexts
{
    public class TelephoneDirectoryDbContext : DbContext
    {
        public TelephoneDirectoryDbContext(DbContextOptions<TelephoneDirectoryDbContext> options) : base(options)
        {
            AppContext.SetSwitch("Npsql.EnableLegacyTimestampBehavior", true);
        }




        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
