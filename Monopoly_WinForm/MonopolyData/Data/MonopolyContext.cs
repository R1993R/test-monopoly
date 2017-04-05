using System.Data.Entity;

namespace MonopolyData.Data
{
    public class MonopolyContext : DbContext
    {
        public MonopolyContext() : base()
        {

        }

        public IDbSet<Company> Companies { get; set; }
        public IDbSet<Counrty> Countries { get; set; }
        public IDbSet<Stock> Stocks { get; set; }
        public IDbSet<Upgrade> Upgrades { get; set; }
        public IDbSet<User> Users { get; set; }
    }
}
