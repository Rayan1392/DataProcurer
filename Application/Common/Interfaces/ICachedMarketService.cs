using Application.Common.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface ICachedMarketService
    {
        Task<IEnumerable<TradeDataDto>> GetMarketHistoryAsync();
        Task<IEnumerable<TradeDataDto>> GetMarketLivaDataAsync();
    }
}
