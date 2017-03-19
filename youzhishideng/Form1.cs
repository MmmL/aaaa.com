using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace youzhishideng
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labelPort_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        System.DateTime historyTime = System.DateTime.Now;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            ovalShapeFire.FillColor = Color.Gray;
            ovalShapeFire.BorderColor = Color.Gray;
            ovalShapeYan.FillColor = Color.Gray;
            ovalShapeYan.BorderColor = Color.Gray;
            for (int i = 1; i < 20; i++)
            {
                comboBoxPort.Items.Add("COM" + i.ToString());
            }
            comboBoxPort.Text = "COM1";//串口号默认值
            comboBoxLv.Text = "2400";//波特率默认值
            serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(port_DataReceived);//必须手动添加事件处理程序
        }
        private void port_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)//串口数据接收事件
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            if (!radioButtonReceiveShu.Checked)//如果接收模式为字符模式
            {
                string str = serialPort1.ReadExisting();//字符换方式读
                                                        //textBoxReceive.AppendText(str);//在文本框内添加收到的字符
            }
            else
            {
                byte data;
                data = (byte)serialPort1.ReadByte();//先把串口传过来的数据强制转换成byte型的
                //string str = Convert.ToString(data,16).ToUpper();
                //if (data == 1)
                //{
                //    textBox1.AppendText("没问题！" + "   ");
                //}
                //else if (data == 2)
                //{
                //    textBox1.AppendText("我操出事了！！" + " ");
                //}
                    if (data == 1)
                    {
                    //    textBox1.AppendText("收到了");
                        ovalShapeFire.FillColor = Color.Green;
                        ovalShapeFire.BorderColor = Color.Green;
                        ovalShapeYan.FillColor = Color.Green;
                        ovalShapeYan.BorderColor = Color.Green;
                    }
                    else if (data == 2)
                    {
                        ovalShapeFire.FillColor = Color.Red;
                        ovalShapeFire.BorderColor = Color.Red;
                        ovalShapeYan.FillColor = Color.Green;
                        ovalShapeYan.BorderColor = Color.Green;
                    }
                    else if (data == 3)
                    {
                        ovalShapeFire.FillColor = Color.Green;
                        ovalShapeFire.BorderColor = Color.Green;
                        ovalShapeYan.FillColor = Color.Red;
                       ovalShapeYan.BorderColor = Color.Red;
                    }
                    //textBoxReceive.AppendText("0x" + (str.Length == 1 ? "0" + str : str) + " ");
                }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            System.DateTime currentTime = System.DateTime.Now;//获取当前时间
            TimeSpan ts = currentTime - historyTime;//计算当前时间与开始时间差
            string str = ts.Days.ToString() + "天" + ts.Hours.ToString() + "小时" + ts.Minutes.ToString() + "分" + ts.Seconds.ToString() + "秒";
            textBoxRunTime.Text = "本监控系统已经运行: " + str;
        }

        private void buttonStartStop_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonOpenClose_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)                                     //串口打开就关闭
            {
               try
                {
                    serialPort1.Close();
                    ovalShapeFire.FillColor = Color.Gray;
                    ovalShapeFire.BorderColor = Color.Gray;
                    ovalShapeYan.FillColor = Color.Gray;
                    ovalShapeYan.BorderColor = Color.Gray;
                }
                catch { }                                               //确保万无一失
                buttonOpenClose.Text = "打开串口";
            }
            else
            {
                try
                {
                    serialPort1.PortName = comboBoxPort.Text;              //端口号
                    serialPort1.Open();
                    //serialPort1.BaudRate = Convert.ToInt32(comboBoxLv.Text, 10);
                    //ovalShapeFire.FillColor = Color.Green;                                //打开端口
                    buttonOpenClose.Text = "关闭串口";
                }
                catch
                {
                    MessageBox.Show("串口打开失败", "错误");
                }
            }
        }
    }
}
