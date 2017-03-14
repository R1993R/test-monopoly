using System.Collections.Generic;
using System.Drawing;

namespace MonopolyData.Data
{
    public class User
    {
        public string Name { get; set; }
        public int Money { get; set; }
        public Point Position { get; set; }
        public Color UserColor { get; set; }
        public List<Company> Companies { get; set; }
        public string IdUser { get; set; }
    }
}
