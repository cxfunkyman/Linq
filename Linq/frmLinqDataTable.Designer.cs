namespace Linq
{
    partial class frmLinqDataTable
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
            this.dataGridViewResultCourse = new System.Windows.Forms.DataGridView();
            this.comboBoxSelectCourse = new System.Windows.Forms.ComboBox();
            this.labelSelectCourse = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewResultCourse
            // 
            this.dataGridViewResultCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultCourse.Location = new System.Drawing.Point(13, 76);
            this.dataGridViewResultCourse.Name = "dataGridViewResultCourse";
            this.dataGridViewResultCourse.Size = new System.Drawing.Size(543, 346);
            this.dataGridViewResultCourse.TabIndex = 5;
            this.dataGridViewResultCourse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewResultCourse_CellContentClick);
            // 
            // comboBoxSelectCourse
            // 
            this.comboBoxSelectCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectCourse.FormattingEnabled = true;
            this.comboBoxSelectCourse.Location = new System.Drawing.Point(146, 29);
            this.comboBoxSelectCourse.Name = "comboBoxSelectCourse";
            this.comboBoxSelectCourse.Size = new System.Drawing.Size(214, 28);
            this.comboBoxSelectCourse.TabIndex = 4;
            this.comboBoxSelectCourse.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectCourse_SelectedIndexChanged);
            // 
            // labelSelectCourse
            // 
            this.labelSelectCourse.AutoSize = true;
            this.labelSelectCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectCourse.Location = new System.Drawing.Point(10, 32);
            this.labelSelectCourse.Name = "labelSelectCourse";
            this.labelSelectCourse.Size = new System.Drawing.Size(119, 20);
            this.labelSelectCourse.TabIndex = 3;
            this.labelSelectCourse.Text = "Select a course";
            // 
            // frmLinqDataTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 450);
            this.Controls.Add(this.dataGridViewResultCourse);
            this.Controls.Add(this.comboBoxSelectCourse);
            this.Controls.Add(this.labelSelectCourse);
            this.Name = "frmLinqDataTable";
            this.Text = "Data Table";
            this.Load += new System.EventHandler(this.frmLinqDataTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewResultCourse;
        private System.Windows.Forms.ComboBox comboBoxSelectCourse;
        private System.Windows.Forms.Label labelSelectCourse;
    }
}