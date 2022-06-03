using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calambrone_Test_Casse_2
{
    public partial class ucSpeaker : UserControl
    {
        public Main parentForm { get; set; }
        private string[] availableComs;

        public ucSpeaker()
        {
            InitializeComponent();
        }

        private void ucSpeaker_Load(object sender, EventArgs e)
        {

        }
        public void setPos(int w, int h)
        {

            int offset = 0;
            Location = new Point(offset, offset);
            Width = w - 1 * offset;
            Height = h - 1 * offset;

        }
    }
}
