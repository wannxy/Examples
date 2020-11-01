namespace MemberTree
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
            this.btn_query = new System.Windows.Forms.Button();
            this.tb_jsessionid = new System.Windows.Forms.TextBox();
            this.tb_logI = new System.Windows.Forms.TextBox();
            this.tb_phones = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_query
            // 
            this.btn_query.Location = new System.Drawing.Point(21, 8);
            this.btn_query.Name = "btn_query";
            this.btn_query.Size = new System.Drawing.Size(75, 31);
            this.btn_query.TabIndex = 0;
            this.btn_query.Text = "查询";
            this.btn_query.UseVisualStyleBackColor = true;
            this.btn_query.Click += new System.EventHandler(this.btn_query_Click);
            // 
            // tb_jsessionid
            // 
            this.tb_jsessionid.Location = new System.Drawing.Point(201, 12);
            this.tb_jsessionid.Name = "tb_jsessionid";
            this.tb_jsessionid.Size = new System.Drawing.Size(285, 23);
            this.tb_jsessionid.TabIndex = 1;
            this.tb_jsessionid.Text = "E4B5939054B6F5002B5E36C312FB9020";
            this.tb_jsessionid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_logI
            // 
            this.tb_logI.Location = new System.Drawing.Point(2, 252);
            this.tb_logI.Multiline = true;
            this.tb_logI.Name = "tb_logI";
            this.tb_logI.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_logI.Size = new System.Drawing.Size(493, 195);
            this.tb_logI.TabIndex = 2;
            // 
            // tb_phones
            // 
            this.tb_phones.Location = new System.Drawing.Point(2, 64);
            this.tb_phones.Multiline = true;
            this.tb_phones.Name = "tb_phones";
            this.tb_phones.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_phones.Size = new System.Drawing.Size(493, 182);
            this.tb_phones.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 450);
            this.Controls.Add(this.tb_phones);
            this.Controls.Add(this.tb_logI);
            this.Controls.Add(this.tb_jsessionid);
            this.Controls.Add(this.btn_query);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "成员树";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_query;
        private System.Windows.Forms.TextBox tb_jsessionid;
        private System.Windows.Forms.TextBox tb_logI;
        private System.Windows.Forms.TextBox tb_phones;
    }
}

