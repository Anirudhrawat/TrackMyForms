using TrackMyForms.Models;
using TrackMyForms.Repositories;

namespace TrackMyForms.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<FormEntry> FormEntries { get; }
        Task<int> SaveAsync();
    }
}
