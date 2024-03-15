using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace ClientTCP
{
    public partial class WelcomeForm : Form
    {
        string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Message.xml"; // Папка с моими документами
        int dR, dG, dB, sign;
        public WelcomeForm()
        {
            InitializeComponent();

            dR = WelcomeLabel.BackColor.R - WelcomeLabel.ForeColor.R;
            dG = WelcomeLabel.BackColor.G - WelcomeLabel.ForeColor.G;
            dB = WelcomeLabel.BackColor.B - WelcomeLabel.ForeColor.B;
            sign = 1;
            Timer timer = new Timer();
            timer.Interval = 150;
            timer.Tick += timer_Tick;
            timer.Start();
        }

        public async void CreateXML(string filePath)
        {
            byte[] bytes;

            using (MemoryStream ms = new MemoryStream())
            {
                Bitmap bitmap = new Bitmap(Properties.Resources.Example);
                bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                bytes = ms.ToArray();
            }

            var result = string.Join(" ", bytes);

            XDocument xdoc = new XDocument(
                new XElement("Message",
                    new XElement("FormatVersion", "1"),
                    new XElement("From", "Developer"),
                    new XElement("To", "User"),
                    new XElement("ID", 1),
                    new XElement("Color", "Red"),
                    new XElement("Text", "ExampleText"),
                    new XElement("Image", result)));
            xdoc.Save(filePath);
        }
      
        private void StartButton_Click(object sender, EventArgs e)
        {
            // CreateXML(filePath);

            Client client = new Client();
            this.Hide();
            client.Show();
        }

        // Плавное появление текста
        private void timer_Tick(object sender, EventArgs e)
        {
            if (Math.Abs(WelcomeLabel.ForeColor.R - WelcomeLabel.BackColor.R) < Math.Abs(dR / 10))
            {
                sign *= -1;
                WelcomeLabel.Text = "Добро пожаловать!";
            }
            WelcomeLabel.ForeColor = Color.FromArgb(255, WelcomeLabel.ForeColor.R + sign * dR / 10, WelcomeLabel.ForeColor.G + sign * dG / 10, WelcomeLabel.ForeColor.B + sign * dB / 10);
            if (WelcomeLabel.BackColor.R == WelcomeLabel.ForeColor.R + dR)
            {
                ((Timer)sender).Stop();
            }
        }
    }
}
