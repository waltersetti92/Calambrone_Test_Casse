using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.IO;
using Newtonsoft.Json;
using System.Threading;



namespace Calambrone_Test_Casse_2
{
    public delegate void ResumeFromMessage();
    public partial class Main : Form
    {
        public static readonly string appPath = Path.GetDirectoryName(Application.ExecutablePath);
        public static readonly string resourcesPath1 = Path.GetDirectoryName(Application.ExecutablePath) + "\\resources1";
        public static readonly string resourcesPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\resources";
        public static readonly string resultsDir = Path.GetDirectoryName(Application.ExecutablePath) + "\\results";
        private UserControl currUC = null;
        public Speakers speakers = null;

        public Main()
        {
        InitializeComponent();
            speakers = new Speakers();
            ucSpeaker1.parentForm = this;
            ucSpeaker1.Visible = false;
           ucSpeaker1.init(speakers);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Size size = this.Size;
            ucSpeaker1.setPos(size.Width, size.Height);
            //speakers.reinitSpeakers(true);
        }

        private void ucSpeaker1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ucSpeaker1.Show();
            currUC = ucSpeaker1;
        }
    }
}