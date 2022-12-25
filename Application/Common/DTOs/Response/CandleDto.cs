using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.DTOs.Response
{
    [DataContract]
    public class CandleDto
    {
        [DataMember]
        public DateTime TradeDateTime { get; set; }
        [DataMember]
        public string? JalaliTradeDate { get; set; }
        [DataMember]
        public int Open { get; set; }
        [DataMember]
        public int High { get; set; }
        [DataMember]
        public int Low { get; set; }
        [DataMember]
        public int Close { get; set; }
        [DataMember]
        public int Last { get; set; }
        [DataMember]
        public int PriceChange { get; set; }
        [DataMember]
        public int PriceYesterday { get; set; }
        [DataMember]
        public long Vol { get; set; }
        [DataMember]
        public long Val { get; set; }
    }
}
