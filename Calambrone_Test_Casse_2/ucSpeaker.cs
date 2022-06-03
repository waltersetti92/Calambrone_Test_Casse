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
        private Speakers speakers = null;
        private string[] availableComs;

        public ucSpeaker()
        {
            InitializeComponent();
        }
        public void Initial_Button()
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button11.Visible = false;
        }
        private void ucSpeaker_Load(object sender, EventArgs e)
        {
            Initial_Button();
        }
        public void setPos(int w, int h)
        {

            int offset = 0;
            Location = new Point(offset, offset);
            Width = w - 1 * offset;
            Height = h - 1 * offset;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            button10.Visible = false;
            button7.Visible = true;
            button8.Visible = true;
            button11.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button9.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button11.Visible = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Initial_Button();
            button10.Visible = true;
            button9.Visible = true;
            button11.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            speakers.startSpeaker(Speakers.available_speakers[0]);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string text = cmbCom.SelectedItem.ToString();
            System.IO.File.WriteAllText(speakers.comFile, text);
            speakers = speakers.openPort(text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            speakers.startSpeaker(Speakers.available_speakers[1]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            speakers.startSpeaker(Speakers.available_speakers[2]);
        }
    }
}
