using System.Collections.Generic;

namespace LabQuest.Domain.Entities
{
    public class Step
    {
        public int Id { get; set; }
        public int LabId { get; set; }
        public string Content { get; set; }
        public int Order { get; set; }

        public Lab Lab { get; set; }
        public List<Hint> Hints { get; set; } = new();
    }
}
