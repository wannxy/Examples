namespace HideWindows
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
            this.btn_hide = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.tb_title = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btn_hide
            // 
            this.btn_hide.Location = new System.Drawing.Point(12, 12);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.Size = new System.Drawing.Size(79, 38);
            this.btn_hide.TabIndex = 0;
            this.btn_hide.Text = "隐藏(&H)";
            this.btn_hide.UseVisualStyleBackColor = true;
            this.btn_hide.Click += new System.EventHandler(this.btn_hide_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(115, 12);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(79, 38);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "显示(&S)";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // tb_title
            // 
            this.tb_title.Location = new System.Drawing.Point(29, 57);
            this.tb_title.Name = "tb_title";
            this.tb_title.Size = new System.Drawing.Size(144, 23);
            this.tb_title.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 90);
            this.Controls.Add(this.tb_title);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btn_hide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.Text = "Hide";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_hide;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox tb_title;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

