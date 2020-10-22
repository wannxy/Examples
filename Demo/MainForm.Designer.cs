namespace Demo
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Log_I = new System.Windows.Forms.TextBox();
            this.Log_E = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_PK_Delay = new System.Windows.Forms.TextBox();
            this.btn_TZSX = new System.Windows.Forms.Button();
            this.btn_PKSX = new System.Windows.Forms.Button();
            this.tb_QJJC_Max = new System.Windows.Forms.TextBox();
            this.btn_TZJC = new System.Windows.Forms.Button();
            this.btn_KSJC = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_QJJC_Min = new System.Windows.Forms.TextBox();
            this.tb_QJJC_Delay = new System.Windows.Forms.TextBox();
            this.btn_ZTYY = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_QJNBD_Size = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_QJNBD_Delay = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_QJNBD_Limit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_QJNBD_EP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_QJNBD_TZ = new System.Windows.Forms.Button();
            this.tb_QJNBD_KS = new System.Windows.Forms.Button();
            this.btn_INNERBB = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_QJNBD_Smin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_QJNBD_Smax = new System.Windows.Forms.TextBox();
            this.tb_QJNBD_Vmax = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_QJNBD_Vmin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_INNERSB = new System.Windows.Forms.Button();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_QJWBD_Limit = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_QJWBD_ED = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_QJWBD_TZ = new System.Windows.Forms.Button();
            this.tb_QJWBD_KS = new System.Windows.Forms.Button();
            this.btn_OUTERBB = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_QJWBD_Smin = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_QJWBD_Smax = new System.Windows.Forms.TextBox();
            this.tb_QJWBD_Vmax = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_QJWBD_Vmin = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_OUTERSB = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Log_I
            // 
            this.Log_I.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Log_I.Location = new System.Drawing.Point(1, 1);
            this.Log_I.Multiline = true;
            this.Log_I.Name = "Log_I";
            this.Log_I.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Log_I.Size = new System.Drawing.Size(550, 300);
            this.Log_I.TabIndex = 0;
            // 
            // Log_E
            // 
            this.Log_E.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Log_E.Location = new System.Drawing.Point(1, 303);
            this.Log_E.Multiline = true;
            this.Log_E.Name = "Log_E";
            this.Log_E.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Log_E.Size = new System.Drawing.Size(550, 150);
            this.Log_E.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_PK_Delay);
            this.groupBox1.Controls.Add(this.btn_TZSX);
            this.groupBox1.Controls.Add(this.btn_PKSX);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(558, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(96, 138);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "盘口数据";
            // 
            // tb_PK_Delay
            // 
            this.tb_PK_Delay.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_PK_Delay.Location = new System.Drawing.Point(16, 101);
            this.tb_PK_Delay.Name = "tb_PK_Delay";
            this.tb_PK_Delay.Size = new System.Drawing.Size(67, 26);
            this.tb_PK_Delay.TabIndex = 1;
            this.tb_PK_Delay.Text = "2000";
            this.tb_PK_Delay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_TZSX
            // 
            this.btn_TZSX.Location = new System.Drawing.Point(12, 62);
            this.btn_TZSX.Name = "btn_TZSX";
            this.btn_TZSX.Size = new System.Drawing.Size(75, 33);
            this.btn_TZSX.TabIndex = 0;
            this.btn_TZSX.Text = "停止刷新";
            this.btn_TZSX.UseVisualStyleBackColor = true;
            this.btn_TZSX.Click += new System.EventHandler(this.btn_TZSX_Click);
            // 
            // btn_PKSX
            // 
            this.btn_PKSX.Location = new System.Drawing.Point(12, 22);
            this.btn_PKSX.Name = "btn_PKSX";
            this.btn_PKSX.Size = new System.Drawing.Size(75, 33);
            this.btn_PKSX.TabIndex = 0;
            this.btn_PKSX.Text = "刷新盘口";
            this.btn_PKSX.UseVisualStyleBackColor = true;
            this.btn_PKSX.Click += new System.EventHandler(this.btn_PKSX_Click);
            // 
            // tb_QJJC_Max
            // 
            this.tb_QJJC_Max.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_QJJC_Max.Location = new System.Drawing.Point(16, 71);
            this.tb_QJJC_Max.Name = "tb_QJJC_Max";
            this.tb_QJJC_Max.Size = new System.Drawing.Size(67, 26);
            this.tb_QJJC_Max.TabIndex = 1;
            this.tb_QJJC_Max.Text = "0.0020";
            this.tb_QJJC_Max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_TZJC
            // 
            this.btn_TZJC.Location = new System.Drawing.Point(12, 143);
            this.btn_TZJC.Name = "btn_TZJC";
            this.btn_TZJC.Size = new System.Drawing.Size(75, 33);
            this.btn_TZJC.TabIndex = 0;
            this.btn_TZJC.Text = "停止检测";
            this.btn_TZJC.UseVisualStyleBackColor = true;
            this.btn_TZJC.Click += new System.EventHandler(this.btn_TZJC_Click);
            // 
            // btn_KSJC
            // 
            this.btn_KSJC.Location = new System.Drawing.Point(12, 20);
            this.btn_KSJC.Name = "btn_KSJC";
            this.btn_KSJC.Size = new System.Drawing.Size(75, 33);
            this.btn_KSJC.TabIndex = 0;
            this.btn_KSJC.Text = "开始检测";
            this.btn_KSJC.UseVisualStyleBackColor = true;
            this.btn_KSJC.Click += new System.EventHandler(this.btn_KSJC_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_QJJC_Min);
            this.groupBox2.Controls.Add(this.tb_QJJC_Delay);
            this.groupBox2.Controls.Add(this.btn_ZTYY);
            this.groupBox2.Controls.Add(this.tb_QJJC_Max);
            this.groupBox2.Controls.Add(this.btn_TZJC);
            this.groupBox2.Controls.Add(this.btn_KSJC);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(558, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(96, 265);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "区间检测";
            // 
            // tb_QJJC_Min
            // 
            this.tb_QJJC_Min.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_QJJC_Min.Location = new System.Drawing.Point(16, 107);
            this.tb_QJJC_Min.Name = "tb_QJJC_Min";
            this.tb_QJJC_Min.Size = new System.Drawing.Size(67, 26);
            this.tb_QJJC_Min.TabIndex = 1;
            this.tb_QJJC_Min.Text = "0.0002";
            this.tb_QJJC_Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_QJJC_Delay
            // 
            this.tb_QJJC_Delay.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_QJJC_Delay.Location = new System.Drawing.Point(16, 227);
            this.tb_QJJC_Delay.Name = "tb_QJJC_Delay";
            this.tb_QJJC_Delay.Size = new System.Drawing.Size(67, 26);
            this.tb_QJJC_Delay.TabIndex = 1;
            this.tb_QJJC_Delay.Text = "5000";
            this.tb_QJJC_Delay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_ZTYY
            // 
            this.btn_ZTYY.Location = new System.Drawing.Point(12, 182);
            this.btn_ZTYY.Name = "btn_ZTYY";
            this.btn_ZTYY.Size = new System.Drawing.Size(75, 33);
            this.btn_ZTYY.TabIndex = 0;
            this.btn_ZTYY.Text = "暂停音乐";
            this.btn_ZTYY.UseVisualStyleBackColor = true;
            this.btn_ZTYY.Click += new System.EventHandler(this.btn_ZTYY_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_QJNBD_Size);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tb_QJNBD_Delay);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tb_QJNBD_Limit);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tb_QJNBD_EP);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tb_QJNBD_TZ);
            this.groupBox3.Controls.Add(this.tb_QJNBD_KS);
            this.groupBox3.Controls.Add(this.btn_INNERBB);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tb_QJNBD_Smin);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tb_QJNBD_Smax);
            this.groupBox3.Controls.Add(this.tb_QJNBD_Vmax);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.tb_QJNBD_Vmin);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btn_INNERSB);
            this.groupBox3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(2, 460);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(650, 131);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "区间内补单";
            // 
            // tb_QJNBD_Size
            // 
            this.tb_QJNBD_Size.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_QJNBD_Size.Location = new System.Drawing.Point(570, 93);
            this.tb_QJNBD_Size.Name = "tb_QJNBD_Size";
            this.tb_QJNBD_Size.Size = new System.Drawing.Size(71, 26);
            this.tb_QJNBD_Size.TabIndex = 2;
            this.tb_QJNBD_Size.Text = "0.005";
            this.tb_QJNBD_Size.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(499, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 21);
            this.label8.TabIndex = 3;
            this.label8.Text = "大小:";
            // 
            // tb_QJNBD_Delay
            // 
            this.tb_QJNBD_Delay.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_QJNBD_Delay.Location = new System.Drawing.Point(419, 93);
            this.tb_QJNBD_Delay.Name = "tb_QJNBD_Delay";
            this.tb_QJNBD_Delay.Size = new System.Drawing.Size(71, 26);
            this.tb_QJNBD_Delay.TabIndex = 2;
            this.tb_QJNBD_Delay.Text = "5000";
            this.tb_QJNBD_Delay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(348, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 21);
            this.label7.TabIndex = 3;
            this.label7.Text = "延迟:";
            // 
            // tb_QJNBD_Limit
            // 
            this.tb_QJNBD_Limit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_QJNBD_Limit.Location = new System.Drawing.Point(248, 93);
            this.tb_QJNBD_Limit.Name = "tb_QJNBD_Limit";
            this.tb_QJNBD_Limit.Size = new System.Drawing.Size(80, 26);
            this.tb_QJNBD_Limit.TabIndex = 2;
            this.tb_QJNBD_Limit.Text = "500";
            this.tb_QJNBD_Limit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(177, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "限制:";
            // 
            // tb_QJNBD_EP
            // 
            this.tb_QJNBD_EP.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_QJNBD_EP.Location = new System.Drawing.Point(83, 93);
            this.tb_QJNBD_EP.Name = "tb_QJNBD_EP";
            this.tb_QJNBD_EP.Size = new System.Drawing.Size(80, 26);
            this.tb_QJNBD_EP.TabIndex = 2;
            this.tb_QJNBD_EP.Text = "0.0000";
            this.tb_QJNBD_EP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(13, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "补到:";
            // 
            // tb_QJNBD_TZ
            // 
            this.tb_QJNBD_TZ.Font = new System.Drawing.Font("宋体", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.tb_QJNBD_TZ.Location = new System.Drawing.Point(570, 22);
            this.tb_QJNBD_TZ.Name = "tb_QJNBD_TZ";
            this.tb_QJNBD_TZ.Size = new System.Drawing.Size(65, 61);
            this.tb_QJNBD_TZ.TabIndex = 0;
            this.tb_QJNBD_TZ.Text = "卖补";
            this.tb_QJNBD_TZ.UseVisualStyleBackColor = true;
            this.tb_QJNBD_TZ.Click += new System.EventHandler(this.tb_QJNBD_TZ_Click);
            // 
            // tb_QJNBD_KS
            // 
            this.tb_QJNBD_KS.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_QJNBD_KS.ForeColor = System.Drawing.Color.BlueViolet;
            this.tb_QJNBD_KS.Location = new System.Drawing.Point(407, 22);
            this.tb_QJNBD_KS.Name = "tb_QJNBD_KS";
            this.tb_QJNBD_KS.Size = new System.Drawing.Size(143, 61);
            this.tb_QJNBD_KS.TabIndex = 0;
            this.tb_QJNBD_KS.Text = "自动区间内";
            this.tb_QJNBD_KS.UseVisualStyleBackColor = true;
            this.tb_QJNBD_KS.Click += new System.EventHandler(this.tb_QJNBD_KS_Click);
            // 
            // btn_INNERBB
            // 
            this.btn_INNERBB.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_INNERBB.ForeColor = System.Drawing.Color.Green;
            this.btn_INNERBB.Location = new System.Drawing.Point(345, 19);
            this.btn_INNERBB.Name = "btn_INNERBB";
            this.btn_INNERBB.Size = new System.Drawing.Size(40, 67);
            this.btn_INNERBB.TabIndex = 0;
            this.btn_INNERBB.Text = "买补";
            this.btn_INNERBB.UseVisualStyleBackColor = true;
            this.btn_INNERBB.Click += new System.EventHandler(this.btn_INNERBB_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(93, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "步长:";
            // 
            // tb_QJNBD_Smin
            // 
            this.tb_QJNBD_Smin.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_QJNBD_Smin.Location = new System.Drawing.Point(163, 60);
            this.tb_QJNBD_Smin.Name = "tb_QJNBD_Smin";
            this.tb_QJNBD_Smin.Size = new System.Drawing.Size(63, 26);
            this.tb_QJNBD_Smin.TabIndex = 2;
            this.tb_QJNBD_Smin.Text = "0.001";
            this.tb_QJNBD_Smin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "-";
            // 
            // tb_QJNBD_Smax
            // 
            this.tb_QJNBD_Smax.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_QJNBD_Smax.Location = new System.Drawing.Point(270, 60);
            this.tb_QJNBD_Smax.Name = "tb_QJNBD_Smax";
            this.tb_QJNBD_Smax.Size = new System.Drawing.Size(63, 26);
            this.tb_QJNBD_Smax.TabIndex = 2;
            this.tb_QJNBD_Smax.Text = "0.002";
            this.tb_QJNBD_Smax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_QJNBD_Vmax
            // 
            this.tb_QJNBD_Vmax.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_QJNBD_Vmax.Location = new System.Drawing.Point(270, 27);
            this.tb_QJNBD_Vmax.Name = "tb_QJNBD_Vmax";
            this.tb_QJNBD_Vmax.Size = new System.Drawing.Size(63, 26);
            this.tb_QJNBD_Vmax.TabIndex = 2;
            this.tb_QJNBD_Vmax.Text = "50";
            this.tb_QJNBD_Vmax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "-";
            // 
            // tb_QJNBD_Vmin
            // 
            this.tb_QJNBD_Vmin.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_QJNBD_Vmin.Location = new System.Drawing.Point(163, 27);
            this.tb_QJNBD_Vmin.Name = "tb_QJNBD_Vmin";
            this.tb_QJNBD_Vmin.Size = new System.Drawing.Size(63, 26);
            this.tb_QJNBD_Vmin.TabIndex = 2;
            this.tb_QJNBD_Vmin.Text = "30";
            this.tb_QJNBD_Vmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(93, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "单量:";
            // 
            // btn_INNERSB
            // 
            this.btn_INNERSB.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_INNERSB.ForeColor = System.Drawing.Color.Red;
            this.btn_INNERSB.Location = new System.Drawing.Point(24, 20);
            this.btn_INNERSB.Name = "btn_INNERSB";
            this.btn_INNERSB.Size = new System.Drawing.Size(40, 67);
            this.btn_INNERSB.TabIndex = 0;
            this.btn_INNERSB.Text = "卖补";
            this.btn_INNERSB.UseVisualStyleBackColor = true;
            this.btn_INNERSB.Click += new System.EventHandler(this.btn_INNERSB_Click);
            // 
            // textBox16
            // 
            this.textBox16.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox16.Location = new System.Drawing.Point(419, 93);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(71, 26);
            this.textBox16.TabIndex = 2;
            this.textBox16.Text = "5000";
            this.textBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(348, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 21);
            this.label10.TabIndex = 3;
            this.label10.Text = "延迟:";
            // 
            // tb_QJWBD_Limit
            // 
            this.tb_QJWBD_Limit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_QJWBD_Limit.Location = new System.Drawing.Point(248, 93);
            this.tb_QJWBD_Limit.Name = "tb_QJWBD_Limit";
            this.tb_QJWBD_Limit.Size = new System.Drawing.Size(80, 26);
            this.tb_QJWBD_Limit.TabIndex = 2;
            this.tb_QJWBD_Limit.Text = "500";
            this.tb_QJWBD_Limit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(177, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 21);
            this.label11.TabIndex = 3;
            this.label11.Text = "限制:";
            // 
            // tb_QJWBD_ED
            // 
            this.tb_QJWBD_ED.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_QJWBD_ED.Location = new System.Drawing.Point(83, 93);
            this.tb_QJWBD_ED.Name = "tb_QJWBD_ED";
            this.tb_QJWBD_ED.Size = new System.Drawing.Size(80, 26);
            this.tb_QJWBD_ED.TabIndex = 2;
            this.tb_QJWBD_ED.Text = "10";
            this.tb_QJWBD_ED.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(13, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 21);
            this.label12.TabIndex = 3;
            this.label12.Text = "深度:";
            // 
            // tb_QJWBD_TZ
            // 
            this.tb_QJWBD_TZ.Font = new System.Drawing.Font("宋体", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.tb_QJWBD_TZ.Location = new System.Drawing.Point(570, 22);
            this.tb_QJWBD_TZ.Name = "tb_QJWBD_TZ";
            this.tb_QJWBD_TZ.Size = new System.Drawing.Size(65, 61);
            this.tb_QJWBD_TZ.TabIndex = 0;
            this.tb_QJWBD_TZ.Text = "卖补";
            this.tb_QJWBD_TZ.UseVisualStyleBackColor = true;
            // 
            // tb_QJWBD_KS
            // 
            this.tb_QJWBD_KS.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_QJWBD_KS.ForeColor = System.Drawing.Color.Crimson;
            this.tb_QJWBD_KS.Location = new System.Drawing.Point(407, 22);
            this.tb_QJWBD_KS.Name = "tb_QJWBD_KS";
            this.tb_QJWBD_KS.Size = new System.Drawing.Size(143, 61);
            this.tb_QJWBD_KS.TabIndex = 0;
            this.tb_QJWBD_KS.Text = "自动区间外";
            this.tb_QJWBD_KS.UseVisualStyleBackColor = true;
            // 
            // btn_OUTERBB
            // 
            this.btn_OUTERBB.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_OUTERBB.ForeColor = System.Drawing.Color.Green;
            this.btn_OUTERBB.Location = new System.Drawing.Point(345, 19);
            this.btn_OUTERBB.Name = "btn_OUTERBB";
            this.btn_OUTERBB.Size = new System.Drawing.Size(40, 67);
            this.btn_OUTERBB.TabIndex = 0;
            this.btn_OUTERBB.Text = "买补";
            this.btn_OUTERBB.UseVisualStyleBackColor = true;
            this.btn_OUTERBB.Click += new System.EventHandler(this.btn_OUTERBB_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(93, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 21);
            this.label13.TabIndex = 1;
            this.label13.Text = "步长:";
            // 
            // tb_QJWBD_Smin
            // 
            this.tb_QJWBD_Smin.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_QJWBD_Smin.Location = new System.Drawing.Point(163, 60);
            this.tb_QJWBD_Smin.Name = "tb_QJWBD_Smin";
            this.tb_QJWBD_Smin.Size = new System.Drawing.Size(63, 26);
            this.tb_QJWBD_Smin.TabIndex = 2;
            this.tb_QJWBD_Smin.Text = "0.003";
            this.tb_QJWBD_Smin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(240, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 17);
            this.label14.TabIndex = 1;
            this.label14.Text = "-";
            // 
            // tb_QJWBD_Smax
            // 
            this.tb_QJWBD_Smax.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_QJWBD_Smax.Location = new System.Drawing.Point(270, 60);
            this.tb_QJWBD_Smax.Name = "tb_QJWBD_Smax";
            this.tb_QJWBD_Smax.Size = new System.Drawing.Size(63, 26);
            this.tb_QJWBD_Smax.TabIndex = 2;
            this.tb_QJWBD_Smax.Text = "0.007";
            this.tb_QJWBD_Smax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_QJWBD_Vmax
            // 
            this.tb_QJWBD_Vmax.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_QJWBD_Vmax.Location = new System.Drawing.Point(270, 27);
            this.tb_QJWBD_Vmax.Name = "tb_QJWBD_Vmax";
            this.tb_QJWBD_Vmax.Size = new System.Drawing.Size(63, 26);
            this.tb_QJWBD_Vmax.TabIndex = 2;
            this.tb_QJWBD_Vmax.Text = "40";
            this.tb_QJWBD_Vmax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(240, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 17);
            this.label15.TabIndex = 1;
            this.label15.Text = "-";
            // 
            // tb_QJWBD_Vmin
            // 
            this.tb_QJWBD_Vmin.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_QJWBD_Vmin.Location = new System.Drawing.Point(163, 27);
            this.tb_QJWBD_Vmin.Name = "tb_QJWBD_Vmin";
            this.tb_QJWBD_Vmin.Size = new System.Drawing.Size(63, 26);
            this.tb_QJWBD_Vmin.TabIndex = 2;
            this.tb_QJWBD_Vmin.Text = "30";
            this.tb_QJWBD_Vmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(93, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 21);
            this.label16.TabIndex = 1;
            this.label16.Text = "单量:";
            // 
            // btn_OUTERSB
            // 
            this.btn_OUTERSB.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_OUTERSB.ForeColor = System.Drawing.Color.Red;
            this.btn_OUTERSB.Location = new System.Drawing.Point(24, 20);
            this.btn_OUTERSB.Name = "btn_OUTERSB";
            this.btn_OUTERSB.Size = new System.Drawing.Size(40, 67);
            this.btn_OUTERSB.TabIndex = 0;
            this.btn_OUTERSB.Text = "卖补";
            this.btn_OUTERSB.UseVisualStyleBackColor = true;
            this.btn_OUTERSB.Click += new System.EventHandler(this.btn_OUTERSB_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox16);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.tb_QJWBD_Limit);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.tb_QJWBD_ED);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.tb_QJWBD_TZ);
            this.groupBox4.Controls.Add(this.tb_QJWBD_KS);
            this.groupBox4.Controls.Add(this.btn_OUTERBB);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.tb_QJWBD_Smin);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.tb_QJWBD_Smax);
            this.groupBox4.Controls.Add(this.tb_QJWBD_Vmax);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.tb_QJWBD_Vmin);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.btn_OUTERSB);
            this.groupBox4.Location = new System.Drawing.Point(4, 597);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(650, 131);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "区间内补单";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 739);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(664, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 761);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Log_E);
            this.Controls.Add(this.Log_I);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "区间检测与补单";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Log_I;
        private System.Windows.Forms.TextBox Log_E;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_PK_Delay;
        private System.Windows.Forms.Button btn_TZSX;
        private System.Windows.Forms.Button btn_PKSX;
        private System.Windows.Forms.TextBox tb_QJJC_Max;
        private System.Windows.Forms.Button btn_TZJC;
        private System.Windows.Forms.Button btn_KSJC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_QJJC_Delay;
        private System.Windows.Forms.Button btn_ZTYY;
        private System.Windows.Forms.TextBox tb_QJJC_Min;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_QJNBD_Vmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_INNERSB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_QJNBD_Smin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_QJNBD_Smax;
        private System.Windows.Forms.TextBox tb_QJNBD_Vmax;
        private System.Windows.Forms.Button tb_QJNBD_TZ;
        private System.Windows.Forms.Button tb_QJNBD_KS;
        private System.Windows.Forms.Button btn_INNERBB;
        private System.Windows.Forms.TextBox tb_QJNBD_Size;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_QJNBD_Delay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_QJNBD_Limit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_QJNBD_EP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_QJWBD_Limit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_QJWBD_ED;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button tb_QJWBD_TZ;
        private System.Windows.Forms.Button tb_QJWBD_KS;
        private System.Windows.Forms.Button btn_OUTERBB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_QJWBD_Smin;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_QJWBD_Smax;
        private System.Windows.Forms.TextBox tb_QJWBD_Vmax;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb_QJWBD_Vmin;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_OUTERSB;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

