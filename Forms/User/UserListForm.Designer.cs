
namespace OOP_TruongMauGiao
{
    partial class UserListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_TimKiemTheoTen = new System.Windows.Forms.TextBox();
            this.textBox_TimKiemTheoMa = new System.Windows.Forms.TextBox();
            this.pictureBox_Refresh = new System.Windows.Forms.PictureBox();
            this.dataGridView_ListOfUsers = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListOfUsers)).BeginInit();
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
            this.groupBox2.Controls.Add(this.dataGridView_ListOfUsers);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1799, 875);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
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
            this.groupBox1.Location = new System.Drawing.Point(385, 744);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1019, 113);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(534, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 31);
            this.label2.TabIndex = 34;
            this.label2.Text = "Tên người dùng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 31);
            this.label1.TabIndex = 32;
            this.label1.Text = "Mã tài khoản:";
            // 
            // textBox_TimKiemTheoTen
            // 
            this.textBox_TimKiemTheoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TimKiemTheoTen.Location = new System.Drawing.Point(732, 43);
            this.textBox_TimKiemTheoTen.Name = "textBox_TimKiemTheoTen";
            this.textBox_TimKiemTheoTen.Size = new System.Drawing.Size(279, 49);
            this.textBox_TimKiemTheoTen.TabIndex = 33;
            this.textBox_TimKiemTheoTen.TextChanged += new System.EventHandler(this.textBox_TimKiemTheoTen_TextChanged);
            // 
            // textBox_TimKiemTheoMa
            // 
            this.textBox_TimKiemTheoMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TimKiemTheoMa.Location = new System.Drawing.Point(194, 45);
            this.textBox_TimKiemTheoMa.Name = "textBox_TimKiemTheoMa";
            this.textBox_TimKiemTheoMa.Size = new System.Drawing.Size(279, 49);
            this.textBox_TimKiemTheoMa.TabIndex = 27;
            this.textBox_TimKiemTheoMa.TextChanged += new System.EventHandler(this.textBox_TimKiemTheoMa_TextChanged);
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
            this.pictureBox_Refresh.Location = new System.Drawing.Point(1711, 18);
            this.pictureBox_Refresh.Name = "pictureBox_Refresh";
            this.pictureBox_Refresh.Size = new System.Drawing.Size(51, 50);
            this.pictureBox_Refresh.TabIndex = 26;
            this.pictureBox_Refresh.TabStop = false;
            this.pictureBox_Refresh.Click += new System.EventHandler(this.pictureBox_Refresh_Click);
            // 
            // dataGridView_ListOfUsers
            // 
            this.dataGridView_ListOfUsers.AllowUserToAddRows = false;
            this.dataGridView_ListOfUsers.AllowUserToDeleteRows = false;
            this.dataGridView_ListOfUsers.AllowUserToResizeColumns = false;
            this.dataGridView_ListOfUsers.AllowUserToResizeRows = false;
            this.dataGridView_ListOfUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_ListOfUsers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_ListOfUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ListOfUsers.Location = new System.Drawing.Point(43, 18);
            this.dataGridView_ListOfUsers.Name = "dataGridView_ListOfUsers";
            this.dataGridView_ListOfUsers.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MintCream;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_ListOfUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_ListOfUsers.RowHeadersWidth = 82;
            this.dataGridView_ListOfUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_ListOfUsers.RowTemplate.Height = 80;
            this.dataGridView_ListOfUsers.Size = new System.Drawing.Size(1719, 705);
            this.dataGridView_ListOfUsers.TabIndex = 0;
            this.dataGridView_ListOfUsers.DoubleClick += new System.EventHandler(this.dataGridView_ListOfUsers_DoubleClick);
            // 
            // UserListForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1839, 899);
            this.Controls.Add(this.groupBox2);
            this.Name = "UserListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DANH SÁCH TÀI KHOẢN";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ListOfUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_TimKiemTheoTen;
        private System.Windows.Forms.TextBox textBox_TimKiemTheoMa;
        private System.Windows.Forms.PictureBox pictureBox_Refresh;
        private System.Windows.Forms.DataGridView dataGridView_ListOfUsers;
    }
}