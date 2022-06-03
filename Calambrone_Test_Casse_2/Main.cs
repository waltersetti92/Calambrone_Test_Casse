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
        public static readonly string resourcesPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\resources";
        private UserControl currUC = null;
        public Main()
        {
            InitializeComponent();
            ucSpeaker1.parentForm = this;
            ucSpeaker1.Visible = false;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Size size = this.Size;
            ucSpeaker1.setPos(size.Width, size.Height);
        }

    }
}