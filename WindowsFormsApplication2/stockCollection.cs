using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stock
{
    public class stockCollection
    {
        List<Stock> stock = new List<Stock>();

        int currentStock = 0;

        //grants access to stock data

        public string GetStockstockName()
        {
            return stock[currentStock].stockName;
        }

        public string GetStockstockLocation()
        {
            return stock[currentStock].stockLocation;
        }

        public string GetStockstockPrice()
        {
            return stock[currentStock].stockPrice;
        }

        public string GetStockstockLevel()
        {
            return stock[currentStock].stockLevel;
        }

        public bool IsNextStock()
        {
            if (currentStock < (stock.Count - 1))
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool IsPreviousStock()
        {
            if (currentStock > 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }


        public void StepToNextStock()
        {
            if (IsNextStock())
            {
                currentStock++;
            }
        }

        public void StepToPreviousStock()
        {
            if (IsPreviousStock())
            {
                currentStock--;
            }
         }

       /* public void AddStock (string stockName, string stockLevel, string stockPrice, string stockLocation)
        {
            // create a new stock object
            Stock stock = new Stock();
            // copy over the stock data
            stock.stockName = stockName;
            stock.stockLevel = stockLevel;
            stock.stockPrice = stockPrice;
            stock.stockLocation = stockLocation;
            // add to stock list
            stock.Add(stock);
            
        }*/
        }
    }

