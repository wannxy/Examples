using System.Windows.Forms;

namespace FormTemple
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resouFormTemplees being used.
        /// </summary>
        /// <param name="disposing">true if managed resouFormTemplees should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        public class DoubleBufferListView : System.Windows.Forms.ListView
        {
            public DoubleBufferListView()
            {
                SetStyle(ControlStyles.DoubleBuffer |
                  ControlStyles.OptimizedDoubleBuffer |
                  ControlStyles.AllPaintingInWmPaint, true);
                UpdateStyles();
            }
        }

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lv_ld_b_me = new FormTemple.MainForm.DoubleBufferListView();
            this.lv_ld_b = new FormTemple.MainForm.DoubleBufferListView();
            this.lv_ld_b_jd = new FormTemple.MainForm.DoubleBufferListView();
            this.lv_ld_s_jd = new FormTemple.MainForm.DoubleBufferListView();
            this.lv_ld_s_me = new FormTemple.MainForm.DoubleBufferListView();
            this.lv_ld_s = new FormTemple.MainForm.DoubleBufferListView();
            this.tb_ld_v = new System.Windows.Forms.TextBox();
            this.btn_ld_s = new System.Windows.Forms.Button();
            this.btn_ld_b = new System.Windows.Forms.Button();
            this.nud_ld_p = new System.Windows.Forms.NumericUpDown();
            this.ld_ks = new System.Windows.Forms.Button();
            this.ld_tz = new System.Windows.Forms.Button();
            this.Log_I = new System.Windows.Forms.TextBox();
            this.Log_E = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cb_klinec_wbf = new System.Windows.Forms.CheckBox();
            this.ld_info = new System.Windows.Forms.Label();
            this.Wbf_info = new System.Windows.Forms.Label();
            this.cb_klinec = new System.Windows.Forms.CheckBox();
            this.wbf_ks = new System.Windows.Forms.Button();
            this.tb_gd = new System.Windows.Forms.TextBox();
            this.wbf_tz = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lv_wbf_b_jd = new FormTemple.MainForm.DoubleBufferListView();
            this.lv_wbf_b = new FormTemple.MainForm.DoubleBufferListView();
            this.lv_wbf_b_me = new FormTemple.MainForm.DoubleBufferListView();
            this.lv_wbf_s_jd = new FormTemple.MainForm.DoubleBufferListView();
            this.lv_wbf_s = new FormTemple.MainForm.DoubleBufferListView();
            this.lv_wbf_s_me = new FormTemple.MainForm.DoubleBufferListView();
            this.nud_wbf_p = new System.Windows.Forms.NumericUpDown();
            this.btn_wbf_b = new System.Windows.Forms.Button();
            this.btn_wbf_s = new System.Windows.Forms.Button();
            this.tb_wbf_v = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tb_qjkz_rlimit_wbf = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tb_qjkz_delay_wbf = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tb_qjkz_minV_wbf = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tb_qjkz_maxV_wbf = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.tb_qjkz_minStep_wbf = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.tb_qjkz_maxStep_wbf = new System.Windows.Forms.TextBox();
            this.tb_qjkz_b1v_wbf = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.tb_qjkz_b1p_wbf = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.tb_qjkz_s1v_wbf = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.tb_qjkz_s1p_wbf = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.cb_qjkz_wbf = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tb_qjkz_rlimit = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tb_qjkz_delay = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tb_qjkz_minV = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_qjkz_maxV = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_qjkz_minStep = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_qjkz_maxStep = new System.Windows.Forms.TextBox();
            this.tb_qjkz_b1v = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_qjkz_b1p = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_qjkz_s1v = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_qjkz_s1p = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_qjkz = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_dqtimeout = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_dqdev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_dz_wtlp_limit = new System.Windows.Forms.TextBox();
            this.tb_dz_wtzp_limit = new System.Windows.Forms.TextBox();
            this.cb_dz_wtlp = new System.Windows.Forms.CheckBox();
            this.cb_dz_wtzp = new System.Windows.Forms.CheckBox();
            this.tb_ldbl_time = new System.Windows.Forms.TextBox();
            this.tb_ldbl_dev = new System.Windows.Forms.TextBox();
            this.tb_ldbz_dev = new System.Windows.Forms.TextBox();
            this.tb_ldbz_time = new System.Windows.Forms.TextBox();
            this.cb_tj_ldbl = new System.Windows.Forms.CheckBox();
            this.cb_tj_ldbz = new System.Windows.Forms.CheckBox();
            this.tb_dqdelay = new System.Windows.Forms.TextBox();
            this.btn_dqtz = new System.Windows.Forms.Button();
            this.btn_dqks = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ld_p)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_wbf_p)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lv_ld_b_me);
            this.groupBox1.Controls.Add(this.lv_ld_b);
            this.groupBox1.Controls.Add(this.lv_ld_b_jd);
            this.groupBox1.Controls.Add(this.lv_ld_s_jd);
            this.groupBox1.Controls.Add(this.lv_ld_s_me);
            this.groupBox1.Controls.Add(this.lv_ld_s);
            this.groupBox1.Controls.Add(this.tb_ld_v);
            this.groupBox1.Controls.Add(this.btn_ld_s);
            this.groupBox1.Controls.Add(this.btn_ld_b);
            this.groupBox1.Controls.Add(this.nud_ld_p);
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 745);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "雷盾盘口";
            // 
            // lv_ld_b_me
            // 
            this.lv_ld_b_me.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lv_ld_b_me.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(175)))), ((int)(((byte)(145)))));
            this.lv_ld_b_me.FullRowSelect = true;
            this.lv_ld_b_me.GridLines = true;
            this.lv_ld_b_me.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lv_ld_b_me.HideSelection = false;
            this.lv_ld_b_me.Location = new System.Drawing.Point(414, 408);
            this.lv_ld_b_me.MultiSelect = false;
            this.lv_ld_b_me.Name = "lv_ld_b_me";
            this.lv_ld_b_me.Scrollable = false;
            this.lv_ld_b_me.Size = new System.Drawing.Size(115, 329);
            this.lv_ld_b_me.TabIndex = 8;
            this.lv_ld_b_me.UseCompatibleStateImageBehavior = false;
            this.lv_ld_b_me.View = System.Windows.Forms.View.Details;
            this.lv_ld_b_me.DoubleClick += new System.EventHandler(this.lv_ld_b_me_DoubleClick);
            // 
            // lv_ld_b
            // 
            this.lv_ld_b.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lv_ld_b.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(175)))), ((int)(((byte)(145)))));
            this.lv_ld_b.FullRowSelect = true;
            this.lv_ld_b.GridLines = true;
            this.lv_ld_b.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lv_ld_b.HideSelection = false;
            this.lv_ld_b.Location = new System.Drawing.Point(160, 408);
            this.lv_ld_b.MultiSelect = false;
            this.lv_ld_b.Name = "lv_ld_b";
            this.lv_ld_b.Scrollable = false;
            this.lv_ld_b.Size = new System.Drawing.Size(250, 329);
            this.lv_ld_b.TabIndex = 7;
            this.lv_ld_b.UseCompatibleStateImageBehavior = false;
            this.lv_ld_b.View = System.Windows.Forms.View.Details;
            this.lv_ld_b.Click += new System.EventHandler(this.lv_ld_b_SelectedIndexChanged);
            // 
            // lv_ld_b_jd
            // 
            this.lv_ld_b_jd.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lv_ld_b_jd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(175)))), ((int)(((byte)(145)))));
            this.lv_ld_b_jd.FullRowSelect = true;
            this.lv_ld_b_jd.GridLines = true;
            this.lv_ld_b_jd.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lv_ld_b_jd.HideSelection = false;
            this.lv_ld_b_jd.Location = new System.Drawing.Point(6, 408);
            this.lv_ld_b_jd.MultiSelect = false;
            this.lv_ld_b_jd.Name = "lv_ld_b_jd";
            this.lv_ld_b_jd.Scrollable = false;
            this.lv_ld_b_jd.Size = new System.Drawing.Size(150, 329);
            this.lv_ld_b_jd.TabIndex = 6;
            this.lv_ld_b_jd.UseCompatibleStateImageBehavior = false;
            this.lv_ld_b_jd.View = System.Windows.Forms.View.Details;
            // 
            // lv_ld_s_jd
            // 
            this.lv_ld_s_jd.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lv_ld_s_jd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.lv_ld_s_jd.FullRowSelect = true;
            this.lv_ld_s_jd.GridLines = true;
            this.lv_ld_s_jd.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lv_ld_s_jd.HideSelection = false;
            this.lv_ld_s_jd.Location = new System.Drawing.Point(7, 22);
            this.lv_ld_s_jd.MultiSelect = false;
            this.lv_ld_s_jd.Name = "lv_ld_s_jd";
            this.lv_ld_s_jd.Scrollable = false;
            this.lv_ld_s_jd.Size = new System.Drawing.Size(150, 329);
            this.lv_ld_s_jd.TabIndex = 5;
            this.lv_ld_s_jd.UseCompatibleStateImageBehavior = false;
            this.lv_ld_s_jd.View = System.Windows.Forms.View.Details;
            // 
            // lv_ld_s_me
            // 
            this.lv_ld_s_me.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lv_ld_s_me.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.lv_ld_s_me.FullRowSelect = true;
            this.lv_ld_s_me.GridLines = true;
            this.lv_ld_s_me.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lv_ld_s_me.HideSelection = false;
            this.lv_ld_s_me.Location = new System.Drawing.Point(415, 22);
            this.lv_ld_s_me.MultiSelect = false;
            this.lv_ld_s_me.Name = "lv_ld_s_me";
            this.lv_ld_s_me.Scrollable = false;
            this.lv_ld_s_me.Size = new System.Drawing.Size(115, 329);
            this.lv_ld_s_me.TabIndex = 4;
            this.lv_ld_s_me.UseCompatibleStateImageBehavior = false;
            this.lv_ld_s_me.View = System.Windows.Forms.View.Details;
            this.lv_ld_s_me.DoubleClick += new System.EventHandler(this.lv_ld_s_me_DoubleClick);
            // 
            // lv_ld_s
            // 
            this.lv_ld_s.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lv_ld_s.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.lv_ld_s.FullRowSelect = true;
            this.lv_ld_s.GridLines = true;
            this.lv_ld_s.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lv_ld_s.HideSelection = false;
            this.lv_ld_s.Location = new System.Drawing.Point(161, 22);
            this.lv_ld_s.MultiSelect = false;
            this.lv_ld_s.Name = "lv_ld_s";
            this.lv_ld_s.Scrollable = false;
            this.lv_ld_s.Size = new System.Drawing.Size(250, 329);
            this.lv_ld_s.TabIndex = 4;
            this.lv_ld_s.UseCompatibleStateImageBehavior = false;
            this.lv_ld_s.View = System.Windows.Forms.View.Details;
            this.lv_ld_s.Click += new System.EventHandler(this.lv_ld_s_SelectedIndexChanged);
            // 
            // tb_ld_v
            // 
            this.tb_ld_v.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_ld_v.Location = new System.Drawing.Point(310, 367);
            this.tb_ld_v.Name = "tb_ld_v";
            this.tb_ld_v.Size = new System.Drawing.Size(100, 28);
            this.tb_ld_v.TabIndex = 3;
            // 
            // btn_ld_s
            // 
            this.btn_ld_s.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ld_s.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.btn_ld_s.Location = new System.Drawing.Point(86, 367);
            this.btn_ld_s.Name = "btn_ld_s";
            this.btn_ld_s.Size = new System.Drawing.Size(70, 28);
            this.btn_ld_s.TabIndex = 2;
            this.btn_ld_s.Text = "卖";
            this.btn_ld_s.UseVisualStyleBackColor = true;
            this.btn_ld_s.Click += new System.EventHandler(this.btn_ld_s_Click);
            // 
            // btn_ld_b
            // 
            this.btn_ld_b.BackColor = System.Drawing.Color.Transparent;
            this.btn_ld_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ld_b.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(175)))), ((int)(((byte)(145)))));
            this.btn_ld_b.Location = new System.Drawing.Point(443, 367);
            this.btn_ld_b.Name = "btn_ld_b";
            this.btn_ld_b.Size = new System.Drawing.Size(70, 28);
            this.btn_ld_b.TabIndex = 2;
            this.btn_ld_b.Text = "买";
            this.btn_ld_b.UseVisualStyleBackColor = false;
            this.btn_ld_b.Click += new System.EventHandler(this.btn_ld_b_Click);
            // 
            // nud_ld_p
            // 
            this.nud_ld_p.DecimalPlaces = 4;
            this.nud_ld_p.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nud_ld_p.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.nud_ld_p.Location = new System.Drawing.Point(162, 367);
            this.nud_ld_p.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nud_ld_p.Name = "nud_ld_p";
            this.nud_ld_p.Size = new System.Drawing.Size(110, 28);
            this.nud_ld_p.TabIndex = 1;
            this.nud_ld_p.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nud_ld_p.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // ld_ks
            // 
            this.ld_ks.Location = new System.Drawing.Point(475, 754);
            this.ld_ks.Name = "ld_ks";
            this.ld_ks.Size = new System.Drawing.Size(65, 33);
            this.ld_ks.TabIndex = 2;
            this.ld_ks.Text = "刷新";
            this.ld_ks.UseVisualStyleBackColor = true;
            this.ld_ks.Click += new System.EventHandler(this.ld_ks_Click);
            // 
            // ld_tz
            // 
            this.ld_tz.Enabled = false;
            this.ld_tz.Location = new System.Drawing.Point(5, 754);
            this.ld_tz.Name = "ld_tz";
            this.ld_tz.Size = new System.Drawing.Size(65, 33);
            this.ld_tz.TabIndex = 2;
            this.ld_tz.Text = "停止";
            this.ld_tz.UseVisualStyleBackColor = true;
            this.ld_tz.Click += new System.EventHandler(this.ld_tz_Click);
            // 
            // Log_I
            // 
            this.Log_I.Location = new System.Drawing.Point(5, 3);
            this.Log_I.Multiline = true;
            this.Log_I.Name = "Log_I";
            this.Log_I.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Log_I.Size = new System.Drawing.Size(669, 865);
            this.Log_I.TabIndex = 3;
            // 
            // Log_E
            // 
            this.Log_E.Location = new System.Drawing.Point(680, 3);
            this.Log_E.Multiline = true;
            this.Log_E.Name = "Log_E";
            this.Log_E.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Log_E.Size = new System.Drawing.Size(437, 865);
            this.Log_E.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1128, 901);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cb_klinec_wbf);
            this.tabPage1.Controls.Add(this.ld_info);
            this.tabPage1.Controls.Add(this.Wbf_info);
            this.tabPage1.Controls.Add(this.cb_klinec);
            this.tabPage1.Controls.Add(this.wbf_ks);
            this.tabPage1.Controls.Add(this.tb_gd);
            this.tabPage1.Controls.Add(this.wbf_tz);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.ld_ks);
            this.tabPage1.Controls.Add(this.ld_tz);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1120, 871);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "操作";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cb_klinec_wbf
            // 
            this.cb_klinec_wbf.AutoSize = true;
            this.cb_klinec_wbf.Location = new System.Drawing.Point(755, 760);
            this.cb_klinec_wbf.Name = "cb_klinec_wbf";
            this.cb_klinec_wbf.Size = new System.Drawing.Size(123, 21);
            this.cb_klinec_wbf.TabIndex = 6;
            this.cb_klinec_wbf.Text = "瓦特无量绿线检查";
            this.cb_klinec_wbf.UseVisualStyleBackColor = true;
            this.cb_klinec_wbf.CheckedChanged += new System.EventHandler(this.cb_klinec_wbf_CheckedChanged);
            // 
            // ld_info
            // 
            this.ld_info.AutoSize = true;
            this.ld_info.Location = new System.Drawing.Point(12, 825);
            this.ld_info.Name = "ld_info";
            this.ld_info.Size = new System.Drawing.Size(39, 17);
            this.ld_info.TabIndex = 1;
            this.ld_info.Text = "   LD ";
            // 
            // Wbf_info
            // 
            this.Wbf_info.AutoSize = true;
            this.Wbf_info.Location = new System.Drawing.Point(12, 846);
            this.Wbf_info.Name = "Wbf_info";
            this.Wbf_info.Size = new System.Drawing.Size(38, 17);
            this.Wbf_info.TabIndex = 1;
            this.Wbf_info.Text = "WBF ";
            // 
            // cb_klinec
            // 
            this.cb_klinec.AutoSize = true;
            this.cb_klinec.Location = new System.Drawing.Point(222, 760);
            this.cb_klinec.Name = "cb_klinec";
            this.cb_klinec.Size = new System.Drawing.Size(123, 21);
            this.cb_klinec.TabIndex = 6;
            this.cb_klinec.Text = "雷盾无量绿线检查";
            this.cb_klinec.UseVisualStyleBackColor = true;
            this.cb_klinec.CheckedChanged += new System.EventHandler(this.cb_klinec_CheckedChanged);
            // 
            // wbf_ks
            // 
            this.wbf_ks.Location = new System.Drawing.Point(568, 754);
            this.wbf_ks.Name = "wbf_ks";
            this.wbf_ks.Size = new System.Drawing.Size(65, 33);
            this.wbf_ks.TabIndex = 2;
            this.wbf_ks.Text = "刷新";
            this.wbf_ks.UseVisualStyleBackColor = true;
            this.wbf_ks.Click += new System.EventHandler(this.wbf_ks_Click);
            // 
            // tb_gd
            // 
            this.tb_gd.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_gd.Location = new System.Drawing.Point(668, 793);
            this.tb_gd.Multiline = true;
            this.tb_gd.Name = "tb_gd";
            this.tb_gd.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_gd.Size = new System.Drawing.Size(435, 70);
            this.tb_gd.TabIndex = 5;
            // 
            // wbf_tz
            // 
            this.wbf_tz.Enabled = false;
            this.wbf_tz.Location = new System.Drawing.Point(1038, 754);
            this.wbf_tz.Name = "wbf_tz";
            this.wbf_tz.Size = new System.Drawing.Size(65, 33);
            this.wbf_tz.TabIndex = 2;
            this.wbf_tz.Text = "停止";
            this.wbf_tz.UseVisualStyleBackColor = true;
            this.wbf_tz.Click += new System.EventHandler(this.wbf_tz_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lv_wbf_b_jd);
            this.groupBox2.Controls.Add(this.lv_wbf_b);
            this.groupBox2.Controls.Add(this.lv_wbf_b_me);
            this.groupBox2.Controls.Add(this.lv_wbf_s_jd);
            this.groupBox2.Controls.Add(this.lv_wbf_s);
            this.groupBox2.Controls.Add(this.lv_wbf_s_me);
            this.groupBox2.Controls.Add(this.nud_wbf_p);
            this.groupBox2.Controls.Add(this.btn_wbf_b);
            this.groupBox2.Controls.Add(this.btn_wbf_s);
            this.groupBox2.Controls.Add(this.tb_wbf_v);
            this.groupBox2.Location = new System.Drawing.Point(568, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(535, 745);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "瓦特盘口";
            // 
            // lv_wbf_b_jd
            // 
            this.lv_wbf_b_jd.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lv_wbf_b_jd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(175)))), ((int)(((byte)(145)))));
            this.lv_wbf_b_jd.FullRowSelect = true;
            this.lv_wbf_b_jd.GridLines = true;
            this.lv_wbf_b_jd.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lv_wbf_b_jd.HideSelection = false;
            this.lv_wbf_b_jd.Location = new System.Drawing.Point(379, 410);
            this.lv_wbf_b_jd.MultiSelect = false;
            this.lv_wbf_b_jd.Name = "lv_wbf_b_jd";
            this.lv_wbf_b_jd.Scrollable = false;
            this.lv_wbf_b_jd.Size = new System.Drawing.Size(150, 329);
            this.lv_wbf_b_jd.TabIndex = 8;
            this.lv_wbf_b_jd.UseCompatibleStateImageBehavior = false;
            this.lv_wbf_b_jd.View = System.Windows.Forms.View.Details;
            // 
            // lv_wbf_b
            // 
            this.lv_wbf_b.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lv_wbf_b.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(175)))), ((int)(((byte)(145)))));
            this.lv_wbf_b.FullRowSelect = true;
            this.lv_wbf_b.GridLines = true;
            this.lv_wbf_b.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lv_wbf_b.HideSelection = false;
            this.lv_wbf_b.Location = new System.Drawing.Point(125, 410);
            this.lv_wbf_b.MultiSelect = false;
            this.lv_wbf_b.Name = "lv_wbf_b";
            this.lv_wbf_b.Scrollable = false;
            this.lv_wbf_b.Size = new System.Drawing.Size(250, 329);
            this.lv_wbf_b.TabIndex = 7;
            this.lv_wbf_b.UseCompatibleStateImageBehavior = false;
            this.lv_wbf_b.View = System.Windows.Forms.View.Details;
            this.lv_wbf_b.Click += new System.EventHandler(this.lv_wbf_b_SelectedIndexChanged);
            // 
            // lv_wbf_b_me
            // 
            this.lv_wbf_b_me.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lv_wbf_b_me.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(175)))), ((int)(((byte)(145)))));
            this.lv_wbf_b_me.FullRowSelect = true;
            this.lv_wbf_b_me.GridLines = true;
            this.lv_wbf_b_me.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lv_wbf_b_me.HideSelection = false;
            this.lv_wbf_b_me.Location = new System.Drawing.Point(6, 410);
            this.lv_wbf_b_me.MultiSelect = false;
            this.lv_wbf_b_me.Name = "lv_wbf_b_me";
            this.lv_wbf_b_me.Scrollable = false;
            this.lv_wbf_b_me.Size = new System.Drawing.Size(115, 329);
            this.lv_wbf_b_me.TabIndex = 6;
            this.lv_wbf_b_me.UseCompatibleStateImageBehavior = false;
            this.lv_wbf_b_me.View = System.Windows.Forms.View.Details;
            this.lv_wbf_b_me.DoubleClick += new System.EventHandler(this.lv_wbf_b_me_DoubleClick);
            // 
            // lv_wbf_s_jd
            // 
            this.lv_wbf_s_jd.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lv_wbf_s_jd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.lv_wbf_s_jd.FullRowSelect = true;
            this.lv_wbf_s_jd.GridLines = true;
            this.lv_wbf_s_jd.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lv_wbf_s_jd.HideSelection = false;
            this.lv_wbf_s_jd.Location = new System.Drawing.Point(379, 22);
            this.lv_wbf_s_jd.MultiSelect = false;
            this.lv_wbf_s_jd.Name = "lv_wbf_s_jd";
            this.lv_wbf_s_jd.Scrollable = false;
            this.lv_wbf_s_jd.Size = new System.Drawing.Size(150, 329);
            this.lv_wbf_s_jd.TabIndex = 8;
            this.lv_wbf_s_jd.UseCompatibleStateImageBehavior = false;
            this.lv_wbf_s_jd.View = System.Windows.Forms.View.Details;
            // 
            // lv_wbf_s
            // 
            this.lv_wbf_s.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lv_wbf_s.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.lv_wbf_s.FullRowSelect = true;
            this.lv_wbf_s.GridLines = true;
            this.lv_wbf_s.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lv_wbf_s.HideSelection = false;
            this.lv_wbf_s.Location = new System.Drawing.Point(125, 22);
            this.lv_wbf_s.MultiSelect = false;
            this.lv_wbf_s.Name = "lv_wbf_s";
            this.lv_wbf_s.Scrollable = false;
            this.lv_wbf_s.Size = new System.Drawing.Size(250, 329);
            this.lv_wbf_s.TabIndex = 7;
            this.lv_wbf_s.UseCompatibleStateImageBehavior = false;
            this.lv_wbf_s.View = System.Windows.Forms.View.Details;
            this.lv_wbf_s.Click += new System.EventHandler(this.lv_wbf_s_SelectedIndexChanged);
            // 
            // lv_wbf_s_me
            // 
            this.lv_wbf_s_me.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lv_wbf_s_me.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.lv_wbf_s_me.FullRowSelect = true;
            this.lv_wbf_s_me.GridLines = true;
            this.lv_wbf_s_me.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lv_wbf_s_me.HideSelection = false;
            this.lv_wbf_s_me.Location = new System.Drawing.Point(6, 22);
            this.lv_wbf_s_me.MultiSelect = false;
            this.lv_wbf_s_me.Name = "lv_wbf_s_me";
            this.lv_wbf_s_me.Scrollable = false;
            this.lv_wbf_s_me.Size = new System.Drawing.Size(115, 329);
            this.lv_wbf_s_me.TabIndex = 6;
            this.lv_wbf_s_me.UseCompatibleStateImageBehavior = false;
            this.lv_wbf_s_me.View = System.Windows.Forms.View.Details;
            this.lv_wbf_s_me.DoubleClick += new System.EventHandler(this.lv_wbf_s_me_DoubleClick);
            // 
            // nud_wbf_p
            // 
            this.nud_wbf_p.DecimalPlaces = 4;
            this.nud_wbf_p.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nud_wbf_p.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.nud_wbf_p.Location = new System.Drawing.Point(125, 365);
            this.nud_wbf_p.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nud_wbf_p.Name = "nud_wbf_p";
            this.nud_wbf_p.Size = new System.Drawing.Size(110, 28);
            this.nud_wbf_p.TabIndex = 1;
            // 
            // btn_wbf_b
            // 
            this.btn_wbf_b.BackColor = System.Drawing.Color.Transparent;
            this.btn_wbf_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_wbf_b.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(175)))), ((int)(((byte)(145)))));
            this.btn_wbf_b.Location = new System.Drawing.Point(31, 365);
            this.btn_wbf_b.Name = "btn_wbf_b";
            this.btn_wbf_b.Size = new System.Drawing.Size(70, 28);
            this.btn_wbf_b.TabIndex = 2;
            this.btn_wbf_b.Text = "买";
            this.btn_wbf_b.UseVisualStyleBackColor = false;
            this.btn_wbf_b.Click += new System.EventHandler(this.btn_wbf_b_Click);
            // 
            // btn_wbf_s
            // 
            this.btn_wbf_s.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_wbf_s.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.btn_wbf_s.Location = new System.Drawing.Point(381, 365);
            this.btn_wbf_s.Name = "btn_wbf_s";
            this.btn_wbf_s.Size = new System.Drawing.Size(70, 28);
            this.btn_wbf_s.TabIndex = 2;
            this.btn_wbf_s.Text = "卖";
            this.btn_wbf_s.UseVisualStyleBackColor = true;
            this.btn_wbf_s.Click += new System.EventHandler(this.btn_wbf_s_Click);
            // 
            // tb_wbf_v
            // 
            this.tb_wbf_v.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_wbf_v.Location = new System.Drawing.Point(275, 365);
            this.tb_wbf_v.Name = "tb_wbf_v";
            this.tb_wbf_v.Size = new System.Drawing.Size(100, 28);
            this.tb_wbf_v.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Log_I);
            this.tabPage2.Controls.Add(this.Log_E);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1120, 871);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "日志";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.tb_dqtimeout);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.tb_dqdev);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.tb_dqdelay);
            this.tabPage3.Controls.Add(this.btn_dqtz);
            this.tabPage3.Controls.Add(this.btn_dqks);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1120, 871);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "区间对齐";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.tb_qjkz_rlimit_wbf);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.tb_qjkz_delay_wbf);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.tb_qjkz_minV_wbf);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Controls.Add(this.tb_qjkz_maxV_wbf);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.tb_qjkz_minStep_wbf);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Controls.Add(this.tb_qjkz_maxStep_wbf);
            this.groupBox5.Controls.Add(this.tb_qjkz_b1v_wbf);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.tb_qjkz_b1p_wbf);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.tb_qjkz_s1v_wbf);
            this.groupBox5.Controls.Add(this.label28);
            this.groupBox5.Controls.Add(this.tb_qjkz_s1p_wbf);
            this.groupBox5.Controls.Add(this.label29);
            this.groupBox5.Controls.Add(this.cb_qjkz_wbf);
            this.groupBox5.Enabled = false;
            this.groupBox5.Location = new System.Drawing.Point(39, 538);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(591, 151);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "瓦特区间控制";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(263, 34);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(75, 17);
            this.label20.TabIndex = 1;
            this.label20.Text = "RangeLimit:";
            // 
            // tb_qjkz_rlimit_wbf
            // 
            this.tb_qjkz_rlimit_wbf.Location = new System.Drawing.Point(341, 31);
            this.tb_qjkz_rlimit_wbf.Name = "tb_qjkz_rlimit_wbf";
            this.tb_qjkz_rlimit_wbf.Size = new System.Drawing.Size(63, 23);
            this.tb_qjkz_rlimit_wbf.TabIndex = 2;
            this.tb_qjkz_rlimit_wbf.Text = "0.003";
            this.tb_qjkz_rlimit_wbf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(142, 34);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(43, 17);
            this.label21.TabIndex = 1;
            this.label21.Text = "Delay:";
            // 
            // tb_qjkz_delay_wbf
            // 
            this.tb_qjkz_delay_wbf.Location = new System.Drawing.Point(194, 31);
            this.tb_qjkz_delay_wbf.Name = "tb_qjkz_delay_wbf";
            this.tb_qjkz_delay_wbf.Size = new System.Drawing.Size(63, 23);
            this.tb_qjkz_delay_wbf.TabIndex = 2;
            this.tb_qjkz_delay_wbf.Text = "6000";
            this.tb_qjkz_delay_wbf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(297, 75);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 17);
            this.label22.TabIndex = 1;
            this.label22.Text = "MinV:";
            // 
            // tb_qjkz_minV_wbf
            // 
            this.tb_qjkz_minV_wbf.Location = new System.Drawing.Point(341, 72);
            this.tb_qjkz_minV_wbf.Name = "tb_qjkz_minV_wbf";
            this.tb_qjkz_minV_wbf.Size = new System.Drawing.Size(63, 23);
            this.tb_qjkz_minV_wbf.TabIndex = 2;
            this.tb_qjkz_minV_wbf.Text = "30";
            this.tb_qjkz_minV_wbf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(444, 75);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(44, 17);
            this.label23.TabIndex = 1;
            this.label23.Text = "MaxV:";
            // 
            // tb_qjkz_maxV_wbf
            // 
            this.tb_qjkz_maxV_wbf.Location = new System.Drawing.Point(494, 72);
            this.tb_qjkz_maxV_wbf.Name = "tb_qjkz_maxV_wbf";
            this.tb_qjkz_maxV_wbf.Size = new System.Drawing.Size(63, 23);
            this.tb_qjkz_maxV_wbf.TabIndex = 2;
            this.tb_qjkz_maxV_wbf.Text = "150";
            this.tb_qjkz_maxV_wbf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(279, 117);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(59, 17);
            this.label24.TabIndex = 1;
            this.label24.Text = "MinStep:";
            // 
            // tb_qjkz_minStep_wbf
            // 
            this.tb_qjkz_minStep_wbf.Location = new System.Drawing.Point(341, 114);
            this.tb_qjkz_minStep_wbf.Name = "tb_qjkz_minStep_wbf";
            this.tb_qjkz_minStep_wbf.Size = new System.Drawing.Size(63, 23);
            this.tb_qjkz_minStep_wbf.TabIndex = 2;
            this.tb_qjkz_minStep_wbf.Text = "0.0001";
            this.tb_qjkz_minStep_wbf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(426, 117);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(62, 17);
            this.label25.TabIndex = 1;
            this.label25.Text = "MaxSetp:";
            // 
            // tb_qjkz_maxStep_wbf
            // 
            this.tb_qjkz_maxStep_wbf.Location = new System.Drawing.Point(494, 114);
            this.tb_qjkz_maxStep_wbf.Name = "tb_qjkz_maxStep_wbf";
            this.tb_qjkz_maxStep_wbf.Size = new System.Drawing.Size(63, 23);
            this.tb_qjkz_maxStep_wbf.TabIndex = 2;
            this.tb_qjkz_maxStep_wbf.Text = "0.0002";
            this.tb_qjkz_maxStep_wbf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_qjkz_b1v_wbf
            // 
            this.tb_qjkz_b1v_wbf.Location = new System.Drawing.Point(194, 114);
            this.tb_qjkz_b1v_wbf.Name = "tb_qjkz_b1v_wbf";
            this.tb_qjkz_b1v_wbf.Size = new System.Drawing.Size(63, 23);
            this.tb_qjkz_b1v_wbf.TabIndex = 2;
            this.tb_qjkz_b1v_wbf.Text = "500";
            this.tb_qjkz_b1v_wbf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(151, 117);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(34, 17);
            this.label26.TabIndex = 1;
            this.label26.Text = "B1V:";
            // 
            // tb_qjkz_b1p_wbf
            // 
            this.tb_qjkz_b1p_wbf.Location = new System.Drawing.Point(69, 114);
            this.tb_qjkz_b1p_wbf.Name = "tb_qjkz_b1p_wbf";
            this.tb_qjkz_b1p_wbf.Size = new System.Drawing.Size(63, 23);
            this.tb_qjkz_b1p_wbf.TabIndex = 2;
            this.tb_qjkz_b1p_wbf.Text = "0.4";
            this.tb_qjkz_b1p_wbf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(28, 117);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(33, 17);
            this.label27.TabIndex = 1;
            this.label27.Text = "B1P:";
            // 
            // tb_qjkz_s1v_wbf
            // 
            this.tb_qjkz_s1v_wbf.Location = new System.Drawing.Point(194, 72);
            this.tb_qjkz_s1v_wbf.Name = "tb_qjkz_s1v_wbf";
            this.tb_qjkz_s1v_wbf.Size = new System.Drawing.Size(63, 23);
            this.tb_qjkz_s1v_wbf.TabIndex = 2;
            this.tb_qjkz_s1v_wbf.Text = "500";
            this.tb_qjkz_s1v_wbf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(152, 75);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(33, 17);
            this.label28.TabIndex = 1;
            this.label28.Text = "S1V:";
            // 
            // tb_qjkz_s1p_wbf
            // 
            this.tb_qjkz_s1p_wbf.Location = new System.Drawing.Point(69, 72);
            this.tb_qjkz_s1p_wbf.Name = "tb_qjkz_s1p_wbf";
            this.tb_qjkz_s1p_wbf.Size = new System.Drawing.Size(63, 23);
            this.tb_qjkz_s1p_wbf.TabIndex = 2;
            this.tb_qjkz_s1p_wbf.Text = "0.6";
            this.tb_qjkz_s1p_wbf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(28, 75);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(32, 17);
            this.label29.TabIndex = 1;
            this.label29.Text = "S1P:";
            // 
            // cb_qjkz_wbf
            // 
            this.cb_qjkz_wbf.AutoSize = true;
            this.cb_qjkz_wbf.Location = new System.Drawing.Point(28, 32);
            this.cb_qjkz_wbf.Name = "cb_qjkz_wbf";
            this.cb_qjkz_wbf.Size = new System.Drawing.Size(75, 21);
            this.cb_qjkz_wbf.TabIndex = 0;
            this.cb_qjkz_wbf.Text = "区间控制";
            this.cb_qjkz_wbf.UseVisualStyleBackColor = true;
            this.cb_qjkz_wbf.CheckedChanged += new System.EventHandler(this.cb_qjkz_wbf_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.tb_qjkz_rlimit);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.tb_qjkz_delay);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.tb_qjkz_minV);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.tb_qjkz_maxV);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.tb_qjkz_minStep);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.tb_qjkz_maxStep);
            this.groupBox4.Controls.Add(this.tb_qjkz_b1v);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.tb_qjkz_b1p);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.tb_qjkz_s1v);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.tb_qjkz_s1p);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.cb_qjkz);
            this.groupBox4.Enabled = false;
            this.groupBox4.Location = new System.Drawing.Point(39, 707);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(591, 151);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "雷盾区间控制";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(263, 34);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 17);
            this.label19.TabIndex = 1;
            this.label19.Text = "RangeLimit:";
            // 
            // tb_qjkz_rlimit
            // 
            this.tb_qjkz_rlimit.Location = new System.Drawing.Point(341, 31);
            this.tb_qjkz_rlimit.Name = "tb_qjkz_rlimit";
            this.tb_qjkz_rlimit.Size = new System.Drawing.Size(63, 23);
            this.tb_qjkz_rlimit.TabIndex = 2;
            this.tb_qjkz_rlimit.Text = "0.002";
            this.tb_qjkz_rlimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(142, 34);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 17);
            this.label18.TabIndex = 1;
            this.label18.Text = "Delay:";
            // 
            // tb_qjkz_delay
            // 
            this.tb_qjkz_delay.Location = new System.Drawing.Point(194, 31);
            this.tb_qjkz_delay.Name = "tb_qjkz_delay";
            this.tb_qjkz_delay.Size = new System.Drawing.Size(63, 23);
            this.tb_qjkz_delay.TabIndex = 2;
            this.tb_qjkz_delay.Text = "3000";
            this.tb_qjkz_delay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(297, 75);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 17);
            this.label17.TabIndex = 1;
            this.label17.Text = "MinV:";
            // 
            // tb_qjkz_minV
            // 
            this.tb_qjkz_minV.Location = new System.Drawing.Point(341, 72);
            this.tb_qjkz_minV.Name = "tb_qjkz_minV";
            this.tb_qjkz_minV.Size = new System.Drawing.Size(63, 23);
            this.tb_qjkz_minV.TabIndex = 2;
            this.tb_qjkz_minV.Text = "30";
            this.tb_qjkz_minV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(444, 75);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 17);
            this.label16.TabIndex = 1;
            this.label16.Text = "MaxV:";
            // 
            // tb_qjkz_maxV
            // 
            this.tb_qjkz_maxV.Location = new System.Drawing.Point(494, 72);
            this.tb_qjkz_maxV.Name = "tb_qjkz_maxV";
            this.tb_qjkz_maxV.Size = new System.Drawing.Size(63, 23);
            this.tb_qjkz_maxV.TabIndex = 2;
            this.tb_qjkz_maxV.Text = "150";
            this.tb_qjkz_maxV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(279, 117);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 17);
            this.label15.TabIndex = 1;
            this.label15.Text = "MinStep:";
            // 
            // tb_qjkz_minStep
            // 
            this.tb_qjkz_minStep.Location = new System.Drawing.Point(341, 114);
            this.tb_qjkz_minStep.Name = "tb_qjkz_minStep";
            this.tb_qjkz_minStep.Size = new System.Drawing.Size(63, 23);
            this.tb_qjkz_minStep.TabIndex = 2;
            this.tb_qjkz_minStep.Text = "0.0001";
            this.tb_qjkz_minStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(426, 117);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 17);
            this.label14.TabIndex = 1;
            this.label14.Text = "MaxSetp:";
            // 
            // tb_qjkz_maxStep
            // 
            this.tb_qjkz_maxStep.Location = new System.Drawing.Point(494, 114);
            this.tb_qjkz_maxStep.Name = "tb_qjkz_maxStep";
            this.tb_qjkz_maxStep.Size = new System.Drawing.Size(63, 23);
            this.tb_qjkz_maxStep.TabIndex = 2;
            this.tb_qjkz_maxStep.Text = "0.0002";
            this.tb_qjkz_maxStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_qjkz_b1v
            // 
            this.tb_qjkz_b1v.Location = new System.Drawing.Point(194, 114);
            this.tb_qjkz_b1v.Name = "tb_qjkz_b1v";
            this.tb_qjkz_b1v.Size = new System.Drawing.Size(63, 23);
            this.tb_qjkz_b1v.TabIndex = 2;
            this.tb_qjkz_b1v.Text = "500";
            this.tb_qjkz_b1v.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(151, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "B1V:";
            // 
            // tb_qjkz_b1p
            // 
            this.tb_qjkz_b1p.Location = new System.Drawing.Point(69, 114);
            this.tb_qjkz_b1p.Name = "tb_qjkz_b1p";
            this.tb_qjkz_b1p.Size = new System.Drawing.Size(63, 23);
            this.tb_qjkz_b1p.TabIndex = 2;
            this.tb_qjkz_b1p.Text = "0.4";
            this.tb_qjkz_b1p.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "B1P:";
            // 
            // tb_qjkz_s1v
            // 
            this.tb_qjkz_s1v.Location = new System.Drawing.Point(194, 72);
            this.tb_qjkz_s1v.Name = "tb_qjkz_s1v";
            this.tb_qjkz_s1v.Size = new System.Drawing.Size(63, 23);
            this.tb_qjkz_s1v.TabIndex = 2;
            this.tb_qjkz_s1v.Text = "500";
            this.tb_qjkz_s1v.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(152, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "S1V:";
            // 
            // tb_qjkz_s1p
            // 
            this.tb_qjkz_s1p.Location = new System.Drawing.Point(69, 72);
            this.tb_qjkz_s1p.Name = "tb_qjkz_s1p";
            this.tb_qjkz_s1p.Size = new System.Drawing.Size(63, 23);
            this.tb_qjkz_s1p.TabIndex = 2;
            this.tb_qjkz_s1p.Text = "0.6";
            this.tb_qjkz_s1p.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "S1P:";
            // 
            // cb_qjkz
            // 
            this.cb_qjkz.AutoSize = true;
            this.cb_qjkz.Location = new System.Drawing.Point(28, 32);
            this.cb_qjkz.Name = "cb_qjkz";
            this.cb_qjkz.Size = new System.Drawing.Size(75, 21);
            this.cb_qjkz.TabIndex = 0;
            this.cb_qjkz.Text = "区间控制";
            this.cb_qjkz.UseVisualStyleBackColor = true;
            this.cb_qjkz.CheckedChanged += new System.EventHandler(this.cb_qjkz_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(497, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "等待超时:";
            // 
            // tb_dqtimeout
            // 
            this.tb_dqtimeout.Location = new System.Drawing.Point(562, 33);
            this.tb_dqtimeout.Name = "tb_dqtimeout";
            this.tb_dqtimeout.Size = new System.Drawing.Size(68, 23);
            this.tb_dqtimeout.TabIndex = 4;
            this.tb_dqtimeout.Text = "30000";
            this.tb_dqtimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "过期:";
            // 
            // tb_dqdev
            // 
            this.tb_dqdev.Location = new System.Drawing.Point(406, 33);
            this.tb_dqdev.Name = "tb_dqdev";
            this.tb_dqdev.Size = new System.Drawing.Size(74, 23);
            this.tb_dqdev.TabIndex = 1;
            this.tb_dqdev.Text = "20000";
            this.tb_dqdev.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "延迟:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tb_dz_wtlp_limit);
            this.groupBox3.Controls.Add(this.tb_dz_wtzp_limit);
            this.groupBox3.Controls.Add(this.cb_dz_wtlp);
            this.groupBox3.Controls.Add(this.cb_dz_wtzp);
            this.groupBox3.Controls.Add(this.tb_ldbl_time);
            this.groupBox3.Controls.Add(this.tb_ldbl_dev);
            this.groupBox3.Controls.Add(this.tb_ldbz_dev);
            this.groupBox3.Controls.Add(this.tb_ldbz_time);
            this.groupBox3.Controls.Add(this.cb_tj_ldbl);
            this.groupBox3.Controls.Add(this.cb_tj_ldbz);
            this.groupBox3.Location = new System.Drawing.Point(39, 83);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(469, 193);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "相对模式-单边操作";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(211, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "限制:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(211, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "限制:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "波动:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "波动:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "过期:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "过期:";
            // 
            // tb_dz_wtlp_limit
            // 
            this.tb_dz_wtlp_limit.Location = new System.Drawing.Point(252, 156);
            this.tb_dz_wtlp_limit.Name = "tb_dz_wtlp_limit";
            this.tb_dz_wtlp_limit.Size = new System.Drawing.Size(68, 23);
            this.tb_dz_wtlp_limit.TabIndex = 2;
            this.tb_dz_wtlp_limit.Text = "500";
            this.tb_dz_wtlp_limit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_dz_wtzp_limit
            // 
            this.tb_dz_wtzp_limit.Location = new System.Drawing.Point(252, 65);
            this.tb_dz_wtzp_limit.Name = "tb_dz_wtzp_limit";
            this.tb_dz_wtzp_limit.Size = new System.Drawing.Size(68, 23);
            this.tb_dz_wtzp_limit.TabIndex = 2;
            this.tb_dz_wtzp_limit.Text = "500";
            this.tb_dz_wtzp_limit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cb_dz_wtlp
            // 
            this.cb_dz_wtlp.AutoSize = true;
            this.cb_dz_wtlp.Enabled = false;
            this.cb_dz_wtlp.Location = new System.Drawing.Point(96, 157);
            this.cb_dz_wtlp.Name = "cb_dz_wtlp";
            this.cb_dz_wtlp.Size = new System.Drawing.Size(104, 21);
            this.cb_dz_wtlp.TabIndex = 3;
            this.cb_dz_wtlp.Text = "动作-瓦特拉盘";
            this.cb_dz_wtlp.UseVisualStyleBackColor = true;
            this.cb_dz_wtlp.CheckedChanged += new System.EventHandler(this.cb_dz_wtlp_CheckedChanged);
            // 
            // cb_dz_wtzp
            // 
            this.cb_dz_wtzp.AutoSize = true;
            this.cb_dz_wtzp.Enabled = false;
            this.cb_dz_wtzp.Location = new System.Drawing.Point(96, 66);
            this.cb_dz_wtzp.Name = "cb_dz_wtzp";
            this.cb_dz_wtzp.Size = new System.Drawing.Size(104, 21);
            this.cb_dz_wtzp.TabIndex = 3;
            this.cb_dz_wtzp.Text = "动作-瓦特砸盘";
            this.cb_dz_wtzp.UseVisualStyleBackColor = true;
            this.cb_dz_wtzp.CheckedChanged += new System.EventHandler(this.cb_dz_wtzp_CheckedChanged);
            // 
            // tb_ldbl_time
            // 
            this.tb_ldbl_time.Location = new System.Drawing.Point(189, 124);
            this.tb_ldbl_time.Name = "tb_ldbl_time";
            this.tb_ldbl_time.Size = new System.Drawing.Size(68, 23);
            this.tb_ldbl_time.TabIndex = 2;
            this.tb_ldbl_time.Text = "20000";
            this.tb_ldbl_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_ldbl_dev
            // 
            this.tb_ldbl_dev.Location = new System.Drawing.Point(326, 124);
            this.tb_ldbl_dev.Name = "tb_ldbl_dev";
            this.tb_ldbl_dev.Size = new System.Drawing.Size(68, 23);
            this.tb_ldbl_dev.TabIndex = 2;
            this.tb_ldbl_dev.Text = "0.005";
            this.tb_ldbl_dev.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_ldbz_dev
            // 
            this.tb_ldbz_dev.Location = new System.Drawing.Point(326, 36);
            this.tb_ldbz_dev.Name = "tb_ldbz_dev";
            this.tb_ldbz_dev.Size = new System.Drawing.Size(68, 23);
            this.tb_ldbz_dev.TabIndex = 2;
            this.tb_ldbz_dev.Text = "0.005";
            this.tb_ldbz_dev.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_ldbz_time
            // 
            this.tb_ldbz_time.Location = new System.Drawing.Point(189, 36);
            this.tb_ldbz_time.Name = "tb_ldbz_time";
            this.tb_ldbz_time.Size = new System.Drawing.Size(68, 23);
            this.tb_ldbz_time.TabIndex = 2;
            this.tb_ldbz_time.Text = "20000";
            this.tb_ldbz_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cb_tj_ldbl
            // 
            this.cb_tj_ldbl.AutoSize = true;
            this.cb_tj_ldbl.Enabled = false;
            this.cb_tj_ldbl.Location = new System.Drawing.Point(28, 125);
            this.cb_tj_ldbl.Name = "cb_tj_ldbl";
            this.cb_tj_ldbl.Size = new System.Drawing.Size(104, 21);
            this.cb_tj_ldbl.TabIndex = 1;
            this.cb_tj_ldbl.Text = "条件-雷盾被拉";
            this.cb_tj_ldbl.UseVisualStyleBackColor = true;
            this.cb_tj_ldbl.CheckedChanged += new System.EventHandler(this.cb_tj_ldbl_CheckedChanged);
            // 
            // cb_tj_ldbz
            // 
            this.cb_tj_ldbz.AutoSize = true;
            this.cb_tj_ldbz.Enabled = false;
            this.cb_tj_ldbz.Location = new System.Drawing.Point(28, 37);
            this.cb_tj_ldbz.Name = "cb_tj_ldbz";
            this.cb_tj_ldbz.Size = new System.Drawing.Size(104, 21);
            this.cb_tj_ldbz.TabIndex = 0;
            this.cb_tj_ldbz.Text = "条件-雷盾被砸";
            this.cb_tj_ldbz.UseVisualStyleBackColor = true;
            this.cb_tj_ldbz.CheckedChanged += new System.EventHandler(this.cb_tj_ldbz_CheckedChanged);
            // 
            // tb_dqdelay
            // 
            this.tb_dqdelay.Location = new System.Drawing.Point(269, 33);
            this.tb_dqdelay.Name = "tb_dqdelay";
            this.tb_dqdelay.Size = new System.Drawing.Size(74, 23);
            this.tb_dqdelay.TabIndex = 1;
            this.tb_dqdelay.Text = "2000";
            this.tb_dqdelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_dqtz
            // 
            this.btn_dqtz.Enabled = false;
            this.btn_dqtz.Location = new System.Drawing.Point(135, 24);
            this.btn_dqtz.Name = "btn_dqtz";
            this.btn_dqtz.Size = new System.Drawing.Size(74, 40);
            this.btn_dqtz.TabIndex = 0;
            this.btn_dqtz.Text = "停止";
            this.btn_dqtz.UseVisualStyleBackColor = true;
            this.btn_dqtz.Click += new System.EventHandler(this.btn_dqtz_Click);
            // 
            // btn_dqks
            // 
            this.btn_dqks.Location = new System.Drawing.Point(39, 24);
            this.btn_dqks.Name = "btn_dqks";
            this.btn_dqks.Size = new System.Drawing.Size(74, 40);
            this.btn_dqks.TabIndex = 0;
            this.btn_dqks.Text = "开始";
            this.btn_dqks.UseVisualStyleBackColor = true;
            this.btn_dqks.Click += new System.EventHandler(this.btn_dqks_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Location = new System.Drawing.Point(39, 369);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(591, 148);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "瓦特区间控制-单侧";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 909);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "区间控制";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ld_p)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_wbf_p)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ld_ks;
        private System.Windows.Forms.Button ld_tz;
        private System.Windows.Forms.TextBox Log_I;
        private System.Windows.Forms.TextBox Log_E;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox2;
        private Button wbf_ks;
        private Button wbf_tz;
        private NumericUpDown nud_ld_p;
        private Button btn_ld_b;
        private TextBox tb_ld_v;
        private Button btn_ld_s;
        private NumericUpDown nud_wbf_p;
        private Button btn_wbf_b;
        private Button btn_wbf_s;
        private TextBox tb_wbf_v;
        private TextBox tb_gd;
        private CheckBox cb_klinec;
        private DoubleBufferListView lv_ld_s;
        private DoubleBufferListView lv_ld_s_me;
        private DoubleBufferListView lv_ld_s_jd;
        private DoubleBufferListView lv_ld_b_jd;
        private DoubleBufferListView lv_ld_b_me;
        private DoubleBufferListView lv_ld_b;
        private DoubleBufferListView lv_wbf_b_jd;
        private DoubleBufferListView lv_wbf_b;
        private DoubleBufferListView lv_wbf_b_me;
        private DoubleBufferListView lv_wbf_s_jd;
        private DoubleBufferListView lv_wbf_s;
        private DoubleBufferListView lv_wbf_s_me;
        private TabPage tabPage3;
        private Button btn_dqks;
        private Button btn_dqtz;
        private TextBox tb_dqdelay;
        private GroupBox groupBox3;
        private TextBox tb_ldbl_time;
        private TextBox tb_ldbl_dev;
        private TextBox tb_ldbz_dev;
        private TextBox tb_ldbz_time;
        private CheckBox cb_tj_ldbl;
        private CheckBox cb_tj_ldbz;
        private CheckBox cb_dz_wtlp;
        private CheckBox cb_dz_wtzp;
        private TextBox tb_dz_wtlp_limit;
        private TextBox tb_dz_wtzp_limit;
        private Label label2;
        private TextBox tb_dqdev;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label8;
        private Label label7;
        private Label label9;
        private TextBox tb_dqtimeout;
        private GroupBox groupBox4;
        private CheckBox cb_qjkz;
        private Label label17;
        private TextBox tb_qjkz_minV;
        private Label label16;
        private TextBox tb_qjkz_maxV;
        private Label label15;
        private TextBox tb_qjkz_minStep;
        private Label label14;
        private TextBox tb_qjkz_maxStep;
        private TextBox tb_qjkz_b1v;
        private Label label13;
        private TextBox tb_qjkz_b1p;
        private Label label12;
        private TextBox tb_qjkz_s1v;
        private Label label11;
        private TextBox tb_qjkz_s1p;
        private Label label10;
        private Label label19;
        private TextBox tb_qjkz_rlimit;
        private Label label18;
        private TextBox tb_qjkz_delay;
        private Label ld_info;
        private Label Wbf_info;
        private CheckBox cb_klinec_wbf;
        private GroupBox groupBox5;
        private Label label20;
        private TextBox tb_qjkz_rlimit_wbf;
        private Label label21;
        private TextBox tb_qjkz_delay_wbf;
        private Label label22;
        private TextBox tb_qjkz_minV_wbf;
        private Label label23;
        private TextBox tb_qjkz_maxV_wbf;
        private Label label24;
        private TextBox tb_qjkz_minStep_wbf;
        private Label label25;
        private TextBox tb_qjkz_maxStep_wbf;
        private TextBox tb_qjkz_b1v_wbf;
        private Label label26;
        private TextBox tb_qjkz_b1p_wbf;
        private Label label27;
        private TextBox tb_qjkz_s1v_wbf;
        private Label label28;
        private TextBox tb_qjkz_s1p_wbf;
        private Label label29;
        private CheckBox cb_qjkz_wbf;
        private GroupBox groupBox6;
    }
}

