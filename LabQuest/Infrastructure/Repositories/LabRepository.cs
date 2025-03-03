using LabQuest.Domain.Entities;
using LabQuest.Infrastructure.Data;
using LabQuest.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LabQuest.Infrastructure.Repositories
{
    public class LabRepository : ILabRepository
    {
        private readonly AppDbContext _context;

        public LabRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Lab>> GetLabsAsync()
        {
            // Retrieve all labs along with their steps.
            return await _context.Labs
                                 .Include(l => l.Steps)
                                 .ToListAsync();
        }

        public async Task<Lab> GetLabByIdAsync(int labId)
        {
            // Retrieve a specific lab including its steps and hints.
            return await _context.Labs
                                 .Include(l => l.Steps)
                                    .ThenInclude(s => s.Hints)
                                 .FirstOrDefaultAsync(l => l.Id == labId);
        }

        public async Task AddLabAsync(Lab lab)
        {
            _context.Labs.Add(lab);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateLabAsync(Lab lab)
        {
            _context.Labs.Update(lab);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteLabAsync(int labId)
        {
            var lab = await GetLabByIdAsync(labId);
            if (lab != null)
            {
                _context.Labs.Remove(lab);
                await _context.SaveChangesAsync();
            }
        }
    }
}
