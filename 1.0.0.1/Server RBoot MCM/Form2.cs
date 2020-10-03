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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string servername;
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
                    dic["name"] = servername;
                    dic["command"] = textBox1.Text;
                    string s = Post(ip + @"api/execute/?apikey=" + apikey,dic);
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
    }
}
