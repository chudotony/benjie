using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Data.OleDb;
using System.Collections;

namespace Biokey01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        //private System.Timers.Timer showpicture = new System.Timers.Timer();

        int FMatchType = 2;
        int fpcHandle;
        int FPID = 1;
        List<int> picID = new List<int>();
        string sRegTemplate, sRegTemplate10;

        private void btnInitialSensor_Click(object sender, EventArgs e)        
        {
            if (axZKFPEngX1.InitEngine() == 0)
            {
                EnableButton(false);

                if (rdb9.Checked)
                {
                    axZKFPEngX1.FPEngineVersion = "9";
                }
                else
                    axZKFPEngX1.FPEngineVersion = "10";

                    
                fpcHandle = axZKFPEngX1.CreateFPCacheDBEx();

                //statusBar1.Panels[0].Text = "Sensor Connected!";         
            }
            else
            {
                axZKFPEngX1.EndEngine();
                //statusBar1.Panels[0].Text = "Error: Scanner not connected, try to reconnect";
            }

            FMatchType = 2;
        }

        private void btnReg_Click(object sender, EventArgs e) //register button
        {
            if (axZKFPEngX1.IsRegister)
            {
                axZKFPEngX1.CancelEnroll();
            }
            axZKFPEngX1.EnrollCount = 3; //finger press times
            axZKFPEngX1.BeginEnroll();
            //statusBar1.Panels[0].Text = "start register";
        }

        private void btnCloseSensor_Click(object sender, EventArgs e) //close sensor button
        {
            axZKFPEngX1.EndEngine();
            EnableButton(true);
        }

        private void btnbrowse_Click(object sender, EventArgs e) //save image button
        {
            if (radioButton1.Checked)
                axZKFPEngX1.SaveBitmap("Fingerprint.bmp");
            else
                axZKFPEngX1.SaveJPG("Fingerprint.jpg");
            MessageBox.Show("Fingerprint Image saved", "Warn", MessageBoxButtons.OK);
        }

        private void btnVerify_Click(object sender, EventArgs e) //verify button
        {
            if (axZKFPEngX1.IsRegister)
                axZKFPEngX1.CancelEnroll();
            //statusBar1.Panels[0].Text = "Verify(1:1)";
            FMatchType = 1;
        }

        private void btnIdentify_Click(object sender, EventArgs e) //identify button
        {
            if (axZKFPEngX1.IsRegister)
                axZKFPEngX1.CancelEnroll();
            statusBar1.Panels[0].Text = "Identify(1:N)";
            FMatchType = 2;
        }

        private void axZKFPEngX1_OnEnroll(object sender, AxZKFPEngXControl.IZKFPEngXEvents_OnEnrollEvent e)
        {
            if (!e.actionResult)
            {
                label2.Text = "Ошибка регистрации\nПопробуйте снова";
            }
            else
            {
                sRegTemplate = axZKFPEngX1.GetTemplateAsStringEx("9");
                sRegTemplate10 = axZKFPEngX1.GetTemplateAsStringEx("10");

                if (sRegTemplate.Length > 0)
                {
                    if (sRegTemplate10.Length > 0)
                        axZKFPEngX1.AddRegTemplateStrToFPCacheDBEx(fpcHandle, FPID, sRegTemplate, sRegTemplate10);
                    else
                        label2.Text = "Ошибка регистрации\nПопробуйте снова";

                    object pTemplate;
                    if (rdb9.Checked)
                    {
                        pTemplate = axZKFPEngX1.DecodeTemplate1(sRegTemplate);
                        // Note: 10.0Template can not be compressed (��ѹ��)
                        axZKFPEngX1.SetTemplateLen(ref pTemplate, 602);
                    }
                    else
                    {
                        pTemplate = axZKFPEngX1.DecodeTemplate1(sRegTemplate10);
                    }
                    axZKFPEngX1.SaveTemplate("fingerprint.tpl", pTemplate);

                    FPID++;
                }
                else
                {
                    MessageBox.Show("Register Failed, template length is zero", "error!");
                };
            }
        }

        private void axZKFPEngX1_OnCapture(object sender, AxZKFPEngXControl.IZKFPEngXEvents_OnCaptureEvent e) //finger scan
        {
            if (FMatchType == 1)
            {
                bool RegChanged = false;
                string sTemp = axZKFPEngX1.GetTemplateAsString();
                string sVerTemplate;
                if (rdb9.Checked)
                    sVerTemplate = sRegTemplate;
                else
                    sVerTemplate = sRegTemplate10;
                if (axZKFPEngX1.VerFingerFromStr(ref sVerTemplate, sTemp, false, ref RegChanged))
                {
                    //statusBar1.Panels[0].Text = "Verify Succeed";
                }
                else
                {
                    //statusBar1.Panels[0].Text = "Verify Failed";
                }
            }
            else if (FMatchType == 2)
            {
                int score = 8;
                int processedNum = 1;
                int ID = axZKFPEngX1.IdentificationInFPCacheDB(fpcHandle, e.aTemplate, ref score, ref processedNum);
                if (ID == -1)
                {
                    //statusBar1.Panels[0].Text = "Identify Failed";
                    axZKFPEngX1.EnrollCount = 3; //finger press times
                    label2.Text = "Неизвестный отпечаток, необходима регистрация\nПриложите палец ещё 4 раз(а)";
                    axZKFPEngX1.BeginEnroll();
                    //statusBar1.Panels[0].Text = "start register";
                }
                else
                {
                    picID.Insert(0, ID);

                    label1.Text = $"Произведение {picID[0]}";
                    label2.Text = "Графический объект создан\nДля нового произведения приложите палец";
                    pictureBox2.ImageLocation = $"{System.AppDomain.CurrentDomain.BaseDirectory}\\start_pics\\{picID[0]}.png";

                    if (picID.Count == 2)
                    {
                        label3.Text = $"Произведение {picID[1]}";
                        pictureBox3.ImageLocation = $"{System.AppDomain.CurrentDomain.BaseDirectory}\\start_pics\\{picID[1]}.png";
                    }

                    if (picID.Count > 2)
                    {
                        label3.Text = $"Произведение {picID[1]}";
                        label4.Text = $"Произведение {picID[2]}";
                        pictureBox3.ImageLocation = $"{System.AppDomain.CurrentDomain.BaseDirectory}\\start_pics\\{picID[1]}.png";
                        pictureBox4.ImageLocation = $"{System.AppDomain.CurrentDomain.BaseDirectory}\\start_pics\\{picID[2]}.png";
                    }

                    //statusBar1.Panels[0].Text = string.Format("Identify Succeed ID = {0} Score = {1}  Processed Number = {2}", ID, score, processedNum);
                }
            }
        }

       

        private void axZKFPEngX1_OnFeatureInfo(object sender, AxZKFPEngXControl.IZKFPEngXEvents_OnFeatureInfoEvent e)
        {
            string sTemp = "";
            if (axZKFPEngX1.IsRegister)
                sTemp = "Register status: still press finger " + axZKFPEngX1.EnrollIndex.ToString() + " times!";

            sTemp = sTemp + " Fingerprint quality";
            int lastq = axZKFPEngX1.LastQuality;
            if (e.aQuality == -1)
                sTemp = sTemp + " not good, Suspicious fingerprints, quality=" + lastq.ToString();
            else if (e.aQuality != 0)
                sTemp = sTemp + " not good, quality=" + lastq.ToString();
            else
                sTemp = sTemp + " good, quality=" + lastq.ToString();
            //statusBar1.Panels[0].Text = sTemp;
            label2.Text = $"Идёт регистрация\nПриложите палец ещё {axZKFPEngX1.EnrollIndex} раз(а)";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //showpicture.Elapsed += new System.Timers.ElapsedEventHandler(showpicture_Elapsed);
            rdb10.Checked = true;
            //chkFakeFunOn.Checked = true;
            EnableButton(true);
        }

        private void btnRegByImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files(*.BMP;*.JPG)|*.BMP;*.JPG|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
	        {
                if (axZKFPEngX1.IsRegister)
                    axZKFPEngX1.CancelEnroll();
                axZKFPEngX1.EnrollCount = 1;
                axZKFPEngX1.BeginEnroll();
                if (!axZKFPEngX1.AddImageFile(openFileDialog1.FileName, 500))
		        {
                    MessageBox.Show("Extract failed or not using the standard version of ZKFinger SDK", "error!");
		        }
	        }
        }

        private void btnIdentifyByImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files(*.BMP;*.JPG)|*.BMP;*.JPG|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
	        {
                if (axZKFPEngX1.IsRegister)
                    axZKFPEngX1.CancelEnroll();

                axZKFPEngX1.BeginCapture();

                if (!axZKFPEngX1.AddImageFile(openFileDialog1.FileName, 500))
		        {
                    MessageBox.Show("Extract failed or not using the standard version of ZKFinger SDK", "error!");
		        }
	        }
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            axZKFPEngX1.ControlSensor(12, 1);
            Thread.Sleep(100);
            axZKFPEngX1.ControlSensor(12, 0);
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            axZKFPEngX1.ControlSensor(11, 1);
            Thread.Sleep(100);
            axZKFPEngX1.ControlSensor(11, 0);
        }

        private void btnBeep_Click(object sender, EventArgs e)
        {
            axZKFPEngX1.ControlSensor(13, 1);
            Thread.Sleep(100);
            axZKFPEngX1.ControlSensor(13, 0);
        }

        private void EnableButton(bool bEnable)
        {
            btnInitialSensor.Enabled = bEnable;
            btnCloseSensor.Enabled = !bEnable;
            btnbrowse.Enabled = !bEnable;
            btnVerify.Enabled = !bEnable;
            btnIdentify.Enabled = !bEnable;
            btnIdentifyByImage.Enabled = !bEnable;
            btnRed.Enabled = !bEnable;
            btnGreen.Enabled = !bEnable;
            btnBeep.Enabled = !bEnable;
        }
    }
}
    
