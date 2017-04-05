using System.Collections.Generic;
using System.Drawing;

namespace MonopolyData.Data
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Salary { get; set; }
        public ICollection<Upgrade> Upgrades { get; set; }
        public Counrty Country { get; set; }
        public string ImagePath { get; set; }
        public int Position { get; set; }
    }
}
