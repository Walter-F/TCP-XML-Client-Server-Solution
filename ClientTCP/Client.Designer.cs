namespace ClientTCP
{
    partial class Client
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.Minimized = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.PictureBox();
            this.StartLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.connectionStatus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.From = new System.Windows.Forms.RichTextBox();
            this.MessageText = new System.Windows.Forms.RichTextBox();
            this.PictureResult = new System.Windows.Forms.PictureBox();
            this.RequestCompleteTime = new System.Windows.Forms.Label();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.SendRequest = new ClientTCP.Components.RoundButton();
            this.BrowseButton = new ClientTCP.Components.RoundButton();
            this.DisconnectButton = new ClientTCP.Components.RoundButton();
            this.ConnectButton = new ClientTCP.Components.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.Minimized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureResult)).BeginInit();
            this.SuspendLayout();
            // 
            // Minimized
            // 
            this.Minimized.BackColor = System.Drawing.Color.Transparent;
            this.Minimized.BackgroundImage = global::ClientTCP.Properties.Resources.Arrow_down;
            this.Minimized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimized.Location = new System.Drawing.Point(1082, 12);
            this.Minimized.Name = "Minimized";
            this.Minimized.Size = new System.Drawing.Size(50, 50);
            this.Minimized.TabIndex = 0;
            this.Minimized.TabStop = false;
            this.Minimized.Click += new System.EventHandler(this.Minimized_Click);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.BackgroundImage = global::ClientTCP.Properties.Resources.Close;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Location = new System.Drawing.Point(1138, 12);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(50, 50);
            this.Close.TabIndex = 1;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // StartLabel
            // 
            this.StartLabel.AutoSize = true;
            this.StartLabel.BackColor = System.Drawing.Color.Transparent;
            this.StartLabel.Font = new System.Drawing.Font("Yu Gothic UI Light", 16F);
            this.StartLabel.Location = new System.Drawing.Point(130, 120);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(241, 30);
            this.StartLabel.TabIndex = 3;
            this.StartLabel.Text = "Информация о сервере";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Light", 16F);
            this.label1.Location = new System.Drawing.Point(91, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP сервера:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Light", 16F);
            this.label2.Location = new System.Drawing.Point(90, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Порт сервера:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Light", 16F);
            this.label3.Location = new System.Drawing.Point(90, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Состояние:";
            // 
            // connectionStatus
            // 
            this.connectionStatus.AutoSize = true;
            this.connectionStatus.BackColor = System.Drawing.Color.Transparent;
            this.connectionStatus.Font = new System.Drawing.Font("Yu Gothic UI Light", 16F);
            this.connectionStatus.Location = new System.Drawing.Point(252, 247);
            this.connectionStatus.Name = "connectionStatus";
            this.connectionStatus.Size = new System.Drawing.Size(274, 30);
            this.connectionStatus.TabIndex = 9;
            this.connectionStatus.Text = "Подключение установлено";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI Light", 16F);
            this.label5.Location = new System.Drawing.Point(252, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "8888";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI Light", 16F);
            this.label6.Location = new System.Drawing.Point(252, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 30);
            this.label6.TabIndex = 7;
            this.label6.Text = "127.0.0.1";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI Light", 16F);
            this.label7.Location = new System.Drawing.Point(90, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(352, 273);
            this.label7.TabIndex = 12;
            this.label7.Text = "Выберите ваш файл формата XML, чтобы получить данные и увидеть их в правой панели" +
    ".\r\n\r\nВы можете обратиться к серверу повторно с тем же файлом или новым, но будьт" +
    "е уверены, что формат данных корректен.";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI Light", 16F);
            this.label8.Location = new System.Drawing.Point(727, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(374, 30);
            this.label8.TabIndex = 14;
            this.label8.Text = "Блок вывода информации от сервера";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI Light", 14F);
            this.label9.Location = new System.Drawing.Point(638, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "От кого сообщение";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Yu Gothic UI Light", 14F);
            this.label10.Location = new System.Drawing.Point(956, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 25);
            this.label10.TabIndex = 16;
            this.label10.Text = "Текст сообщение";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Yu Gothic UI Light", 14F);
            this.label11.Location = new System.Drawing.Point(814, 351);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 25);
            this.label11.TabIndex = 17;
            this.label11.Text = "Изображение";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Yu Gothic UI Light", 16F);
            this.label12.Location = new System.Drawing.Point(727, 631);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(322, 30);
            this.label12.TabIndex = 18;
            this.label12.Text = "Время полученного сообщения:";
            // 
            // From
            // 
            this.From.Location = new System.Drawing.Point(607, 205);
            this.From.Name = "From";
            this.From.ReadOnly = true;
            this.From.Size = new System.Drawing.Size(235, 143);
            this.From.TabIndex = 20;
            this.From.Text = "";
            // 
            // MessageText
            // 
            this.MessageText.Location = new System.Drawing.Point(916, 207);
            this.MessageText.Name = "MessageText";
            this.MessageText.ReadOnly = true;
            this.MessageText.Size = new System.Drawing.Size(235, 143);
            this.MessageText.TabIndex = 21;
            this.MessageText.Text = "";
            // 
            // PictureResult
            // 
            this.PictureResult.Location = new System.Drawing.Point(785, 388);
            this.PictureResult.Name = "PictureResult";
            this.PictureResult.Size = new System.Drawing.Size(200, 202);
            this.PictureResult.TabIndex = 22;
            this.PictureResult.TabStop = false;
            // 
            // RequestCompleteTime
            // 
            this.RequestCompleteTime.BackColor = System.Drawing.Color.Transparent;
            this.RequestCompleteTime.Font = new System.Drawing.Font("Yu Gothic UI Light", 16F);
            this.RequestCompleteTime.Location = new System.Drawing.Point(727, 674);
            this.RequestCompleteTime.Name = "RequestCompleteTime";
            this.RequestCompleteTime.Size = new System.Drawing.Size(322, 30);
            this.RequestCompleteTime.TabIndex = 23;
            this.RequestCompleteTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.FileNameLabel.Font = new System.Drawing.Font("Yu Gothic UI Light", 16F);
            this.FileNameLabel.Location = new System.Drawing.Point(347, 674);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(0, 30);
            this.FileNameLabel.TabIndex = 25;
            // 
            // SendRequest
            // 
            this.SendRequest.BackColor2 = System.Drawing.Color.Transparent;
            this.SendRequest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SendRequest.BackgroundImage")));
            this.SendRequest.ButtonBorderColor = System.Drawing.Color.Black;
            this.SendRequest.ButtonHighlightColor = System.Drawing.Color.Black;
            this.SendRequest.ButtonHighlightColor2 = System.Drawing.Color.Black;
            this.SendRequest.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.SendRequest.ButtonPressedColor = System.Drawing.Color.Black;
            this.SendRequest.ButtonPressedColor2 = System.Drawing.Color.Black;
            this.SendRequest.ButtonPressedForeColor = System.Drawing.Color.Black;
            this.SendRequest.ButtonRoundRadius = 30;
            this.SendRequest.Font = new System.Drawing.Font("Yu Gothic UI Light", 8.25F);
            this.SendRequest.Location = new System.Drawing.Point(180, 731);
            this.SendRequest.Name = "SendRequest";
            this.SendRequest.Size = new System.Drawing.Size(147, 57);
            this.SendRequest.TabIndex = 24;
            this.SendRequest.Text = "Отправить запрос на сервер";
            this.SendRequest.Click += new System.EventHandler(this.SendRequest_Click);
            // 
            // BrowseButton
            // 
            this.BrowseButton.BackColor2 = System.Drawing.Color.Transparent;
            this.BrowseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BrowseButton.BackgroundImage")));
            this.BrowseButton.ButtonBorderColor = System.Drawing.Color.Black;
            this.BrowseButton.ButtonHighlightColor = System.Drawing.Color.Black;
            this.BrowseButton.ButtonHighlightColor2 = System.Drawing.Color.Black;
            this.BrowseButton.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.BrowseButton.ButtonPressedColor = System.Drawing.Color.Black;
            this.BrowseButton.ButtonPressedColor2 = System.Drawing.Color.Black;
            this.BrowseButton.ButtonPressedForeColor = System.Drawing.Color.Black;
            this.BrowseButton.ButtonRoundRadius = 30;
            this.BrowseButton.Font = new System.Drawing.Font("Yu Gothic UI Light", 8.25F);
            this.BrowseButton.Location = new System.Drawing.Point(180, 664);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(147, 57);
            this.BrowseButton.TabIndex = 13;
            this.BrowseButton.Text = "Обзор..";
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.BackColor2 = System.Drawing.Color.Transparent;
            this.DisconnectButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DisconnectButton.BackgroundImage")));
            this.DisconnectButton.ButtonBorderColor = System.Drawing.Color.Black;
            this.DisconnectButton.ButtonHighlightColor = System.Drawing.Color.Black;
            this.DisconnectButton.ButtonHighlightColor2 = System.Drawing.Color.Black;
            this.DisconnectButton.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.DisconnectButton.ButtonPressedColor = System.Drawing.Color.Black;
            this.DisconnectButton.ButtonPressedColor2 = System.Drawing.Color.Black;
            this.DisconnectButton.ButtonPressedForeColor = System.Drawing.Color.Black;
            this.DisconnectButton.ButtonRoundRadius = 30;
            this.DisconnectButton.Font = new System.Drawing.Font("Yu Gothic UI Light", 8.25F);
            this.DisconnectButton.Location = new System.Drawing.Point(257, 298);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(147, 57);
            this.DisconnectButton.TabIndex = 11;
            this.DisconnectButton.Text = "Отключиться";
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.BackColor2 = System.Drawing.Color.Transparent;
            this.ConnectButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ConnectButton.BackgroundImage")));
            this.ConnectButton.ButtonBorderColor = System.Drawing.Color.Black;
            this.ConnectButton.ButtonHighlightColor = System.Drawing.Color.Black;
            this.ConnectButton.ButtonHighlightColor2 = System.Drawing.Color.Black;
            this.ConnectButton.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.ConnectButton.ButtonPressedColor = System.Drawing.Color.Black;
            this.ConnectButton.ButtonPressedColor2 = System.Drawing.Color.Black;
            this.ConnectButton.ButtonPressedForeColor = System.Drawing.Color.Black;
            this.ConnectButton.ButtonRoundRadius = 30;
            this.ConnectButton.Font = new System.Drawing.Font("Yu Gothic UI Light", 8.25F);
            this.ConnectButton.Location = new System.Drawing.Point(104, 298);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(147, 57);
            this.ConnectButton.TabIndex = 10;
            this.ConnectButton.Text = "Подключиться";
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ClientTCP.Properties.Resources.Клиентская_часть;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.SendRequest);
            this.Controls.Add(this.RequestCompleteTime);
            this.Controls.Add(this.PictureResult);
            this.Controls.Add(this.MessageText);
            this.Controls.Add(this.From);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DisconnectButton);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.connectionStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartLabel);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Minimized);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Client_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.Minimized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Minimized;
        private System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.Label StartLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label connectionStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Components.RoundButton ConnectButton;
        private Components.RoundButton DisconnectButton;
        private System.Windows.Forms.Label label7;
        private Components.RoundButton BrowseButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox From;
        private System.Windows.Forms.RichTextBox MessageText;
        private System.Windows.Forms.PictureBox PictureResult;
        private System.Windows.Forms.Label RequestCompleteTime;
        private Components.RoundButton SendRequest;
        private System.Windows.Forms.Label FileNameLabel;
    }
}