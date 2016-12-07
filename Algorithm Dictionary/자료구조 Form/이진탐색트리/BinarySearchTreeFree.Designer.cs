namespace Algorithm_Dictionary.자료구조_Form.이진탐색트리
{
    partial class BinarySearchTreeFree
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
            this.tb_free = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_free
            // 
            this.tb_free.BackColor = System.Drawing.SystemColors.Window;
            this.tb_free.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold);
            this.tb_free.Location = new System.Drawing.Point(11, 15);
            this.tb_free.Multiline = true;
            this.tb_free.Name = "tb_free";
            this.tb_free.ReadOnly = true;
            this.tb_free.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_free.Size = new System.Drawing.Size(513, 347);
            this.tb_free.TabIndex = 0;
            // 
            // BinarySearchTreeFree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(541, 372);
            this.Controls.Add(this.tb_free);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BinarySearchTreeFree";
            this.Text = "BinarySearchTreeFree";
            this.Load += new System.EventHandler(this.BinarySearchTreeFree_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_free;
    }
}