namespace Algorithm_Dictionary.자료구조_Form.링크드리스트
{
    partial class LinkedList_PushBack
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
            this.tb_PushBack = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_PushBack
            // 
            this.tb_PushBack.BackColor = System.Drawing.SystemColors.Window;
            this.tb_PushBack.Font = new System.Drawing.Font("한컴바탕확장", 14.25F, System.Drawing.FontStyle.Bold);
            this.tb_PushBack.Location = new System.Drawing.Point(18, 19);
            this.tb_PushBack.Multiline = true;
            this.tb_PushBack.Name = "tb_PushBack";
            this.tb_PushBack.ReadOnly = true;
            this.tb_PushBack.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_PushBack.Size = new System.Drawing.Size(326, 221);
            this.tb_PushBack.TabIndex = 0;
            // 
            // LinkedList_PushBack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(359, 257);
            this.Controls.Add(this.tb_PushBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LinkedList_PushBack";
            this.Text = "LinkedList_PushBack";
            this.Load += new System.EventHandler(this.LinkedList_PushBack_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_PushBack;
    }
}