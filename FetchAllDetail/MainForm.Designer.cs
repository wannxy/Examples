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
            this.SuspendLayout();
            // 
            // btn_fetch
            // 
            this.btn_fetch.Location = new System.Drawing.Point(13, 14);
            this.btn_fetch.Name = "btn_fetch";
            this.btn_fetch.Size = new System.Drawing.Size(66, 34);
            this.btn_fetch.TabIndex = 0;
            this.btn_fetch.Text = "拉取";
            this.btn_fetch.UseVisualStyleBackColor = true;
            this.btn_fetch.Click += new System.EventHandler(this.btn_fetch_Click);
            // 
            // lb_log
            // 
            this.lb_log.AutoSize = true;
            this.lb_log.Location = new System.Drawing.Point(227, 23);
            this.lb_log.Name = "lb_log";
            this.lb_log.Size = new System.Drawing.Size(27, 17);
            this.lb_log.TabIndex = 1;
            this.lb_log.Text = "0/0";
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(98, 20);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(100, 23);
            this.tb_phone.TabIndex = 2;
            this.tb_phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_jsession
            // 
            this.tb_jsession.Location = new System.Drawing.Point(25, 54);
            this.tb_jsession.Name = "tb_jsession";
            this.tb_jsession.Size = new System.Drawing.Size(305, 23);
            this.tb_jsession.TabIndex = 2;
            this.tb_jsession.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 85);
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
    }
}

