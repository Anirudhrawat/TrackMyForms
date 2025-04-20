using TrackMyForms.Data;
using TrackMyForms.Models;
using TrackMyForms.Repositories;

namespace TrackMyForms.UnitOfWork
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly AppDbContext _context;
        public IRepository<FormEntry> FormEntries { get; }

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            FormEntries = new FormEntryRepository(context);
        }

        public async Task<int> SaveAsync() => await _context.SaveChangesAsync();

        public void Dispose() => _context.Dispose();
    }
}
