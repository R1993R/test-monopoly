using System.Collections.Generic;
using System.Drawing;

namespace MonopolyData.Data
{
    public class Company
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Salary { get; set; }
        public List<Upgrade> Upgrades { get; set; }
        public List<Counrty> Countries { get; set; }
        public string ImagePath { get; set; }
        public Point Position { get; set; }
    }
}
