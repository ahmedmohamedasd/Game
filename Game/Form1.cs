using AForge.Video;
using AForge.Video.DirectShow;
using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.QrCode;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string phUserName = "Your Name";
        string phUserEmail = "Your Email";
        string qrCode = "";
        string apiUrl = "https://macber.online/sta/index.php?action=";
        Color farbe;
        Color newColour = Color.FromArgb(119, 2, 110);
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;
        ApiService service = new ApiService();
        private int counter = 0;
        private DateTime _lastClickedAt = DateTime.MinValue;
        UserModel currentUser = new UserModel();
        SettingForm settingForm = new SettingForm();
        
        private async void Form1_Load(object sender, EventArgs e)
        {


            #region styling
            this.ActiveControl = WelcomeMessage;
            WelcomeMessage.ForeColor = newColour;
            UserName.ForeColor = newColour;
            UserEmail.ForeColor = newColour;

            StartGame_newUser.ForeColor = newColour;
            Session_Message.ForeColor = newColour;
            Session_Message2.ForeColor = newColour;
            Scan_Message1.ForeColor = newColour;
            Scan_Message2.ForeColor = newColour;

            Logged_User.ForeColor = newColour;
            Logged_User.Left = (this.ClientSize.Width - Logged_User.Width) / 2;
            Welcome_Back.Left = (this.ClientSize.Width - Welcome_Back.Width) / 2;
            //Scanning Panel
            Scan_Message1.Left = (this.ClientSize.Width - Scan_Message1.Width) / 2;
            Scan_Message2.Left = (this.ClientSize.Width - Scan_Message2.Width) / 2;
            btn_endGame.Left = (this.ClientSize.Width - btn_endGame.Width) / 2;
            lbl_loading.Left = (this.ClientSize.Width - lbl_loading.Width) / 2;
            btn_endGame.ForeColor = newColour;
            lbl_loading.ForeColor = newColour;

            Logo.Left = (this.ClientSize.Width - Logo.Width) / 2;
            StartGame_Logged.ForeColor = newColour;

            if (UserEmail.Text == "Your Email")
            {
                UserEmail.ForeColor = Color.Gray;
            }
            else
            {
                UserEmail.ForeColor = newColour;
            }

            if (UserName.Text == "Your Name")
            {
                UserName.ForeColor = Color.Gray;
            }
            else
            {
                UserName.ForeColor = newColour;

            }
            farbe = newColour;
            UserName.GotFocus += RemoveText;
            UserName.LostFocus += AddText;
            UserName.Text = phUserName;


            UserEmail.GotFocus += RemoveEmailText;
            UserEmail.LostFocus += AddEmailText;
            UserEmail.Text = phUserEmail;

            lbl_camera.ForeColor = newColour;
            #endregion


            #region Scanning

            // Selecting Camera

            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                cboDevice.Items.Add(filterInfo);
            cboDevice.SelectedIndex = 0;
            cboDevice.Visible = false;
            lbl_camera.Visible = false;
            //End Of Selecting Camera




            #endregion

            displayLoadingPanel();
            
            #region checking Game
            var machineModel = settingForm.getMachineModelFromJsonfile();
            if(machineModel?.currentMachine.game_id == "")
            {
                settingForm.Closed += (s, args) => this.Close();
                settingForm.Show();
                this.Hide();

            }
            var checkcFormdata = new Dictionary<string, string>() {

                {"machine_id",machineModel.currentMachine.machine_id },
                {"game_id",machineModel.currentMachine.game_id }

            };

            var checkingGame = await service.CheckingGame(apiUrl, "check", checkcFormdata);
            if (checkingGame.Errors == null)
            {
                if (checkingGame.running == 1)
                {
                    displaySessionPanel();
                    checking_Game_timer.Start();
                }
                else
                {
                    displayScanPanel();
                    checking_Game_timer.Stop();
                }
            }
            #endregion
            cameraTimer.Interval = 20000;
        }
        #region Methoud Styling
        public void RemoveText(object sender, EventArgs e)
        {
            UserName.ForeColor = farbe;
            if (UserName.Text == phUserName)
            {
                UserName.Text = "";

            }

        }

        public void RemoveEmailText(object sender, EventArgs e)
        {
            UserEmail.ForeColor = farbe;

            if (UserEmail.Text == phUserEmail)
                UserEmail.Text = "";
        }

        public void AddText(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(UserName.Text))
            {
                UserName.ForeColor = Color.Gray;
                UserName.Text = phUserName;
            }

        }
        public void AddEmailText(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(UserEmail.Text))
            {
                UserEmail.ForeColor = Color.Gray;
                UserEmail.Text = phUserEmail;
            }
        }
        #endregion

        private async void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox_Scanning.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                barcodeReader.Options.PossibleFormats = new List<BarcodeFormat> { BarcodeFormat.QR_CODE };
                Result result = barcodeReader.Decode((Bitmap)pictureBox_Scanning.Image);
                if (result != null)
                {
                   qrCode = result.ToString();

                    if (captureDevice.IsRunning)
                    {
                        captureDevice.Stop();
                    }
                    var formData = new Dictionary<string, string>
                    {
                        {"qr_code",qrCode }
                    };

                     var scannedQrcode = await  service.ScanQrcode(apiUrl, "scan", formData);
                    if(scannedQrcode.user == null)
                    {
                        displayNewRegisterPanel();

                    }
                    else
                    {
                        displayloggedPanel();
                        currentUser = scannedQrcode.user;
                        Logged_User.Text = currentUser.name;

                    }

                    timer1.Stop();
                }
            }
        }

       
        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {

            pictureBox_Scanning.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice != null && captureDevice.IsRunning)
            {
                captureDevice.Stop();
            }
        }

        private void pic_scan_MouseClick(object sender, MouseEventArgs e)
        {
            Panel_Camera.Visible = true;
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cboDevice.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
            cameraTimer.Start();
            cboDevice.Visible = true;
            lbl_camera.Visible = true;
        }

        private void cameraTimer_Tick(object sender, EventArgs e)
        {
            panel_Scan.Visible = true;
            Panel_Camera.Visible = false;
            cameraTimer.Stop();
            if (captureDevice != null && captureDevice.IsRunning)
            {
                captureDevice.Stop();
                timer1.Stop();
            }
            cboDevice.Visible = false;
            lbl_camera.Visible = false;
        }

        private async void StartGame_newUser_Click(object sender, EventArgs e)
        {
            displayLoadingPanel();
            if(string.IsNullOrWhiteSpace(UserName.Text) || UserName.Text =="Your Name" || string.IsNullOrWhiteSpace(UserEmail.Text) || UserEmail.Text == "Your Email")
            {
                MessageBox.Show("User Name or Email can not be Null");
                displayNewRegisterPanel();
            }
            else
            {
                string emailPattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
                if (!System.Text.RegularExpressions.Regex.IsMatch(UserEmail.Text, emailPattern))
                {
                    displayNewRegisterPanel();
                    MessageBox.Show("InValid email format");
                }
                else
                {
                    var formData = new Dictionary<string, string>
                    {
                        { "name", UserName.Text },
                        { "email", UserEmail.Text },
                        { "qr_code", qrCode }
                     };

                    var register = await service.Register(apiUrl, "register", formData);
                    if (register.Errors == null && register.user != null)
                    {

                        var machineModel = settingForm.getMachineModelFromJsonfile();
                        var gameFormData = new Dictionary<string, string>
                        {
                            {"machine_id", machineModel.currentMachine.machine_id},
                            {"game_id", machineModel.currentMachine.game_id},
                            {"user_id", register.user.id.ToString()}
                        };
                        var startGame = await service.StartGame(apiUrl, "start", gameFormData);
                        if (startGame.status == 200)
                        {

                            if (startGame.running == 1)
                            {
                                displaySessionPanel();

                            }
                            else
                            {
                                displayScanPanel();
                                MessageBox.Show("Game is Available Now you can Scan to Play");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Un Expected error");
                            displayScanPanel();

                        }

                    }
                }
              
            }
          

        }
        #region Display Panel

        private void displayLoadingPanel()
        {
            panel_newRegister.Visible = true;
            panel_logged.Visible = true;
            panel_Scan.Visible = true;
            panel_Session.Visible = true;
            btn_endGame.Visible = false;
            panel_Loading.Visible = true;
        }
        private void displayScanPanel()
        {
            panel_newRegister.Visible = true;
            panel_logged.Visible = true;
            panel_Scan.Visible = true;
            panel_Session.Visible = true;

            panel_Scan.Visible = true;
            Panel_Camera.Visible = false;

            btn_endGame.Visible = false;
            panel_Loading.Visible = false;

        }
        private void displaySessionPanel()
        {
            panel_newRegister.Visible = true;
            panel_logged.Visible = false;
            panel_Scan.Visible = false;
            panel_Session.Visible = true;
            btn_endGame.Visible = true;
            panel_Loading.Visible = false;


        }
        private void displayNewRegisterPanel()
        {
            panel_newRegister.Visible = true;
            panel_logged.Visible = false;
            panel_Scan.Visible = false;
            panel_Session.Visible = false;
            btn_endGame.Visible = false;
            panel_Loading.Visible = false;


        }
        private void displayloggedPanel()
        {

            panel_newRegister.Visible = true;
            panel_logged.Visible = true;
            panel_Scan.Visible = false;
            panel_Session.Visible = true;
            btn_endGame.Visible = false;
            panel_Loading.Visible = false;

        }

        #endregion

        private void label1_Click(object sender, EventArgs e)
        {
            
            counter++;
            if(counter == 1)
            {
                Setting_Timer.Start();
            }
           
        }
      

        private async void checking_Game_timer_Tick(object sender, EventArgs e)
        {

            var machineModel = settingForm.getMachineModelFromJsonfile();
            var checkcFormdata = new Dictionary<string, string>() {

                {"machine_id",machineModel.currentMachine.machine_id },
                {"game_id",machineModel.currentMachine.game_id }

            };

            var checkingGame = await service.CheckingGame(apiUrl, "check", checkcFormdata);
            if (checkingGame.Errors == null)
            {
                if (checkingGame.running == 1)
                {
                    displaySessionPanel();
                }
                else
                {
                    displayScanPanel();
                    checking_Game_timer.Stop();
                }
            }
        }

        private async void StartGame_Logged_Click(object sender, EventArgs e)
        {
            displayLoadingPanel();
            var machineModel = settingForm.getMachineModelFromJsonfile();
            var gameFormData = new Dictionary<string, string>
                {
                    {"machine_id", machineModel.currentMachine.machine_id},
                    {"game_id", machineModel.currentMachine.game_id},
                    {"user_id", currentUser.id.ToString()}
                };
            var startGame = await service.StartGame(apiUrl, "start", gameFormData);
            if (startGame.status == 200)
            {

                if (startGame.running == 1)
                {
                    displaySessionPanel();
                    checking_Game_timer.Start();

                }
                else
                {
                    displayScanPanel();
                    checking_Game_timer.Stop();

                    MessageBox.Show("Game is Available Now you can Scan to Play");
                }
            }
            else
            {
                MessageBox.Show("Un Expected error" + startGame.Errors);
                displayScanPanel();
            }
        }

        private void Setting_Timer_Tick(object sender, EventArgs e)
        {
            if (counter >= 5)
            {
                settingForm.Closed += (s, args) => this.Close();
                settingForm.Show();
                this.Hide();
                counter = 0;

            }
            else
            {
                counter = 0;
            }
            Setting_Timer.Stop();
        }


      

        private async void btn_endGame_Click(object sender, EventArgs e)
        {
            displayLoadingPanel();
            var machineModel = settingForm.getMachineModelFromJsonfile();
            var gameFormData = new Dictionary<string, string>
                {
                    {"machine_id", machineModel.currentMachine.machine_id},
                    {"game_id", machineModel.currentMachine.game_id},
                    {"user_id", currentUser.id.ToString()}
                };
            var startGame = await service.EndGame(apiUrl, "end", gameFormData);
            if (startGame.status == 200)
            {

                if (startGame.running == 1)
                {
                    displaySessionPanel();
                    MessageBox.Show("Un Expected Error Game can not be Stopped");

                }
                else
                {
                    displayScanPanel();
                    MessageBox.Show("Game is Available Now you can Scan to Play");
                }
            }
            else
            {
                MessageBox.Show("Un Expected error" + startGame.Errors);
                displayScanPanel();

            }
            checking_Game_timer.Stop();
        }
    }
}
