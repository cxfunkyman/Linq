namespace Linq
{
    partial class frmLinq
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
            this.labelSelectProgram = new System.Windows.Forms.Label();
            this.comboBoxSelectProgram = new System.Windows.Forms.ComboBox();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSelectProgram
            // 
            this.labelSelectProgram.AutoSize = true;
            this.labelSelectProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectProgram.Location = new System.Drawing.Point(17, 31);
            this.labelSelectProgram.Name = "labelSelectProgram";
            this.labelSelectProgram.Size = new System.Drawing.Size(130, 20);
            this.labelSelectProgram.TabIndex = 0;
            this.labelSelectProgram.Text = "Select a program";
            // 
            // comboBoxSelectProgram
            // 
            this.comboBoxSelectProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectProgram.FormattingEnabled = true;
            this.comboBoxSelectProgram.Location = new System.Drawing.Point(153, 28);
            this.comboBoxSelectProgram.Name = "comboBoxSelectProgram";
            this.comboBoxSelectProgram.Size = new System.Drawing.Size(214, 28);
            this.comboBoxSelectProgram.TabIndex = 1;
            this.comboBoxSelectProgram.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectProgram_SelectedIndexChanged);
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.Location = new System.Drawing.Point(20, 75);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.Size = new System.Drawing.Size(543, 346);
            this.dataGridViewResult.TabIndex = 2;
            // 
            // frmLinq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 450);
            this.Controls.Add(this.dataGridViewResult);
            this.Controls.Add(this.comboBoxSelectProgram);
            this.Controls.Add(this.labelSelectProgram);
            this.Name = "frmLinq";
            this.Text = "Linq";
            this.Load += new System.EventHandler(this.frmLinq_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSelectProgram;
        private System.Windows.Forms.ComboBox comboBoxSelectProgram;
        private System.Windows.Forms.DataGridView dataGridViewResult;
    }
}

