namespace Algorithm_Dictionary.자료구조_Form.링크드리스트
{
    partial class LinkedList_New_Node
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
            this.tb_New_Node = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_New_Node
            // 
            this.tb_New_Node.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_New_Node.Location = new System.Drawing.Point(13, 13);
            this.tb_New_Node.Multiline = true;
            this.tb_New_Node.Name = "tb_New_Node";
            this.tb_New_Node.ReadOnly = true;
            this.tb_New_Node.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_New_Node.Size = new System.Drawing.Size(337, 382);
            this.tb_New_Node.TabIndex = 0;
            // 
            // LinkedList_New_Node
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(369, 407);
            this.Controls.Add(this.tb_New_Node);
            this.Name = "LinkedList_New_Node";
            this.Text = "LinkedList_New_Node";
            this.Load += new System.EventHandler(this.LinkedList_New_Node_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_New_Node;
    }
}