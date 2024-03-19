using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net.NetworkInformation;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Globalization;

namespace ServerTCP
{
    public partial class Server : Form
    {
        IPEndPoint ipPoint = new IPEndPoint(IPAddress.Any, 8888);
        Socket tcpListener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public Server()
        {
            InitializeComponent();
        }

        private async void OpenConnection_Click(object sender, EventArgs e)
        {
            tcpListener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            connectionStatusLabel.Text = "Сервер активен";
            try
            {
                tcpListener.Bind(ipPoint);
                tcpListener.Listen(5);  
                MessageBox.Show("Сервер запущен. Ожидание подключений... ");

                while (true)
                {
                    using var tcpClient = await tcpListener.AcceptAsync();
                    Logs.Text += "Клиент подключен: " + tcpClient.RemoteEndPoint + '\n';

                    await Task.Delay(500);
                    var responseData = new byte[512000];
                    var response = new StringBuilder();
                                                        
                    SocketAsyncEventArgs completeArgsForReceive = new SocketAsyncEventArgs();
                    completeArgsForReceive.SetBuffer(responseData, 0, 512000);
                    completeArgsForReceive.UserToken = tcpClient;
                    completeArgsForReceive.AcceptSocket = tcpClient;
                    
                    tcpClient.ReceiveAsync(completeArgsForReceive);
                    response.Append(Encoding.UTF8.GetString(responseData, 0, responseData.Length));

                    File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\MessageForServer.xml", Encoding.UTF8.GetString(responseData, 0, completeArgsForReceive.BytesTransferred));
                    XmlSerializer ser = new XmlSerializer(typeof(Message));
                    Message message;
                    
                    using (XmlReader reader = XmlReader.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\MessageForServer.xml"))
                    {
                        message = (Message)ser.Deserialize(reader);
                    }

                    var splitStringFromXML = message.Image.Split(' ');
                    List<byte> listBytes = new List<byte>();   
                    foreach ( var item in splitStringFromXML)
                    {
                        listBytes.Add((Byte)Int32.Parse(item));
                    }
                    byte[] arrayBytes = listBytes.ToArray();

                    FormatVersionResult.Text = message.FormatVersion;
                    FromResult.Text = message.From;
                    ToResult.Text = message.To;
                    IDResult.Text = message.ID.ToString();
                    ColorResult.Text = message.Color.ToString();
                    TextResult.Text = message.Text;
                    TextResult.ForeColor = Color.FromName(message.Color);

                    MemoryStream ms = new MemoryStream(arrayBytes);
                    ms.Seek(0, SeekOrigin.Begin);
                    Bitmap bmp = new Bitmap(ms);

                    ImageResult.Image = bmp;

                    ListViewItem LVI = new ListViewItem(message.Color);
                    LVI.Tag = message;
                    XMLsListView.Items.Add(LVI);


                    string resultStringForSend = message.From + "," + message.Text + "," + message.Color + "," + message.Image + '\n';
                    byte[] data = Encoding.UTF8.GetBytes(resultStringForSend);

                    SocketAsyncEventArgs completeArgs = new SocketAsyncEventArgs();
                    completeArgs.SetBuffer(data, 0, data.Length);
                    completeArgs.UserToken = tcpClient;
                    completeArgs.AcceptSocket = tcpClient;
                    tcpClient.SendAsync(completeArgs);

                    await Task.Delay(2000);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Server_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите завершить работу с программой?", "Внимание!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void XMLsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(XMLsListView.SelectedItems.Count == 1)
            {
                Message message = (Message)XMLsListView.SelectedItems[0].Tag;

                if(message != null)
                {
                    var splitStringFromXML = message.Image.Split(' ');
                    List<byte> listBytes = new List<byte>();
                    foreach (var item in splitStringFromXML)
                    {
                        listBytes.Add((Byte)Int32.Parse(item));
                    }
                    byte[] arrayBytes = listBytes.ToArray();

                    FormatVersionResult.Text = message.FormatVersion;
                    FromResult.Text = message.From;
                    ToResult.Text = message.To;
                    IDResult.Text = message.ID.ToString();
                    ColorResult.Text = message.Color.ToString();
                    TextResult.Text = message.Text;
                    TextResult.ForeColor = Color.FromName(message.Color);

                    MemoryStream ms = new MemoryStream(arrayBytes);
                    ms.Seek(0, SeekOrigin.Begin);
                    Bitmap bmp = new Bitmap(ms);

                    ImageResult.Image = bmp;
                }
            } else if(XMLsListView.SelectedItems.Count == 0)
            {
                FormatVersionResult.Text = string.Empty;
                FromResult.Text = string.Empty;
                ToResult.Text = string.Empty;
                IDResult.Text = string.Empty;
                ColorResult.Text = string.Empty;
                TextResult.Text = string.Empty;
                ImageResult.Image = null;
            }
        }

        private void CloseConnection_Click(object sender, EventArgs e)
        {
            tcpListener.Close();
            connectionStatusLabel.Text = "Сервер неактивен";
        }

        private void Minimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
