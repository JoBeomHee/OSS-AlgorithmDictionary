namespace Algorithm_Dictionary.자료구조_Form.큐
{
    partial class EnQueue
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
            this.tb_enqueue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_enqueue
            // 
            this.tb_enqueue.BackColor = System.Drawing.SystemColors.Window;
            this.tb_enqueue.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold);
            this.tb_enqueue.Location = new System.Drawing.Point(10, 18);
            this.tb_enqueue.Multiline = true;
            this.tb_enqueue.Name = "tb_enqueue";
            this.tb_enqueue.ReadOnly = true;
            this.tb_enqueue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_enqueue.Size = new System.Drawing.Size(539, 329);
            this.tb_enqueue.TabIndex = 0;
            // 
            // EnQueue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(571, 370);
            this.Controls.Add(this.tb_enqueue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EnQueue";
            this.Text = "EnQueue";
            this.Load += new System.EventHandler(this.EnQueue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_enqueue;
    }
}