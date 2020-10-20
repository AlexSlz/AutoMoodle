namespace autoMoodle
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Start = new System.Windows.Forms.Button();
            this.Login_box = new System.Windows.Forms.TextBox();
            this.Pass_box = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.autoOpen = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.context = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browserVisib = new System.Windows.Forms.CheckBox();
            this.ticktak = new System.Windows.Forms.Timer(this.components);
            this.saveinternet = new System.Windows.Forms.Timer(this.components);
            this.consoleVisib = new System.Windows.Forms.CheckBox();
            this.loginText = new System.Windows.Forms.Label();
            this.passText = new System.Windows.Forms.Label();
            this.reloadBest = new System.Windows.Forms.Label();
            this.reloadCountT = new System.Windows.Forms.Label();
            this.link = new System.Windows.Forms.Label();
            this.UpdButton = new System.Windows.Forms.Button();
            this.link2 = new System.Windows.Forms.Label();
            this.internetTest = new System.Windows.Forms.Label();
            this.context.SuspendLayout();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start.Location = new System.Drawing.Point(12, 12);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(148, 23);
            this.Start.TabIndex = 0;
            this.Start.Text = "Запустить Браузер";
            this.Start.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login_box
            // 
            this.Login_box.AccessibleDescription = "";
            this.Login_box.Location = new System.Drawing.Point(272, 100);
            this.Login_box.Name = "Login_box";
            this.Login_box.Size = new System.Drawing.Size(100, 20);
            this.Login_box.TabIndex = 1;
            this.Login_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Login_box.TextChanged += new System.EventHandler(this.Login_box_TextChanged);
            // 
            // Pass_box
            // 
            this.Pass_box.Location = new System.Drawing.Point(272, 139);
            this.Pass_box.Name = "Pass_box";
            this.Pass_box.Size = new System.Drawing.Size(100, 20);
            this.Pass_box.TabIndex = 2;
            this.Pass_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Pass_box.TextChanged += new System.EventHandler(this.Pass_box_TextChanged);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(272, 165);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(100, 23);
            this.Save.TabIndex = 3;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // autoOpen
            // 
            this.autoOpen.AutoSize = true;
            this.autoOpen.Checked = true;
            this.autoOpen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.autoOpen.Location = new System.Drawing.Point(12, 41);
            this.autoOpen.Name = "autoOpen";
            this.autoOpen.Size = new System.Drawing.Size(193, 22);
            this.autoOpen.TabIndex = 4;
            this.autoOpen.Text = "Автоматический запуск";
            this.autoOpen.UseVisualStyleBackColor = true;
            this.autoOpen.CheckedChanged += new System.EventHandler(this.autoOpen_CheckedChanged);
            this.autoOpen.MouseCaptureChanged += new System.EventHandler(this.autoOpen_MouseCaptureChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trayIcon
            // 
            this.trayIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.trayIcon.BalloonTipText = "Why";
            this.trayIcon.BalloonTipTitle = "Alert";
            this.trayIcon.ContextMenuStrip = this.context;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "Wa";
            this.trayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseClick);
            // 
            // context
            // 
            this.context.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.закрытьToolStripMenuItem});
            this.context.Name = "context";
            this.context.Size = new System.Drawing.Size(121, 26);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // browserVisib
            // 
            this.browserVisib.AutoSize = true;
            this.browserVisib.Location = new System.Drawing.Point(12, 155);
            this.browserVisib.Name = "browserVisib";
            this.browserVisib.Size = new System.Drawing.Size(132, 17);
            this.browserVisib.TabIndex = 5;
            this.browserVisib.Text = "Отображать браузер";
            this.browserVisib.UseVisualStyleBackColor = true;
            this.browserVisib.CheckedChanged += new System.EventHandler(this.browserVisib_CheckedChanged);
            this.browserVisib.MouseCaptureChanged += new System.EventHandler(this.CheckBoxRelandVisib);
            // 
            // ticktak
            // 
            this.ticktak.Tick += new System.EventHandler(this.ticktak_Tick);
            // 
            // saveinternet
            // 
            this.saveinternet.Interval = 5000;
            this.saveinternet.Tick += new System.EventHandler(this.saveinternet_Tick);
            // 
            // consoleVisib
            // 
            this.consoleVisib.AutoSize = true;
            this.consoleVisib.Location = new System.Drawing.Point(12, 171);
            this.consoleVisib.Name = "consoleVisib";
            this.consoleVisib.Size = new System.Drawing.Size(133, 17);
            this.consoleVisib.TabIndex = 7;
            this.consoleVisib.Text = "Отображать консоль";
            this.consoleVisib.UseVisualStyleBackColor = true;
            this.consoleVisib.MouseCaptureChanged += new System.EventHandler(this.CheckBoxRelandVisib);
            // 
            // loginText
            // 
            this.loginText.AutoSize = true;
            this.loginText.Location = new System.Drawing.Point(269, 84);
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(38, 13);
            this.loginText.TabIndex = 10;
            this.loginText.Text = "Логин";
            // 
            // passText
            // 
            this.passText.AutoSize = true;
            this.passText.Location = new System.Drawing.Point(269, 123);
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(45, 13);
            this.passText.TabIndex = 11;
            this.passText.Text = "Пароль";
            // 
            // reloadBest
            // 
            this.reloadBest.AutoSize = true;
            this.reloadBest.Location = new System.Drawing.Point(9, 64);
            this.reloadBest.Name = "reloadBest";
            this.reloadBest.Size = new System.Drawing.Size(236, 13);
            this.reloadBest.TabIndex = 13;
            this.reloadBest.Text = "Максимальное количество перезагрузок = 0";
            // 
            // reloadCountT
            // 
            this.reloadCountT.AutoSize = true;
            this.reloadCountT.Location = new System.Drawing.Point(9, 77);
            this.reloadCountT.Name = "reloadCountT";
            this.reloadCountT.Size = new System.Drawing.Size(157, 13);
            this.reloadCountT.TabIndex = 14;
            this.reloadCountT.Text = "Количество перезагрузок = 0";
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.link.Location = new System.Drawing.Point(151, 173);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(103, 15);
            this.link.TabIndex = 17;
            this.link.Text = "Create By ALex S.";
            this.link.Click += new System.EventHandler(this.link_Click);
            // 
            // UpdButton
            // 
            this.UpdButton.Location = new System.Drawing.Point(165, 12);
            this.UpdButton.Name = "UpdButton";
            this.UpdButton.Size = new System.Drawing.Size(89, 23);
            this.UpdButton.TabIndex = 18;
            this.UpdButton.Text = "Обновиться";
            this.UpdButton.UseVisualStyleBackColor = true;
            this.UpdButton.Visible = false;
            this.UpdButton.Click += new System.EventHandler(this.UpdButton_Click);
            // 
            // link2
            // 
            this.link2.AutoSize = true;
            this.link2.Location = new System.Drawing.Point(279, 77);
            this.link2.Name = "link2";
            this.link2.Size = new System.Drawing.Size(93, 13);
            this.link2.TabIndex = 19;
            this.link2.Text = "Create By ALex S.";
            this.link2.Visible = false;
            this.link2.Click += new System.EventHandler(this.link_Click);
            // 
            // internetTest
            // 
            this.internetTest.AutoSize = true;
            this.internetTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.internetTest.ForeColor = System.Drawing.Color.Black;
            this.internetTest.Location = new System.Drawing.Point(277, 9);
            this.internetTest.Name = "internetTest";
            this.internetTest.Size = new System.Drawing.Size(59, 18);
            this.internetTest.TabIndex = 20;
            this.internetTest.Text = "хмммм";
            this.internetTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 191);
            this.Controls.Add(this.internetTest);
            this.Controls.Add(this.link2);
            this.Controls.Add(this.UpdButton);
            this.Controls.Add(this.link);
            this.Controls.Add(this.reloadCountT);
            this.Controls.Add(this.reloadBest);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.loginText);
            this.Controls.Add(this.consoleVisib);
            this.Controls.Add(this.browserVisib);
            this.Controls.Add(this.autoOpen);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Pass_box);
            this.Controls.Add(this.Login_box);
            this.Controls.Add(this.Start);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.context.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TextBox Login_box;
        private System.Windows.Forms.TextBox Pass_box;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.CheckBox autoOpen;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.CheckBox browserVisib;
        private System.Windows.Forms.Timer ticktak;
        private System.Windows.Forms.Timer saveinternet;
        private System.Windows.Forms.CheckBox consoleVisib;
        private System.Windows.Forms.Label loginText;
        private System.Windows.Forms.Label passText;
        private System.Windows.Forms.ContextMenuStrip context;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.Label reloadBest;
        private System.Windows.Forms.Label reloadCountT;
        private System.Windows.Forms.Label link;
        private System.Windows.Forms.Button UpdButton;
        private System.Windows.Forms.Label link2;
        private System.Windows.Forms.Label internetTest;
    }
}

