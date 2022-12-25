using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.DTOs.Response
{
    public class TradeDataDto
    {
        public long InsCode { get; set; }
        public string? IsinCode { get; set; }
        public string? Symbol { get; set; }
        public int Flow { get; set; }
        public IReadOnlyList<CandleDto>? Candles { get; set; }
    }
}
