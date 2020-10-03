using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Server_RBoot_MCM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (!File.Exists("mmalips.json"))
            {
                File.WriteAllText("mmalips.json", "{\n  \"t1\": [  ],  \"t3\": [  ],  \"t4\": [  ]}");
            }
            JObject obj = JObject.Parse(File.ReadAllText("mmalips.json"));
            foreach(var obj0 in (JArray)obj["t1"])
            {
                if (obj0.ToString() != "")
                {
                    textBox1.Items.Add(obj0.ToString());
                    textBox1.SelectedIndex = 0;
                }
            }
            foreach (var obj0 in (JArray)obj["t3"])
            {
                if (obj0.ToString() != "")
                {
                    textBox3.Items.Add(obj0.ToString());
                    textBox3.SelectedIndex = 0;
                }
            }
            foreach (var obj0 in (JArray)obj["t4"])
            {
                if (obj0.ToString() != "")
                {
                    textBox4.Items.Add(obj0.ToString());
                    textBox4.SelectedIndex = 0;
                }
            }
            new Update().ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string __s = Get(textBox3.Text + @"api/server_list/" + "?apikey=" + textBox4.Text);
                MessageBox.Show(__s);
                JObject __obj = JObject.Parse(__s);
                JArray _arr = (JArray)__obj["data"];
                foreach (JObject obj in _arr)
                {
                    bool anc = true;
                    foreach (string s in textBox1.Items)
                    {
                        if (s == obj["serverName"].ToString())
                        {
                            anc = false;
                        }
                    }
                    if (anc)
                        textBox1.Items.Add(obj["serverName"].ToString());
                }
            }
            catch (Exception) { }

            bool a = true;
            foreach (string s in textBox1.Items)
            {
                if (s == textBox1.Text)
                {
                    a = false;
                }
            }
            if (a)
                textBox1.Items.Add(textBox1.Text);
            a = true;
            foreach (string s in textBox3.Items)
            {
                if (s == textBox3.Text)
                {
                    a = false;
                }
            }
            if (a)
                textBox3.Items.Add(textBox3.Text);
            a = true;
            foreach (string s in textBox4.Items)
            {
                if (s == textBox4.Text)
                {
                    a = false;
                }
            }
            if (a)
                textBox4.Items.Add(textBox4.Text);
            try
            {
                if (textBox4.Text == "")
                {
                    MessageBox.Show("错误，请求失败:\nApikey不能为NULL");
                }
                else
                {

                    string s = Get(textBox3.Text + @"api/stop_server/" + textBox1.Text + "?apikey=" + textBox4.Text);
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
        }
        /// <summary>
        /// 指定Url地址使用Get 方式获取全部字符串
        /// </summary>
        /// <param name="url">请求链接地址</param>
        /// <returns></returns>
        public static string Get(string url)
        {
            string result = "";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            Stream stream = resp.GetResponseStream();
            try
            {
                //获取内容
                using (StreamReader reader = new StreamReader(stream))
                {
                    result = reader.ReadToEnd();
                }
            }
            finally
            {
                stream.Close();
            }
            return result;
        }
        ///
        /// Get请求
        /// 
        /// 
        /// 字符串
        public static string GetHttpResponse(string url, int Timeout)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "text/html;charset=UTF-8";
            request.UserAgent = null;
            request.Timeout = Timeout;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();

            return retString;
        }
        /// <summary>
        /// 发送Get请求
        /// </summary>
        /// <param name="url">地址</param>
        /// <param name="dic">请求参数定义</param>
        /// <returns></returns>
        public static string Get(string url, Dictionary<string, string> dic)
        {
            string result = "";
            StringBuilder builder = new StringBuilder();
            builder.Append(url);
            if (dic.Count > 0)
            {
                builder.Append("?");
                int i = 0;
                foreach (var item in dic)
                {
                    if (i > 0)
                        builder.Append("&");
                    builder.AppendFormat("{0}={1}", item.Key, item.Value);
                    i++;
                }
            }
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(builder.ToString());
            //添加参数
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            Stream stream = resp.GetResponseStream();
            try
            {
                //获取内容
                using (StreamReader reader = new StreamReader(stream))
                {
                    result = reader.ReadToEnd();
                }
            }
            finally
            {
                stream.Close();
            }
            return result;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                string __s = Get(textBox3.Text + @"api/server_list/" + "?apikey=" + textBox4.Text);
                MessageBox.Show(__s);
                JObject __obj = JObject.Parse(__s);
                JArray _arr = (JArray)__obj["data"];
                foreach (JObject obj in _arr)
                {
                    bool anc = true;
                    foreach (string s in textBox1.Items)
                    {
                        if (s == obj["serverName"].ToString())
                        {
                            anc = false;
                        }
                    }
                    if (anc)
                        textBox1.Items.Add(obj["serverName"].ToString());
                }
            }
            catch (Exception) { }

            bool a = true;
            foreach (string s in textBox1.Items)
            {
                if (s == textBox1.Text)
                {
                    a = false;
                }
            }
            if (a)
                textBox1.Items.Add(textBox1.Text);
            a = true;
            foreach (string s in textBox3.Items)
            {
                if (s == textBox3.Text)
                {
                    a = false;
                }
            }
            if (a)
                textBox3.Items.Add(textBox3.Text);
            a = true;
            foreach (string s in textBox4.Items)
            {
                if (s == textBox4.Text)
                {
                    a = false;
                }
            }
            if (a)
                textBox4.Items.Add(textBox4.Text);
            try
            {
                if (textBox4.Text == "")
                {
                    MessageBox.Show("错误，请求失败:\nApikey不能为NULL");
                }
                else
                {

                    string s = Get(textBox3.Text + @"api/restart_server/" + textBox1.Text + "?apikey=" + textBox4.Text);
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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string __s = Get(textBox3.Text + @"api/server_list/" + "?apikey=" + textBox4.Text);
                MessageBox.Show(__s);
                JObject __obj = JObject.Parse(__s);
                JArray _arr = (JArray)__obj["data"];
                foreach (JObject obj in _arr)
                {
                    bool anc = true;
                    foreach (string s in textBox1.Items)
                    {
                        if (s == obj["serverName"].ToString())
                        {
                            anc = false;
                        }
                    }
                    if (anc)
                        textBox1.Items.Add(obj["serverName"].ToString());
                }
            }
            catch (Exception) { }

            bool a = true;
            foreach (string s in textBox1.Items)
            {
                if (s == textBox1.Text)
                {
                    a = false;
                }
            }
            if (a)
                textBox1.Items.Add(textBox1.Text);
            a = true;
            foreach (string s in textBox3.Items)
            {
                if (s == textBox3.Text)
                {
                    a = false;
                }
            }
            if (a)
                textBox3.Items.Add(textBox3.Text);
            a = true;
            foreach (string s in textBox4.Items)
            {
                if (s == textBox4.Text)
                {
                    a = false;
                }
            }
            if (a)
                textBox4.Items.Add(textBox4.Text);
            try
            {
                string s = Get(textBox3.Text + @"api/status/" + textBox1.Text);
                if (s.StartsWith("<!"))
                {
                    s = "错误，请求失败:\n负载请求不能为空";
                }
                else if (s.StartsWith("null"))
                {
                    s = "错误，请求失败:\n服务器不存在";
                }
                else
                {
                    JObject retjson = JObject.Parse(s);
                    if (bool.Parse(retjson["status"].ToString()) == false)
                    {
                        s = "服务器ID : " + retjson["id"] + "\n服务器状态 : 已关闭\n服务器开启日期 : " + retjson["lastDate"];
                    }
                    else if (bool.Parse(retjson["status"].ToString()))
                    {
                        if (retjson["serverName"] == null)
                        {
                            s = "服务器ID : " + retjson["id"] + "\n服务器状态 : 已开启\n服务器开启日期 : " + retjson["lastDate"] + "\n其他信息获取失败";
                        }
                        else
                        {
                            s = "服务器ID : " + retjson["id"] + "\n服务器状态 : 已开启\n服务器名称 : " + retjson["serverName"] + "\n在线人数 : " + retjson["current_players"] + "\n最大在线人数 : " + retjson["max_players"] + "\n服务器MOTD : " + retjson["motd"] + "\n服务器版本 : " + retjson["version"];
                        }
                    }
                }
                MessageBox.Show(s);
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误，请求失败:\n" + ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                string __s = Get(textBox3.Text + @"api/server_list/" + "?apikey=" + textBox4.Text);
                MessageBox.Show(__s);
                JObject __obj = JObject.Parse(__s);
                JArray _arr = (JArray)__obj["data"];
                foreach (JObject obj in _arr)
                {
                    bool anc = true;
                    foreach (string s in textBox1.Items)
                    {
                        if (s == obj["serverName"].ToString())
                        {
                            anc = false;
                        }
                    }
                    if (anc)
                        textBox1.Items.Add(obj["serverName"].ToString());
                }
            }
            catch (Exception) { }
            bool a = true;
            foreach (string s in textBox1.Items)
            {
                if (s == textBox1.Text)
                {
                    a = false;
                }
            }
            if (a)
                textBox1.Items.Add(textBox1.Text);
            a = true;
            foreach (string s in textBox3.Items)
            {
                if (s == textBox3.Text)
                {
                    a = false;
                }
            }
            if (a)
                textBox3.Items.Add(textBox3.Text);
            a = true;
            foreach (string s in textBox4.Items)
            {
                if (s == textBox4.Text)
                {
                    a = false;
                }
            }
            if (a)
                textBox4.Items.Add(textBox4.Text); 
            try
            {
                if (textBox4.Text == "")
                {
                    MessageBox.Show("错误，请求失败:\nApikey不能为NULL");
                }
                else
                {

                    string s = Get(textBox3.Text + @"api/start_server/" + textBox1.Text + "?apikey=" + textBox4.Text);
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
        }

        private void button5_Click(object sender, EventArgs e)
        {

            try
            {
                string __s = Get(textBox3.Text + @"api/server_list/" + "?apikey=" + textBox4.Text);
                MessageBox.Show(__s);
                JObject __obj = JObject.Parse(__s);
                JArray _arr = (JArray)__obj["data"];
                foreach (JObject obj in _arr)
                {
                    bool anc = true;
                    foreach (string s in textBox1.Items)
                    {
                        if (s == obj["serverName"].ToString())
                        {
                            anc = false;
                        }
                    }
                    if (anc)
                        textBox1.Items.Add(obj["serverName"].ToString());
                }
            }
            catch (Exception) { }

            bool a = true;
            foreach (string s in textBox1.Items)
            {
                if (s == textBox1.Text)
                {
                    a = false;
                }
            }
            if (a)
                textBox1.Items.Add(textBox1.Text);
            a = true;
            foreach (string s in textBox3.Items)
            {
                if (s == textBox3.Text)
                {
                    a = false;
                }
            }
            if (a)
                textBox3.Items.Add(textBox3.Text);
            a = true;
            foreach (string s in textBox4.Items)
            {
                if (s == textBox4.Text)
                {
                    a = false;
                }
            }
            if (a)
                textBox4.Items.Add(textBox4.Text);
            new Form2() { ip=textBox3.Text,servername=textBox1.Text,apikey=textBox4.Text}.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            try
            {
                string __s = Get(textBox3.Text + @"api/server_list/" + "?apikey=" + textBox4.Text);
                MessageBox.Show(__s);
                JObject __obj = JObject.Parse(__s);
                JArray _arr = (JArray)__obj["data"];
                foreach (JObject obj in _arr)
                {
                    bool anc = true;
                    foreach (string s in textBox1.Items)
                    {
                        if (s == obj["serverName"].ToString())
                        {
                            anc = false;
                        }
                    }
                    if (anc)
                        textBox1.Items.Add(obj["serverName"].ToString());
                }
            }
            catch (Exception) { }

            bool a = true;
            foreach (string s in textBox1.Items)
            {
                if (s == textBox1.Text)
                {
                    a = false;
                }
            }
            if (a)
                textBox1.Items.Add(textBox1.Text);
            a = true;
            foreach (string s in textBox3.Items)
            {
                if (s == textBox3.Text)
                {
                    a = false;
                }
            }
            if (a)
                textBox3.Items.Add(textBox3.Text);
            a = true;
            foreach (string s in textBox4.Items)
            {
                if (s == textBox4.Text)
                {
                    a = false;
                }
            }
            if (a)
                textBox4.Items.Add(textBox4.Text);
            new Form3() { ip = textBox3.Text, apikey = textBox4.Text }.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            try
            {
                string __s = Get(textBox3.Text + @"api/server_list/" + "?apikey=" + textBox4.Text);
                MessageBox.Show(__s);
                JObject __obj = JObject.Parse(__s);
                JArray _arr = (JArray)__obj["data"];
                foreach (JObject obj in _arr)
                {
                    bool anc = true;
                    foreach (string s in textBox1.Items)
                    {
                        if (s == obj["serverName"].ToString())
                        {
                            anc = false;
                        }
                    }
                    if (anc)
                        textBox1.Items.Add(obj["serverName"].ToString());
                }
            }
            catch (Exception) { }

            bool a = true;
            foreach (string s in textBox1.Items)
            {
                if (s == textBox1.Text)
                {
                    a = false;
                }
            }
            if (a)
                textBox1.Items.Add(textBox1.Text);
            a = true;
            foreach (string s in textBox3.Items)
            {
                if (s == textBox3.Text)
                {
                    a = false;
                }
            }
            if (a)
                textBox3.Items.Add(textBox3.Text);
            a = true;
            foreach (string s in textBox4.Items)
            {
                if (s == textBox4.Text)
                {
                    a = false;
                }
            }
            if (a)
                textBox4.Items.Add(textBox4.Text);
            new Form4() { ip = textBox3.Text, apikey = textBox4.Text }.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            try
            {
                string __s = Get(textBox3.Text + @"api/server_list/" + "?apikey=" + textBox4.Text);
                MessageBox.Show(__s);
                JObject __obj = JObject.Parse(__s);
                JArray _arr = (JArray)__obj["data"];
                foreach (JObject obj in _arr)
                {
                    bool anc = true;
                    foreach (string s in textBox1.Items)
                    {
                        if (s == obj["serverName"].ToString())
                        {
                            anc = false;
                        }
                    }
                    if (anc)
                        textBox1.Items.Add(obj["serverName"].ToString());
                }
            }
            catch (Exception) { }
            bool a = true;
            foreach (string s in textBox1.Items)
            {
                if (s == textBox1.Text)
                {
                    a = false;
                }
            }
            if (a)
                textBox1.Items.Add(textBox1.Text);
            a = true;
            foreach (string s in textBox3.Items)
            {
                if (s == textBox3.Text)
                {
                    a = false;
                }
            }
            if (a)
                textBox3.Items.Add(textBox3.Text);
            a = true;
            foreach (string s in textBox4.Items)
            {
                if (s == textBox4.Text)
                {
                    a = false;
                }
            }
            if (a)
                textBox4.Items.Add(textBox4.Text);

            new Form5() { ip = textBox3.Text, apikey = textBox4.Text,style=0 }.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            try
            {
                string __s = Get(textBox3.Text + @"api/server_list/" + "?apikey=" + textBox4.Text);
                MessageBox.Show(__s);
                JObject __obj = JObject.Parse(__s);
                JArray _arr = (JArray)__obj["data"];
                foreach (JObject obj in _arr)
                {
                    bool anc = true;
                    foreach (string s in textBox1.Items)
                    {
                        if (s == obj["serverName"].ToString())
                        {
                            anc = false;
                        }
                    }
                    if (anc)
                        textBox1.Items.Add(obj["serverName"].ToString());
                }
            }
            catch (Exception) { }

            bool a = true;
            foreach (string s in textBox1.Items)
            {
                if (s == textBox1.Text)
                {
                    a = false;
                }
            }
            if (a)
                textBox1.Items.Add(textBox1.Text);
            a = true;
            foreach (string s in textBox3.Items)
            {
                if (s == textBox3.Text)
                {
                    a = false;
                }
            }
            if (a)
                textBox3.Items.Add(textBox3.Text);
            a = true;
            foreach (string s in textBox4.Items)
            {
                if (s == textBox4.Text)
                {
                    a = false;
                }
            }
            if (a)
                textBox4.Items.Add(textBox4.Text);
            new Form5() { ip = textBox3.Text, apikey = textBox4.Text, style = 1 }.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            try
            {
                string __s = Get(textBox3.Text + @"api/server_list/" + "?apikey=" + textBox4.Text);
                MessageBox.Show(__s);
                JObject __obj = JObject.Parse(__s);
                JArray _arr = (JArray)__obj["data"];
                foreach (JObject obj in _arr)
                {
                    bool anc = true;
                    foreach (string s in textBox1.Items)
                    {
                        if (s == obj["serverName"].ToString())
                        {
                            anc = false;
                        }
                    }
                    if (anc)
                        textBox1.Items.Add(obj["serverName"].ToString());
                }
            }
            catch (Exception) { }

            bool a = true;
            foreach (string s in textBox1.Items)
            {
                if (s == textBox1.Text)
                {
                    a = false;
                }
            }
            if (a)
                textBox1.Items.Add(textBox1.Text);
            a = true;
            foreach (string s in textBox3.Items)
            {
                if (s == textBox3.Text)
                {
                    a = false;
                }
            }
            if (a)
                textBox3.Items.Add(textBox3.Text);
            a = true;
            foreach (string s in textBox4.Items)
            {
                if (s == textBox4.Text)
                {
                    a = false;
                }
            }
            if (a)
                textBox4.Items.Add(textBox4.Text);
            try
            {
                if (textBox4.Text == "")
                {
                    MessageBox.Show("错误，请求失败:\nApikey不能为NULL");
                }
                else
                {

                    string s = Get(textBox3.Text + @"api/server_list/"+"?apikey=" + textBox4.Text);
                    JObject obj = JObject.Parse(s);
                    if (obj["status"].ToString() == "200")
                    {
                        new Form6(obj.ToString()).ShowDialog();
                    }
                    else
                    {
                        s = "请求失败\n" + obj["error"];

                        MessageBox.Show(s);
                    }
                    //MessageBox.Show(s);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误，请求失败:\n" + ex.Message);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

            try
            {
                string __s = Get(textBox3.Text + @"api/server_list/" + "?apikey=" + textBox4.Text);
                MessageBox.Show(__s);
                JObject __obj = JObject.Parse(__s);
                JArray _arr = (JArray)__obj["data"];
                foreach (JObject obj in _arr)
                {
                    bool anc = true;
                    foreach (string s in textBox1.Items)
                    {
                        if (s == obj["serverName"].ToString())
                        {
                            anc = false;
                        }
                    }
                    if (anc)
                        textBox1.Items.Add(obj["serverName"].ToString());
                }
            }
            catch (Exception) { }

            bool a = true;
            foreach (string s in textBox1.Items)
            {
                if (s == textBox1.Text)
                {
                    a = false;
                }
            }
            if (a)
                textBox1.Items.Add(textBox1.Text);
            a = true;
            foreach (string s in textBox3.Items)
            {
                if (s == textBox3.Text)
                {
                    a = false;
                }
            }
            if (a)
                textBox3.Items.Add(textBox3.Text);
            a = true;
            foreach (string s in textBox4.Items)
            {
                if (s == textBox4.Text)
                {
                    a = false;
                }
            }
            if (a)
                textBox4.Items.Add(textBox4.Text);
            try
            {
                if (textBox4.Text == "")
                {
                    MessageBox.Show("错误，请求失败:\nApikey不能为NULL");
                }
                else
                {

                    string s = Get(textBox3.Text + @"api/user_list/" + "?apikey=" + textBox4.Text);
                    JObject obj = JObject.Parse(s);
                    if (obj["status"].ToString() == "200")
                    {
                        new Form7(s).ShowDialog();
                    }
                    else
                    {
                        s = "请求失败\n" + obj["error"];

                        MessageBox.Show(s);
                    }
                    //MessageBox.Show(s);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误，请求失败:\n" + ex.Message);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            new Update().ShowDialog();///ss
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            try
            {
                string __s = Get(textBox3.Text + @"api/server_list/" + "?apikey=" + textBox4.Text);
                MessageBox.Show(__s);
                JObject __obj = JObject.Parse(__s);
                JArray _arr = (JArray)__obj["data"];
                foreach (JObject obj in _arr)
                {
                    bool anc = true;
                    foreach (string s in textBox1.Items)
                    {
                        if (s == obj["serverName"].ToString())
                        {
                            anc = false;
                        }
                    }
                    if (anc)
                        textBox1.Items.Add(obj["serverName"].ToString());
                }
            }
            catch (Exception) { }

            bool a = true;
            foreach (string s in textBox1.Items)
            {
                if (s == textBox1.Text)
                {
                    a = false;
                }
            }
            if (a)
                textBox1.Items.Add(textBox1.Text);
            a = true;
            foreach (string s in textBox3.Items)
            {
                if (s == textBox3.Text)
                {
                    a = false;
                }
            }
            if (a)
                textBox3.Items.Add(textBox3.Text);
            a = true;
            foreach (string s in textBox4.Items)
            {
                if (s == textBox4.Text)
                {
                    a = false;
                }
            }
            if (a)
                textBox4.Items.Add(textBox4.Text);
            
            JObject j = new JObject();
            JArray t1 = new JArray();
            foreach(string s in textBox1.Items)
            {
                t1.Add(s);
            }
            j["t1"] = t1;
            JArray t3 = new JArray();
            foreach (string s in textBox3.Items)
            {
                t3.Add(s);
            }
            j["t3"] = t3;
            JArray t4 = new JArray();
            foreach (string s in textBox4.Items)
            {
                t4.Add(s);
            }
            
            j["t4"] = t4;
            File.WriteAllText("mmalips.json",j.ToString());
        }
    }
}

