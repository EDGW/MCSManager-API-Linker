namespace Server_RBoot_MCM
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addCmd = new System.Windows.Forms.RichTextBox();
            this.schedule = new System.Windows.Forms.RichTextBox();
            this.oe = new System.Windows.Forms.TextBox();
            this.run = new System.Windows.Forms.TextBox();
            this.currentPlayers = new System.Windows.Forms.TextBox();
            this.Xms = new System.Windows.Forms.TextBox();
            this.cwd = new System.Windows.Forms.TextBox();
            this.maxPlayers = new System.Windows.Forms.TextBox();
            this.jarName = new System.Windows.Forms.TextBox();
            this.hcmd = new System.Windows.Forms.TextBox();
            this.serverName = new System.Windows.Forms.TextBox();
            this.Xmx = new System.Windows.Forms.TextBox();
            this.java = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mcpingMotd = new System.Windows.Forms.TextBox();
            this.mcpingHost = new System.Windows.Forms.TextBox();
            this.mcpingPort = new System.Windows.Forms.TextBox();
            this.mcpingName = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dockerPorts = new System.Windows.Forms.TextBox();
            this.dockerImageName = new System.Windows.Forms.TextBox();
            this.DockerXmx = new System.Windows.Forms.TextBox();
            this.isDocker = new System.Windows.Forms.TextBox();
            this.dockerCommand = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.timeLimitDate = new System.Windows.Forms.TextBox();
            this.autoRestart = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.createDate = new System.Windows.Forms.TextBox();
            this.ie = new System.Windows.Forms.TextBox();
            this.@__filename__ = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(135, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(276, 25);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "选择要查看的服务器";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(16, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 397);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "请先选择要查看的服务器";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.addCmd);
            this.panel1.Controls.Add(this.schedule);
            this.panel1.Controls.Add(this.oe);
            this.panel1.Controls.Add(this.run);
            this.panel1.Controls.Add(this.currentPlayers);
            this.panel1.Controls.Add(this.Xms);
            this.panel1.Controls.Add(this.cwd);
            this.panel1.Controls.Add(this.maxPlayers);
            this.panel1.Controls.Add(this.jarName);
            this.panel1.Controls.Add(this.hcmd);
            this.panel1.Controls.Add(this.serverName);
            this.panel1.Controls.Add(this.Xmx);
            this.panel1.Controls.Add(this.java);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.timeLimitDate);
            this.panel1.Controls.Add(this.autoRestart);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.createDate);
            this.panel1.Controls.Add(this.ie);
            this.panel1.Controls.Add(this.@__filename__);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label36);
            this.panel1.Controls.Add(this.label35);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label33);
            this.panel1.Controls.Add(this.label31);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label29);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 375);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // addCmd
            // 
            this.addCmd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addCmd.Location = new System.Drawing.Point(92, 366);
            this.addCmd.Name = "addCmd";
            this.addCmd.ReadOnly = true;
            this.addCmd.Size = new System.Drawing.Size(270, 152);
            this.addCmd.TabIndex = 26;
            this.addCmd.Text = "NULL";
            // 
            // schedule
            // 
            this.schedule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.schedule.Location = new System.Drawing.Point(90, 102);
            this.schedule.Name = "schedule";
            this.schedule.ReadOnly = true;
            this.schedule.Size = new System.Drawing.Size(270, 65);
            this.schedule.TabIndex = 25;
            this.schedule.Text = "NULL";
            // 
            // oe
            // 
            this.oe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.oe.Location = new System.Drawing.Point(210, 71);
            this.oe.Name = "oe";
            this.oe.ReadOnly = true;
            this.oe.Size = new System.Drawing.Size(135, 16);
            this.oe.TabIndex = 24;
            this.oe.Text = "NULL";
            // 
            // run
            // 
            this.run.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.run.Location = new System.Drawing.Point(90, 624);
            this.run.Name = "run";
            this.run.ReadOnly = true;
            this.run.Size = new System.Drawing.Size(270, 16);
            this.run.TabIndex = 17;
            this.run.Text = "run";
            // 
            // currentPlayers
            // 
            this.currentPlayers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentPlayers.Location = new System.Drawing.Point(90, 658);
            this.currentPlayers.Name = "currentPlayers";
            this.currentPlayers.ReadOnly = true;
            this.currentPlayers.Size = new System.Drawing.Size(270, 16);
            this.currentPlayers.TabIndex = 18;
            this.currentPlayers.Text = "currentPlayers";
            // 
            // Xms
            // 
            this.Xms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Xms.Location = new System.Drawing.Point(90, 575);
            this.Xms.Name = "Xms";
            this.Xms.ReadOnly = true;
            this.Xms.Size = new System.Drawing.Size(270, 16);
            this.Xms.TabIndex = 17;
            this.Xms.Text = "NULL";
            // 
            // cwd
            // 
            this.cwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cwd.Location = new System.Drawing.Point(90, 592);
            this.cwd.Name = "cwd";
            this.cwd.ReadOnly = true;
            this.cwd.Size = new System.Drawing.Size(270, 16);
            this.cwd.TabIndex = 18;
            this.cwd.Text = "cwd";
            // 
            // maxPlayers
            // 
            this.maxPlayers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maxPlayers.Location = new System.Drawing.Point(90, 675);
            this.maxPlayers.Name = "maxPlayers";
            this.maxPlayers.ReadOnly = true;
            this.maxPlayers.Size = new System.Drawing.Size(270, 16);
            this.maxPlayers.TabIndex = 20;
            this.maxPlayers.Text = "NULL";
            // 
            // jarName
            // 
            this.jarName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.jarName.Location = new System.Drawing.Point(90, 541);
            this.jarName.Name = "jarName";
            this.jarName.ReadOnly = true;
            this.jarName.Size = new System.Drawing.Size(270, 16);
            this.jarName.TabIndex = 19;
            this.jarName.Text = "NULL";
            // 
            // hcmd
            // 
            this.hcmd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hcmd.Location = new System.Drawing.Point(90, 609);
            this.hcmd.Name = "hcmd";
            this.hcmd.ReadOnly = true;
            this.hcmd.Size = new System.Drawing.Size(270, 16);
            this.hcmd.TabIndex = 20;
            this.hcmd.Text = "highCommande";
            // 
            // serverName
            // 
            this.serverName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.serverName.Location = new System.Drawing.Point(90, 641);
            this.serverName.Name = "serverName";
            this.serverName.ReadOnly = true;
            this.serverName.Size = new System.Drawing.Size(270, 16);
            this.serverName.TabIndex = 22;
            this.serverName.Text = "serverName";
            // 
            // Xmx
            // 
            this.Xmx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Xmx.Location = new System.Drawing.Point(90, 558);
            this.Xmx.Name = "Xmx";
            this.Xmx.ReadOnly = true;
            this.Xmx.Size = new System.Drawing.Size(270, 16);
            this.Xmx.TabIndex = 21;
            this.Xmx.Text = "NULL";
            // 
            // java
            // 
            this.java.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.java.Location = new System.Drawing.Point(90, 524);
            this.java.Name = "java";
            this.java.ReadOnly = true;
            this.java.Size = new System.Drawing.Size(270, 16);
            this.java.TabIndex = 23;
            this.java.Text = "NULL";
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.mcpingMotd);
            this.panel3.Controls.Add(this.mcpingHost);
            this.panel3.Controls.Add(this.mcpingPort);
            this.panel3.Controls.Add(this.mcpingName);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Location = new System.Drawing.Point(92, 273);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(268, 87);
            this.panel3.TabIndex = 15;
            // 
            // mcpingMotd
            // 
            this.mcpingMotd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mcpingMotd.Location = new System.Drawing.Point(54, 50);
            this.mcpingMotd.Name = "mcpingMotd";
            this.mcpingMotd.ReadOnly = true;
            this.mcpingMotd.Size = new System.Drawing.Size(220, 16);
            this.mcpingMotd.TabIndex = 24;
            this.mcpingMotd.Text = "NULL";
            this.mcpingMotd.TextChanged += new System.EventHandler(this.textBox19_TextChanged);
            // 
            // mcpingHost
            // 
            this.mcpingHost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mcpingHost.Location = new System.Drawing.Point(54, 16);
            this.mcpingHost.Name = "mcpingHost";
            this.mcpingHost.ReadOnly = true;
            this.mcpingHost.Size = new System.Drawing.Size(220, 16);
            this.mcpingHost.TabIndex = 25;
            this.mcpingHost.Text = "NULL";
            // 
            // mcpingPort
            // 
            this.mcpingPort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mcpingPort.Location = new System.Drawing.Point(54, 33);
            this.mcpingPort.Name = "mcpingPort";
            this.mcpingPort.ReadOnly = true;
            this.mcpingPort.Size = new System.Drawing.Size(220, 16);
            this.mcpingPort.TabIndex = 26;
            this.mcpingPort.Text = "NULL";
            this.mcpingPort.TextChanged += new System.EventHandler(this.textBox21_TextChanged);
            // 
            // mcpingName
            // 
            this.mcpingName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mcpingName.Location = new System.Drawing.Point(54, -1);
            this.mcpingName.Name = "mcpingName";
            this.mcpingName.ReadOnly = true;
            this.mcpingName.Size = new System.Drawing.Size(220, 16);
            this.mcpingName.TabIndex = 27;
            this.mcpingName.Text = "NULL";
            this.mcpingName.TextChanged += new System.EventHandler(this.textBox22_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(19, 33);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(32, 17);
            this.label20.TabIndex = 3;
            this.label20.Text = "端口";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, -1);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 17);
            this.label14.TabIndex = 11;
            this.label14.Text = "名字";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(5, 50);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 17);
            this.label16.TabIndex = 9;
            this.label16.Text = "MOTD";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(19, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 17);
            this.label17.TabIndex = 7;
            this.label17.Text = "地址";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dockerPorts);
            this.panel2.Controls.Add(this.dockerImageName);
            this.panel2.Controls.Add(this.DockerXmx);
            this.panel2.Controls.Add(this.isDocker);
            this.panel2.Controls.Add(this.dockerCommand);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Location = new System.Drawing.Point(91, 169);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 101);
            this.panel2.TabIndex = 14;
            // 
            // dockerPorts
            // 
            this.dockerPorts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dockerPorts.Location = new System.Drawing.Point(117, 49);
            this.dockerPorts.Name = "dockerPorts";
            this.dockerPorts.ReadOnly = true;
            this.dockerPorts.Size = new System.Drawing.Size(270, 16);
            this.dockerPorts.TabIndex = 24;
            this.dockerPorts.Text = "NULL";
            // 
            // dockerImageName
            // 
            this.dockerImageName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dockerImageName.Location = new System.Drawing.Point(117, 15);
            this.dockerImageName.Name = "dockerImageName";
            this.dockerImageName.ReadOnly = true;
            this.dockerImageName.Size = new System.Drawing.Size(270, 16);
            this.dockerImageName.TabIndex = 25;
            this.dockerImageName.Text = "NULL";
            // 
            // DockerXmx
            // 
            this.DockerXmx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DockerXmx.Location = new System.Drawing.Point(117, 32);
            this.DockerXmx.Name = "DockerXmx";
            this.DockerXmx.ReadOnly = true;
            this.DockerXmx.Size = new System.Drawing.Size(270, 16);
            this.DockerXmx.TabIndex = 26;
            this.DockerXmx.Text = "NULL";
            // 
            // isDocker
            // 
            this.isDocker.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.isDocker.Location = new System.Drawing.Point(117, 66);
            this.isDocker.Name = "isDocker";
            this.isDocker.ReadOnly = true;
            this.isDocker.Size = new System.Drawing.Size(270, 16);
            this.isDocker.TabIndex = 27;
            this.isDocker.Text = "NULL";
            // 
            // dockerCommand
            // 
            this.dockerCommand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dockerCommand.HideSelection = false;
            this.dockerCommand.Location = new System.Drawing.Point(117, -2);
            this.dockerCommand.Name = "dockerCommand";
            this.dockerCommand.ReadOnly = true;
            this.dockerCommand.Size = new System.Drawing.Size(570, 16);
            this.dockerCommand.TabIndex = 28;
            this.dockerCommand.Text = "NULL";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 17);
            this.label12.TabIndex = 3;
            this.label12.Text = "Docker命令";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 50);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 17);
            this.label15.TabIndex = 10;
            this.label15.Text = "容器开放的端口";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(68, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "镜像名";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 17);
            this.label11.TabIndex = 5;
            this.label11.Text = "容器最大内存限制";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(14, 65);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(98, 17);
            this.label18.TabIndex = 6;
            this.label18.Text = "是否使用Docker";
            // 
            // timeLimitDate
            // 
            this.timeLimitDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timeLimitDate.Location = new System.Drawing.Point(90, 54);
            this.timeLimitDate.Name = "timeLimitDate";
            this.timeLimitDate.ReadOnly = true;
            this.timeLimitDate.Size = new System.Drawing.Size(270, 16);
            this.timeLimitDate.TabIndex = 13;
            this.timeLimitDate.Text = "NULL";
            // 
            // autoRestart
            // 
            this.autoRestart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.autoRestart.Location = new System.Drawing.Point(90, 88);
            this.autoRestart.Name = "autoRestart";
            this.autoRestart.ReadOnly = true;
            this.autoRestart.Size = new System.Drawing.Size(270, 16);
            this.autoRestart.TabIndex = 13;
            this.autoRestart.Text = "NULL";
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Location = new System.Drawing.Point(90, 20);
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Size = new System.Drawing.Size(270, 16);
            this.name.TabIndex = 13;
            this.name.Text = "NULL";
            // 
            // createDate
            // 
            this.createDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.createDate.Location = new System.Drawing.Point(90, 37);
            this.createDate.Name = "createDate";
            this.createDate.ReadOnly = true;
            this.createDate.Size = new System.Drawing.Size(270, 16);
            this.createDate.TabIndex = 13;
            this.createDate.Text = "NULL";
            // 
            // ie
            // 
            this.ie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ie.Location = new System.Drawing.Point(90, 71);
            this.ie.Name = "ie";
            this.ie.ReadOnly = true;
            this.ie.Size = new System.Drawing.Size(270, 16);
            this.ie.TabIndex = 13;
            this.ie.Text = "NULL";
            // 
            // __filename__
            // 
            this.@__filename__.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.@__filename__.Location = new System.Drawing.Point(90, 3);
            this.@__filename__.Name = "__filename__";
            this.@__filename__.ReadOnly = true;
            this.@__filename__.Size = new System.Drawing.Size(270, 16);
            this.@__filename__.TabIndex = 13;
            this.@__filename__.Text = "NULL";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(10, 270);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(80, 17);
            this.label21.TabIndex = 2;
            this.label21.Text = "玩家监听协议";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "是否自动重启";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(9, 625);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(80, 17);
            this.label36.TabIndex = 3;
            this.label36.Text = "是否正在运行";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(11, 540);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(80, 17);
            this.label35.TabIndex = 4;
            this.label35.Text = "服务端文件名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "最后启动时间";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(33, 366);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 17);
            this.label19.TabIndex = 5;
            this.label19.Text = "附加参数";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(10, 659);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(80, 17);
            this.label33.TabIndex = 5;
            this.label33.Text = "当前玩家数量";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(33, 574);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(56, 17);
            this.label31.TabIndex = 6;
            this.label31.Text = "最小内存";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-2, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "输入/输出编码";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(-3, 608);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(92, 17);
            this.label29.TabIndex = 7;
            this.label29.Text = "自定义启动参数";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "Docker配置";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(33, 523);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(57, 17);
            this.label28.TabIndex = 8;
            this.label28.Text = "Java路径";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "服务器名";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(21, 642);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(68, 17);
            this.label26.TabIndex = 9;
            this.label26.Text = "服务器名字";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(9, 675);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(80, 17);
            this.label25.TabIndex = 10;
            this.label25.Text = "最大玩家数量";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(33, 557);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(56, 17);
            this.label23.TabIndex = 10;
            this.label23.Text = "最大内存";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "到期时间";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(34, 591);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(56, 17);
            this.label22.TabIndex = 11;
            this.label22.Text = "工作目录";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "计划任务";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "文件位置";
            // 
            // Form6
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(422, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "获取全部服务器信息";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox __filename__;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox run;
        private System.Windows.Forms.TextBox currentPlayers;
        private System.Windows.Forms.TextBox Xms;
        private System.Windows.Forms.TextBox maxPlayers;
        private System.Windows.Forms.TextBox jarName;
        private System.Windows.Forms.TextBox hcmd;
        private System.Windows.Forms.TextBox serverName;
        private System.Windows.Forms.TextBox Xmx;
        private System.Windows.Forms.TextBox cwd;
        private System.Windows.Forms.TextBox java;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox timeLimitDate;
        private System.Windows.Forms.TextBox autoRestart;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox createDate;
        private System.Windows.Forms.TextBox ie;
        private System.Windows.Forms.TextBox mcpingMotd;
        private System.Windows.Forms.TextBox mcpingHost;
        private System.Windows.Forms.TextBox mcpingPort;
        private System.Windows.Forms.TextBox mcpingName;
        private System.Windows.Forms.TextBox dockerPorts;
        private System.Windows.Forms.TextBox dockerImageName;
        private System.Windows.Forms.TextBox DockerXmx;
        private System.Windows.Forms.TextBox isDocker;
        private System.Windows.Forms.TextBox dockerCommand;
        private System.Windows.Forms.TextBox oe;
        private System.Windows.Forms.RichTextBox addCmd;
        private System.Windows.Forms.RichTextBox schedule;
    }
}