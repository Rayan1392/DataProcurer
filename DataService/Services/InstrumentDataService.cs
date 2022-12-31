using Application.Common.Interfaces;
using DataService.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.Services
{
    public class InstrumentDataService : DataSerciceBase
    {
        private static Timer _timer;
        private readonly object _lock = new object();


        public InstrumentDataService() {
            OffDays = new List<DayOfWeek> { DayOfWeek.Friday, DayOfWeek.Thursday };
            IsAsleep = true;
            StartTime = 5;
            StopTime = 9;
            IntervalMinute = TseHelper.GetServiceMilisecondInterval("Instrument");// Convert.ToInt32(10800000);
        }

        public override void Persist()
        {
            throw new NotImplementedException();
        }
    }
}
