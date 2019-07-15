using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImGraph
{
    public partial class Pins : UserControl
    {

        public Pins()
        {
            InitializeComponent();
        }

        private void Pins_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.
            e.Graphics.DrawEllipse(new Pen(Color.Red, 3), new Rectangle(2,2,10,10));
        }

        private void Pins_Load(object sender, EventArgs e)
        {

        }
    }
}
