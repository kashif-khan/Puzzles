using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace CSharp.com.hackerrank
{
    public class StockOpenClosePriceOnParticularWeekdays
    {
        public static string[] Solve(string firstDate, string lastDate, string weekDay)
        {
            var fromDate = DateTime.Parse(firstDate);
            var toDate = DateTime.Parse(lastDate);

            var finalResult = new List<string>();

            var startDate = fromDate;
            for (int i = 0; i < 7; i++)
            {
                if (startDate.DayOfWeek.ToString() != weekDay)
                {
                    startDate = startDate.AddDays(1);
                }
                else
                {
                    break;
                }
            }
            for (DateTime currentDate = startDate; currentDate < toDate; currentDate = currentDate.AddDays(7))
            {
                var url = $"https://jsonmock.hackerrank.com/api/stocks/search?date={currentDate.ToString("d-MMMM-yyyy")}";
                var json = new WebClient().DownloadString(url);
                var stockResults = JsonConvert.DeserializeObject<StockResults>(json);
                if (stockResults.total_pages > 0)
                {
                    var dayPrice = stockResults.data.Where(i => i.date == currentDate).FirstOrDefault();
                    if (dayPrice != null)
                    {
                        finalResult.Add($"{dayPrice.date.ToString("d-MMMM-yyyy")} {dayPrice.open} {dayPrice.close}");
                        for (int pageNumber = 2; pageNumber <= stockResults.total_pages; pageNumber++)
                        {
                            url = $"https://jsonmock.hackerrank.com/api/stocks/search?date={currentDate.ToString("d-MMMM-yyyy")}&page={pageNumber}";
                            json = new WebClient().DownloadString(url);
                            stockResults = JsonConvert.DeserializeObject<StockResults>(json);
                            dayPrice = stockResults.data.Where(i => i.date == currentDate).First();
                            finalResult.Add($"{dayPrice.date.ToString("d-MMMM-yyyy")} {dayPrice.open} {dayPrice.close}");
                        }
                    }
                }
            }

            return finalResult.ToArray(); ;
        }
    }

    public class StockResults
    {
        public int page { get; set; }
        public int per_page { get; set; }
        public int total { get; set; }
        public int total_pages { get; set; }
        public StockData[] data { get; set; }
        public class StockData
        {
            public DateTime date { get; set; }
            public double open { get; set; }
            public double close { get; set; }
        }
    }
}

