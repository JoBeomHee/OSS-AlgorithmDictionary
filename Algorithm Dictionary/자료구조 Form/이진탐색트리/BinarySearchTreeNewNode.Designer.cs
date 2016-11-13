namespace Algorithm_Dictionary.자료구조_Form.이진탐색트리
{
    partial class BinarySearchTreeNewNode
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
            this.tb_NewNode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_NewNode
            // 
            this.tb_NewNode.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_NewNode.Location = new System.Drawing.Point(3, 11);
            this.tb_NewNode.Multiline = true;
            this.tb_NewNode.Name = "tb_NewNode";
            this.tb_NewNode.ReadOnly = true;
            this.tb_NewNode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_NewNode.Size = new System.Drawing.Size(324, 142);
            this.tb_NewNode.TabIndex = 0;
            // 
            // BinarySearchTreeNewNode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 163);
            this.Controls.Add(this.tb_NewNode);
            this.Name = "BinarySearchTreeNewNode";
            this.Text = "BinarySearchTreeNewNode";
            this.Load += new System.EventHandler(this.BinarySearchTreeNewNode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_NewNode;
    }
}