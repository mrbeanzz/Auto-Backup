namespace AutoSmartPhoneBackup
{
    partial class AutoBKMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chksaveimages = new System.Windows.Forms.CheckBox();
            this.chksavecontacts = new System.Windows.Forms.CheckBox();
            this.chksavevideos = new System.Windows.Forms.CheckBox();
            this.chksavemessages = new System.Windows.Forms.CheckBox();
            this.txtstoredfolder = new System.Windows.Forms.TextBox();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.chkstartwithwindow = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblchooselang = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(367, 226);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnbrowse);
            this.tabPage1.Controls.Add(this.txtstoredfolder);
            this.tabPage1.Controls.Add(this.chksavemessages);
            this.tabPage1.Controls.Add(this.chksavevideos);
            this.tabPage1.Controls.Add(this.chksavecontacts);
            this.tabPage1.Controls.Add(this.chksaveimages);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(359, 200);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cài đặt chung";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblchooselang);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.chkstartwithwindow);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(359, 200);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hệ thống";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chksaveimages
            // 
            this.chksaveimages.AutoSize = true;
            this.chksaveimages.Location = new System.Drawing.Point(8, 15);
            this.chksaveimages.Name = "chksaveimages";
            this.chksaveimages.Size = new System.Drawing.Size(107, 17);
            this.chksaveimages.TabIndex = 0;
            this.chksaveimages.Text = "Tự động lưu hình";
            this.chksaveimages.UseVisualStyleBackColor = true;
            this.chksaveimages.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chksavecontacts
            // 
            this.chksavecontacts.AutoSize = true;
            this.chksavecontacts.Location = new System.Drawing.Point(8, 38);
            this.chksavecontacts.Name = "chksavecontacts";
            this.chksavecontacts.Size = new System.Drawing.Size(128, 17);
            this.chksavecontacts.TabIndex = 1;
            this.chksavecontacts.Text = "Tự động lưu Danh bạ";
            this.chksavecontacts.UseVisualStyleBackColor = true;
            // 
            // chksavevideos
            // 
            this.chksavevideos.AutoSize = true;
            this.chksavevideos.Location = new System.Drawing.Point(8, 61);
            this.chksavevideos.Name = "chksavevideos";
            this.chksavevideos.Size = new System.Drawing.Size(114, 17);
            this.chksavevideos.TabIndex = 2;
            this.chksavevideos.Text = "Tự động lưu Video";
            this.chksavevideos.UseVisualStyleBackColor = true;
            // 
            // chksavemessages
            // 
            this.chksavemessages.AutoSize = true;
            this.chksavemessages.Location = new System.Drawing.Point(8, 84);
            this.chksavemessages.Name = "chksavemessages";
            this.chksavemessages.Size = new System.Drawing.Size(129, 17);
            this.chksavemessages.TabIndex = 3;
            this.chksavemessages.Text = "Tự động lưu Tin nhắn";
            this.chksavemessages.UseVisualStyleBackColor = true;
            // 
            // txtstoredfolder
            // 
            this.txtstoredfolder.Location = new System.Drawing.Point(8, 113);
            this.txtstoredfolder.Name = "txtstoredfolder";
            this.txtstoredfolder.Size = new System.Drawing.Size(177, 20);
            this.txtstoredfolder.TabIndex = 4;
            // 
            // btnbrowse
            // 
            this.btnbrowse.Location = new System.Drawing.Point(220, 113);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(75, 23);
            this.btnbrowse.TabIndex = 5;
            this.btnbrowse.Text = "Browse";
            this.btnbrowse.UseVisualStyleBackColor = true;
            // 
            // chkstartwithwindow
            // 
            this.chkstartwithwindow.AutoSize = true;
            this.chkstartwithwindow.Location = new System.Drawing.Point(6, 17);
            this.chkstartwithwindow.Name = "chkstartwithwindow";
            this.chkstartwithwindow.Size = new System.Drawing.Size(147, 17);
            this.chkstartwithwindow.TabIndex = 0;
            this.chkstartwithwindow.Text = "Khởi động cùng hệ thống";
            this.chkstartwithwindow.UseVisualStyleBackColor = true;
            this.chkstartwithwindow.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // lblchooselang
            // 
            this.lblchooselang.AutoSize = true;
            this.lblchooselang.Location = new System.Drawing.Point(8, 54);
            this.lblchooselang.Name = "lblchooselang";
            this.lblchooselang.Size = new System.Drawing.Size(100, 13);
            this.lblchooselang.TabIndex = 2;
            this.lblchooselang.Text = "Lựa chọn ngôn ngữ";
            // 
            // AutoBKMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 222);
            this.Controls.Add(this.tabControl1);
            this.Name = "AutoBKMain";
            this.Text = "Auto Backup";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox chksavemessages;
        private System.Windows.Forms.CheckBox chksavevideos;
        private System.Windows.Forms.CheckBox chksavecontacts;
        private System.Windows.Forms.CheckBox chksaveimages;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.TextBox txtstoredfolder;
        private System.Windows.Forms.CheckBox chkstartwithwindow;
        private System.Windows.Forms.Label lblchooselang;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

