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
    public partial class Form6 : Form
    {
        string JSON;
        public Form6(string json)
        {
            InitializeComponent();
            JSON = json;
        }

        private void Form6_Load(object sender, EventArgs e)
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
                comboBox1.Items.Add(j["serverName"]);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox1.Text = comboBox1.SelectedItem.ToString();
            JObject obj = JObject.Parse(JSON);
            if (int.Parse(obj["status"].ToString()) != 200)
            {
                MessageBox.Show("获取失败,错误码 " + obj["status"]);
                this.Close();
            }
            JArray dataa = (JArray)obj["data"];
            foreach (JObject j2 in dataa)
            {
                if (j2["serverName"].ToString() == comboBox1.SelectedItem.ToString())
                {

                    JObject j = (JObject)j2["data"];
                    try
                    {
                        __filename__.Text = j["__filename__"].ToString();
                    }
                    catch (Exception) { }
                    try
                    {
                        name.Text = j["name"].ToString();
                    }
                    catch (Exception) { }
                    try
                    {
                        createDate.Text = j["createDate"].ToString();
                    }
                    catch (Exception) { }
                    try
                    {
                        timeLimitDate.Text = j["timeLimitDate"].ToString();
                    }
                    catch (Exception) { }
                    try
                    {
                        ie.Text = j["ie"].ToString();
                    }
                    catch (Exception) { }
                    try
                    {
                        oe.Text = j["oe"].ToString();
                    }
                    catch (Exception) { }
                    try
                    {
                        autoRestart.Text = j["autoRestart"].ToString();
                    }
                    catch (Exception) { }
                    try
                    {
                        schedule.Text = j["schedule"].ToString();
                    }
                    catch (Exception) { }
                    try
                    {
                        dockerCommand.Text = (j["dockerConfig"])["dockerCommand"].ToString();
                    }
                    catch (Exception) { }
                    try
                    {
                        dockerImageName.Text = (j["dockerConfig"])["dockerImageName"].ToString();
                    }
                    catch (Exception) { }
                    try
                    {
                        DockerXmx.Text = (j["dockerConfig"])["dockerXmx"].ToString();
                    }
                    catch (Exception) { }
                    try
                    {
                        dockerPorts.Text = (j["dockerConfig"])["dockerPorts"].ToString();
                    }
                    catch (Exception) { }
                    try
                    {
                        isDocker.Text = (j["dockerConfig"])["isDocker"].ToString();
                    }
                    catch (Exception) { }
                    try
                    {
                        mcpingName.Text = (j["mcpingConfig"])["mcpingName"].ToString();
                    }
                    catch (Exception) { }
                    try
                    {
                        mcpingHost.Text = (j["mcpingConfig"])["mcpingHost"].ToString();
                    }
                    catch (Exception) { }
                    try
                    {
                        mcpingPort.Text = (j["mcpingConfig"])["mcpingPort"].ToString();
                    }
                    catch (Exception) { }
                    try
                    {
                        mcpingMotd.Text = (j["mcpingConfig"])["mcpingMotd"].ToString();
                    }
                    catch (Exception) { }
                    try
                    {
                        addCmd.Text = j["addCmd"].ToString();
                    }
                    catch (Exception) { }
                    try
                    {
                        java.Text = j["java"].ToString();
                    }
                    catch (Exception) { }
                    try
                    {
                        jarName.Text = j["jarName"].ToString();
                    }
                    catch (Exception) { }
                    try
                    {
                        Xmx.Text = j["Xmx"].ToString();
                    }
                    catch (Exception) { }
                    try
                    {
                        Xms.Text = j["Xms"].ToString();
                    }
                    catch (Exception) { }
                    try
                    {
                        cwd.Text = j["cwd"].ToString();
                    }
                    catch (Exception) { }
                    try
                    {
                        hcmd.Text = j["highCommande"].ToString();
                    }
                    catch (Exception) { }
                    try
                    {
                        run.Text = j["run"].ToString();
                    }
                    catch (Exception) { }
                    try
                    {
                        serverName.Text = j["serverName"].ToString();
                    }
                    catch (Exception) { }
                    try
                    {
                        currentPlayers.Text = j["currnetPlayers"].ToString();
                    }
                    catch (Exception) { }
                    try
                    {
                        maxPlayers.Text = j["maxPlayers"].ToString();
                    }
                    catch (Exception) { }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
