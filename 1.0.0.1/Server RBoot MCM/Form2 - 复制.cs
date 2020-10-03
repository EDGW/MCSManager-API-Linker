using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server_RBoot_MCM
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public string ip;

        public string apikey;
        public static string Post(string url, string content)
        {
            string result = "";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";

            #region 添加Post 参数
            byte[] data = Encoding.UTF8.GetBytes(content);
            req.ContentLength = data.Length;
            using (Stream reqStream = req.GetRequestStream())
            {
                reqStream.Write(data, 0, data.Length);
                reqStream.Close();
            }
            #endregion

            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            Stream stream = resp.GetResponseStream();
            //获取响应内容
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                result = reader.ReadToEnd();
            }
            return result;
        }
        public static string Post(string url, Dictionary<string, string> dic)
        {
            string result = "";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";
            #region 添加Post 参数
            StringBuilder builder = new StringBuilder();
            int i = 0;
            foreach (var item in dic)
            {
                if (i > 0)
                    builder.Append("&");
                builder.AppendFormat("{0}={1}", item.Key, item.Value);
                i++;
            }
            byte[] data = Encoding.UTF8.GetBytes(builder.ToString());
            req.ContentLength = data.Length;
            using (Stream reqStream = req.GetRequestStream())
            {
                reqStream.Write(data, 0, data.Length);
                reqStream.Close();
            }
            #endregion
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            Stream stream = resp.GetResponseStream();
            //获取响应内容
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                result = reader.ReadToEnd();
            }
            return result;
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
                    dic["serverName"] = textBox1.Text;
                    if(textBox2.Text!="")
                        dic["java"] = textBox2.Text;
                    if (textBox3.Text != "")
                        dic["jarName"] = textBox3.Text;
                    if (textBox4.Text != "")
                        dic["Xmx"] = textBox4.Text;
                    if (textBox5.Text != "")
                        dic["Xms"] = textBox5.Text;
                    if (textBox6.Text != "")
                        dic["ie"] = textBox6.Text;
                    if (textBox7.Text != "")
                        dic["oe"] = textBox7.Text;
                    if (textBox8.Text != "")
                        dic["timeLimitDate"] = textBox8.Text;
                    if (textBox9.Text != "")
                        dic["cwd"] = textBox9.Text;
                    if (textBox10.Text != "")
                        dic["highCommande"] = textBox10.Text;
                    if (textBox11.Text != "")
                        dic["addCmd"] = textBox1.Text;
                    string s = Post(ip + @"api/create_server/?apikey=" + apikey, dic);
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
                .Replace("Z", "").Replace("_", "");
            str1 = str1 + "0";
            try
            {
                long int0 = long.Parse(str1);
                if(textBox1.Text.Replace("-", "").Replace("-", "")==textBox1.Text)
                    button7.Enabled = true;
                else
                    button7.Enabled = false;
            }
            catch (Exception)
            {
                button7.Enabled = false;
            }

        }
    }
}
