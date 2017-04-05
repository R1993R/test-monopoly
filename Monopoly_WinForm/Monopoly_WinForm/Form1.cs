using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MonopolyData.Data;

namespace Monopoly_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (var context = new MonopolyContext())
            {
                var user = new User()
                {
                    Argb = 124,
                    Money = 5,
                    Name = "weg",
                    Position = 5
                };
                context.Users.Add(user);
                context.SaveChanges();
            }
        }
    }
}
