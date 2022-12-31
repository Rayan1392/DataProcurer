using Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public IMarketRepository MarketTrades { get; }

        public UnitOfWork(IMarketRepository tradeRepository)
        {
            MarketTrades = tradeRepository;
        }
    }
}