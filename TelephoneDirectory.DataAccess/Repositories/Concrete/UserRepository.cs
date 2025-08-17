using TelephoneDirectory.DataAccess.Entities;
using TelephoneDirectory.DataAccess.Repositories.Abstract;
using TelephoneDirectory.DataAccess.TelephoneDirectoryDbContexts;


namespace TelephoneDirectory.DataAccess.Repositories.Concrete
{
    public class UserRepository : Repository<User, TelephoneDirectoryDbContext>, IUserRepository
    {
        public UserRepository(TelephoneDirectoryDbContext context) : base(context)
        {
        }
    }
}