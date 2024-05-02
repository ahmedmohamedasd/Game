namespace Game
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_count = new System.Windows.Forms.Label();
            this.panel_newRegister = new System.Windows.Forms.Panel();
            this.panel_Session = new System.Windows.Forms.Panel();
            this.btn_endGame = new System.Windows.Forms.Button();
            this.panel_logged = new System.Windows.Forms.Panel();
            this.panel_Scan = new System.Windows.Forms.Panel();
            this.lbl_camera = new System.Windows.Forms.Label();
            this.cboDevice = new System.Windows.Forms.ComboBox();
            this.Panel_Camera = new System.Windows.Forms.Panel();
            this.pictureBox_Scanning = new System.Windows.Forms.PictureBox();
            this.pic_scan = new System.Windows.Forms.PictureBox();
            this.Scan_Message2 = new System.Windows.Forms.Label();
            this.Scan_Message1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.StartGame_Logged = new System.Windows.Forms.Button();
            this.Logged_User = new System.Windows.Forms.Label();
            this.Welcome_Back = new System.Windows.Forms.Label();
            this.Session_Message2 = new System.Windows.Forms.Label();
            this.Session_Message = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.StartGame_newUser = new System.Windows.Forms.Button();
            this.UserEmail = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.TextBox();
            this.WelcomeMessage = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cameraTimer = new System.Windows.Forms.Timer(this.components);
            this.checking_Game_timer = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Setting_Timer = new System.Windows.Forms.Timer(this.components);
            this.panel_Loading = new System.Windows.Forms.Panel();
            this.lbl_loading = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel_newRegister.SuspendLayout();
            this.panel_Session.SuspendLayout();
            this.panel_logged.SuspendLayout();
            this.panel_Scan.SuspendLayout();
            this.Panel_Camera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Scanning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_scan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_Loading.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_count);
            this.panel1.Controls.Add(this.panel_newRegister);
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // lbl_count
            // 
            resources.ApplyResources(this.lbl_count, "lbl_count");
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel_newRegister
            // 
            this.panel_newRegister.Controls.Add(this.panel_Loading);
            this.panel_newRegister.Controls.Add(this.panel_Session);
            this.panel_newRegister.Controls.Add(this.pictureBox3);
            this.panel_newRegister.Controls.Add(this.StartGame_newUser);
            this.panel_newRegister.Controls.Add(this.UserEmail);
            this.panel_newRegister.Controls.Add(this.UserName);
            this.panel_newRegister.Controls.Add(this.WelcomeMessage);
            resources.ApplyResources(this.panel_newRegister, "panel_newRegister");
            this.panel_newRegister.Name = "panel_newRegister";
            // 
            // panel_Session
            // 
            this.panel_Session.Controls.Add(this.btn_endGame);
            this.panel_Session.Controls.Add(this.panel_logged);
            this.panel_Session.Controls.Add(this.Session_Message2);
            this.panel_Session.Controls.Add(this.Session_Message);
            resources.ApplyResources(this.panel_Session, "panel_Session");
            this.panel_Session.Name = "panel_Session";
            // 
            // btn_endGame
            // 
            this.btn_endGame.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btn_endGame, "btn_endGame");
            this.btn_endGame.Name = "btn_endGame";
            this.btn_endGame.UseVisualStyleBackColor = false;
            this.btn_endGame.Click += new System.EventHandler(this.btn_endGame_Click);
            // 
            // panel_logged
            // 
            this.panel_logged.Controls.Add(this.panel_Scan);
            this.panel_logged.Controls.Add(this.pictureBox2);
            this.panel_logged.Controls.Add(this.StartGame_Logged);
            this.panel_logged.Controls.Add(this.Logged_User);
            this.panel_logged.Controls.Add(this.Welcome_Back);
            resources.ApplyResources(this.panel_logged, "panel_logged");
            this.panel_logged.Name = "panel_logged";
            // 
            // panel_Scan
            // 
            this.panel_Scan.Controls.Add(this.lbl_camera);
            this.panel_Scan.Controls.Add(this.cboDevice);
            this.panel_Scan.Controls.Add(this.Panel_Camera);
            this.panel_Scan.Controls.Add(this.pic_scan);
            this.panel_Scan.Controls.Add(this.Scan_Message2);
            this.panel_Scan.Controls.Add(this.Scan_Message1);
            resources.ApplyResources(this.panel_Scan, "panel_Scan");
            this.panel_Scan.Name = "panel_Scan";
            // 
            // lbl_camera
            // 
            resources.ApplyResources(this.lbl_camera, "lbl_camera");
            this.lbl_camera.Name = "lbl_camera";
            // 
            // cboDevice
            // 
            this.cboDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDevice.FormattingEnabled = true;
            resources.ApplyResources(this.cboDevice, "cboDevice");
            this.cboDevice.Name = "cboDevice";
            // 
            // Panel_Camera
            // 
            this.Panel_Camera.Controls.Add(this.pictureBox_Scanning);
            resources.ApplyResources(this.Panel_Camera, "Panel_Camera");
            this.Panel_Camera.Name = "Panel_Camera";
            // 
            // pictureBox_Scanning
            // 
            resources.ApplyResources(this.pictureBox_Scanning, "pictureBox_Scanning");
            this.pictureBox_Scanning.Name = "pictureBox_Scanning";
            this.pictureBox_Scanning.TabStop = false;
            // 
            // pic_scan
            // 
            this.pic_scan.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.pic_scan, "pic_scan");
            this.pic_scan.Name = "pic_scan";
            this.pic_scan.TabStop = false;
            this.pic_scan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_scan_MouseClick);
            // 
            // Scan_Message2
            // 
            resources.ApplyResources(this.Scan_Message2, "Scan_Message2");
            this.Scan_Message2.Name = "Scan_Message2";
            // 
            // Scan_Message1
            // 
            resources.ApplyResources(this.Scan_Message1, "Scan_Message1");
            this.Scan_Message1.Name = "Scan_Message1";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // StartGame_Logged
            // 
            this.StartGame_Logged.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.StartGame_Logged, "StartGame_Logged");
            this.StartGame_Logged.Name = "StartGame_Logged";
            this.StartGame_Logged.UseVisualStyleBackColor = false;
            this.StartGame_Logged.Click += new System.EventHandler(this.StartGame_Logged_Click);
            // 
            // Logged_User
            // 
            resources.ApplyResources(this.Logged_User, "Logged_User");
            this.Logged_User.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Logged_User.Name = "Logged_User";
            // 
            // Welcome_Back
            // 
            resources.ApplyResources(this.Welcome_Back, "Welcome_Back");
            this.Welcome_Back.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Welcome_Back.Name = "Welcome_Back";
            // 
            // Session_Message2
            // 
            resources.ApplyResources(this.Session_Message2, "Session_Message2");
            this.Session_Message2.Name = "Session_Message2";
            // 
            // Session_Message
            // 
            resources.ApplyResources(this.Session_Message, "Session_Message");
            this.Session_Message.BackColor = System.Drawing.SystemColors.Control;
            this.Session_Message.Name = "Session_Message";
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // StartGame_newUser
            // 
            this.StartGame_newUser.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.StartGame_newUser, "StartGame_newUser");
            this.StartGame_newUser.Name = "StartGame_newUser";
            this.StartGame_newUser.UseVisualStyleBackColor = false;
            this.StartGame_newUser.Click += new System.EventHandler(this.StartGame_newUser_Click);
            // 
            // UserEmail
            // 
            this.UserEmail.BackColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.UserEmail, "UserEmail");
            this.UserEmail.ForeColor = System.Drawing.SystemColors.Window;
            this.UserEmail.Name = "UserEmail";
            // 
            // UserName
            // 
            this.UserName.BackColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.UserName, "UserName");
            this.UserName.ForeColor = System.Drawing.SystemColors.Window;
            this.UserName.Name = "UserName";
            // 
            // WelcomeMessage
            // 
            resources.ApplyResources(this.WelcomeMessage, "WelcomeMessage");
            this.WelcomeMessage.ForeColor = System.Drawing.Color.DarkOrchid;
            this.WelcomeMessage.Name = "WelcomeMessage";
            // 
            // Logo
            // 
            resources.ApplyResources(this.Logo, "Logo");
            this.Logo.Name = "Logo";
            this.Logo.TabStop = false;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cameraTimer
            // 
            this.cameraTimer.Interval = 15000;
            this.cameraTimer.Tick += new System.EventHandler(this.cameraTimer_Tick);
            // 
            // checking_Game_timer
            // 
            this.checking_Game_timer.Interval = 10000;
            this.checking_Game_timer.Tick += new System.EventHandler(this.checking_Game_timer_Tick);
            // 
            // Setting_Timer
            // 
            this.Setting_Timer.Interval = 3000;
            this.Setting_Timer.Tick += new System.EventHandler(this.Setting_Timer_Tick);
            // 
            // panel_Loading
            // 
            this.panel_Loading.Controls.Add(this.lbl_loading);
            resources.ApplyResources(this.panel_Loading, "panel_Loading");
            this.panel_Loading.Name = "panel_Loading";
            // 
            // lbl_loading
            // 
            resources.ApplyResources(this.lbl_loading, "lbl_loading");
            this.lbl_loading.Name = "lbl_loading";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_newRegister.ResumeLayout(false);
            this.panel_newRegister.PerformLayout();
            this.panel_Session.ResumeLayout(false);
            this.panel_Session.PerformLayout();
            this.panel_logged.ResumeLayout(false);
            this.panel_logged.PerformLayout();
            this.panel_Scan.ResumeLayout(false);
            this.panel_Scan.PerformLayout();
            this.Panel_Camera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Scanning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_scan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_Loading.ResumeLayout(false);
            this.panel_Loading.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel panel_newRegister;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button StartGame_newUser;
        private System.Windows.Forms.TextBox UserEmail;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Label WelcomeMessage;
        private System.Windows.Forms.Panel panel_Session;
        private System.Windows.Forms.Label Session_Message2;
        private System.Windows.Forms.Label Session_Message;
        private System.Windows.Forms.Panel panel_logged;
        private System.Windows.Forms.Label Logged_User;
        private System.Windows.Forms.Label Welcome_Back;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button StartGame_Logged;
        private System.Windows.Forms.Panel panel_Scan;
        private System.Windows.Forms.PictureBox pic_scan;
        private System.Windows.Forms.Label Scan_Message2;
        private System.Windows.Forms.Label Scan_Message1;
        private System.Windows.Forms.Panel Panel_Camera;
        private System.Windows.Forms.PictureBox pictureBox_Scanning;
        private System.Windows.Forms.ComboBox cboDevice;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer cameraTimer;
        private System.Windows.Forms.Label lbl_camera;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.Timer checking_Game_timer;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer Setting_Timer;
        private System.Windows.Forms.Button btn_endGame;
        private System.Windows.Forms.Panel panel_Loading;
        private System.Windows.Forms.Label lbl_loading;
    }
}

