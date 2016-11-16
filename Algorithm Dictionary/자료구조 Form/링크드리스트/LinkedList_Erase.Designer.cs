namespace Algorithm_Dictionary.자료구조_Form.링크드리스트
{
    partial class LinkedList_Erase
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
            this.tb_Erase = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_Erase
            // 
            this.tb_Erase.BackColor = System.Drawing.SystemColors.Window;
            this.tb_Erase.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold);
            this.tb_Erase.Location = new System.Drawing.Point(12, 13);
            this.tb_Erase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Erase.Multiline = true;
            this.tb_Erase.Name = "tb_Erase";
            this.tb_Erase.ReadOnly = true;
            this.tb_Erase.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Erase.Size = new System.Drawing.Size(791, 482);
            this.tb_Erase.TabIndex = 0;
            // 
            // LinkedList_Erase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(815, 517);
            this.Controls.Add(this.tb_Erase);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LinkedList_Erase";
            this.Text = "LinkedList_Erase";
            this.Load += new System.EventHandler(this.LinkedList_Erase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Erase;
    }
}