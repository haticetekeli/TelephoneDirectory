using TelephoneDirectory.Business.Services.Directory.Abstract;

namespace TelephoneDirectory.Business.Services.Directory.Concrete
{
    class DirectoryService : IDirectoryService
    {
        public async Task<IEnumerable<string>> GetAllEntriesAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<string> GetEntryByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
        public async Task AddEntryAsync(string entry)
        {

            throw new NotImplementedException();
        }
        public async Task UpdateEntryAsync(int id, string entry)
        {

            throw new NotImplementedException();
        }
        public async Task DeleteEntryAsync(int id)
        {

            throw new NotImplementedException();
        }
        public async Task<IEnumerable<string>> GetEntriesByPhoneNumberAsync(string phoneNumber)
        {

            throw new NotImplementedException();
        }
        public async Task<IEnumerable<string>> GetEntriesByEmailAsync(string email)
        {

            throw new NotImplementedException();
        }
        public async Task<IEnumerable<string>> GetEntriesByNameAsync(string name)
        {

            throw new NotImplementedException();
        }
    }
}
