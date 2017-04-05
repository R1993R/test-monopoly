using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace MonopolyData.Data
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Money { get; set; }
        public int Position { get; set; }
        [NotMapped]
        public Color UserColor { get; set; }
        public int Argb
        {
            get
            {
                return UserColor.ToArgb();
            }
            set
            {
                UserColor = Color.FromArgb(value);
            }
        }
        public ICollection<Company> Companies { get; set; }
    }
}
