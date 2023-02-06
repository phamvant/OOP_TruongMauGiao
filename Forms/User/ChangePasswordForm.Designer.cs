
namespace OOP_TruongMauGiao
{
    partial class ChangePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
            this.textBox_NewPassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_OldPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_ChangePassword = new System.Windows.Forms.Button();
            this.textBox_NewPasswordRetype = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_ShowPassword1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_ShowPassword2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_ShowPassword3 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ShowPassword1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ShowPassword2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ShowPassword3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_NewPassword
            // 
            this.textBox_NewPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_NewPassword.BackColor = System.Drawing.Color.White;
            this.textBox_NewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NewPassword.Location = new System.Drawing.Point(32, 193);
            this.textBox_NewPassword.Name = "textBox_NewPassword";
            this.textBox_NewPassword.Size = new System.Drawing.Size(509, 49);
            this.textBox_NewPassword.TabIndex = 102;
            this.textBox_NewPassword.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(32, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(273, 37);
            this.label10.TabIndex = 100;
            this.label10.Text = "MẬT KHẨU MỚI:";
            // 
            // textBox_OldPassword
            // 
            this.textBox_OldPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_OldPassword.BackColor = System.Drawing.Color.White;
            this.textBox_OldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_OldPassword.Location = new System.Drawing.Point(32, 85);
            this.textBox_OldPassword.Name = "textBox_OldPassword";
            this.textBox_OldPassword.Size = new System.Drawing.Size(509, 49);
            this.textBox_OldPassword.TabIndex = 98;
            this.textBox_OldPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 37);
            this.label5.TabIndex = 97;
            this.label5.Text = "MẬT KHẨU CŨ:";
            // 
            // button_ChangePassword
            // 
            this.button_ChangePassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_ChangePassword.BackColor = System.Drawing.Color.Peru;
            this.button_ChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ChangePassword.ForeColor = System.Drawing.Color.White;
            this.button_ChangePassword.Location = new System.Drawing.Point(138, 412);
            this.button_ChangePassword.Name = "button_ChangePassword";
            this.button_ChangePassword.Size = new System.Drawing.Size(274, 72);
            this.button_ChangePassword.TabIndex = 105;
            this.button_ChangePassword.Text = "ĐỔI MẬT KHẨU";
            this.button_ChangePassword.UseVisualStyleBackColor = false;
            this.button_ChangePassword.Click += new System.EventHandler(this.button_ChangePassword_Click);
            // 
            // textBox_NewPasswordRetype
            // 
            this.textBox_NewPasswordRetype.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_NewPasswordRetype.BackColor = System.Drawing.Color.White;
            this.textBox_NewPasswordRetype.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NewPasswordRetype.Location = new System.Drawing.Point(32, 301);
            this.textBox_NewPasswordRetype.Name = "textBox_NewPasswordRetype";
            this.textBox_NewPasswordRetype.Size = new System.Drawing.Size(509, 49);
            this.textBox_NewPasswordRetype.TabIndex = 107;
            this.textBox_NewPasswordRetype.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 37);
            this.label1.TabIndex = 106;
            this.label1.Text = "NHẬP LẠI MẬT KHẨU MỚI:";
            // 
            // pictureBox_ShowPassword1
            // 
            this.pictureBox_ShowPassword1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_ShowPassword1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox_ShowPassword1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_ShowPassword1.Image")));
            this.pictureBox_ShowPassword1.Location = new System.Drawing.Point(491, 85);
            this.pictureBox_ShowPassword1.Name = "pictureBox_ShowPassword1";
            this.pictureBox_ShowPassword1.Size = new System.Drawing.Size(52, 52);
            this.pictureBox_ShowPassword1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_ShowPassword1.TabIndex = 108;
            this.pictureBox_ShowPassword1.TabStop = false;
            this.pictureBox_ShowPassword1.MouseLeave += new System.EventHandler(this.pictureBox_SowPassword1_MouseLeave);
            this.pictureBox_ShowPassword1.MouseHover += new System.EventHandler(this.pictureBox_SowPassword1_MouseHover);
            // 
            // pictureBox_ShowPassword2
            // 
            this.pictureBox_ShowPassword2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_ShowPassword2.BackColor = System.Drawing.Color.Gray;
            this.pictureBox_ShowPassword2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_ShowPassword2.Image")));
            this.pictureBox_ShowPassword2.Location = new System.Drawing.Point(491, 193);
            this.pictureBox_ShowPassword2.Name = "pictureBox_ShowPassword2";
            this.pictureBox_ShowPassword2.Size = new System.Drawing.Size(52, 52);
            this.pictureBox_ShowPassword2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_ShowPassword2.TabIndex = 109;
            this.pictureBox_ShowPassword2.TabStop = false;
            this.pictureBox_ShowPassword2.MouseLeave += new System.EventHandler(this.pictureBox_ShowPassword2_MouseLeave);
            this.pictureBox_ShowPassword2.MouseHover += new System.EventHandler(this.pictureBox_ShowPassword2_MouseHover);
            // 
            // pictureBox_ShowPassword3
            // 
            this.pictureBox_ShowPassword3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_ShowPassword3.BackColor = System.Drawing.Color.Gray;
            this.pictureBox_ShowPassword3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_ShowPassword3.Image")));
            this.pictureBox_ShowPassword3.Location = new System.Drawing.Point(491, 301);
            this.pictureBox_ShowPassword3.Name = "pictureBox_ShowPassword3";
            this.pictureBox_ShowPassword3.Size = new System.Drawing.Size(52, 52);
            this.pictureBox_ShowPassword3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_ShowPassword3.TabIndex = 110;
            this.pictureBox_ShowPassword3.TabStop = false;
            this.pictureBox_ShowPassword3.MouseLeave += new System.EventHandler(this.pictureBox_ShowPassword3_MouseLeave);
            this.pictureBox_ShowPassword3.MouseHover += new System.EventHandler(this.pictureBox_ShowPassword3_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Bisque;
            this.groupBox1.Controls.Add(this.pictureBox_ShowPassword3);
            this.groupBox1.Controls.Add(this.pictureBox_ShowPassword2);
            this.groupBox1.Controls.Add(this.pictureBox_ShowPassword1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_NewPassword);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBox_OldPassword);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_NewPasswordRetype);
            this.groupBox1.Controls.Add(this.button_ChangePassword);
            this.groupBox1.Location = new System.Drawing.Point(18, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 519);
            this.groupBox1.TabIndex = 111;
            this.groupBox1.TabStop = false;
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(612, 560);
            this.Controls.Add(this.groupBox1);
            this.Name = "ChangePasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐỔI MẬT KHẨU";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ShowPassword1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ShowPassword2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ShowPassword3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_NewPassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_OldPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_ChangePassword;
        private System.Windows.Forms.TextBox textBox_NewPasswordRetype;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_ShowPassword1;
        private System.Windows.Forms.PictureBox pictureBox_ShowPassword2;
        private System.Windows.Forms.PictureBox pictureBox_ShowPassword3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}