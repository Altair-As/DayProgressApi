using DayProgressApi.Models;

namespace DayProgressApi.Services.Interfaces
{
    public interface IProgressService
    {
        Progress GetProgress(TimeSpan start, TimeSpan end);
        bool IsWorkingTime(TimeSpan start, TimeSpan end);
        string GetDescription(TimeSpan start, TimeSpan end);
        double GetPercentage(TimeSpan start, TimeSpan end);
    }
}
