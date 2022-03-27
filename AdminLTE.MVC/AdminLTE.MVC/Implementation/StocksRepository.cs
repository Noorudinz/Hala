using AdminLTE.MVC.Data;
using AdminLTE.MVC.Models;
using AdminLTE.MVC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE.MVC.Implementation
{
    public class StocksRepository : IStocks
    {
        private readonly ApplicationDbContext _context;
        public StocksRepository(ApplicationDbContext appDbContext)
        {
            _context = appDbContext;
        }
        public Stocks AddStocks(Stocks stocks)
        {
            throw new NotImplementedException();
        }

        public void DeleteStocks(int stocksId)
        {
            throw new NotImplementedException();
        }

        public List<Stocks> GetAllStocks()
        {
            throw new NotImplementedException();
        }

        public Stocks GetStocksById(int stocksId)
        {
            throw new NotImplementedException();
        }

        public Stocks UpdateStocks(Stocks stocks)
        {
            throw new NotImplementedException();
        }
    }
}
