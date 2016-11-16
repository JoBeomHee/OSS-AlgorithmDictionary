namespace Algorithm_Dictionary.자료구조_Form.큐
{
    partial class DeQueue
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
            this.tb_dqqueue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_dqqueue
            // 
            this.tb_dqqueue.BackColor = System.Drawing.SystemColors.Window;
            this.tb_dqqueue.Font = new System.Drawing.Font("한컴바탕확장", 14.25F, System.Drawing.FontStyle.Bold);
            this.tb_dqqueue.Location = new System.Drawing.Point(15, 13);
            this.tb_dqqueue.Multiline = true;
            this.tb_dqqueue.Name = "tb_dqqueue";
            this.tb_dqqueue.ReadOnly = true;
            this.tb_dqqueue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_dqqueue.Size = new System.Drawing.Size(542, 386);
            this.tb_dqqueue.TabIndex = 0;
            // 
            // DeQueue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(569, 422);
            this.Controls.Add(this.tb_dqqueue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DeQueue";
            this.Text = "DeQueue";
            this.Load += new System.EventHandler(this.DeQueue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_dqqueue;
    }
}