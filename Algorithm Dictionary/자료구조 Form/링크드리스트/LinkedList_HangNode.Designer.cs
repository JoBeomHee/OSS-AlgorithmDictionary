namespace Algorithm_Dictionary.자료구조_Form.링크드리스트
{
    partial class LinkedList_HangNode
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
            this.tb_HangNode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_HangNode
            // 
            this.tb_HangNode.BackColor = System.Drawing.SystemColors.Window;
            this.tb_HangNode.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_HangNode.Location = new System.Drawing.Point(9, 14);
            this.tb_HangNode.Multiline = true;
            this.tb_HangNode.Name = "tb_HangNode";
            this.tb_HangNode.ReadOnly = true;
            this.tb_HangNode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_HangNode.Size = new System.Drawing.Size(335, 317);
            this.tb_HangNode.TabIndex = 0;
            // 
            // LinkedList_HangNode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(356, 355);
            this.Controls.Add(this.tb_HangNode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LinkedList_HangNode";
            this.Text = "LinkedList_HangNode";
            this.Load += new System.EventHandler(this.LinkedList_HangNode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_HangNode;
    }
}