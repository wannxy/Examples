namespace FetchAllDetail
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
            this.btn_fetch = new System.Windows.Forms.Button();
            this.lb_log = new System.Windows.Forms.Label();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.tb_jsession = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cb_all = new System.Windows.Forms.CheckBox();
            this.lb_progress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_fetch
            // 
            this.btn_fetch.Location = new System.Drawing.Point(12, 235);
            this.btn_fetch.Name = "btn_fetch";
            this.btn_fetch.Size = new System.Drawing.Size(66, 30);
            this.btn_fetch.TabIndex = 0;
            this.btn_fetch.Text = "拉取";
            this.btn_fetch.UseVisualStyleBackColor = true;
            this.btn_fetch.Click += new System.EventHandler(this.btn_fetch_Click);
            // 
            // lb_log
            // 
            this.lb_log.AutoSize = true;
            this.lb_log.Location = new System.Drawing.Point(205, 243);
            this.lb_log.Name = "lb_log";
            this.lb_log.Size = new System.Drawing.Size(56, 15);
            this.lb_log.TabIndex = 1;
            this.lb_log.Text = "明细: 0/0";
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(12, 3);
            this.tb_phone.Multiline = true;
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_phone.Size = new System.Drawing.Size(305, 226);
            this.tb_phone.TabIndex = 2;
            // 
            // tb_jsession
            // 
            this.tb_jsession.Location = new System.Drawing.Point(12, 309);
            this.tb_jsession.Name = "tb_jsession";
            this.tb_jsession.Size = new System.Drawing.Size(305, 23);
            this.tb_jsession.TabIndex = 2;
            this.tb_jsession.Text = "C205C5797F4B0E4D294A7BD3BD2FCCE6";
            this.tb_jsession.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(12, 278);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker.TabIndex = 3;
            // 
            // cb_all
            // 
            this.cb_all.AutoSize = true;
            this.cb_all.Location = new System.Drawing.Point(236, 280);
            this.cb_all.Name = "cb_all";
            this.cb_all.Size = new System.Drawing.Size(78, 19);
            this.cb_all.TabIndex = 4;
            this.cb_all.Text = "全部时间";
            this.cb_all.UseVisualStyleBackColor = true;
            // 
            // lb_progress
            // 
            this.lb_progress.AutoSize = true;
            this.lb_progress.Location = new System.Drawing.Point(104, 243);
            this.lb_progress.Name = "lb_progress";
            this.lb_progress.Size = new System.Drawing.Size(56, 15);
            this.lb_progress.TabIndex = 5;
            this.lb_progress.Text = "账号: 0/0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 346);
            this.Controls.Add(this.lb_progress);
            this.Controls.Add(this.cb_all);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.tb_jsession);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.lb_log);
            this.Controls.Add(this.btn_fetch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "拉取所有资金明细";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_fetch;
        private System.Windows.Forms.Label lb_log;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.TextBox tb_jsession;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.CheckBox cb_all;
        private System.Windows.Forms.Label lb_progress;
    }
}

