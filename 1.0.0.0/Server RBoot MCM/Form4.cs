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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public string ip;

        public string apikey;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string str0 = textBox1.Text.ToUpper();
            string str1 = str0.Replace("A", "")
                .Replace("B", "").Replace("C", "").Replace("D", "").Replace("E", "")
                .Replace("F", "").Replace("G", "").Replace("H", "").Replace("I", "")
                .Replace("J", "").Replace("K", "").Replace("L", "").Replace("M", "")
                .Replace("N", "").Replace("O", "").Replace("P", "").Replace("Q", "")
                .Replace("R", "").Replace("S", "").Replace("T", "").Replace("U", "")
                .Replace("V", "").Replace("W", "").Replace("X", "").Replace("Y", "")
                .Replace("Z", "").Replace("#", "").Replace("_", "");
            button7.Enabled = (str1 == ""&&textBox2.Text!="");
        }

        private void 显示密码_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*')
            {
                显示密码.Text = "隐藏密码";
                textBox2.PasswordChar = char.MinValue;
            }
            else
            {
                显示密码.Text = "显示密码";
                textBox2.PasswordChar = '*';
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (apikey == "")
                {
                    MessageBox.Show("错误，请求失败:\nApikey不能为NULL");
                }
                else
                {
                    Dictionary<string, string> dic = new Dictionary<string, string>();
                    dic["username"] = textBox1.Text;
                    
                        dic["password"] = textBox2.Text;
                    
                        dic["serverlist"] = textBox3.Text.Replace("\n","").Replace(Environment.NewLine, "");
                    
                    string s = Form3.Post(ip + @"api/create_user/?apikey=" + apikey, dic);
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
                MessageBox.Show("错误，请求失败:\n" + ex.Message);
            }
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string str0 = textBox1.Text.ToUpper();
            string str1 = str0.Replace("A", "")
                .Replace("B", "").Replace("C", "").Replace("D", "").Replace("E", "")
                .Replace("F", "").Replace("G", "").Replace("H", "").Replace("I", "")
                .Replace("J", "").Replace("K", "").Replace("L", "").Replace("M", "")
                .Replace("N", "").Replace("O", "").Replace("P", "").Replace("Q", "")
                .Replace("R", "").Replace("S", "").Replace("T", "").Replace("U", "")
                .Replace("V", "").Replace("W", "").Replace("X", "").Replace("Y", "")
                .Replace("Z", "").Replace("#", "").Replace("_", "");
            button7.Enabled = (str1 == "" && textBox2.Text != "");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string str0 = textBox1.Text.ToUpper();
            string str1 = str0.Replace("A", "")
                .Replace("B", "").Replace("C", "").Replace("D", "").Replace("E", "")
                .Replace("F", "").Replace("G", "").Replace("H", "").Replace("I", "")
                .Replace("J", "").Replace("K", "").Replace("L", "").Replace("M", "")
                .Replace("N", "").Replace("O", "").Replace("P", "").Replace("Q", "")
                .Replace("R", "").Replace("S", "").Replace("T", "").Replace("U", "")
                .Replace("V", "").Replace("W", "").Replace("X", "").Replace("Y", "")
                .Replace("Z", "").Replace("#", "").Replace("_", "");
            button7.Enabled = (str1 == "" && textBox2.Text != "");
        }
    }
}
