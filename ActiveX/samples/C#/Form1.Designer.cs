using System.Drawing;

namespace Biokey01
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                //axZKFPEngX1.FreeFPCacheDB(fpcHandle);
            }
            //showpicture.Stop();
            //showpicture.Close();
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            /*this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.statusbar0 = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanel3 = new System.Windows.Forms.StatusBarPanel();*/
            this.btnCloseSensor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnInitialSensor = new System.Windows.Forms.Button();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnBeep = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnIdentifyByImage = new System.Windows.Forms.Button();
            this.btnVerify = new System.Windows.Forms.Button();
            this.axZKFPEngX1 = new AxZKFPEngXControl.AxZKFPEngX();
            this.rdb10 = new System.Windows.Forms.RadioButton();
            this.rdb9 = new System.Windows.Forms.RadioButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnIdentify = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            /*((System.ComponentModel.ISupportInitialize)(this.statusbar0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel3)).BeginInit();*/
            ((System.ComponentModel.ISupportInitialize)(this.axZKFPEngX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBar1
            /* 
            this.statusBar1.Location = new System.Drawing.Point(0, 371);
            this.statusBar1.Font = new System.Drawing.Font("IBM Plex Mono", 10);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusbar0});
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(714, 20);
            this.statusBar1.TabIndex = 14;
            // 
            // statusbar0
            // 
            this.statusbar0.Name = "statusbar0";
            this.statusbar0.Text = "Status:";
            this.statusbar0.Width = 1024;
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Text = "Status:";
            this.statusBarPanel1.Width = 80;
            // 
            // statusBarPanel2
            // 
            this.statusBarPanel2.Name = "statusBarPanel2";
            this.statusBarPanel2.Width = 200;
            // 
            // statusBarPanel3
            // 
            this.statusBarPanel3.Name = "statusBarPanel3";
            */
            //
            //hidden titlebar
            //
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            //
            //instruction
            //
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            this.label2.Text = "Для нового произведения приложите палец";
            this.label2.Location = new System.Drawing.Point(15, 70);
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("IBM Plex Mono", 18);
            // 
            //heading1.1
            //
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            this.label1.Text = $"Произведение N";
            this.label1.Location = new System.Drawing.Point(5, 150);
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("IBM Plex Mono", 42);
            //
            //heading1.2
            //
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.label3.Name = "label3";
            this.label3.Text = $"Произведение N";
            this.label3.Location = new System.Drawing.Point(655, 150);
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("IBM Plex Mono", 42);
            //
            //heading1.3
            //
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.label4.Name = "label4";
            this.label4.Text = $"Произведение N";
            this.label4.Location = new System.Drawing.Point(1305, 150);
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("IBM Plex Mono", 42);
            //
            // btnInitialSensor
            // 
            this.btnInitialSensor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInitialSensor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInitialSensor.Location = new System.Drawing.Point(15, 15);
            this.btnInitialSensor.Name = "btnInitialSensor";
            this.btnInitialSensor.Size = new System.Drawing.Size(60, 24);
            this.btnInitialSensor.TabIndex = 0;
            this.btnInitialSensor.Text = "STArt";
            this.btnInitialSensor.UseVisualStyleBackColor = true;
            this.btnInitialSensor.ForeColor = System.Drawing.Color.White;
            this.btnInitialSensor.Font = new System.Drawing.Font("IBM Plex Mono", 9);
            this.btnInitialSensor.FlatAppearance.BorderSize = 1;
            this.btnInitialSensor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnInitialSensor.Click += new System.EventHandler(this.btnInitialSensor_Click);
            //
            // radioButton2 !
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(60, 14);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(41, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "JPG";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1 !
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 14);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(41, 16);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "BMP";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnBeep !
            // 
            this.btnBeep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBeep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBeep.Location = new System.Drawing.Point(617, 332);
            this.btnBeep.Name = "btnBeep";
            this.btnBeep.Size = new System.Drawing.Size(72, 23);
            this.btnBeep.TabIndex = 14;
            this.btnBeep.Text = "Beep";
            this.btnBeep.UseVisualStyleBackColor = true;
            this.btnBeep.Click += new System.EventHandler(this.btnBeep_Click);
            // 
            // btnGreen !
            // 
            this.btnGreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGreen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGreen.Location = new System.Drawing.Point(571, 332);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(72, 23);
            this.btnGreen.TabIndex = 13;
            this.btnGreen.Text = "Green";
            this.btnGreen.UseVisualStyleBackColor = true;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnRed !
            // 
            this.btnRed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRed.Location = new System.Drawing.Point(367, 332);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(72, 23);
            this.btnRed.TabIndex = 12;
            this.btnRed.Text = "Red";
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnIdentifyByImage !
            // 
            this.btnIdentifyByImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIdentifyByImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIdentifyByImage.Location = new System.Drawing.Point(571, 292);
            this.btnIdentifyByImage.Name = "btnIdentifyByImage";
            this.btnIdentifyByImage.Size = new System.Drawing.Size(118, 23);
            this.btnIdentifyByImage.TabIndex = 11;
            this.btnIdentifyByImage.Text = "Identify by image";
            this.btnIdentifyByImage.UseVisualStyleBackColor = true;
            this.btnIdentifyByImage.Click += new System.EventHandler(this.btnIdentifyByImage_Click);
            // 
            // btnVerify !
            // 
            this.btnVerify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerify.Location = new System.Drawing.Point(367, 252);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(118, 23);
            this.btnVerify.TabIndex = 4;
            this.btnVerify.Text = "Verify 1 : 1";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // axZKFPEngX1
            // 
            this.axZKFPEngX1.Enabled = true;
            this.axZKFPEngX1.Location = new System.Drawing.Point(458, 166); //458,166
            this.axZKFPEngX1.Name = "axZKFPEngX1";
            this.axZKFPEngX1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axZKFPEngX1.OcxState")));
            this.axZKFPEngX1.Size = new System.Drawing.Size(24, 24);
            this.axZKFPEngX1.TabIndex = 3;
            this.axZKFPEngX1.OnFeatureInfo += new AxZKFPEngXControl.IZKFPEngXEvents_OnFeatureInfoEventHandler(this.axZKFPEngX1_OnFeatureInfo);
            this.axZKFPEngX1.OnEnroll += new AxZKFPEngXControl.IZKFPEngXEvents_OnEnrollEventHandler(this.axZKFPEngX1_OnEnroll);
            this.axZKFPEngX1.OnCapture += new AxZKFPEngXControl.IZKFPEngXEvents_OnCaptureEventHandler(this.axZKFPEngX1_OnCapture);
            // 
            // rdb10
            // 
            this.rdb10.AutoSize = true;
            this.rdb10.Checked = true;
            this.rdb10.Location = new System.Drawing.Point(569, 92);
            this.rdb10.Name = "rdb10";
            this.rdb10.Size = new System.Drawing.Size(101, 16);
            this.rdb10.TabIndex = 1;
            this.rdb10.TabStop = true;
            this.rdb10.Text = "ZKFinger 10.0";
            this.rdb10.UseVisualStyleBackColor = true;
            // 
            // rdb9
            // 
            this.rdb9.AutoSize = true;
            this.rdb9.Location = new System.Drawing.Point(367, 92);
            this.rdb9.Name = "rdb9";
            this.rdb9.Size = new System.Drawing.Size(95, 16);
            this.rdb9.TabIndex = 0;
            this.rdb9.Text = "ZKFinger 9.0";
            this.rdb9.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnIdentify !
            // 
            this.btnIdentify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIdentify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIdentify.Location = new System.Drawing.Point(569, 252);
            this.btnIdentify.Name = "btnIdentify";
            this.btnIdentify.Size = new System.Drawing.Size(118, 23);
            this.btnIdentify.TabIndex = 18;
            this.btnIdentify.Text = "Identify 1 : N";
            this.btnIdentify.UseVisualStyleBackColor = true;
            this.btnIdentify.Click += new System.EventHandler(this.btnIdentify_Click);
            //
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(20, 250);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(512, 512);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(670, 250);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(512, 512);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            //
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(1320, 250);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(512, 512);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1300, 720);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.axZKFPEngX1);
            this.Controls.Add(this.btnInitialSensor);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "\"Беньямин, ты был неправ!\"    Антонина Алексеева, Максим Господинко, Кристина Сулла.";
            this.Load += new System.EventHandler(this.Form1_Load);
            /*((System.ComponentModel.ISupportInitialize)(this.statusbar0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel3)).EndInit();*/
            ((System.ComponentModel.ISupportInitialize)(this.axZKFPEngX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtb2;
        private System.Windows.Forms.StatusBar statusBar1;
        internal System.Windows.Forms.StatusBarPanel statusBarPanel1;
        internal System.Windows.Forms.StatusBarPanel statusBarPanel2;
        internal System.Windows.Forms.StatusBarPanel statusBarPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInitialSensor;
        private System.Windows.Forms.TextBox txtb5;
        private System.Windows.Forms.TextBox txtb1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnCloseSensor;
        private System.Windows.Forms.StatusBarPanel sstatusbar0;
        private System.Windows.Forms.StatusBarPanel statusBarPanel4;
        private System.Windows.Forms.StatusBarPanel statusbar0;
        private System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.RadioButton rdb10;
        private System.Windows.Forms.RadioButton rdb9;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private AxZKFPEngXControl.AxZKFPEngX axZKFPEngX1;
        private System.Windows.Forms.CheckBox chkFakeFunOn;
        private System.Windows.Forms.Button btnBeep;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnIdentifyByImage;
        private System.Windows.Forms.Button btnRegByImage;
        private System.Windows.Forms.Button btnIdentify;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

