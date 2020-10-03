using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server_RBoot_MCM
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        public string ip;

        public string apikey;
        public int style;
        private void button7_Click(object sender, EventArgs e)
        {
            string s = "";
            try
            {
                if (apikey == "")
                {
                    MessageBox.Show("错误，请求失败:\nApikey不能为NULL");
                }
                else
                {
                    if (style == 0)
                        s = Form1.Get(ip + @"api/delete_user/" + textBox1.Text + "?apikey=" + apikey);
                    else
                        s = Form1.Get(ip + @"api/delete_server/" + textBox1.Text + "?apikey=" + apikey);
                    JObject obj = JObject.Parse(s);
                    if (obj["status"].ToString() == "200")
                    {
                        if (obj["data"] == null)
                        {
                            s = "请求成功";

                        }
                        else
                        {
                            s = "请求成功\n" + obj["data"];
                        }
                    }
                    else
                    {
                        s = "请求失败\n" + obj["error"];
                    }
                    MessageBox.Show(s);
                }
            }
            catch (Exception ex)
            {

                if (style == 0)
                {

                    if (ex.Message.StartsWith("Un"))
                    {
                        MessageBox.Show("错误，请求失败:\nAPI不允许删除管理员用户");
                    }
                    else
                        MessageBox.Show("错误，请求失败:\n" + ex.Message);
                }
                else
                {
                    MessageBox.Show("错误，请求失败:\n" + ex.Message);
                }
            }
            Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            if (style == 1)
            {
                Text = "删除服务器";
            }
        }
    }
}
