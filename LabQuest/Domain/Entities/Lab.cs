using System.Collections.Generic;
using System;

namespace LabQuest.Domain.Entities
{
    public class Lab
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Difficulty { get; set; } // Easy, Medium, Hard
        public string Language { get; set; } // C#, Python, JavaScript
        public TimeSpan EstimatedTime { get; set; }

        public List<Step> Steps { get; set; } = new();
    }
}
