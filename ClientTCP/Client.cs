using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClientTCP
{
    public partial class Client : Form
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        string filename = string.Empty;
        Socket tcpClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public Client()
        {
            InitializeComponent();

            openFileDialog.Filter = "XML files(*.xml)|*.xml|All files(*.*)|*.*";
        }

        // Выбор файла для последующей отправки на сервер
        private async void BrowseButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            filename = openFileDialog.FileName;

            FileNameLabel.Text = openFileDialog.SafeFileName;
        }


        // Перемещение форму по нажатию мыши для None-Sizable свойства
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Client_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // Завершение работы 
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

        // Создание сокета для подключения
        private async void ConnectButton_Click(object sender, EventArgs e)
        {
            tcpClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            connectionStatus.Text = "Подключение установлено";
        }

        // Закрытие подключения и освобождение ресурсов
        private async void DisconnectButton_Click(object sender, EventArgs e)
        {
            /*
            SocketAsyncEventArgs socketAsyncEventArgs = new SocketAsyncEventArgs();
            socketAsyncEventArgs.DisconnectReuseSocket = true;
            socketAsyncEventArgs.AcceptSocket = tcpClient;
            socketAsyncEventArgs.UserToken = tcpClient;
            */

            tcpClient.Close();
            connectionStatus.Text = "Подключение не установлено";
        }

        // Ключевая функция для взаимодействия с сервером
        private async void SendRequest_Click(object sender, EventArgs e)
        {
            if (filename != string.Empty)
            {
                if(connectionStatus.Text == "Соединение завершено")
                {
                    MessageBox.Show("Подключитесь к серверу, воспользовавшись соответствующей кнопкой выше");
                    return;
                }

                if (tcpClient.Connected == false)
                {
                    await tcpClient.ConnectAsync("127.0.0.1", 8888);
                }

                string fileText = System.IO.File.ReadAllText(filename);

                try
                {
                    byte[] requestData = Encoding.UTF8.GetBytes(fileText);

                    SocketAsyncEventArgs completeArgs = new SocketAsyncEventArgs();
                    completeArgs.SetBuffer(requestData, 0, requestData.Length);
                    completeArgs.UserToken = tcpClient;
                    completeArgs.AcceptSocket = tcpClient;
                    tcpClient.SendAsync(completeArgs);

                    await Task.Delay(2000);
                    var responseData = new byte[512000];
                    var response = new StringBuilder();

                    SocketAsyncEventArgs completeArgsForReceive = new SocketAsyncEventArgs();
                    completeArgsForReceive.SetBuffer(responseData, 0, 512000);
                    completeArgsForReceive.UserToken = tcpClient;
                    completeArgsForReceive.AcceptSocket = tcpClient;
                    tcpClient.ReceiveAsync(completeArgsForReceive);
                    response.Append(Encoding.UTF8.GetString(responseData, 0, responseData.Length));

                    var resultArrayToShow = response.ToString().Split(',');
                    From.Text = resultArrayToShow[0];
                    MessageText.Text = resultArrayToShow[1];
                    MessageText.ForeColor = Color.FromName(resultArrayToShow[2]);

                    var splitStringFromXML = resultArrayToShow[3].Split(' ');
                    List<byte> listBytes = new List<byte>();
                    foreach (var item in splitStringFromXML)
                    {
                        listBytes.Add((Byte)Int32.Parse(item));
                    }
                    byte[] arrayBytes = listBytes.ToArray();

                    MemoryStream ms = new MemoryStream(arrayBytes);
                    ms.Seek(0, SeekOrigin.Begin);
                    Bitmap bmp = new Bitmap(ms);

                    PictureResult.Image = bmp;
                    RequestCompleteTime.Text = DateTime.Now.ToString();

                    tcpClient.Close();
                    connectionStatus.Text = "Соединение завершено";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } else
            {
                MessageBox.Show("Для начала выберите XML-файла, который хотите отправить для обработки");
            }
        }

        private void Minimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
