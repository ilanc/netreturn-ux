using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcApplication1.Controllers.Api
{
    public class GridData
    {
        public string company;
        public double price;
        public double change;
        public double pctChange;
        public DateTime lastChange;
    }

    public class ChartData
    {
        public int ID;
        public string Month;
        public decimal Sample1;
    }

    public class App1Controller :ApiController
    {
        public static GridData[] static_GridData = new GridData[] 
        {
            new GridData { company = "TestWebAPI", price = 71.72, change = 0.02, pctChange = 0.03, lastChange = new DateTime(2013, 9, 1) },
            new GridData { company = "3m Co", price = 71.72, change = 0.02, pctChange = 0.03, lastChange = new DateTime(2013, 9, 1) },
            new GridData { company = "Alcoa Inc", price = 29.01, change = 0.42, pctChange = 1.47, lastChange = new DateTime(2013, 9, 1) },
            new GridData { company = "Altria Group Inc", price = 83.81, change = 0.28, pctChange = 0.34, lastChange = new DateTime(2013, 9, 1) },
            new GridData { company = "American Express Company", price = 52.55, change = 0.01, pctChange = 0.02, lastChange = new DateTime(2013, 9, 1) },
            new GridData { company = "American International Group, Inc.", price = 64.13, change = 0.31, pctChange = 0.49, lastChange = new DateTime(2013, 9, 1) },
            new GridData { company = "AT&T Inc.", price = 31.61, change = -0.48, pctChange = -1.54, lastChange = new DateTime(2013, 9, 1) },
            new GridData { company = "Boeing Co.", price = 75.43, change = 0.53, pctChange = 0.71, lastChange = new DateTime(2013, 9, 1) },
            new GridData { company = "Caterpillar Inc.", price = 67.27, change = 0.92, pctChange = 1.39, lastChange = new DateTime(2013, 9, 1) },
            new GridData { company = "Citigroup, Inc.", price = 49.37, change = 0.02, pctChange = 0.04, lastChange = new DateTime(2013, 9, 1) },
            new GridData { company = "E.I. du Pont de Nemours and Company", price = 40.48, change = 0.51, pctChange = 1.28, lastChange = new DateTime(2013, 9, 1) },
            new GridData { company = "Exxon Mobil Corp", price = 68.1, change = -0.43, pctChange = -0.64, lastChange = new DateTime(2013, 9, 1) },
            new GridData { company = "General Electric Company", price = 34.14, change = -0.08, pctChange = -0.23, lastChange = new DateTime(2013, 9, 1) },
            new GridData { company = "General Motors Corporation", price = 30.27, change = 1.09, pctChange = 3.74, lastChange = new DateTime(2013, 9, 1) },
            new GridData { company = "Hewlett-Packard Co.", price = 36.53, change = -0.03, pctChange = -0.08, lastChange = new DateTime(2013, 9, 1) },
            new GridData { company = "Honeywell Intl Inc", price = 38.77, change = 0.05, pctChange = 0.13, lastChange = new DateTime(2013, 9, 1) },
            new GridData { company = "Intel Corporation", price = 19.88, change = 0.31, pctChange = 1.58, lastChange = new DateTime(2013, 9, 1) },
            new GridData { company = "International Business Machines", price = 81.41, change = 0.44, pctChange = 0.54, lastChange = new DateTime(2013, 9, 1) },
            new GridData { company = "Johnson & Johnson", price = 64.72, change = 0.06, pctChange = 0.09, lastChange = new DateTime(2013, 9, 1) },
            new GridData { company = "JP Morgan & Chase & Co", price = 45.73, change = 0.07, pctChange = 0.15, lastChange = new DateTime(2013, 9, 1) },
            new GridData { company = "McDonald's Corporation", price = 36.76, change = 0.86, pctChange = 2.4, lastChange = new DateTime(2013, 9, 1) },
            new GridData { company = "Merck & Co., Inc.", price = 40.96, change = 0.41, pctChange = 1.01, lastChange = new DateTime(2013, 9, 1) },
            new GridData { company = "Microsoft Corporation", price = 25.84, change = 0.14, pctChange = 0.54, lastChange = new DateTime(2013, 9, 1) },
            new GridData { company = "Pfizer Inc", price = 27.96, change = 0.4, pctChange = 1.45, lastChange = new DateTime(2013, 9, 1) },
            new GridData { company = "The Coca-Cola Company", price = 45.07, change = 0.26, pctChange = 0.58, lastChange = new DateTime(2013, 9, 1) },
            new GridData { company = "The Home Depot, Inc.", price = 34.64, change = 0.35, pctChange = 1.02, lastChange = new DateTime(2013, 9, 1) },
            new GridData { company = "The Procter & Gamble Company", price = 61.91, change = 0.01, pctChange = 0.02, lastChange = new DateTime(2013, 9, 1) },
            new GridData { company = "United Technologies Corporation", price = 63.26, change = 0.55, pctChange = 0.88, lastChange = new DateTime(2013, 9, 1) },
            new GridData { company = "Verizon Communications", price = 35.57, change = 0.39, pctChange = 1.11, lastChange = new DateTime(2013, 9, 1) },
            new GridData { company = "Wal-Mart Stores, Inc.", price = 45.45, change = 0.73, pctChange = 1.63, lastChange = new DateTime(2013, 9, 1) }
        };

        public GridData[] GetGrid()
        {
            return static_GridData;
        }

        public static ChartData[] static_ChartData = new ChartData[]
        {
            new ChartData { ID = 1, Month = "Jan-11", Sample1 = 40 },
            new ChartData { ID = 2, Month = "Feb-11", Sample1 = 30},
            new ChartData { ID = 3, Month = "Mar-11", Sample1 = 30},
            new ChartData { ID = 4, Month = "Apr-11", Sample1 = 40},
            new ChartData { ID = 5, Month = "May-11", Sample1 = 20},
            new ChartData { ID = 6, Month = "Jun-11", Sample1 = 40},
            new ChartData { ID = 7, Month = "Jul-11", Sample1 = 20},
            new ChartData { ID = 8, Month = "Aug-11", Sample1 = 40},
            new ChartData { ID = 9, Month = "Sep-11", Sample1 = 20},
            new ChartData { ID = 10, Month = "Oct-11", Sample1 = 40},
            new ChartData { ID = 11, Month = "Nov-11", Sample1 = 20},
            new ChartData { ID = 12, Month = "Dec-11", Sample1 = 40}
        };

        public ChartData[] GetChart(string id)
        {
            return static_ChartData;
        }
    }
}
