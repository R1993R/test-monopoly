using System.Collections.Generic;

namespace MonopolyData.Data
{
    public class Upgrade
    {
        public int Id { get; set; }
        public int MonopolySalary { get; set; }
        public ICollection<Stock> Stocks { get; set; }
    }
}
