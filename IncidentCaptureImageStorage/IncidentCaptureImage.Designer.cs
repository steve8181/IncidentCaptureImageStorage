namespace IncidentCaptureImageStorage
{
    partial class IncidentCaptureStorage
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
            this.btnFileSelection = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lbRunningTime = new System.Windows.Forms.Label();
            this.lbFrameNumber = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.ofdVideoFile = new System.Windows.Forms.OpenFileDialog();
            this.IncidentImgBox = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.IncidentImgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFileSelection
            // 
            this.btnFileSelection.Location = new System.Drawing.Point(32, 31);
            this.btnFileSelection.Name = "btnFileSelection";
            this.btnFileSelection.Size = new System.Drawing.Size(75, 23);
            this.btnFileSelection.TabIndex = 0;
            this.btnFileSelection.Text = "Open Video";
            this.btnFileSelection.UseVisualStyleBackColor = true;
            this.btnFileSelection.Click += new System.EventHandler(this.btnFileSelection_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(542, 30);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(32, 460);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // lbRunningTime
            // 
            this.lbRunningTime.AutoSize = true;
            this.lbRunningTime.Location = new System.Drawing.Point(258, 465);
            this.lbRunningTime.Name = "lbRunningTime";
            this.lbRunningTime.Size = new System.Drawing.Size(79, 13);
            this.lbRunningTime.TabIndex = 3;
            this.lbRunningTime.Text = "Running Time: ";
            // 
            // lbFrameNumber
            // 
            this.lbFrameNumber.AutoSize = true;
            this.lbFrameNumber.Location = new System.Drawing.Point(484, 465);
            this.lbFrameNumber.Name = "lbFrameNumber";
            this.lbFrameNumber.Size = new System.Drawing.Size(101, 13);
            this.lbFrameNumber.TabIndex = 4;
            this.lbFrameNumber.Text = "Number Of Frames: ";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(132, 33);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(158, 20);
            this.txtFilePath.TabIndex = 5;
            // 
            // ofdVideoFile
            // 
            this.ofdVideoFile.FileName = "openFileDialog1";
            // 
            // IncidentImgBox
            // 
            this.IncidentImgBox.Location = new System.Drawing.Point(109, 83);
            this.IncidentImgBox.Name = "IncidentImgBox";
            this.IncidentImgBox.Size = new System.Drawing.Size(433, 349);
            this.IncidentImgBox.TabIndex = 2;
            this.IncidentImgBox.TabStop = false;
            // 
            // IncidentCaptureStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 499);
            this.Controls.Add(this.IncidentImgBox);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.lbFrameNumber);
            this.Controls.Add(this.lbRunningTime);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnFileSelection);
            this.Name = "IncidentCaptureStorage";
            this.Text = "Captured Incident";
            ((System.ComponentModel.ISupportInitialize)(this.IncidentImgBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFileSelection;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lbRunningTime;
        private System.Windows.Forms.Label lbFrameNumber;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.OpenFileDialog ofdVideoFile;
        private Emgu.CV.UI.ImageBox IncidentImgBox;
    }
}

