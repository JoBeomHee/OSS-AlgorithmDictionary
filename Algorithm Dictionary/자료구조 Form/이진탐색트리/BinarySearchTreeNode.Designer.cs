namespace Algorithm_Dictionary.자료구조_Form.이진탐색트리
{
    partial class BinarySearchTreeNode
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
            this.tb_newNode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_newNode
            // 
            this.tb_newNode.BackColor = System.Drawing.SystemColors.Window;
            this.tb_newNode.Font = new System.Drawing.Font("한컴바탕확장", 14.25F, System.Drawing.FontStyle.Bold);
            this.tb_newNode.Location = new System.Drawing.Point(14, 16);
            this.tb_newNode.Multiline = true;
            this.tb_newNode.Name = "tb_newNode";
            this.tb_newNode.ReadOnly = true;
            this.tb_newNode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_newNode.Size = new System.Drawing.Size(310, 275);
            this.tb_newNode.TabIndex = 0;
            // 
            // BinarySearchTreeNode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(334, 305);
            this.Controls.Add(this.tb_newNode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BinarySearchTreeNode";
            this.Text = "BinarySearchTreeNode";
            this.Load += new System.EventHandler(this.BinarySearchTreeNode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_newNode;
    }
}