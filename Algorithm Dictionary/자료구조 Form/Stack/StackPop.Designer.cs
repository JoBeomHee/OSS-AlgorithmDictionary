namespace Algorithm_Dictionary.자료구조_Form.Stack
{
    partial class StackPop
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
            this.tb_pop = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_pop
            // 
            this.tb_pop.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_pop.Location = new System.Drawing.Point(18, 26);
            this.tb_pop.Multiline = true;
            this.tb_pop.Name = "tb_pop";
            this.tb_pop.ReadOnly = true;
            this.tb_pop.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_pop.Size = new System.Drawing.Size(303, 386);
            this.tb_pop.TabIndex = 0;
            // 
            // StackPop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 424);
            this.Controls.Add(this.tb_pop);
            this.Name = "StackPop";
            this.Text = "StackPop";
            this.Load += new System.EventHandler(this.StackPop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_pop;
    }
}