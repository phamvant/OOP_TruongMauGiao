
namespace OOP_TruongMauGiao
{
    partial class HelloWorldForm
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
            this.dataGridView_Test = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Test)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Test
            // 
            this.dataGridView_Test.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Test.Location = new System.Drawing.Point(89, 38);
            this.dataGridView_Test.Name = "dataGridView_Test";
            this.dataGridView_Test.RowHeadersWidth = 82;
            this.dataGridView_Test.RowTemplate.Height = 33;
            this.dataGridView_Test.Size = new System.Drawing.Size(1281, 673);
            this.dataGridView_Test.TabIndex = 0;
            // 
            // HelloWorldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 827);
            this.Controls.Add(this.dataGridView_Test);
            this.Name = "HelloWorldForm";
            this.Text = "HelloWorldForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Test)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Test;
    }
}