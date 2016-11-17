namespace Algorithm_Dictionary.자료구조_Form.큐
{
    partial class QueueDispose
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
            this.tb_dispose = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_dispose
            // 
            this.tb_dispose.BackColor = System.Drawing.SystemColors.Window;
            this.tb_dispose.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold);
            this.tb_dispose.Location = new System.Drawing.Point(10, 11);
            this.tb_dispose.Multiline = true;
            this.tb_dispose.Name = "tb_dispose";
            this.tb_dispose.ReadOnly = true;
            this.tb_dispose.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_dispose.Size = new System.Drawing.Size(518, 142);
            this.tb_dispose.TabIndex = 0;
            // 
            // QueueDispose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(547, 190);
            this.Controls.Add(this.tb_dispose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "QueueDispose";
            this.Text = "QueueDispose";
            this.Load += new System.EventHandler(this.QueueDispose_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_dispose;
    }
}