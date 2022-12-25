using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class TradeClient
    {
        public long InsCode { get; set; }
        public DateTime TradeDate { get; set; }
        public int? RealAskCount { get; set; }
        public int? LegalAskCount { get; set; }
        public float? RealAskVolume { get; set; }
        public float? LegalAskVolume { get; set; }
        public int? RealBidCount { get; set; }
        public int? LegalBidCount { get; set; }
        public float? RealBidVolume { get; set; }
        public float? LegalBidVolume { get; set; }
    }
}
