namespace DayProgressApi.Models
{
    public class Progress
    {
        public bool IsWorkingTime { get; set; } = false;

        public double Percentage { get; set; }

        public string? Description { get; set; }
    }
}
