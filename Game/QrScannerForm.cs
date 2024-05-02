using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Presentation;
using BarcodeReader = ZXing.BarcodeReader;
namespace Game
{
    public partial class QrScannerForm : Form
    {
        public QrScannerForm()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;
        private void QrScannerForm_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                cboDevice.Items.Add(filterInfo);
            cboDevice.SelectedIndex = 0;
            cboDevice.Visible = false;

            progressBar1.Visible = true;
            //for(int i = progressBar1.Minimum; i < progressBar1.Maximum; i++)
            //{
            //    progressBar1.Value = i;
            //    Application.DoEvents();
            //}

            progress_timer.Start();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cboDevice.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {

            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void QrScannerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice != null && captureDevice.IsRunning)
            {
                captureDevice.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pictureBox1.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBox1.Image);
                if(result != null)
                {
                    txtQrCode.Text = result.ToString();
                    if (captureDevice.IsRunning)
                    {
                        captureDevice.Stop();
                    }
                }
            }
        }

        private void progress_timer_Tick(object sender, EventArgs e)
        {
            while(progressBar1.Value < 100)
            {
                progressBar1.Value = +1;
                Application.DoEvents();
            }
                
        }
    }
}
