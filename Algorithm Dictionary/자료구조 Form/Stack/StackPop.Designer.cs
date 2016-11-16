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
            this.pb_pop = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pop)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_pop
            // 
            this.tb_pop.BackColor = System.Drawing.SystemColors.Window;
            this.tb_pop.Font = new System.Drawing.Font("한컴바탕확장", 12F, System.Drawing.FontStyle.Bold);
            this.tb_pop.Location = new System.Drawing.Point(18, 26);
            this.tb_pop.Multiline = true;
            this.tb_pop.Name = "tb_pop";
            this.tb_pop.ReadOnly = true;
            this.tb_pop.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_pop.Size = new System.Drawing.Size(555, 209);
            this.tb_pop.TabIndex = 0;
            // 
            // pb_pop
            // 
            this.pb_pop.Image = global::Algorithm_Dictionary.Properties.Resources.스택_삭제_;
            this.pb_pop.Location = new System.Drawing.Point(18, 241);
            this.pb_pop.Name = "pb_pop";
            this.pb_pop.Size = new System.Drawing.Size(555, 266);
            this.pb_pop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_pop.TabIndex = 1;
            this.pb_pop.TabStop = false;
            // 
            // StackPop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(585, 519);
            this.Controls.Add(this.pb_pop);
            this.Controls.Add(this.tb_pop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StackPop";
            this.Text = "StackPop";
            this.Load += new System.EventHandler(this.StackPop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_pop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_pop;
        private System.Windows.Forms.PictureBox pb_pop;
    }
}