namespace TelephoneDirectory.Business.Services.Directory.Abstract
{
    public interface IDirectoryService
    {
        Task<IEnumerable<string>> GetAllEntriesAsync();
        Task<string> GetEntryByIdAsync(int id);
        Task AddEntryAsync(string entry);
        Task UpdateEntryAsync(int id, string entry);
        Task DeleteEntryAsync(int id);
        Task<IEnumerable<string>> GetEntriesByPhoneNumberAsync(string phoneNumber);
        Task<IEnumerable<string>> GetEntriesByEmailAsync(string email);
        Task<IEnumerable<string>> GetEntriesByNameAsync(string name);
    }
}
