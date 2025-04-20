using TrackMyForms.Models;
using TrackMyForms.UnitOfWork;

namespace TrackMyForms.Services
{
    public class FormEntryService : IFormEntryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public FormEntryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<FormEntry>> GetAllAsync() => await _unitOfWork.FormEntries.GetAllAsync();

        public async Task<FormEntry> GetByIdAsync(int id) => await _unitOfWork.FormEntries.GetByIdAsync(id);

        public async Task AddAsync(FormEntry entry)
        {
            await _unitOfWork.FormEntries.AddAsync(entry);
            await _unitOfWork.SaveAsync();
        }

        public async Task UpdateAsync(FormEntry entry)
        {
            _unitOfWork.FormEntries.Update(entry);
            await _unitOfWork.SaveAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _unitOfWork.FormEntries.GetByIdAsync(id);
            if (entity != null)
            {
                _unitOfWork.FormEntries.Delete(entity);
                await _unitOfWork.SaveAsync();
            }
        }
    }
}
