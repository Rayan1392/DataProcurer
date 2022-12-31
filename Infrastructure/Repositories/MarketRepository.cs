using Microsoft.Extensions.Configuration;
using Application.Common.Interfaces;
using Domain.Entities;
using System.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Logging;


namespace Infrastructure.Repositories
{
    public class MarketRepository : IMarketRepository
    {
        private readonly IConfiguration configuration;
        private readonly ILogger<MarketRepository> _logger;

        public MarketRepository(IConfiguration configuration, ILogger<MarketRepository> logger)
        {
            this.configuration = configuration;
            _logger = logger;
        }

        public Task<int> AddAsync(Trade entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IReadOnlyList<Trade>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Trade> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IReadOnlyList<Trade>> GetMarketHistoryAsync()
        {
            List<Trade> response = null;
            try
            {
                var sql = "Tse.SP_TradeRefined_SelectHistory";
                using (var connection = new SqlConnection(configuration.GetConnectionString("Connection")))
                {
                    connection.Open();
                    var result = await connection.QueryAsync<Trade>(sql, commandType: System.Data.CommandType.StoredProcedure);
                    response = result.ToList();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return response;
        }

        public async Task<IReadOnlyList<Trade>> GetMarketLivaDataAsync()
        {

            List<Trade> response = null;
            try
            {
                var sql = "Tse.SP_Trade_Select";
                using (var connection = new SqlConnection(configuration.GetConnectionString("Connection")))
                {
                    connection.Open();
                    var result = await connection.QueryAsync<Trade>(sql, commandType: System.Data.CommandType.StoredProcedure);
                    response = result.ToList();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return response;
        }

        public Task<int> UpdateAsync(Trade entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IReadOnlyList<Fundamental>> GetFundamentalsAsync()
        {
            List<Fundamental>? response = null;
            try
            {
                var sql = "Codal.SP_Fundamental_Variables";
                using (var connection = new SqlConnection(configuration.GetConnectionString("Connection")))
                {
                    connection.Open();
                    var result = await connection.QueryAsync<Fundamental>(sql, commandType: System.Data.CommandType.StoredProcedure);
                    response = result.ToList();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return response;
        }

        public async Task<IReadOnlyList<FreeFloatShare>> GetFreeFloatSharesAsync()
        {
            List<FreeFloatShare>? response = null;
            try
            {
                var sql = "Tse.SP_InstrumentFreeFloat_Select";
                using (var connection = new SqlConnection(configuration.GetConnectionString("Connection")))
                {
                    connection.Open();
                    var result = await connection.QueryAsync<FreeFloatShare>(sql, commandType: System.Data.CommandType.StoredProcedure);
                    response = result.ToList();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return response;
        }

        public async Task<IReadOnlyList<TradeClient>> GetTradeClientsAsync()
        {
            List<TradeClient>? response = null;
            try
            {
                var sql = "Tse.SP_TradeClient_Select ";
                using (var connection = new SqlConnection(configuration.GetConnectionString("Connection")))
                {
                    connection.Open();
                    var result = await connection.QueryAsync<TradeClient>(sql, commandType: System.Data.CommandType.StoredProcedure);
                    response = result.ToList();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return response;
        }
    }
}
