namespace AccountCheck
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
            this.btn_zombie = new System.Windows.Forms.Button();
            this.btn_wool = new System.Windows.Forms.Button();
            this.tb_zombie_log = new System.Windows.Forms.TextBox();
            this.tb_wool_log = new System.Windows.Forms.TextBox();
            this.btn_fetch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_zombie
            // 
            this.btn_zombie.Location = new System.Drawing.Point(177, 403);
            this.btn_zombie.Name = "btn_zombie";
            this.btn_zombie.Size = new System.Drawing.Size(73, 44);
            this.btn_zombie.TabIndex = 0;
            this.btn_zombie.Text = "僵尸检查";
            this.btn_zombie.UseVisualStyleBackColor = true;
            this.btn_zombie.Click += new System.EventHandler(this.btn_zombie_Click);
            // 
            // btn_wool
            // 
            this.btn_wool.Location = new System.Drawing.Point(576, 403);
            this.btn_wool.Name = "btn_wool";
            this.btn_wool.Size = new System.Drawing.Size(75, 44);
            this.btn_wool.TabIndex = 1;
            this.btn_wool.Text = "羊毛检查";
            this.btn_wool.UseVisualStyleBackColor = true;
            this.btn_wool.Click += new System.EventHandler(this.btn_wool_Click);
            // 
            // tb_zombie_log
            // 
            this.tb_zombie_log.Location = new System.Drawing.Point(2, 1);
            this.tb_zombie_log.Multiline = true;
            this.tb_zombie_log.Name = "tb_zombie_log";
            this.tb_zombie_log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_zombie_log.Size = new System.Drawing.Size(403, 396);
            this.tb_zombie_log.TabIndex = 2;
            // 
            // tb_wool_log
            // 
            this.tb_wool_log.Location = new System.Drawing.Point(411, 1);
            this.tb_wool_log.Multiline = true;
            this.tb_wool_log.Name = "tb_wool_log";
            this.tb_wool_log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_wool_log.Size = new System.Drawing.Size(403, 396);
            this.tb_wool_log.TabIndex = 2;
            // 
            // btn_fetch
            // 
            this.btn_fetch.Location = new System.Drawing.Point(366, 403);
            this.btn_fetch.Name = "btn_fetch";
            this.btn_fetch.Size = new System.Drawing.Size(75, 44);
            this.btn_fetch.TabIndex = 3;
            this.btn_fetch.Text = "拉取账号";
            this.btn_fetch.UseVisualStyleBackColor = true;
            this.btn_fetch.Click += new System.EventHandler(this.btn_fetch_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 451);
            this.Controls.Add(this.btn_fetch);
            this.Controls.Add(this.tb_wool_log);
            this.Controls.Add(this.tb_zombie_log);
            this.Controls.Add(this.btn_wool);
            this.Controls.Add(this.btn_zombie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "账号检查";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_zombie;
        private System.Windows.Forms.Button btn_wool;
        private System.Windows.Forms.TextBox tb_zombie_log;
        private System.Windows.Forms.TextBox tb_wool_log;
        private System.Windows.Forms.Button btn_fetch;
    }
}

