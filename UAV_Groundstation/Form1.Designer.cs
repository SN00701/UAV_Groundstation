namespace UAV_Groundstation
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
            this.Button_set = new System.Windows.Forms.Button();
            this.button_flycal = new System.Windows.Forms.Button();
            this.button_trackline = new System.Windows.Forms.Button();
            this.button_formationsetting = new System.Windows.Forms.Button();
            this.button_flysimulation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_port = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboBox_baudrate = new System.Windows.Forms.ComboBox();
            this.baudrate_connect = new System.Windows.Forms.Button();
            this.button_portselect = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Connection_status = new System.Windows.Forms.Label();
            this.lib_rxcnt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lib_rol = new System.Windows.Forms.Label();
            this.lib_yaw = new System.Windows.Forms.Label();
            this.lib_pit = new System.Windows.Forms.Label();
            this.lib_Vol = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb_seconds = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button_set
            // 
            this.Button_set.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Button_set.Location = new System.Drawing.Point(13, 1);
            this.Button_set.Name = "Button_set";
            this.Button_set.Size = new System.Drawing.Size(51, 23);
            this.Button_set.TabIndex = 0;
            this.Button_set.Text = "设置";
            this.Button_set.UseVisualStyleBackColor = true;
            this.Button_set.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_flycal
            // 
            this.button_flycal.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_flycal.Location = new System.Drawing.Point(64, 0);
            this.button_flycal.Name = "button_flycal";
            this.button_flycal.Size = new System.Drawing.Size(86, 23);
            this.button_flycal.TabIndex = 1;
            this.button_flycal.Text = "飞行校准";
            this.button_flycal.UseVisualStyleBackColor = true;
            // 
            // button_trackline
            // 
            this.button_trackline.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_trackline.Location = new System.Drawing.Point(150, 0);
            this.button_trackline.Name = "button_trackline";
            this.button_trackline.Size = new System.Drawing.Size(81, 23);
            this.button_trackline.TabIndex = 2;
            this.button_trackline.Text = "航迹规划";
            this.button_trackline.UseVisualStyleBackColor = true;
            // 
            // button_formationsetting
            // 
            this.button_formationsetting.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_formationsetting.Location = new System.Drawing.Point(231, 1);
            this.button_formationsetting.Name = "button_formationsetting";
            this.button_formationsetting.Size = new System.Drawing.Size(85, 23);
            this.button_formationsetting.TabIndex = 3;
            this.button_formationsetting.Text = "编队设置";
            this.button_formationsetting.UseVisualStyleBackColor = true;
            this.button_formationsetting.Click += new System.EventHandler(this.button_formationsetting_Click);
            // 
            // button_flysimulation
            // 
            this.button_flysimulation.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_flysimulation.Location = new System.Drawing.Point(316, 1);
            this.button_flysimulation.Name = "button_flysimulation";
            this.button_flysimulation.Size = new System.Drawing.Size(83, 23);
            this.button_flysimulation.TabIndex = 4;
            this.button_flysimulation.Text = "模拟飞行";
            this.button_flysimulation.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(609, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "端口：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox_port
            // 
            this.comboBox_port.FormattingEnabled = true;
            this.comboBox_port.Location = new System.Drawing.Point(667, 2);
            this.comboBox_port.Name = "comboBox_port";
            this.comboBox_port.Size = new System.Drawing.Size(121, 23);
            this.comboBox_port.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(594, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "波特率：";
            // 
            // ComboBox_baudrate
            // 
            this.ComboBox_baudrate.FormattingEnabled = true;
            this.ComboBox_baudrate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.ComboBox_baudrate.Location = new System.Drawing.Point(667, 34);
            this.ComboBox_baudrate.Name = "ComboBox_baudrate";
            this.ComboBox_baudrate.Size = new System.Drawing.Size(121, 23);
            this.ComboBox_baudrate.TabIndex = 8;
            this.ComboBox_baudrate.Text = "115200";
            this.ComboBox_baudrate.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // baudrate_connect
            // 
            this.baudrate_connect.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baudrate_connect.Location = new System.Drawing.Point(512, 34);
            this.baudrate_connect.Name = "baudrate_connect";
            this.baudrate_connect.Size = new System.Drawing.Size(85, 22);
            this.baudrate_connect.TabIndex = 9;
            this.baudrate_connect.Text = "连接飞控";
            this.baudrate_connect.UseVisualStyleBackColor = true;
            this.baudrate_connect.Click += new System.EventHandler(this.baudrate_connect_Click);
            // 
            // button_portselect
            // 
            this.button_portselect.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_portselect.Location = new System.Drawing.Point(512, -1);
            this.button_portselect.Name = "button_portselect";
            this.button_portselect.Size = new System.Drawing.Size(85, 23);
            this.button_portselect.TabIndex = 10;
            this.button_portselect.Text = "扫描串口";
            this.button_portselect.UseVisualStyleBackColor = true;
            this.button_portselect.Click += new System.EventHandler(this.button_portselect_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Connection_status
            // 
            this.Connection_status.AutoSize = true;
            this.Connection_status.BackColor = System.Drawing.SystemColors.Control;
            this.Connection_status.ForeColor = System.Drawing.Color.Red;
            this.Connection_status.Location = new System.Drawing.Point(713, 7);
            this.Connection_status.Name = "Connection_status";
            this.Connection_status.Size = new System.Drawing.Size(52, 15);
            this.Connection_status.TabIndex = 11;
            this.Connection_status.Text = "未连接";
            // 
            // lib_rxcnt
            // 
            this.lib_rxcnt.AutoSize = true;
            this.lib_rxcnt.Location = new System.Drawing.Point(13, 374);
            this.lib_rxcnt.Name = "lib_rxcnt";
            this.lib_rxcnt.Size = new System.Drawing.Size(55, 15);
            this.lib_rxcnt.TabIndex = 12;
            this.lib_rxcnt.Text = "label3";
            this.lib_rxcnt.Click += new System.EventHandler(this.lib_rxcnt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(10, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "横滚角";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(76, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "俯仰角";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(10, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "偏航角";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(76, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "电池电压";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lib_rol
            // 
            this.lib_rol.AutoSize = true;
            this.lib_rol.Font = new System.Drawing.Font("宋体", 12F);
            this.lib_rol.Location = new System.Drawing.Point(4, 165);
            this.lib_rol.Name = "lib_rol";
            this.lib_rol.Size = new System.Drawing.Size(69, 20);
            this.lib_rol.TabIndex = 17;
            this.lib_rol.Text = "0.00°";
            // 
            // lib_yaw
            // 
            this.lib_yaw.AutoSize = true;
            this.lib_yaw.Font = new System.Drawing.Font("宋体", 12F);
            this.lib_yaw.Location = new System.Drawing.Point(4, 229);
            this.lib_yaw.Name = "lib_yaw";
            this.lib_yaw.Size = new System.Drawing.Size(69, 20);
            this.lib_yaw.TabIndex = 18;
            this.lib_yaw.Text = "0.00°";
            // 
            // lib_pit
            // 
            this.lib_pit.AutoSize = true;
            this.lib_pit.Font = new System.Drawing.Font("宋体", 12F);
            this.lib_pit.Location = new System.Drawing.Point(75, 165);
            this.lib_pit.Name = "lib_pit";
            this.lib_pit.Size = new System.Drawing.Size(69, 20);
            this.lib_pit.TabIndex = 19;
            this.lib_pit.Text = "0.00°";
            this.lib_pit.Click += new System.EventHandler(this.lib_pit_Click);
            // 
            // lib_Vol
            // 
            this.lib_Vol.AutoSize = true;
            this.lib_Vol.Font = new System.Drawing.Font("宋体", 12F);
            this.lib_Vol.Location = new System.Drawing.Point(75, 229);
            this.lib_Vol.Name = "lib_Vol";
            this.lib_Vol.Size = new System.Drawing.Size(59, 20);
            this.lib_Vol.TabIndex = 20;
            this.lib_Vol.Text = "0.00V";
            this.lib_Vol.Click += new System.EventHandler(this.lib_Vol_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lb_seconds
            // 
            this.lb_seconds.AutoSize = true;
            this.lb_seconds.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_seconds.Location = new System.Drawing.Point(664, 60);
            this.lb_seconds.Name = "lb_seconds";
            this.lb_seconds.Size = new System.Drawing.Size(35, 13);
            this.lb_seconds.TabIndex = 21;
            this.lb_seconds.Text = "0.00";
            this.lb_seconds.Click += new System.EventHandler(this.lb_seconds_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(705, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "S";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lb_seconds);
            this.Controls.Add(this.lib_Vol);
            this.Controls.Add(this.lib_pit);
            this.Controls.Add(this.lib_yaw);
            this.Controls.Add(this.lib_rol);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lib_rxcnt);
            this.Controls.Add(this.Connection_status);
            this.Controls.Add(this.button_portselect);
            this.Controls.Add(this.baudrate_connect);
            this.Controls.Add(this.ComboBox_baudrate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_port);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_flysimulation);
            this.Controls.Add(this.button_formationsetting);
            this.Controls.Add(this.button_trackline);
            this.Controls.Add(this.button_flycal);
            this.Controls.Add(this.Button_set);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_set;
        private System.Windows.Forms.Button button_flycal;
        private System.Windows.Forms.Button button_trackline;
        private System.Windows.Forms.Button button_formationsetting;
        private System.Windows.Forms.Button button_flysimulation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboBox_baudrate;
        private System.Windows.Forms.Button baudrate_connect;
        private System.Windows.Forms.Button button_portselect;
        private System.Windows.Forms.Label Connection_status;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lib_rxcnt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lib_rol;
        private System.Windows.Forms.Label lib_yaw;
        private System.Windows.Forms.Label lib_pit;
        private System.Windows.Forms.Label lib_Vol;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lb_seconds;
        private System.Windows.Forms.Label label7;
    }
}

