using TrackMyForms.Models;

namespace TrackMyForms.Services
{
    public interface IFormEntryService
    {
        Task<IEnumerable<FormEntry>> GetAllAsync();
        Task<FormEntry> GetByIdAsync(int id);
        Task AddAsync(FormEntry entry);
        Task UpdateAsync(FormEntry entry);
        Task DeleteAsync(int id);
    }
}
