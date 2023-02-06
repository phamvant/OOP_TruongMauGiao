
namespace OOP_TruongMauGiao
{
    partial class StudentList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentList));
            this.dataGridView_ListOfStudents = new System.Windows.Forms.DataGridView();
            this.textBox_TimKiemTheoMa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_TimKiemTheoTen = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox_Refresh = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListOfStudents)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Refresh)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_ListOfStudents
            // 
            this.dataGridView_ListOfStudents.AllowUserToAddRows = false;
            this.dataGridView_ListOfStudents.AllowUserToDeleteRows = false;
            this.dataGridView_ListOfStudents.AllowUserToResizeColumns = false;
            this.dataGridView_ListOfStudents.AllowUserToResizeRows = false;
            this.dataGridView_ListOfStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_ListOfStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dataGridView_ListOfStudents.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_ListOfStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ListOfStudents.Location = new System.Drawing.Point(46, 18);
            this.dataGridView_ListOfStudents.Name = "dataGridView_ListOfStudents";
            this.dataGridView_ListOfStudents.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_ListOfStudents.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_ListOfStudents.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView_ListOfStudents.RowTemplate.Height = 80;
            this.dataGridView_ListOfStudents.Size = new System.Drawing.Size(1351, 513);
            this.dataGridView_ListOfStudents.TabIndex = 0;
            this.dataGridView_ListOfStudents.DoubleClick += new System.EventHandler(this.dataGridView_StudentsList_DoubleClick);
            // 
            // textBox_TimKiemTheoMa
            // 
            this.textBox_TimKiemTheoMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TimKiemTheoMa.Location = new System.Drawing.Point(193, 45);
            this.textBox_TimKiemTheoMa.Name = "textBox_TimKiemTheoMa";
            this.textBox_TimKiemTheoMa.Size = new System.Drawing.Size(280, 49);
            this.textBox_TimKiemTheoMa.TabIndex = 27;
            this.textBox_TimKiemTheoMa.TextChanged += new System.EventHandler(this.textBox_TimKiemTheoMa_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 31);
            this.label1.TabIndex = 32;
            this.label1.Text = "Mã học sinh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(534, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 31);
            this.label2.TabIndex = 34;
            this.label2.Text = "Tên học sinh:";
            // 
            // textBox_TimKiemTheoTen
            // 
            this.textBox_TimKiemTheoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TimKiemTheoTen.Location = new System.Drawing.Point(731, 43);
            this.textBox_TimKiemTheoTen.Name = "textBox_TimKiemTheoTen";
            this.textBox_TimKiemTheoTen.Size = new System.Drawing.Size(280, 49);
            this.textBox_TimKiemTheoTen.TabIndex = 33;
            this.textBox_TimKiemTheoTen.TextChanged += new System.EventHandler(this.textBox_TimKiemTheoTen_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_TimKiemTheoTen);
            this.groupBox1.Controls.Add(this.textBox_TimKiemTheoMa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(228, 550);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1019, 113);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm học sinh";
            // 
            // pictureBox_Refresh
            // 
            this.pictureBox_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_Refresh.BackColor = System.Drawing.Color.Chartreuse;
            this.pictureBox_Refresh.BackgroundImage = global::OOP_TruongMauGiao.Properties.Resources.refresh;
            this.pictureBox_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Refresh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Refresh.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox_Refresh.ErrorImage = null;
            this.pictureBox_Refresh.Location = new System.Drawing.Point(1373, 0);
            this.pictureBox_Refresh.Name = "pictureBox_Refresh";
            this.pictureBox_Refresh.Size = new System.Drawing.Size(51, 50);
            this.pictureBox_Refresh.TabIndex = 26;
            this.pictureBox_Refresh.TabStop = false;
            this.pictureBox_Refresh.Click += new System.EventHandler(this.pictureBox_Refresh_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.pictureBox_Refresh);
            this.groupBox2.Controls.Add(this.dataGridView_ListOfStudents);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1618, 683);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            // 
            // StudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1642, 716);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DANH SÁCH HỌC SINH";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListOfStudents)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Refresh)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_ListOfStudents;
        private System.Windows.Forms.PictureBox pictureBox_Refresh;
        private System.Windows.Forms.TextBox textBox_TimKiemTheoMa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_TimKiemTheoTen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}