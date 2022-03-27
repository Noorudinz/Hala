using AdminLTE.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE.MVC.Repository
{
    public interface IStocks
    {
        List<Stocks> GetAllStocks();
        Stocks GetStocksById(int stocksId);
        Stocks AddStocks(Stocks stocks);
        Stocks UpdateStocks(Stocks stocks);
        void DeleteStocks(int stocksId);
    }
}
