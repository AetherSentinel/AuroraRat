namespace Server.Forms
{
    partial class FormBuilder
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuilder));
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPaste_bin = new System.Windows.Forms.TextBox();
            this.chkPaste_bin = new System.Windows.Forms.CheckBox();
            this.btnRemoveIP = new System.Windows.Forms.Button();
            this.btnAddIP = new System.Windows.Forms.Button();
            this.textIP = new System.Windows.Forms.TextBox();
            this.listBoxIP = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRemovePort = new System.Windows.Forms.Button();
            this.btnAddPort = new System.Windows.Forms.Button();
            this.listBoxPort = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBoxFolder = new System.Windows.Forms.ComboBox();
            this.textFilename = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkAntiProcess = new System.Windows.Forms.CheckBox();
            this.chkAnti = new System.Windows.Forms.CheckBox();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.numDelay = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.chkBsod = new System.Windows.Forms.CheckBox();
            this.txtMutex = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnClone = new System.Windows.Forms.Button();
            this.btnAssembly = new System.Windows.Forms.CheckBox();
            this.txtFileVersion = new System.Windows.Forms.TextBox();
            this.txtProductVersion = new System.Windows.Forms.TextBox();
            this.txtOriginalFilename = new System.Windows.Forms.TextBox();
            this.txtTrademarks = new System.Windows.Forms.TextBox();
            this.txtCopyright = new System.Windows.Forms.TextBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chkIcon = new System.Windows.Forms.CheckBox();
            this.txtIcon = new System.Windows.Forms.TextBox();
            this.btnIcon = new System.Windows.Forms.Button();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.chkObfu = new System.Windows.Forms.CheckBox();
            this.btnBuild = new System.Windows.Forms.Button();
            this.btnShellcode = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(420, 352);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(412, 324);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Connection";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPaste_bin);
            this.groupBox1.Controls.Add(this.chkPaste_bin);
            this.groupBox1.Controls.Add(this.btnRemoveIP);
            this.groupBox1.Controls.Add(this.btnAddIP);
            this.groupBox1.Controls.Add(this.textIP);
            this.groupBox1.Controls.Add(this.listBoxIP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textPort);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnRemovePort);
            this.groupBox1.Controls.Add(this.btnAddPort);
            this.groupBox1.Controls.Add(this.listBoxPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(412, 342);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // txtPaste_bin
            // 
            this.txtPaste_bin.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Server.Properties.Settings.Default, "Paste_bin", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtPaste_bin.Enabled = false;
            this.txtPaste_bin.Location = new System.Drawing.Point(116, 194);
            this.txtPaste_bin.Margin = new System.Windows.Forms.Padding(2);
            this.txtPaste_bin.Name = "txtPaste_bin";
            this.txtPaste_bin.Size = new System.Drawing.Size(229, 23);
            this.txtPaste_bin.TabIndex = 91;
            // 
            // chkPaste_bin
            // 
            this.chkPaste_bin.AutoSize = true;
            this.chkPaste_bin.Location = new System.Drawing.Point(17, 194);
            this.chkPaste_bin.Margin = new System.Windows.Forms.Padding(2);
            this.chkPaste_bin.Name = "chkPaste_bin";
            this.chkPaste_bin.Size = new System.Drawing.Size(95, 19);
            this.chkPaste_bin.TabIndex = 92;
            this.chkPaste_bin.Text = "Get ip by link";
            this.chkPaste_bin.UseVisualStyleBackColor = true;
            // 
            // btnRemoveIP
            // 
            this.btnRemoveIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveIP.Location = new System.Drawing.Point(128, 144);
            this.btnRemoveIP.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveIP.Name = "btnRemoveIP";
            this.btnRemoveIP.Size = new System.Drawing.Size(34, 28);
            this.btnRemoveIP.TabIndex = 90;
            this.btnRemoveIP.Text = "-";
            this.btnRemoveIP.UseVisualStyleBackColor = true;
            this.btnRemoveIP.Click += new System.EventHandler(this.btnRemoveIP_Click);
            // 
            // btnAddIP
            // 
            this.btnAddIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddIP.Location = new System.Drawing.Point(36, 144);
            this.btnAddIP.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddIP.Name = "btnAddIP";
            this.btnAddIP.Size = new System.Drawing.Size(34, 28);
            this.btnAddIP.TabIndex = 89;
            this.btnAddIP.Text = "+";
            this.btnAddIP.UseVisualStyleBackColor = true;
            this.btnAddIP.Click += new System.EventHandler(this.btnAddIP_Click);
            // 
            // textIP
            // 
            this.textIP.Location = new System.Drawing.Point(36, 24);
            this.textIP.Margin = new System.Windows.Forms.Padding(2);
            this.textIP.Name = "textIP";
            this.textIP.Size = new System.Drawing.Size(126, 23);
            this.textIP.TabIndex = 87;
            // 
            // listBoxIP
            // 
            this.listBoxIP.FormattingEnabled = true;
            this.listBoxIP.ItemHeight = 15;
            this.listBoxIP.Location = new System.Drawing.Point(36, 61);
            this.listBoxIP.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxIP.Name = "listBoxIP";
            this.listBoxIP.Size = new System.Drawing.Size(126, 79);
            this.listBoxIP.TabIndex = 88;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 81;
            this.label2.Text = "Port";
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(219, 24);
            this.textPort.Margin = new System.Windows.Forms.Padding(2);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(126, 23);
            this.textPort.TabIndex = 82;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 15);
            this.label3.TabIndex = 86;
            this.label3.Text = "IP";
            // 
            // btnRemovePort
            // 
            this.btnRemovePort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemovePort.Location = new System.Drawing.Point(311, 142);
            this.btnRemovePort.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemovePort.Name = "btnRemovePort";
            this.btnRemovePort.Size = new System.Drawing.Size(34, 30);
            this.btnRemovePort.TabIndex = 85;
            this.btnRemovePort.Text = "-";
            this.btnRemovePort.UseVisualStyleBackColor = true;
            this.btnRemovePort.Click += new System.EventHandler(this.btnRemovePort_Click);
            // 
            // btnAddPort
            // 
            this.btnAddPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPort.Location = new System.Drawing.Point(219, 144);
            this.btnAddPort.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPort.Name = "btnAddPort";
            this.btnAddPort.Size = new System.Drawing.Size(34, 28);
            this.btnAddPort.TabIndex = 84;
            this.btnAddPort.Text = "+";
            this.btnAddPort.UseVisualStyleBackColor = true;
            this.btnAddPort.Click += new System.EventHandler(this.btnAddPort_Click);
            // 
            // listBoxPort
            // 
            this.listBoxPort.FormattingEnabled = true;
            this.listBoxPort.ItemHeight = 15;
            this.listBoxPort.Location = new System.Drawing.Point(219, 61);
            this.listBoxPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.listBoxPort.Name = "listBoxPort";
            this.listBoxPort.Size = new System.Drawing.Size(126, 79);
            this.listBoxPort.TabIndex = 83;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, -12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 80;
            this.label1.Text = "IP";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(412, 324);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Install";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.comboBoxFolder);
            this.groupBox2.Controls.Add(this.textFilename);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(4, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(412, 342);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Install";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 20);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(58, 19);
            this.checkBox1.TabIndex = 107;
            this.checkBox1.Text = "Install";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBoxFolder
            // 
            this.comboBoxFolder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFolder.Enabled = false;
            this.comboBoxFolder.FormattingEnabled = true;
            this.comboBoxFolder.Items.AddRange(new object[] {
            "%AppData%",
            "%Temp%"});
            this.comboBoxFolder.Location = new System.Drawing.Point(66, 88);
            this.comboBoxFolder.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxFolder.Name = "comboBoxFolder";
            this.comboBoxFolder.Size = new System.Drawing.Size(236, 23);
            this.comboBoxFolder.TabIndex = 106;
            // 
            // textFilename
            // 
            this.textFilename.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Server.Properties.Settings.Default, "Filename", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textFilename.Enabled = false;
            this.textFilename.Location = new System.Drawing.Point(66, 50);
            this.textFilename.Margin = new System.Windows.Forms.Padding(2);
            this.textFilename.Name = "textFilename";
            this.textFilename.Size = new System.Drawing.Size(236, 23);
            this.textFilename.TabIndex = 104;
            this.textFilename.Text = global::Server.Properties.Settings.Default.Filename;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 102;
            this.label4.Text = "File path";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 103;
            this.label5.Text = "File name";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(412, 324);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Misc";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkAntiProcess);
            this.groupBox3.Controls.Add(this.chkAnti);
            this.groupBox3.Controls.Add(this.txtGroup);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.numDelay);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.chkBsod);
            this.groupBox3.Controls.Add(this.txtMutex);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(4, 10);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(412, 342);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MISC";
            // 
            // chkAntiProcess
            // 
            this.chkAntiProcess.AutoSize = true;
            this.chkAntiProcess.Location = new System.Drawing.Point(147, 94);
            this.chkAntiProcess.Margin = new System.Windows.Forms.Padding(4);
            this.chkAntiProcess.Name = "chkAntiProcess";
            this.chkAntiProcess.Size = new System.Drawing.Size(101, 19);
            this.chkAntiProcess.TabIndex = 121;
            this.chkAntiProcess.Text = "Block taskmgr";
            this.chkAntiProcess.UseVisualStyleBackColor = true;
            // 
            // chkAnti
            // 
            this.chkAnti.AutoSize = true;
            this.chkAnti.Location = new System.Drawing.Point(49, 94);
            this.chkAnti.Margin = new System.Windows.Forms.Padding(4);
            this.chkAnti.Name = "chkAnti";
            this.chkAnti.Size = new System.Drawing.Size(72, 19);
            this.chkAnti.TabIndex = 120;
            this.chkAnti.Text = "Anti-VM";
            this.chkAnti.UseVisualStyleBackColor = true;
            // 
            // txtGroup
            // 
            this.txtGroup.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Server.Properties.Settings.Default, "Group", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtGroup.Location = new System.Drawing.Point(48, 15);
            this.txtGroup.Margin = new System.Windows.Forms.Padding(2);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(128, 23);
            this.txtGroup.TabIndex = 119;
            this.txtGroup.Text = global::Server.Properties.Settings.Default.Group;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(4, 18);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 15);
            this.label17.TabIndex = 118;
            this.label17.Text = "Group";
            // 
            // numDelay
            // 
            this.numDelay.Location = new System.Drawing.Point(75, 128);
            this.numDelay.Margin = new System.Windows.Forms.Padding(2);
            this.numDelay.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numDelay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDelay.Name = "numDelay";
            this.numDelay.Size = new System.Drawing.Size(65, 23);
            this.numDelay.TabIndex = 117;
            this.numDelay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 130);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 15);
            this.label16.TabIndex = 116;
            this.label16.Text = "Sleep (s)";
            // 
            // chkBsod
            // 
            this.chkBsod.AutoSize = true;
            this.chkBsod.Location = new System.Drawing.Point(190, 20);
            this.chkBsod.Margin = new System.Windows.Forms.Padding(2);
            this.chkBsod.Name = "chkBsod";
            this.chkBsod.Size = new System.Drawing.Size(58, 19);
            this.chkBsod.TabIndex = 115;
            this.chkBsod.Text = "BSOD";
            this.chkBsod.UseVisualStyleBackColor = true;
            // 
            // txtMutex
            // 
            this.txtMutex.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Server.Properties.Settings.Default, "Mutex", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtMutex.Location = new System.Drawing.Point(49, 53);
            this.txtMutex.Margin = new System.Windows.Forms.Padding(2);
            this.txtMutex.Name = "txtMutex";
            this.txtMutex.Size = new System.Drawing.Size(238, 23);
            this.txtMutex.TabIndex = 114;
            this.txtMutex.Text = global::Server.Properties.Settings.Default.Mutex;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 53);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 113;
            this.label6.Text = "Mutex";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(412, 324);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Assembly";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnClone);
            this.groupBox4.Controls.Add(this.btnAssembly);
            this.groupBox4.Controls.Add(this.txtFileVersion);
            this.groupBox4.Controls.Add(this.txtProductVersion);
            this.groupBox4.Controls.Add(this.txtOriginalFilename);
            this.groupBox4.Controls.Add(this.txtTrademarks);
            this.groupBox4.Controls.Add(this.txtCopyright);
            this.groupBox4.Controls.Add(this.txtCompany);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtDescription);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtProduct);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(4, 10);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(412, 342);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Assembly Information";
            // 
            // btnClone
            // 
            this.btnClone.Enabled = false;
            this.btnClone.Location = new System.Drawing.Point(270, 18);
            this.btnClone.Margin = new System.Windows.Forms.Padding(2);
            this.btnClone.Name = "btnClone";
            this.btnClone.Size = new System.Drawing.Size(80, 29);
            this.btnClone.TabIndex = 108;
            this.btnClone.Text = "Clone";
            this.btnClone.UseVisualStyleBackColor = true;
            this.btnClone.Click += new System.EventHandler(this.btnClone_Click);
            // 
            // btnAssembly
            // 
            this.btnAssembly.AutoSize = true;
            this.btnAssembly.Location = new System.Drawing.Point(43, 23);
            this.btnAssembly.Margin = new System.Windows.Forms.Padding(2);
            this.btnAssembly.Name = "btnAssembly";
            this.btnAssembly.Size = new System.Drawing.Size(77, 19);
            this.btnAssembly.TabIndex = 107;
            this.btnAssembly.Text = "Assembly";
            this.btnAssembly.UseVisualStyleBackColor = true;
            this.btnAssembly.CheckedChanged += new System.EventHandler(this.btnAssembly_CheckedChanged);
            // 
            // txtFileVersion
            // 
            this.txtFileVersion.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Server.Properties.Settings.Default, "txtFileVersion", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtFileVersion.Enabled = false;
            this.txtFileVersion.Location = new System.Drawing.Point(175, 283);
            this.txtFileVersion.Margin = new System.Windows.Forms.Padding(2);
            this.txtFileVersion.Name = "txtFileVersion";
            this.txtFileVersion.Size = new System.Drawing.Size(176, 23);
            this.txtFileVersion.TabIndex = 106;
            this.txtFileVersion.Text = global::Server.Properties.Settings.Default.txtFileVersion;
            // 
            // txtProductVersion
            // 
            this.txtProductVersion.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Server.Properties.Settings.Default, "txtProductVersion", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtProductVersion.Enabled = false;
            this.txtProductVersion.Location = new System.Drawing.Point(175, 252);
            this.txtProductVersion.Margin = new System.Windows.Forms.Padding(2);
            this.txtProductVersion.Name = "txtProductVersion";
            this.txtProductVersion.Size = new System.Drawing.Size(176, 23);
            this.txtProductVersion.TabIndex = 105;
            this.txtProductVersion.Text = global::Server.Properties.Settings.Default.txtProductVersion;
            // 
            // txtOriginalFilename
            // 
            this.txtOriginalFilename.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Server.Properties.Settings.Default, "txtOriginalFilename", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtOriginalFilename.Enabled = false;
            this.txtOriginalFilename.Location = new System.Drawing.Point(175, 219);
            this.txtOriginalFilename.Margin = new System.Windows.Forms.Padding(2);
            this.txtOriginalFilename.Name = "txtOriginalFilename";
            this.txtOriginalFilename.Size = new System.Drawing.Size(176, 23);
            this.txtOriginalFilename.TabIndex = 104;
            this.txtOriginalFilename.Text = global::Server.Properties.Settings.Default.txtOriginalFilename;
            // 
            // txtTrademarks
            // 
            this.txtTrademarks.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Server.Properties.Settings.Default, "txtTrademarks", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtTrademarks.Enabled = false;
            this.txtTrademarks.Location = new System.Drawing.Point(175, 188);
            this.txtTrademarks.Margin = new System.Windows.Forms.Padding(2);
            this.txtTrademarks.Name = "txtTrademarks";
            this.txtTrademarks.Size = new System.Drawing.Size(176, 23);
            this.txtTrademarks.TabIndex = 103;
            this.txtTrademarks.Text = global::Server.Properties.Settings.Default.txtTrademarks;
            // 
            // txtCopyright
            // 
            this.txtCopyright.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Server.Properties.Settings.Default, "txtCopyright", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtCopyright.Enabled = false;
            this.txtCopyright.Location = new System.Drawing.Point(175, 157);
            this.txtCopyright.Margin = new System.Windows.Forms.Padding(2);
            this.txtCopyright.Name = "txtCopyright";
            this.txtCopyright.Size = new System.Drawing.Size(176, 23);
            this.txtCopyright.TabIndex = 102;
            this.txtCopyright.Text = global::Server.Properties.Settings.Default.txtCopyright;
            // 
            // txtCompany
            // 
            this.txtCompany.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Server.Properties.Settings.Default, "txtCompany", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtCompany.Enabled = false;
            this.txtCompany.Location = new System.Drawing.Point(175, 126);
            this.txtCompany.Margin = new System.Windows.Forms.Padding(2);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(176, 23);
            this.txtCompany.TabIndex = 101;
            this.txtCompany.Text = global::Server.Properties.Settings.Default.txtCompany;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(41, 254);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 15);
            this.label14.TabIndex = 100;
            this.label14.Text = "Product Version:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(41, 287);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 15);
            this.label13.TabIndex = 99;
            this.label13.Text = "File Version:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(41, 223);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 15);
            this.label12.TabIndex = 98;
            this.label12.Text = "Original Filename:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 192);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 15);
            this.label11.TabIndex = 97;
            this.label11.Text = "Trademarks:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 160);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 15);
            this.label10.TabIndex = 96;
            this.label10.Text = "Copyright:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 129);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 15);
            this.label9.TabIndex = 95;
            this.label9.Text = "Company:";
            // 
            // txtDescription
            // 
            this.txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Server.Properties.Settings.Default, "txtDescription", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtDescription.Enabled = false;
            this.txtDescription.Location = new System.Drawing.Point(175, 94);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(176, 23);
            this.txtDescription.TabIndex = 94;
            this.txtDescription.Text = global::Server.Properties.Settings.Default.txtDescription;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 97);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 15);
            this.label7.TabIndex = 93;
            this.label7.Text = "Description:";
            // 
            // txtProduct
            // 
            this.txtProduct.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Server.Properties.Settings.Default, "ProductName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtProduct.Enabled = false;
            this.txtProduct.Location = new System.Drawing.Point(175, 62);
            this.txtProduct.Margin = new System.Windows.Forms.Padding(2);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(176, 23);
            this.txtProduct.TabIndex = 92;
            this.txtProduct.Text = global::Server.Properties.Settings.Default.ProductName;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 66);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 91;
            this.label8.Text = "Product:";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox5);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage5.Size = new System.Drawing.Size(412, 324);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Icon";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chkIcon);
            this.groupBox5.Controls.Add(this.txtIcon);
            this.groupBox5.Controls.Add(this.btnIcon);
            this.groupBox5.Controls.Add(this.picIcon);
            this.groupBox5.Location = new System.Drawing.Point(4, 10);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(412, 342);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Add Icon";
            // 
            // chkIcon
            // 
            this.chkIcon.AutoSize = true;
            this.chkIcon.Location = new System.Drawing.Point(76, 28);
            this.chkIcon.Margin = new System.Windows.Forms.Padding(2);
            this.chkIcon.Name = "chkIcon";
            this.chkIcon.Size = new System.Drawing.Size(50, 19);
            this.chkIcon.TabIndex = 98;
            this.chkIcon.Text = "Icon";
            this.chkIcon.UseVisualStyleBackColor = true;
            this.chkIcon.CheckedChanged += new System.EventHandler(this.chkIcon_CheckedChanged);
            // 
            // txtIcon
            // 
            this.txtIcon.Enabled = false;
            this.txtIcon.Location = new System.Drawing.Point(76, 53);
            this.txtIcon.Margin = new System.Windows.Forms.Padding(2);
            this.txtIcon.Name = "txtIcon";
            this.txtIcon.Size = new System.Drawing.Size(238, 23);
            this.txtIcon.TabIndex = 97;
            // 
            // btnIcon
            // 
            this.btnIcon.Enabled = false;
            this.btnIcon.Location = new System.Drawing.Point(212, 98);
            this.btnIcon.Margin = new System.Windows.Forms.Padding(2);
            this.btnIcon.Name = "btnIcon";
            this.btnIcon.Size = new System.Drawing.Size(103, 48);
            this.btnIcon.TabIndex = 96;
            this.btnIcon.Text = "Choose icon";
            this.btnIcon.UseVisualStyleBackColor = true;
            this.btnIcon.Click += new System.EventHandler(this.btnIcon_Click);
            // 
            // picIcon
            // 
            this.picIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picIcon.ErrorImage = null;
            this.picIcon.InitialImage = null;
            this.picIcon.Location = new System.Drawing.Point(76, 98);
            this.picIcon.Margin = new System.Windows.Forms.Padding(2);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(128, 137);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIcon.TabIndex = 95;
            this.picIcon.TabStop = false;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.chkObfu);
            this.tabPage6.Controls.Add(this.btnBuild);
            this.tabPage6.Controls.Add(this.btnShellcode);
            this.tabPage6.Location = new System.Drawing.Point(4, 24);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage6.Size = new System.Drawing.Size(412, 324);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Build";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // chkObfu
            // 
            this.chkObfu.AutoSize = true;
            this.chkObfu.Location = new System.Drawing.Point(130, 64);
            this.chkObfu.Margin = new System.Windows.Forms.Padding(2);
            this.chkObfu.Name = "chkObfu";
            this.chkObfu.Size = new System.Drawing.Size(125, 19);
            this.chkObfu.TabIndex = 117;
            this.chkObfu.Text = "Simple Obfuscator";
            this.chkObfu.UseVisualStyleBackColor = true;
            // 
            // btnBuild
            // 
            this.btnBuild.Location = new System.Drawing.Point(218, 123);
            this.btnBuild.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(141, 56);
            this.btnBuild.TabIndex = 116;
            this.btnBuild.Text = "Build exe";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // btnShellcode
            // 
            this.btnShellcode.Location = new System.Drawing.Point(31, 123);
            this.btnShellcode.Margin = new System.Windows.Forms.Padding(4);
            this.btnShellcode.Name = "btnShellcode";
            this.btnShellcode.Size = new System.Drawing.Size(141, 56);
            this.btnShellcode.TabIndex = 115;
            this.btnShellcode.Text = "Shellcode";
            this.btnShellcode.UseVisualStyleBackColor = true;
            this.btnShellcode.Click += new System.EventHandler(this.btnShellcode_Click);
            // 
            // FormBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 352);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormBuilder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Builder";
            this.Load += new System.EventHandler(this.Builder_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPaste_bin;
        private System.Windows.Forms.CheckBox chkPaste_bin;
        private System.Windows.Forms.Button btnRemoveIP;
        private System.Windows.Forms.Button btnAddIP;
        private System.Windows.Forms.TextBox textIP;
        private System.Windows.Forms.ListBox listBoxIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRemovePort;
        private System.Windows.Forms.Button btnAddPort;
        private System.Windows.Forms.ListBox listBoxPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxFolder;
        private System.Windows.Forms.TextBox textFilename;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkAntiProcess;
        private System.Windows.Forms.CheckBox chkAnti;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown numDelay;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox chkBsod;
        private System.Windows.Forms.TextBox txtMutex;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnClone;
        private System.Windows.Forms.CheckBox btnAssembly;
        private System.Windows.Forms.TextBox txtFileVersion;
        private System.Windows.Forms.TextBox txtProductVersion;
        private System.Windows.Forms.TextBox txtOriginalFilename;
        private System.Windows.Forms.TextBox txtTrademarks;
        private System.Windows.Forms.TextBox txtCopyright;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox chkIcon;
        private System.Windows.Forms.TextBox txtIcon;
        private System.Windows.Forms.Button btnIcon;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button btnShellcode;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox chkObfu;
    }
}
