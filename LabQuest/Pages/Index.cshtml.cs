using LabQuest.Application.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;
using LabQuest.Domain.Entities;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace LabQuest.Pages.Labs
{
    public class IndexModel : PageModel
    {
        private readonly ILabRepository _labRepository;
        private readonly ILogger<IndexModel> _logger;

        public IEnumerable<Lab> Labs { get; private set; }

        public IndexModel(ILabRepository labRepository, ILogger<IndexModel> logger)
        {
            _labRepository = labRepository;
            _logger = logger;
        }

        public async Task OnGetAsync()
        {
            Labs = await _labRepository.GetLabsAsync();
            _logger.LogInformation("Retrieved {Count} labs from the repository.", Labs?.Count() ?? 0);
        }
    }
}
