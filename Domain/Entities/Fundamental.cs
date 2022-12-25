using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Fundamental
    {
        public long InsCode { get; set; }
        public string InstrumentID { get; set; }
        public decimal CurrentRatio { get; set; }
        public decimal DebtToEquityRatio { get; set; }
        public decimal GrossProfitMargin { get; set; }
        public decimal OperatingProfitMargin { get; set; }
        public decimal NetProfitMargin { get; set; }
        public decimal NetProgiftGrowth { get; set; }
        public decimal ROEGrowth { get; set; }
        public decimal ROIGrowth { get; set; }
        public decimal PE { get; set; }
        public decimal PS { get; set; }
    }
}
