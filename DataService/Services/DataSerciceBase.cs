using Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.Services
{
    public abstract class DataSerciceBase : IDataService
    {
        public int StartTime { set; get; }
        public int StopTime { set; get; }

        public int StopMinute { get; set; }

        public List<DayOfWeek> OffDays { set; get; }
        public int IntervalMinute { set; get; }
        public int RetryCount { set; get; }
        public int RetryIntervalMinute { set; get; }
        public bool IsAsleep { get; set; }
        public abstract void Persist();
    }
}
