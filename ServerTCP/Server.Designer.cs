namespace ServerTCP
{
    partial class Server
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server));
            this.Minimized = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.PictureBox();
            this.connectionStatusLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StartLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.XMLsListView = new System.Windows.Forms.ListView();
            this.label8 = new System.Windows.Forms.Label();
            this.Logs = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.FormatVersionResult = new System.Windows.Forms.RichTextBox();
            this.FromResult = new System.Windows.Forms.RichTextBox();
            this.ToResult = new System.Windows.Forms.RichTextBox();
            this.IDResult = new System.Windows.Forms.RichTextBox();
            this.ColorResult = new System.Windows.Forms.RichTextBox();
            this.TextResult = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.ImageResult = new System.Windows.Forms.PictureBox();
            this.CloseConnection = new ServerTCP.Components.RoundButton();
            this.OpenConnection = new ServerTCP.Components.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.Minimized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageResult)).BeginInit();
            this.SuspendLayout();
            // 
            // Minimized
            // 
            this.Minimized.BackColor = System.Drawing.Color.Transparent;
            this.Minimized.BackgroundImage = global::ServerTCP.Properties.Resources.Arrow_down;
            this.Minimized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimized.Location = new System.Drawing.Point(882, 12);
            this.Minimized.Name = "Minimized";
            this.Minimized.Size = new System.Drawing.Size(50, 50);
            this.Minimized.TabIndex = 0;
            this.Minimized.TabStop = false;
            this.Minimized.Click += new System.EventHandler(this.Minimized_Click);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.BackgroundImage = global::ServerTCP.Properties.Resources.Close;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Location = new System.Drawing.Point(938, 12);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(50, 50);
            this.Close.TabIndex = 1;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // connectionStatusLabel
            // 
            this.connectionStatusLabel.AutoSize = true;
            this.connectionStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.connectionStatusLabel.Font = new System.Drawing.Font("Yu Gothic UI Light", 16F);
            this.connectionStatusLabel.Location = new System.Drawing.Point(231, 257);
            this.connectionStatusLabel.Name = "connectionStatusLabel";
            this.connectionStatusLabel.Size = new System.Drawing.Size(188, 30);
            this.connectionStatusLabel.TabIndex = 16;
            this.connectionStatusLabel.Text = "Сервер неактивен";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI Light", 16F);
            this.label5.Location = new System.Drawing.Point(231, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 30);
            this.label5.TabIndex = 15;
            this.label5.Text = "8888";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI Light", 16F);
            this.label6.Location = new System.Drawing.Point(231, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 30);
            this.label6.TabIndex = 14;
            this.label6.Text = "127.0.0.1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Light", 16F);
            this.label3.Location = new System.Drawing.Point(69, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 30);
            this.label3.TabIndex = 13;
            this.label3.Text = "Состояние:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Light", 16F);
            this.label2.Location = new System.Drawing.Point(69, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 30);
            this.label2.TabIndex = 12;
            this.label2.Text = "Порт сервера:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Light", 16F);
            this.label1.Location = new System.Drawing.Point(70, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "IP сервера:";
            // 
            // StartLabel
            // 
            this.StartLabel.AutoSize = true;
            this.StartLabel.BackColor = System.Drawing.Color.Transparent;
            this.StartLabel.Font = new System.Drawing.Font("Yu Gothic UI Light", 16F);
            this.StartLabel.Location = new System.Drawing.Point(109, 130);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(241, 30);
            this.StartLabel.TabIndex = 10;
            this.StartLabel.Text = "Информация о сервере";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI Light", 16F);
            this.label7.Location = new System.Drawing.Point(41, 403);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(464, 30);
            this.label7.TabIndex = 19;
            this.label7.Text = "Список XML-файлов, поступивших от клиентов";
            // 
            // XMLsListView
            // 
            this.XMLsListView.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.XMLsListView.Font = new System.Drawing.Font("Yu Gothic UI Light", 16F);
            this.XMLsListView.HideSelection = false;
            this.XMLsListView.Location = new System.Drawing.Point(83, 462);
            this.XMLsListView.Name = "XMLsListView";
            this.XMLsListView.Size = new System.Drawing.Size(339, 503);
            this.XMLsListView.TabIndex = 20;
            this.XMLsListView.UseCompatibleStateImageBehavior = false;
            this.XMLsListView.View = System.Windows.Forms.View.List;
            this.XMLsListView.SelectedIndexChanged += new System.EventHandler(this.XMLsListView_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI Light", 16F);
            this.label8.Location = new System.Drawing.Point(558, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(398, 30);
            this.label8.TabIndex = 21;
            this.label8.Text = "Информация о подключаемых клиентах";
            // 
            // Logs
            // 
            this.Logs.BackColor = System.Drawing.SystemColors.Window;
            this.Logs.Location = new System.Drawing.Point(563, 178);
            this.Logs.Name = "Logs";
            this.Logs.ReadOnly = true;
            this.Logs.Size = new System.Drawing.Size(393, 172);
            this.Logs.TabIndex = 22;
            this.Logs.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI Light", 16F);
            this.label9.Location = new System.Drawing.Point(558, 403);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(406, 30);
            this.label9.TabIndex = 23;
            this.label9.Text = "Блок вывода информации из XML-файла";
            // 
            // FormatVersionResult
            // 
            this.FormatVersionResult.BackColor = System.Drawing.SystemColors.Window;
            this.FormatVersionResult.Location = new System.Drawing.Point(563, 492);
            this.FormatVersionResult.Name = "FormatVersionResult";
            this.FormatVersionResult.ReadOnly = true;
            this.FormatVersionResult.Size = new System.Drawing.Size(168, 51);
            this.FormatVersionResult.TabIndex = 24;
            this.FormatVersionResult.Text = "";
            // 
            // FromResult
            // 
            this.FromResult.BackColor = System.Drawing.SystemColors.Window;
            this.FromResult.Location = new System.Drawing.Point(796, 492);
            this.FromResult.Name = "FromResult";
            this.FromResult.ReadOnly = true;
            this.FromResult.Size = new System.Drawing.Size(168, 51);
            this.FromResult.TabIndex = 25;
            this.FromResult.Text = "";
            // 
            // ToResult
            // 
            this.ToResult.BackColor = System.Drawing.SystemColors.Window;
            this.ToResult.Location = new System.Drawing.Point(563, 578);
            this.ToResult.Name = "ToResult";
            this.ToResult.ReadOnly = true;
            this.ToResult.Size = new System.Drawing.Size(168, 51);
            this.ToResult.TabIndex = 26;
            this.ToResult.Text = "";
            // 
            // IDResult
            // 
            this.IDResult.BackColor = System.Drawing.SystemColors.Window;
            this.IDResult.Location = new System.Drawing.Point(796, 578);
            this.IDResult.Name = "IDResult";
            this.IDResult.ReadOnly = true;
            this.IDResult.Size = new System.Drawing.Size(168, 51);
            this.IDResult.TabIndex = 27;
            this.IDResult.Text = "";
            // 
            // ColorResult
            // 
            this.ColorResult.BackColor = System.Drawing.SystemColors.Window;
            this.ColorResult.Location = new System.Drawing.Point(563, 661);
            this.ColorResult.Name = "ColorResult";
            this.ColorResult.ReadOnly = true;
            this.ColorResult.Size = new System.Drawing.Size(168, 51);
            this.ColorResult.TabIndex = 28;
            this.ColorResult.Text = "";
            // 
            // TextResult
            // 
            this.TextResult.BackColor = System.Drawing.SystemColors.Window;
            this.TextResult.Location = new System.Drawing.Point(796, 661);
            this.TextResult.Name = "TextResult";
            this.TextResult.ReadOnly = true;
            this.TextResult.Size = new System.Drawing.Size(168, 51);
            this.TextResult.TabIndex = 29;
            this.TextResult.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Yu Gothic UI Light", 16F);
            this.label10.Location = new System.Drawing.Point(576, 459);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 30);
            this.label10.TabIndex = 30;
            this.label10.Text = "FormatVersion";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Yu Gothic UI Light", 16F);
            this.label11.Location = new System.Drawing.Point(802, 459);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 30);
            this.label11.TabIndex = 31;
            this.label11.Text = "From";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Yu Gothic UI Light", 16F);
            this.label12.Location = new System.Drawing.Point(576, 545);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 30);
            this.label12.TabIndex = 32;
            this.label12.Text = "To";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Yu Gothic UI Light", 16F);
            this.label13.Location = new System.Drawing.Point(802, 545);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 30);
            this.label13.TabIndex = 33;
            this.label13.Text = "ID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Yu Gothic UI Light", 16F);
            this.label14.Location = new System.Drawing.Point(576, 628);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 30);
            this.label14.TabIndex = 34;
            this.label14.Text = "Color";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Yu Gothic UI Light", 16F);
            this.label15.Location = new System.Drawing.Point(802, 632);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 30);
            this.label15.TabIndex = 35;
            this.label15.Text = "Text";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Yu Gothic UI Light", 16F);
            this.label16.Location = new System.Drawing.Point(732, 739);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 30);
            this.label16.TabIndex = 36;
            this.label16.Text = "Image";
            // 
            // ImageResult
            // 
            this.ImageResult.Location = new System.Drawing.Point(670, 786);
            this.ImageResult.Name = "ImageResult";
            this.ImageResult.Size = new System.Drawing.Size(200, 202);
            this.ImageResult.TabIndex = 37;
            this.ImageResult.TabStop = false;
            // 
            // CloseConnection
            // 
            this.CloseConnection.BackColor2 = System.Drawing.Color.Transparent;
            this.CloseConnection.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseConnection.BackgroundImage")));
            this.CloseConnection.ButtonBorderColor = System.Drawing.Color.Black;
            this.CloseConnection.ButtonHighlightColor = System.Drawing.Color.Black;
            this.CloseConnection.ButtonHighlightColor2 = System.Drawing.Color.Black;
            this.CloseConnection.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.CloseConnection.ButtonPressedColor = System.Drawing.Color.Black;
            this.CloseConnection.ButtonPressedColor2 = System.Drawing.Color.Black;
            this.CloseConnection.ButtonPressedForeColor = System.Drawing.Color.Black;
            this.CloseConnection.ButtonRoundRadius = 30;
            this.CloseConnection.Font = new System.Drawing.Font("Yu Gothic UI Light", 8.25F);
            this.CloseConnection.Location = new System.Drawing.Point(236, 303);
            this.CloseConnection.Name = "CloseConnection";
            this.CloseConnection.Size = new System.Drawing.Size(147, 57);
            this.CloseConnection.TabIndex = 18;
            this.CloseConnection.Text = "Отключиться";
            this.CloseConnection.Click += new System.EventHandler(this.CloseConnection_Click);
            // 
            // OpenConnection
            // 
            this.OpenConnection.BackColor2 = System.Drawing.Color.Transparent;
            this.OpenConnection.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OpenConnection.BackgroundImage")));
            this.OpenConnection.ButtonBorderColor = System.Drawing.Color.Black;
            this.OpenConnection.ButtonHighlightColor = System.Drawing.Color.Black;
            this.OpenConnection.ButtonHighlightColor2 = System.Drawing.Color.Black;
            this.OpenConnection.ButtonHighlightForeColor = System.Drawing.Color.Black;
            this.OpenConnection.ButtonPressedColor = System.Drawing.Color.Black;
            this.OpenConnection.ButtonPressedColor2 = System.Drawing.Color.Black;
            this.OpenConnection.ButtonPressedForeColor = System.Drawing.Color.Black;
            this.OpenConnection.ButtonRoundRadius = 30;
            this.OpenConnection.Font = new System.Drawing.Font("Yu Gothic UI Light", 8.25F);
            this.OpenConnection.Location = new System.Drawing.Point(83, 303);
            this.OpenConnection.Name = "OpenConnection";
            this.OpenConnection.Size = new System.Drawing.Size(147, 57);
            this.OpenConnection.TabIndex = 17;
            this.OpenConnection.Text = "Подключиться";
            this.OpenConnection.Click += new System.EventHandler(this.OpenConnection_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ServerTCP.Properties.Resources.Серверная_часть;
            this.ClientSize = new System.Drawing.Size(1000, 1040);
            this.Controls.Add(this.ImageResult);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TextResult);
            this.Controls.Add(this.ColorResult);
            this.Controls.Add(this.IDResult);
            this.Controls.Add(this.ToResult);
            this.Controls.Add(this.FromResult);
            this.Controls.Add(this.FormatVersionResult);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Logs);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.XMLsListView);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CloseConnection);
            this.Controls.Add(this.OpenConnection);
            this.Controls.Add(this.connectionStatusLabel);
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
            this.Name = "Server";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Server_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.Minimized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Minimized;
        private System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.Label connectionStatusLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StartLabel;
        private Components.RoundButton OpenConnection;
        private Components.RoundButton CloseConnection;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView XMLsListView;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox Logs;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox FormatVersionResult;
        private System.Windows.Forms.RichTextBox FromResult;
        private System.Windows.Forms.RichTextBox ToResult;
        private System.Windows.Forms.RichTextBox IDResult;
        private System.Windows.Forms.RichTextBox ColorResult;
        private System.Windows.Forms.RichTextBox TextResult;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox ImageResult;
    }
}

