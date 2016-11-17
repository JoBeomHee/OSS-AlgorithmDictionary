namespace Algorithm_Dictionary.자료구조_Form.큐
{
    partial class QueueInit
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
            this.tb_Init = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_Init
            // 
            this.tb_Init.BackColor = System.Drawing.SystemColors.Window;
            this.tb_Init.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold);
            this.tb_Init.Location = new System.Drawing.Point(10, 11);
            this.tb_Init.Multiline = true;
            this.tb_Init.Name = "tb_Init";
            this.tb_Init.ReadOnly = true;
            this.tb_Init.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Init.Size = new System.Drawing.Size(466, 214);
            this.tb_Init.TabIndex = 0;
            // 
            // QueueInit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(492, 245);
            this.Controls.Add(this.tb_Init);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "QueueInit";
            this.Text = "QueueInit";
            this.Load += new System.EventHandler(this.QueueInit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Init;
    }
}