
namespace OOP_TruongMauGiao
{
    partial class QuenMatKhauForm
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
            this.button_Send = new System.Windows.Forms.Button();
            this.textBox_Mail = new System.Windows.Forms.TextBox();
            this.pictureBox_IconTaiKhoan = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_IconTaiKhoan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Send
            // 
            this.button_Send.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Send.BackColor = System.Drawing.Color.Green;
            this.button_Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Send.ForeColor = System.Drawing.Color.White;
            this.button_Send.Location = new System.Drawing.Point(21, 141);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(591, 69);
            this.button_Send.TabIndex = 11;
            this.button_Send.Text = "YÊU CẦU CẤP LẠI MẬT KHẨU MỚI";
            this.button_Send.UseVisualStyleBackColor = false;
            // 
            // textBox_Mail
            // 
            this.textBox_Mail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Mail.Location = new System.Drawing.Point(218, 34);
            this.textBox_Mail.Name = "textBox_Mail";
            this.textBox_Mail.Size = new System.Drawing.Size(394, 49);
            this.textBox_Mail.TabIndex = 10;
            // 
            // pictureBox_IconTaiKhoan
            // 
            this.pictureBox_IconTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_IconTaiKhoan.Image = global::OOP_TruongMauGiao.Properties.Resources.mail;
            this.pictureBox_IconTaiKhoan.InitialImage = global::OOP_TruongMauGiao.Properties.Resources.mail;
            this.pictureBox_IconTaiKhoan.Location = new System.Drawing.Point(21, 14);
            this.pictureBox_IconTaiKhoan.Name = "pictureBox_IconTaiKhoan";
            this.pictureBox_IconTaiKhoan.Size = new System.Drawing.Size(80, 80);
            this.pictureBox_IconTaiKhoan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_IconTaiKhoan.TabIndex = 9;
            this.pictureBox_IconTaiKhoan.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 37);
            this.label2.TabIndex = 8;
            this.label2.Text = "MAIL:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.button_Send);
            this.groupBox1.Controls.Add(this.textBox_Mail);
            this.groupBox1.Controls.Add(this.pictureBox_IconTaiKhoan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(29, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 233);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // QuenMatKhauForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(695, 280);
            this.Controls.Add(this.groupBox1);
            this.Name = "QuenMatKhauForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUÊN MẬT KHẨU";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_IconTaiKhoan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Send;
        public System.Windows.Forms.TextBox textBox_Mail;
        private System.Windows.Forms.PictureBox pictureBox_IconTaiKhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}