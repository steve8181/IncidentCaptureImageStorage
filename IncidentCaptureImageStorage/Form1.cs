using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

//emgucCV references
using Emgu.CV;
using Emgu.CV.Util;
using Emgu.CV.Structure;
using Emgu.CV.UI;

namespace IncidentCaptureImageStorage
{
    public partial class IncidentCaptureStorage : Form
    {

        private Capture recording;
        Image<Bgr, Byte> recordingFrame, recordingFrameResized;

        double recordingFrameNumber = 0, recordingNoOfFrames = 0, recordingFrameRate = 0;

        public IncidentCaptureStorage()
        {
            InitializeComponent();
        }

        private void EndProcess()
        {
            if (recording == null)
                recording.Dispose();
        }

        private void VideoProcessing(object sender, EventArgs e)
        {
            try
            {
                recordingNoOfFrames = recording.GetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_POS_FRAMES);
                recordingFrame = recording.QueryFrame();

                if (recording != null)
                {
                    recordingFrameResized = recordingFrame.Resize(433, 349, Emgu.CV.CvEnum.INTER.CV_INTER_LINEAR);
                    IncidentImgBox.Image = recordingFrameResized;

                    double timeStamp = recording.GetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_POS_MSEC);
                    lbRunningTime.Text = "Time: " + TimeSpan.FromMilliseconds(timeStamp).ToString().Substring(0, 8);

                    double currentFrameNumber = recording.GetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_POS_FRAMES);
                    lbFrameNumber.Text = "Current Frame Number: " + recordingFrameNumber.ToString();

                    Thread.Sleep((int)(1000f / recordingFrameRate));

                    recordingFrame.Save(@"C:\DevOps_Project\Incident_Capture\Incident_Number_" + recordingFrameNumber + " Timestamp_" + timeStamp + ".jpg");

                    recordingFrameNumber++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnFileSelection_Click(object sender, EventArgs e)
        {
            ofdVideoFile.FileName = "";

            if (ofdVideoFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    recording = null;
                    recording = new Capture(ofdVideoFile.FileName);
                    recording.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_HEIGHT, 433);
                    recording.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_WIDTH, 349);
                    recordingFrameRate = recording.GetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FPS);
                    recordingFrameNumber = recording.GetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_COUNT);
                    Application.Idle += VideoProcessing;
                    btnStart.Text = "Stop Extraction";
                    txtFilePath.Text = ofdVideoFile.FileName;
                }
                catch (NullReferenceException except)
                {
                    MessageBox.Show(except.Message);
                }
            }
            if (btnFileSelection.Text == "Pause Extraction")
            {
                recording.Stop();

                Application.Idle -= VideoProcessing;
                EndProcess();
                btnStart.Text = "Restart Extraction";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
