using Microsoft.EntityFrameworkCore;
using TrackMyForms.Data;
using TrackMyForms.Models;

namespace TrackMyForms.Repositories
{
    public class FormEntryRepository : IRepository<FormEntry>
    {
        private readonly AppDbContext _context;

        public FormEntryRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<FormEntry>> GetAllAsync() => await _context.FormEntries.ToListAsync();

        public async Task<FormEntry> GetByIdAsync(int id) => await _context.FormEntries.FindAsync(id);

        public async Task AddAsync(FormEntry entity) => await _context.FormEntries.AddAsync(entity);

        public void Update(FormEntry entity) => _context.FormEntries.Update(entity);

        public void Delete(FormEntry entity) => _context.FormEntries.Remove(entity);
    }
}
