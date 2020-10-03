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
    public partial class Form7 : Form
    {
        string JSON;
        public Form7(string json)
        {
            InitializeComponent();
            JSON = json;
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            JObject obj = JObject.Parse(JSON);
            if (int.Parse(obj["status"].ToString()) != 200)
            {
                MessageBox.Show("获取失败,错误码 " + obj["status"]);
                this.Close();
            }
            JArray dataa = (JArray)obj["data"];
            foreach (JObject j in dataa)
            {
                comboBox1.Items.Add(j["username"]);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            JObject obj = JObject.Parse(JSON);
            if (int.Parse(obj["status"].ToString()) != 200)
            {
                MessageBox.Show("获取失败,错误码 " + obj["status"]);
                this.Close();
            }
            JArray dataa = (JArray)obj["data"];
            foreach (JObject j in dataa)
            {
                if (j["username"].ToString() == comboBox1.SelectedItem.ToString())
                {
                    groupBox1.Text = j["username"].ToString();
                    username.Text = j["data"]["username"].ToString();
                    lastDate.Text = j["data"]["lastDate"].ToString();
                    createDate.Text = j["data"]["createDate"].ToString();
                    break;
                }
            }
        }
    }
}
