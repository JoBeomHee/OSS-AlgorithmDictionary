namespace Algorithm_Dictionary.자료구조_Form.링크드리스트
{
    partial class LinkedList_Malloclist
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
            this.tb_malloclist = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_malloclist
            // 
            this.tb_malloclist.BackColor = System.Drawing.SystemColors.Window;
            this.tb_malloclist.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_malloclist.Location = new System.Drawing.Point(18, 20);
            this.tb_malloclist.Multiline = true;
            this.tb_malloclist.Name = "tb_malloclist";
            this.tb_malloclist.ReadOnly = true;
            this.tb_malloclist.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_malloclist.Size = new System.Drawing.Size(344, 407);
            this.tb_malloclist.TabIndex = 0;
            // 
            // LinkedList_Malloclist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(382, 439);
            this.Controls.Add(this.tb_malloclist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LinkedList_Malloclist";
            this.Text = "LinkedList 동적생성";
            this.Load += new System.EventHandler(this.LinkedList_Malloclist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_malloclist;
    }
}