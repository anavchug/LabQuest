namespace LabQuest.Domain.Entities
{
    public class Hint
    {
        public int Id { get; set; }
        public int StepId { get; set; }
        public string Text { get; set; }

        public Step Step { get; set; }
    }
}
