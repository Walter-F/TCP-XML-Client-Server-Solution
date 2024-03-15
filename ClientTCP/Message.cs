using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientTCP
{
    public class Message
    {
        public string FormatVersion { get; set; }   
        public string From {  get; set; }   
        public string To { get; set; }
        public int ID { get; set; } 
        public Color Color { get; set; }
        public string Text { get; set; }
        public PictureBox Image {  get; set; }

        Message() { } 
    }
}
