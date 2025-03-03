using LabQuest.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LabQuest.Application.Interfaces
{
    public interface ILabRepository
    {
        Task<IEnumerable<Lab>> GetLabsAsync();
        Task<Lab> GetLabByIdAsync(int labId);
        Task AddLabAsync(Lab lab);
        Task UpdateLabAsync(Lab lab);
        Task DeleteLabAsync(int labId);
    }
}
