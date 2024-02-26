using DayProgressApi.Models;
using DayProgressApi.Services.Interfaces;

namespace DayProgressApi.Services
{
    public class ProgressService : IProgressService
    {
        public Progress GetProgress(TimeSpan start, TimeSpan end)
        {
            var progress = new Progress()
            {
                IsWorkingTime = IsWorkingTime(start, end),
                Description = GetDescription(start, end),
                Percentage = GetPercentage(start, end)
            };

            return progress;
        }

        public bool IsWorkingTime(TimeSpan start, TimeSpan end)
        {
            var now = DateTime.Now.TimeOfDay;

            if (start < end)
            {
                return start <= now && now <= end;
            }
            return !(end < now && now < start);
        }

        public string GetDescription(TimeSpan start, TimeSpan end)
        {
            switch(IsWorkingTime(start, end))
            {
                case true:
                    return "Work in progress";

                case false:
                    return "Work is over";
            }
        }

        public double GetPercentage(TimeSpan start, TimeSpan end)
        {
            if (IsWorkingTime(start, end))
            {
                var now = DateTime.Now.TimeOfDay;

                var percentage = (int)((now.TotalMinutes - start.TotalMinutes) / (end.TotalMinutes - start.TotalMinutes) * 100);

                return percentage;
            }
            return 100;
        }
    }
}
