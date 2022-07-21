namespace Linq
{
    partial class frmLinQ
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
            this.lblSelect = new System.Windows.Forms.Label();
            this.cboProgram = new System.Windows.Forms.ComboBox();
            this.GridResult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridResult)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(63, 66);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(114, 16);
            this.lblSelect.TabIndex = 0;
            this.lblSelect.Text = "Select a Program:";
            // 
            // cboProgram
            // 
            this.cboProgram.FormattingEnabled = true;
            this.cboProgram.Location = new System.Drawing.Point(195, 66);
            this.cboProgram.Name = "cboProgram";
            this.cboProgram.Size = new System.Drawing.Size(214, 24);
            this.cboProgram.TabIndex = 1;
            this.cboProgram.SelectedIndexChanged += new System.EventHandler(this.cboProgram_SelectedIndexChanged);
            // 
            // GridResult
            // 
            this.GridResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridResult.Location = new System.Drawing.Point(66, 115);
            this.GridResult.Name = "GridResult";
            this.GridResult.RowHeadersWidth = 51;
            this.GridResult.RowTemplate.Height = 24;
            this.GridResult.Size = new System.Drawing.Size(660, 291);
            this.GridResult.TabIndex = 2;
            // 
            // frmLinQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GridResult);
            this.Controls.Add(this.cboProgram);
            this.Controls.Add(this.lblSelect);
            this.Name = "frmLinQ";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmLinQ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.ComboBox cboProgram;
        private System.Windows.Forms.DataGridView GridResult;
    }
}

