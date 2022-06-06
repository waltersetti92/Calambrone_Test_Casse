using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

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
        public void init(Speakers spk)
        {
            speakers = spk;
            availableComs = Speakers.getAvailableComs();
            foreach (string com in availableComs)
                cmbCom.Items.Add(com);

            if (cmbCom.Items.Count > 0)
                cmbCom.SelectedIndex = 0;
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
            speakers.startSpeaker(Speakers.available_speakers[0],"01 ");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string text = cmbCom.SelectedItem.ToString();
            System.IO.File.WriteAllText(speakers.comFile, text);
            speakers = speakers.openPort(text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            speakers.startSpeaker(Speakers.available_speakers[1],"01 ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            speakers.startSpeaker(Speakers.available_speakers[2],"01 ");
        }
    }
}
