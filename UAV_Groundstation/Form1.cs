using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAV_Groundstation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region 变量
        public float D_ang_rol, D_ang_pit,D_ang_yaw,B_vol;
        public bool isOpen = false;
        bool isReceving = false;
        int n = 0;
        private long RX_CNT = 0;
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void baudrate_connect_Click(object sender, EventArgs e)
        {
            if (isOpen == false)
            {
                try
                {
                    string[] ports = SerialPort.GetPortNames();
                    Array.Sort(ports);
                    int com_is_alive = Array.IndexOf(ports, comboBox_port.Text.Trim());
                    if(com_is_alive == -1)
                    {
                        MessageBox.Show("串口已经不存在");
                        com_Sacn();
                        return;
                    }
                    serialPort1.PortName = comboBox_port.Text;
                    serialPort1.BaudRate =int.Parse(ComboBox_baudrate.Text);
                    serialPort1.Open();

                    comboBox_port.Enabled = false;//端口下拉功能关闭
                    ComboBox_baudrate.Enabled = false;//波特率选择功能关闭
                    button_portselect.Enabled = false;//连接飞控按钮功能关闭

                    isOpen = true;
                    baudrate_connect.Text = "断开连接";
                    Connection_status.Text = "已连接";
                    Connection_status.ForeColor = System.Drawing.Color.Green;
                    timer1.Enabled = true;

                }
                catch (Exception ex)
                {
                    baudrate_connect_Click(null, null);
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            else
            {
                try
                {
                    serialPort1.Close();
                    isOpen = false;

                    
                    comboBox_port.Enabled = true;//端口下拉菜单打开
                    ComboBox_baudrate.Enabled = true;//波特率下拉菜单打开
                    button_portselect.Enabled = true;//连接飞控按钮功能打开

                    isOpen = false;
                    baudrate_connect.Text = "连接飞控";
                    Connection_status.Text = "未连接";
                    Connection_status.ForeColor = System.Drawing.Color.Red;
                    timer1.Enabled = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
       

        private void button_portselect_Click(object sender, EventArgs e)
        {
            com_Sacn();
        }



        public void com_Sacn()
        {
            string[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);
            comboBox_port.Items.Clear();
            comboBox_port.Items.AddRange(ports);
            comboBox_port.SelectedIndex = comboBox_port.Items.Count > 0 ? 0 : -1;//选择第一个可用串口
        }
        #region 协议解析

        public class Buff  //先建立缓冲区
        {
            List<byte> cache = new List<byte>();
            public List<byte> Cache
            {
                get { return cache; }
            }

            private static Buff buffer;
            public static Buff Buffer
            {
                get
                {
                    if (buffer == null)
                    {
                        buffer = new Buff();
                    }
                    return buffer;
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            n++;
            lb_seconds.Text = n.ToString();
            lib_rol.Text = D_ang_rol.ToString("#0.00") + " °";
            lib_pit.Text = D_ang_pit.ToString("#0.00") + " °";
            lib_yaw.Text = D_ang_yaw.ToString("#0.00") + " °";
            lib_Vol.Text = B_vol.ToString("#0.00") + " V ";
            if(B_vol<11.8)
            {
                lib_Vol.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lib_Vol.ForeColor = System.Drawing.Color.Green;

            }
            lib_rxcnt.Text = RX_CNT.ToString();

        }

        private void lb_seconds_Click(object sender, EventArgs e)
        {
            
        }

        private void lib_pit_Click(object sender, EventArgs e)
        {

        }

        private void lib_Vol_Click(object sender, EventArgs e)
        {

        }

        private void lib_rxcnt_Click(object sender, EventArgs e)
        {

        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            isReceving = true;
            int n = serialPort1.BytesToRead;
            byte[] temp= new byte[n];

            RX_CNT += n;

            serialPort1.Read(temp, 0, n);

            foreach (byte data in temp)
            {
                Buff.Buffer.Cache.Add(data);
            }
            for (int i = 0;i<Buff.Buffer.Cache.Count;i++)
            {
                if (Buff.Buffer.Cache[i] == 0xFA && Buff.Buffer.Cache.Count - i > 4 && Buff.Buffer.Cache[i + 4] == 0xFA)
                {
                    int len = Buff.Buffer.Cache[i + 3];
                    int package_tail = i + len + 7;

                    if(package_tail <= Buff.Buffer.Cache.Count)
                    {
                        if (Buff.Buffer.Cache[package_tail - 1] == 0x16)
                        {
                            List<byte> listbyte;
                            listbyte = Buff.Buffer.Cache.GetRange(i,len + 7);
                            GetReciveInfo(listbyte);
                        }
                        Buff.Buffer.Cache.RemoveRange(0, i + len + 7);
                    }
                }
            }
            isReceving = false;

        }
        void GetReciveInfo(List<byte> listbyte)
        {
            int datalength = listbyte.Count - 7;
            byte[] datainfo = new byte[datalength];


            Array.Copy(listbyte.ToArray(), 5, datainfo, 0, datalength);

            switch(listbyte[2])
            {
                 case 0x04:
                    D_ang_rol = (float)(Int16)(datainfo[3] * 256 * 256 * 256 + datainfo[2] * 256 * 256 + datainfo[1] * 256 + datainfo[0]) / 100;
                    D_ang_pit = (float)(Int16)(datainfo[7] * 256 * 256 * 256 + datainfo[6] * 256 * 256 + datainfo[5] * 256 + datainfo[4]) / 100;
                    D_ang_yaw = (float)(Int16)(datainfo[11] * 256 * 256 * 256 + datainfo[10] * 256 * 256 + datainfo[9] * 256 + datainfo[8]) / 100;
                     break;
                 case 0x07:
                    B_vol = (float)(Int32)(datainfo[4] * 256 * 256 * 256 + datainfo[3] * 256 * 256 + datainfo[2] * 256 + datainfo[1]) / 1000;
                    break;

            }
        }

        #endregion

        private void button_formationsetting_Click(object sender, EventArgs e)
        {

        }
    }
}
