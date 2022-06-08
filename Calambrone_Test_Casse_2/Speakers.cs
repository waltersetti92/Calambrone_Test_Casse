using System;
using System.IO;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Drawing;
using System.Windows.Forms;

namespace Calambrone_Test_Casse_2
{
    public class Speakers : IDisposable
    {
        private SerialPort sp;
        private string com = "";
        public readonly string comFile;
        public bool isOpened = false;
        public string sound_speaker = " ";
        public string sound_time = "00";
        public static string[] available_speakers = new string[3] { "02", "01", "04" };

        public Speakers()
        {
            comFile = Main.resourcesPath + "\\com.txt";
            string[] ports = getAvailableComs();

            com = getSavedCom();
            // MessageBox.Show(com);

            if (com.Length > 0)
                if (Array.IndexOf(ports, com) > -1)

                    if (openPort(com) != null)
                        isOpened = true;

        }
        static public string[] getAvailableComs()
        {
            return SerialPort.GetPortNames();

        }

        private string getSavedCom()
        {
            if (File.Exists(comFile) is true) return File.ReadAllText(comFile);
            else return "";
        }
        public Speakers openPort(string c)
        {
            try
            {
                sp = new System.IO.Ports.SerialPort(c, 250000, System.IO.Ports.Parity.None, 8, System.IO.Ports.StopBits.One);

                sp.Open();
                com = c;

                return this;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                com = "";
                return null;
            }
        }
        public static string ByteArrayToString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2} ", b);
            return hex.ToString();
        }

        private static byte[] hexstr2ByteArray(string str)
        {
            string[] hexValuesSplit = str.Split(' ');
           
            byte[] arr = new byte[hexValuesSplit.Length];
           
            int cnt = 0;
            foreach (String hex in hexValuesSplit)
            {
                arr[cnt] = Convert.ToByte(hex, 16);
                cnt++;
            }
            return arr; //return str.Split(' ').Select(s => Convert.ToByte(s, 16)).ToArray();
        }
        public bool reinitSpeakers(bool test = true)
        {
            if (sp.IsOpen is false)
                return false;
            //return true;


            string str;
            byte[] bytes;
            foreach (string speaker in available_speakers)
            {
                str = "F5 02 " + speaker + " 21 " + sound_speaker + " 03 F0";
                bytes = hexstr2ByteArray(str);
                sp.Write(bytes, 0, bytes.Length);
                Thread.Sleep(200);

                str = "F5 02 " + speaker + " 21 " + sound_speaker + " 03 F0";
                bytes = hexstr2ByteArray(str);
                sp.Write(bytes, 0, bytes.Length);
                Thread.Sleep(200);

                str = "F5 02 " + speaker + " 21 " + sound_speaker + " 03 F0";
                bytes = hexstr2ByteArray(str);
                sp.Write(bytes, 0, bytes.Length);
                Thread.Sleep(200);

                str = "F5 02 " + speaker + " 21 " + sound_speaker + " 03 F0";
                bytes = hexstr2ByteArray(str);
                sp.Write(bytes, 0, bytes.Length);
                Thread.Sleep(200);

                str = "F5 02 " + speaker + " 21 " + sound_speaker + " 03 F0";
                bytes = hexstr2ByteArray(str);
                sp.Write(bytes, 0, bytes.Length);
                Thread.Sleep(200);

                str = "F5 02 " + speaker + " 21 " + sound_speaker + " 03 F0";
                bytes = hexstr2ByteArray(str);
                sp.Write(bytes, 0, bytes.Length);
                Thread.Sleep(200);

            }
            if (test)
            {
                foreach (string speaker in available_speakers)
                {
                    //startSpeaker(speaker);
                    //Thread.Sleep(2000);
                }
            }
            return true;
        }

        public bool startSpeaker(string speaker, string sound_speaker)
        {
            if (sp == null)
                return false;
            if (sp.IsOpen is false)
                return false;
            string str, arr1, indata;
            int length_response;
            byte[] bytes;
            int dataLength = 0;
            str = "F5 02 " + speaker + " 21 " + sound_speaker + "05 04 F0";
            bytes = hexstr2ByteArray(str);
            arr1 = "";
            indata = "";
            while (dataLength == 0)
            {
                sp.Write(bytes, 0, bytes.Length);
                Thread.Sleep(1000);
                indata = sp.ReadExisting();
                length_response = indata.Length;
                if (length_response > 20)
                {
                    arr1 = char.ToString(indata[18]);
                }
                if (String.Equals(arr1, "1") || String.Equals(arr1, "2") || String.Equals(arr1, "4"))
                    break;
            }
            return true;
        }
        ~Speakers()
        {
            Dispose(false);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (sp != null)
                    if (sp.IsOpen)
                    {
                        sp.Close();
                        sp.Dispose();
                    }
            }
            // free native resources
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    
}
}
