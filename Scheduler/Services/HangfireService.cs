using Application.Common.Interfaces;
using Hangfire;

namespace Scheduler.Services
{
    public class HangfireService : IBackgroundJobs
    {
        private readonly object _locker = new object();
        private readonly TimeOnly from = new TimeOnly(9, 5);
        private readonly TimeOnly to = new TimeOnly(13, 0);

        public HangfireService()
        {
        }

        public string CronMagnetStrategy
        {
            get
            {
                return "*/10 * * * *";
            }
        }

        [AutomaticRetry(Attempts = 0)]
        public void Execute()
        {
            if (CheckMarketDateTime())
                return;
        }

        private bool CheckMarketDateTime()
        {
            bool res = false;

            DateTime currentDate = DateTime.Now;
            DateTime fromDateTime = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, from.Hour, from.Minute, 0);
            DateTime toDateTime = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, to.Hour, to.Minute, 0);
            if (DateTime.Now < fromDateTime || DateTime.Now > toDateTime)
                res = true;
            if (DateTime.Now.DayOfWeek == DayOfWeek.Thursday || DateTime.Now.DayOfWeek == DayOfWeek.Friday)
                res = true;

            return res;
        }
    }
}
