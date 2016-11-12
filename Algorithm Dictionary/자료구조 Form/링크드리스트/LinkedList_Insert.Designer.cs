namespace Algorithm_Dictionary.자료구조_Form.링크드리스트
{
    partial class LinkedList_Insert
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
            this.tb_insert = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_insert
            // 
            this.tb_insert.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_insert.Location = new System.Drawing.Point(13, 9);
            this.tb_insert.Multiline = true;
            this.tb_insert.Name = "tb_insert";
            this.tb_insert.ReadOnly = true;
            this.tb_insert.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_insert.Size = new System.Drawing.Size(323, 394);
            this.tb_insert.TabIndex = 0;
            // 
            // LinkedList_Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(352, 415);
            this.Controls.Add(this.tb_insert);
            this.Name = "LinkedList_Insert";
            this.Text = "LinkedList_Insert";
            this.Load += new System.EventHandler(this.LinkedList_Insert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_insert;
    }
}