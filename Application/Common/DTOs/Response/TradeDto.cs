using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.DTOs.Response
{
    public class TradeDto
    {
        public long InsCode { get; set; }
        public string IsinCode { get; set; }
        public string Symbol { get; set; }
        public DateTime TradeDateTime { get; set; }
        public string JalaliTradeDate { get; set; }
        public int Open { get; set; }
        public int High { get; set; }
        public int Low { get; set; }
        public int Close { get; set; }
        public int Last { get; set; }
        public int PriceChange { get; set; }
        public int PriceYesterday { get; set; }
        public long Vol { get; set; }
        public long Val { get; set; }
        public int Flow { get; set; }
    }
}
