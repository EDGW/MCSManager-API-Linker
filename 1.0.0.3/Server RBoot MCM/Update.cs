using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server_RBoot_MCM
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12; //加上这一句
            CheckForIllegalCrossThreadCalls = false;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }
        public void DownloadFile(string URL, string filename, System.Windows.Forms.ProgressBar prog, System.Windows.Forms.Label label1)
        {
            float percent = 0;
            try
            {
                System.Net.HttpWebRequest Myrq = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(URL);
                System.Net.HttpWebResponse myrp = (System.Net.HttpWebResponse)Myrq.GetResponse();
                long totalBytes = myrp.ContentLength;
                if (prog != null)
                {
                    prog.Maximum = (int)totalBytes;
                }
                System.IO.Stream st = myrp.GetResponseStream();
                System.IO.Stream so = new System.IO.FileStream(filename, System.IO.FileMode.Create);
                long totalDownloadedByte = 0;
                byte[] by = new byte[1024];
                int osize = st.Read(by, 0, (int)by.Length);
                while (osize > 0)
                {
                    totalDownloadedByte = osize + totalDownloadedByte;
                    System.Windows.Forms.Application.DoEvents();
                    so.Write(by, 0, osize);
                    if (prog != null)
                    {
                        prog.Value = (int)totalDownloadedByte;
                    }
                    osize = st.Read(by, 0, (int)by.Length);

                    percent = (float)totalDownloadedByte / (float)totalBytes * 100;
                    label1.Text = "当前补丁下载进度" + percent.ToString() + "%";
                    System.Windows.Forms.Application.DoEvents(); //必须加注这句代码，否则label1将因为循环执行太快而来不及显示信息
                }
                so.Close();
                st.Close();
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        private void Update_Shown(object sender, EventArgs e)
        {
            DownloadFile("https://edgw.github.io/MMAL/version.txt", "ver.updatelog", progressBar1, new Label());
            if (File.ReadAllLines("ver.updatelog")[0].StartsWith("1.0.0.3"))
            {
                MessageBox.Show("没有可更新版本");
                Close();
            }
            else
            {
              if(MessageBox.Show("发现新版本 : "+ File.ReadAllText("ver.updatelog") + "\n是否要更新", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    File.Delete("ver.updatelog");
                    backgroundWorker1.RunWorkerAsync();
                }
                else
                {
                    Close();
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            string guid = Guid.NewGuid().ToString();
            DownloadFile("https://edgw.github.io/MMAL/MCSManager API Linker.exe", guid, progressBar1, new Label());
            string s = Properties.Settings.Default.UPDATEBAT.Replace("[&STARTUPPATH&]", Application.StartupPath).Replace("[&EXECUTNAME&]", Application.ExecutablePath).Replace("[&EXECUTNAME2&]", Path.GetFileName(Application.ExecutablePath)).Replace("[&UPDATENAME&]", guid);
            
            File.WriteAllText("update.bat", s);
            Process.Start("update.bat");
            Process.GetCurrentProcess().Kill();
        }
    }
}
