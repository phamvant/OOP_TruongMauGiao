
namespace OOP_TruongMauGiao
{
    partial class PhanCongForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhanCongForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Year = new System.Windows.Forms.TextBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Remove = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_PhanCongId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_ClassId = new System.Windows.Forms.ComboBox();
            this.comboBox_TeacherId = new System.Windows.Forms.ComboBox();
            this.button_TeacherInfo = new System.Windows.Forms.Button();
            this.button_ClassInfo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Moccasin;
            this.groupBox1.Controls.Add(this.button_TeacherInfo);
            this.groupBox1.Controls.Add(this.button_ClassInfo);
            this.groupBox1.Controls.Add(this.comboBox_TeacherId);
            this.groupBox1.Controls.Add(this.textBox_PhanCongId);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.comboBox_ClassId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox_Year);
            this.groupBox1.Controls.Add(this.button_Add);
            this.groupBox1.Controls.Add(this.button_Update);
            this.groupBox1.Controls.Add(this.button_Remove);
            this.groupBox1.Controls.Add(this.button_Cancel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(15, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1155, 371);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(728, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 37);
            this.label4.TabIndex = 58;
            this.label4.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(728, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 37);
            this.label7.TabIndex = 50;
            this.label7.Text = "*";
            // 
            // textBox_Year
            // 
            this.textBox_Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Year.Location = new System.Drawing.Point(328, 130);
            this.textBox_Year.Name = "textBox_Year";
            this.textBox_Year.Size = new System.Drawing.Size(394, 49);
            this.textBox_Year.TabIndex = 57;
            // 
            // button_Add
            // 
            this.button_Add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_Add.BackColor = System.Drawing.Color.DarkGreen;
            this.button_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add.ForeColor = System.Drawing.Color.White;
            this.button_Add.Location = new System.Drawing.Point(764, 26);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(349, 69);
            this.button_Add.TabIndex = 53;
            this.button_Add.Text = "THÊM PHÂN CÔNG";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Update
            // 
            this.button_Update.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_Update.BackColor = System.Drawing.Color.Goldenrod;
            this.button_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Update.ForeColor = System.Drawing.Color.White;
            this.button_Update.Location = new System.Drawing.Point(766, 74);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(349, 69);
            this.button_Update.TabIndex = 56;
            this.button_Update.Text = "CẬP NHẬT";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Remove
            // 
            this.button_Remove.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_Remove.BackColor = System.Drawing.Color.DarkRed;
            this.button_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Remove.ForeColor = System.Drawing.Color.White;
            this.button_Remove.Location = new System.Drawing.Point(766, 269);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(349, 69);
            this.button_Remove.TabIndex = 55;
            this.button_Remove.Text = "XÓA PHÂN CÔNG";
            this.button_Remove.UseVisualStyleBackColor = false;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_Cancel.BackColor = System.Drawing.Color.Navy;
            this.button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Cancel.ForeColor = System.Drawing.Color.White;
            this.button_Cancel.Location = new System.Drawing.Point(766, 170);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(349, 69);
            this.button_Cancel.TabIndex = 54;
            this.button_Cancel.Text = "HỦY";
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 37);
            this.label3.TabIndex = 47;
            this.label3.Text = "NĂM HỌC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 37);
            this.label2.TabIndex = 44;
            this.label2.Text = "MÃ PHÂN CÔNG:";
            // 
            // textBox_PhanCongId
            // 
            this.textBox_PhanCongId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PhanCongId.Location = new System.Drawing.Point(328, 52);
            this.textBox_PhanCongId.Name = "textBox_PhanCongId";
            this.textBox_PhanCongId.Size = new System.Drawing.Size(394, 49);
            this.textBox_PhanCongId.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 37);
            this.label1.TabIndex = 39;
            this.label1.Text = "MÃ GIÁO VIÊN :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(92, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 37);
            this.label5.TabIndex = 37;
            this.label5.Text = "MÃ LỚP:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(728, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 37);
            this.label6.TabIndex = 59;
            this.label6.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(728, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 37);
            this.label8.TabIndex = 60;
            this.label8.Text = "*";
            // 
            // comboBox_ClassId
            // 
            this.comboBox_ClassId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ClassId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_ClassId.FormattingEnabled = true;
            this.comboBox_ClassId.Items.AddRange(new object[] {
            ""});
            this.comboBox_ClassId.Location = new System.Drawing.Point(328, 211);
            this.comboBox_ClassId.Name = "comboBox_ClassId";
            this.comboBox_ClassId.Size = new System.Drawing.Size(338, 45);
            this.comboBox_ClassId.TabIndex = 51;
            // 
            // comboBox_TeacherId
            // 
            this.comboBox_TeacherId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TeacherId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_TeacherId.FormattingEnabled = true;
            this.comboBox_TeacherId.Items.AddRange(new object[] {
            ""});
            this.comboBox_TeacherId.Location = new System.Drawing.Point(328, 290);
            this.comboBox_TeacherId.Name = "comboBox_TeacherId";
            this.comboBox_TeacherId.Size = new System.Drawing.Size(338, 45);
            this.comboBox_TeacherId.TabIndex = 61;
            // 
            // button_TeacherInfo
            // 
            this.button_TeacherInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_TeacherInfo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_TeacherInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_TeacherInfo.BackgroundImage")));
            this.button_TeacherInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_TeacherInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_TeacherInfo.ForeColor = System.Drawing.Color.White;
            this.button_TeacherInfo.Location = new System.Drawing.Point(672, 286);
            this.button_TeacherInfo.Name = "button_TeacherInfo";
            this.button_TeacherInfo.Size = new System.Drawing.Size(50, 49);
            this.button_TeacherInfo.TabIndex = 63;
            this.button_TeacherInfo.UseVisualStyleBackColor = false;
            this.button_TeacherInfo.Click += new System.EventHandler(this.button_TeacherInfo_Click);
            // 
            // button_ClassInfo
            // 
            this.button_ClassInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_ClassInfo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_ClassInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_ClassInfo.BackgroundImage")));
            this.button_ClassInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_ClassInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ClassInfo.ForeColor = System.Drawing.Color.White;
            this.button_ClassInfo.Location = new System.Drawing.Point(672, 211);
            this.button_ClassInfo.Name = "button_ClassInfo";
            this.button_ClassInfo.Size = new System.Drawing.Size(50, 49);
            this.button_ClassInfo.TabIndex = 62;
            this.button_ClassInfo.UseVisualStyleBackColor = false;
            this.button_ClassInfo.Click += new System.EventHandler(this.button_ClassInfo_Click);
            // 
            // PhanCongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1185, 411);
            this.Controls.Add(this.groupBox1);
            this.Name = "PhanCongForm";
            this.Text = "BẢNG PHÂN CÔNG GIÁO VIÊN";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox textBox_Year;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Remove;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox textBox_PhanCongId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.ComboBox comboBox_ClassId;
        internal System.Windows.Forms.ComboBox comboBox_TeacherId;
        private System.Windows.Forms.Button button_TeacherInfo;
        private System.Windows.Forms.Button button_ClassInfo;
    }
}