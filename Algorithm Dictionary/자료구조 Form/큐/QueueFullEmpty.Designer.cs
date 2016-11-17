namespace Algorithm_Dictionary.자료구조_Form.큐
{
    partial class QueueFullEmpty
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
            this.tb_FullEmpty = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_FullEmpty
            // 
            this.tb_FullEmpty.BackColor = System.Drawing.SystemColors.Window;
            this.tb_FullEmpty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_FullEmpty.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold);
            this.tb_FullEmpty.Location = new System.Drawing.Point(11, 15);
            this.tb_FullEmpty.Multiline = true;
            this.tb_FullEmpty.Name = "tb_FullEmpty";
            this.tb_FullEmpty.ReadOnly = true;
            this.tb_FullEmpty.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_FullEmpty.Size = new System.Drawing.Size(524, 278);
            this.tb_FullEmpty.TabIndex = 0;
            // 
            // QueueFullEmpty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(544, 353);
            this.Controls.Add(this.tb_FullEmpty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "QueueFullEmpty";
            this.Text = "QueueFullEmpty";
            this.Load += new System.EventHandler(this.QueueFullEmpty_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_FullEmpty;
    }
}