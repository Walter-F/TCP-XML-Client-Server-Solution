using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerTCP
{
    [Serializable()]
    public class Message
    {
        [System.Xml.Serialization.XmlElementAttribute("FormatVersion")]
        public string FormatVersion { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("From")]
        public string From {  get; set; }

        [System.Xml.Serialization.XmlElementAttribute("To")]
        public string To { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("ID")]
        public int ID { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("Color")]
        public string Color { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("Text")]
        public string Text { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("Image")]
        public string Image {  get; set; }

        Message() { } 
    }
}
