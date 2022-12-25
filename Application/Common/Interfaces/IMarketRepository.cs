using Domain.Entities;

namespace Application.Common.Interfaces
{
    public interface IMarketRepository : IGenericRepository<Trade>
    {
        Task<IReadOnlyList<Trade>> GetMarketHistoryAsync();
        Task<IReadOnlyList<Trade>> GetMarketLivaDataAsync();
        Task<IReadOnlyList<Fundamental>> GetFundamentalsAsync();
        Task<IReadOnlyList<FreeFloatShare>> GetFreeFloatSharesAsync();
        Task<IReadOnlyList<TradeClient>> GetTradeClientsAsync();
    }
}
