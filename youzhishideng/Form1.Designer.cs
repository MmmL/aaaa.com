namespace youzhishideng
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonStartStop = new System.Windows.Forms.Button();
            this.buttonOpenClose = new System.Windows.Forms.Button();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.ovalShapeFire = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShapeYan = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.labelLv = new System.Windows.Forms.Label();
            this.comboBoxLv = new System.Windows.Forms.ComboBox();
            this.labelReceive = new System.Windows.Forms.Label();
            this.labelSend = new System.Windows.Forms.Label();
            this.radioButtonReceiveShu = new System.Windows.Forms.RadioButton();
            this.radioButtonReceiveZi = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButtonSendShu = new System.Windows.Forms.RadioButton();
            this.radioButtonSendFu = new System.Windows.Forms.RadioButton();
            this.groupBoxJianKong = new System.Windows.Forms.GroupBox();
            this.buttonYanClose = new System.Windows.Forms.Button();
            this.buttonFireClose = new System.Windows.Forms.Button();
            this.buttonYanOpen = new System.Windows.Forms.Button();
            this.buttonFireOpen = new System.Windows.Forms.Button();
            this.labelYan = new System.Windows.Forms.Label();
            this.labelFire = new System.Windows.Forms.Label();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.textBoxRunTime = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxJianKong.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStartStop
            // 
            this.buttonStartStop.Location = new System.Drawing.Point(380, 236);
            this.buttonStartStop.Name = "buttonStartStop";
            this.buttonStartStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStartStop.TabIndex = 0;
            this.buttonStartStop.Text = "1";
            this.buttonStartStop.UseVisualStyleBackColor = true;
            this.buttonStartStop.Click += new System.EventHandler(this.buttonStartStop_Click);
            // 
            // buttonOpenClose
            // 
            this.buttonOpenClose.Location = new System.Drawing.Point(85, 236);
            this.buttonOpenClose.Name = "buttonOpenClose";
            this.buttonOpenClose.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenClose.TabIndex = 0;
            this.buttonOpenClose.Text = "打开串口";
            this.buttonOpenClose.UseVisualStyleBackColor = true;
            this.buttonOpenClose.Click += new System.EventHandler(this.buttonOpenClose_Click);
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(73, 32);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(121, 20);
            this.comboBoxPort.TabIndex = 1;
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(12, 37);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(53, 12);
            this.labelPort.TabIndex = 2;
            this.labelPort.Text = "选择串口";
            this.labelPort.Click += new System.EventHandler(this.labelPort_Click);
            // 
            // ovalShapeFire
            // 
            this.ovalShapeFire.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.ovalShapeFire.Location = new System.Drawing.Point(84, 26);
            this.ovalShapeFire.Name = "ovalShapeFire";
            this.ovalShapeFire.Size = new System.Drawing.Size(26, 26);
            // 
            // ovalShapeYan
            // 
            this.ovalShapeYan.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.ovalShapeYan.Location = new System.Drawing.Point(85, 93);
            this.ovalShapeYan.Name = "ovalShapeYan";
            this.ovalShapeYan.Size = new System.Drawing.Size(26, 28);
            // 
            // labelLv
            // 
            this.labelLv.AutoSize = true;
            this.labelLv.Location = new System.Drawing.Point(12, 74);
            this.labelLv.Name = "labelLv";
            this.labelLv.Size = new System.Drawing.Size(41, 12);
            this.labelLv.TabIndex = 2;
            this.labelLv.Text = "波特率";
            this.labelLv.Click += new System.EventHandler(this.labelPort_Click);
            // 
            // comboBoxLv
            // 
            this.comboBoxLv.FormattingEnabled = true;
            this.comboBoxLv.Location = new System.Drawing.Point(73, 71);
            this.comboBoxLv.Name = "comboBoxLv";
            this.comboBoxLv.Size = new System.Drawing.Size(121, 20);
            this.comboBoxLv.TabIndex = 1;
            // 
            // labelReceive
            // 
            this.labelReceive.AutoSize = true;
            this.labelReceive.Location = new System.Drawing.Point(12, 126);
            this.labelReceive.Name = "labelReceive";
            this.labelReceive.Size = new System.Drawing.Size(53, 12);
            this.labelReceive.TabIndex = 2;
            this.labelReceive.Text = "接收模式";
            this.labelReceive.Click += new System.EventHandler(this.labelPort_Click);
            // 
            // labelSend
            // 
            this.labelSend.AutoSize = true;
            this.labelSend.Location = new System.Drawing.Point(12, 181);
            this.labelSend.Name = "labelSend";
            this.labelSend.Size = new System.Drawing.Size(53, 12);
            this.labelSend.TabIndex = 2;
            this.labelSend.Text = "发送模式";
            this.labelSend.Click += new System.EventHandler(this.labelPort_Click);
            // 
            // radioButtonReceiveShu
            // 
            this.radioButtonReceiveShu.AutoSize = true;
            this.radioButtonReceiveShu.Checked = true;
            this.radioButtonReceiveShu.Location = new System.Drawing.Point(3, 6);
            this.radioButtonReceiveShu.Name = "radioButtonReceiveShu";
            this.radioButtonReceiveShu.Size = new System.Drawing.Size(47, 16);
            this.radioButtonReceiveShu.TabIndex = 4;
            this.radioButtonReceiveShu.TabStop = true;
            this.radioButtonReceiveShu.Text = "数值";
            this.radioButtonReceiveShu.UseVisualStyleBackColor = true;
            // 
            // radioButtonReceiveZi
            // 
            this.radioButtonReceiveZi.AutoSize = true;
            this.radioButtonReceiveZi.Location = new System.Drawing.Point(74, 6);
            this.radioButtonReceiveZi.Name = "radioButtonReceiveZi";
            this.radioButtonReceiveZi.Size = new System.Drawing.Size(47, 16);
            this.radioButtonReceiveZi.TabIndex = 4;
            this.radioButtonReceiveZi.Text = "字符";
            this.radioButtonReceiveZi.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonReceiveShu);
            this.panel1.Controls.Add(this.radioButtonReceiveZi);
            this.panel1.Location = new System.Drawing.Point(73, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 27);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButtonSendShu);
            this.panel2.Controls.Add(this.radioButtonSendFu);
            this.panel2.Location = new System.Drawing.Point(73, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(137, 27);
            this.panel2.TabIndex = 7;
            // 
            // radioButtonSendShu
            // 
            this.radioButtonSendShu.AutoSize = true;
            this.radioButtonSendShu.Checked = true;
            this.radioButtonSendShu.Location = new System.Drawing.Point(3, 6);
            this.radioButtonSendShu.Name = "radioButtonSendShu";
            this.radioButtonSendShu.Size = new System.Drawing.Size(47, 16);
            this.radioButtonSendShu.TabIndex = 4;
            this.radioButtonSendShu.TabStop = true;
            this.radioButtonSendShu.Text = "数值";
            this.radioButtonSendShu.UseVisualStyleBackColor = true;
            // 
            // radioButtonSendFu
            // 
            this.radioButtonSendFu.AutoSize = true;
            this.radioButtonSendFu.Location = new System.Drawing.Point(74, 7);
            this.radioButtonSendFu.Name = "radioButtonSendFu";
            this.radioButtonSendFu.Size = new System.Drawing.Size(47, 16);
            this.radioButtonSendFu.TabIndex = 4;
            this.radioButtonSendFu.Text = "字符";
            this.radioButtonSendFu.UseVisualStyleBackColor = true;
            // 
            // groupBoxJianKong
            // 
            this.groupBoxJianKong.Controls.Add(this.buttonYanClose);
            this.groupBoxJianKong.Controls.Add(this.buttonFireClose);
            this.groupBoxJianKong.Controls.Add(this.buttonYanOpen);
            this.groupBoxJianKong.Controls.Add(this.buttonFireOpen);
            this.groupBoxJianKong.Controls.Add(this.labelYan);
            this.groupBoxJianKong.Controls.Add(this.labelFire);
            this.groupBoxJianKong.Controls.Add(this.shapeContainer2);
            this.groupBoxJianKong.Location = new System.Drawing.Point(216, 32);
            this.groupBoxJianKong.Name = "groupBoxJianKong";
            this.groupBoxJianKong.Size = new System.Drawing.Size(352, 167);
            this.groupBoxJianKong.TabIndex = 8;
            this.groupBoxJianKong.TabStop = false;
            this.groupBoxJianKong.Text = "监控区";
            // 
            // buttonYanClose
            // 
            this.buttonYanClose.Location = new System.Drawing.Point(238, 114);
            this.buttonYanClose.Name = "buttonYanClose";
            this.buttonYanClose.Size = new System.Drawing.Size(75, 23);
            this.buttonYanClose.TabIndex = 0;
            this.buttonYanClose.Text = "关闭";
            this.buttonYanClose.UseVisualStyleBackColor = true;
            // 
            // buttonFireClose
            // 
            this.buttonFireClose.Location = new System.Drawing.Point(238, 47);
            this.buttonFireClose.Name = "buttonFireClose";
            this.buttonFireClose.Size = new System.Drawing.Size(75, 23);
            this.buttonFireClose.TabIndex = 0;
            this.buttonFireClose.Text = "关闭";
            this.buttonFireClose.UseVisualStyleBackColor = true;
            // 
            // buttonYanOpen
            // 
            this.buttonYanOpen.Location = new System.Drawing.Point(136, 114);
            this.buttonYanOpen.Name = "buttonYanOpen";
            this.buttonYanOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonYanOpen.TabIndex = 0;
            this.buttonYanOpen.Text = "开启";
            this.buttonYanOpen.UseVisualStyleBackColor = true;
            // 
            // buttonFireOpen
            // 
            this.buttonFireOpen.Location = new System.Drawing.Point(136, 47);
            this.buttonFireOpen.Name = "buttonFireOpen";
            this.buttonFireOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonFireOpen.TabIndex = 0;
            this.buttonFireOpen.Text = "开启";
            this.buttonFireOpen.UseVisualStyleBackColor = true;
            // 
            // labelYan
            // 
            this.labelYan.AutoSize = true;
            this.labelYan.Location = new System.Drawing.Point(26, 119);
            this.labelYan.Name = "labelYan";
            this.labelYan.Size = new System.Drawing.Size(53, 12);
            this.labelYan.TabIndex = 1;
            this.labelYan.Text = "烟雾状况";
            // 
            // labelFire
            // 
            this.labelFire.AutoSize = true;
            this.labelFire.Location = new System.Drawing.Point(26, 49);
            this.labelFire.Name = "labelFire";
            this.labelFire.Size = new System.Drawing.Size(53, 12);
            this.labelFire.TabIndex = 1;
            this.labelFire.Text = "火焰状况";
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(3, 17);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.ovalShapeYan,
            this.ovalShapeFire});
            this.shapeContainer2.Size = new System.Drawing.Size(346, 147);
            this.shapeContainer2.TabIndex = 0;
            this.shapeContainer2.TabStop = false;
            // 
            // textBoxRunTime
            // 
            this.textBoxRunTime.Location = new System.Drawing.Point(14, 364);
            this.textBoxRunTime.Name = "textBoxRunTime";
            this.textBoxRunTime.Size = new System.Drawing.Size(281, 21);
            this.textBoxRunTime.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 2400;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(301, 236);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(195, 134);
            this.textBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 397);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxRunTime);
            this.Controls.Add(this.groupBoxJianKong);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelSend);
            this.Controls.Add(this.labelReceive);
            this.Controls.Add(this.comboBoxLv);
            this.Controls.Add(this.labelLv);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.comboBoxPort);
            this.Controls.Add(this.buttonOpenClose);
            this.Controls.Add(this.buttonStartStop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBoxJianKong.ResumeLayout(false);
            this.groupBoxJianKong.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStartStop;
        private System.Windows.Forms.Button buttonOpenClose;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.Label labelPort;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShapeFire;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShapeYan;
        private System.Windows.Forms.Label labelLv;
        private System.Windows.Forms.ComboBox comboBoxLv;
        private System.Windows.Forms.Label labelReceive;
        private System.Windows.Forms.Label labelSend;
        private System.Windows.Forms.RadioButton radioButtonReceiveShu;
        private System.Windows.Forms.RadioButton radioButtonReceiveZi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButtonSendShu;
        private System.Windows.Forms.RadioButton radioButtonSendFu;
        private System.Windows.Forms.GroupBox groupBoxJianKong;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private System.Windows.Forms.Button buttonYanClose;
        private System.Windows.Forms.Button buttonFireClose;
        private System.Windows.Forms.Button buttonYanOpen;
        private System.Windows.Forms.Button buttonFireOpen;
        private System.Windows.Forms.Label labelYan;
        private System.Windows.Forms.Label labelFire;
        private System.Windows.Forms.TextBox textBoxRunTime;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

