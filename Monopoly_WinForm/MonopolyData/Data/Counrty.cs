using System.Collections.Generic;

namespace MonopolyData.Data
{
    public class Counrty
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Company> Companies { get; set; }
        public string ImagePath { get; set; }
    }
}
