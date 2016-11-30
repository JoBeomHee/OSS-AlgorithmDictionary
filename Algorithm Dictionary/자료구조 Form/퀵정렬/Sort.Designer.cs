namespace Algorithm_Dictionary.자료구조_Form.퀵정렬
{
    partial class Sort
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
            this.tb_sort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_sort
            // 
            this.tb_sort.BackColor = System.Drawing.SystemColors.Window;
            this.tb_sort.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.tb_sort.Location = new System.Drawing.Point(14, 15);
            this.tb_sort.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tb_sort.Multiline = true;
            this.tb_sort.Name = "tb_sort";
            this.tb_sort.ReadOnly = true;
            this.tb_sort.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_sort.Size = new System.Drawing.Size(449, 429);
            this.tb_sort.TabIndex = 0;
            // 
            // Sort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(477, 459);
            this.Controls.Add(this.tb_sort);
            this.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Sort";
            this.Text = "Sort";
            this.Load += new System.EventHandler(this.Sort_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_sort;
    }
}