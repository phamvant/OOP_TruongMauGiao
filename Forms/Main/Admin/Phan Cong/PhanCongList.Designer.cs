
namespace OOP_TruongMauGiao
{
    partial class PhanCongList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_TeacherIdSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ClassIdSearch = new System.Windows.Forms.TextBox();
            this.textBox_PhanCongIdSearch = new System.Windows.Forms.TextBox();
            this.pictureBox_Refresh = new System.Windows.Forms.PictureBox();
            this.dataGridView_ListOfPhanCongs = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListOfPhanCongs)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.pictureBox_Refresh);
            this.groupBox2.Controls.Add(this.dataGridView_ListOfPhanCongs);
            this.groupBox2.Location = new System.Drawing.Point(18, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1416, 785);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_TeacherIdSearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_ClassIdSearch);
            this.groupBox1.Controls.Add(this.textBox_PhanCongIdSearch);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(60, 582);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1311, 168);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm bảng phân công";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 31);
            this.label3.TabIndex = 36;
            this.label3.Text = "Mã giáo viên:";
            // 
            // textBox_TeacherIdSearch
            // 
            this.textBox_TeacherIdSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TeacherIdSearch.Location = new System.Drawing.Point(219, 113);
            this.textBox_TeacherIdSearch.Name = "textBox_TeacherIdSearch";
            this.textBox_TeacherIdSearch.Size = new System.Drawing.Size(280, 49);
            this.textBox_TeacherIdSearch.TabIndex = 35;
            this.textBox_TeacherIdSearch.TextChanged += new System.EventHandler(this.textBox_TeacherIdSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(645, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 31);
            this.label2.TabIndex = 34;
            this.label2.Text = "Mã lớp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 31);
            this.label1.TabIndex = 32;
            this.label1.Text = "Mã phân công:";
            // 
            // textBox_ClassIdSearch
            // 
            this.textBox_ClassIdSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ClassIdSearch.Location = new System.Drawing.Point(767, 43);
            this.textBox_ClassIdSearch.Name = "textBox_ClassIdSearch";
            this.textBox_ClassIdSearch.Size = new System.Drawing.Size(280, 49);
            this.textBox_ClassIdSearch.TabIndex = 33;
            this.textBox_ClassIdSearch.TextChanged += new System.EventHandler(this.textBox_ClassIdSearch_TextChanged);
            // 
            // textBox_PhanCongIdSearch
            // 
            this.textBox_PhanCongIdSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PhanCongIdSearch.Location = new System.Drawing.Point(219, 45);
            this.textBox_PhanCongIdSearch.Name = "textBox_PhanCongIdSearch";
            this.textBox_PhanCongIdSearch.Size = new System.Drawing.Size(280, 49);
            this.textBox_PhanCongIdSearch.TabIndex = 27;
            this.textBox_PhanCongIdSearch.TextChanged += new System.EventHandler(this.textBox_PhanCongIdSearch_TextChanged);
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
            this.pictureBox_Refresh.Location = new System.Drawing.Point(1320, 30);
            this.pictureBox_Refresh.Name = "pictureBox_Refresh";
            this.pictureBox_Refresh.Size = new System.Drawing.Size(51, 50);
            this.pictureBox_Refresh.TabIndex = 26;
            this.pictureBox_Refresh.TabStop = false;
            this.pictureBox_Refresh.Click += new System.EventHandler(this.pictureBox_Refresh_Click);
            // 
            // dataGridView_ListOfPhanCongs
            // 
            this.dataGridView_ListOfPhanCongs.AllowUserToAddRows = false;
            this.dataGridView_ListOfPhanCongs.AllowUserToDeleteRows = false;
            this.dataGridView_ListOfPhanCongs.AllowUserToResizeColumns = false;
            this.dataGridView_ListOfPhanCongs.AllowUserToResizeRows = false;
            this.dataGridView_ListOfPhanCongs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_ListOfPhanCongs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dataGridView_ListOfPhanCongs.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_ListOfPhanCongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ListOfPhanCongs.Location = new System.Drawing.Point(60, 30);
            this.dataGridView_ListOfPhanCongs.Name = "dataGridView_ListOfPhanCongs";
            this.dataGridView_ListOfPhanCongs.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_ListOfPhanCongs.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_ListOfPhanCongs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView_ListOfPhanCongs.RowTemplate.Height = 80;
            this.dataGridView_ListOfPhanCongs.Size = new System.Drawing.Size(1311, 535);
            this.dataGridView_ListOfPhanCongs.TabIndex = 0;
            this.dataGridView_ListOfPhanCongs.DoubleClick += new System.EventHandler(this.dataGridView_ListOfPhanCongs_DoubleClick);
            // 
            // PhanCongList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 815);
            this.Controls.Add(this.groupBox2);
            this.Name = "PhanCongList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DANH SÁCH PHÂN CÔNG GIÁO VIÊN CHỦ NHIỆM";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListOfPhanCongs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_TeacherIdSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ClassIdSearch;
        private System.Windows.Forms.TextBox textBox_PhanCongIdSearch;
        private System.Windows.Forms.PictureBox pictureBox_Refresh;
        private System.Windows.Forms.DataGridView dataGridView_ListOfPhanCongs;
    }
}