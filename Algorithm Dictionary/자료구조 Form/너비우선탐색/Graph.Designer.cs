namespace Algorithm_Dictionary.자료구조_Form.너비우선탐색
{
    partial class Graph
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
            this.tb_Graph = new System.Windows.Forms.TextBox();
            this.pb_Graph = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Graph)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Graph
            // 
            this.tb_Graph.BackColor = System.Drawing.SystemColors.Window;
            this.tb_Graph.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.tb_Graph.Location = new System.Drawing.Point(11, 12);
            this.tb_Graph.Multiline = true;
            this.tb_Graph.Name = "tb_Graph";
            this.tb_Graph.ReadOnly = true;
            this.tb_Graph.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Graph.Size = new System.Drawing.Size(392, 239);
            this.tb_Graph.TabIndex = 2;
            // 
            // pb_Graph
            // 
            this.pb_Graph.Image = global::Algorithm_Dictionary.Properties.Resources.너비우선탐색_그래프_;
            this.pb_Graph.Location = new System.Drawing.Point(14, 276);
            this.pb_Graph.Name = "pb_Graph";
            this.pb_Graph.Size = new System.Drawing.Size(388, 262);
            this.pb_Graph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Graph.TabIndex = 3;
            this.pb_Graph.TabStop = false;
            // 
            // Graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(415, 550);
            this.Controls.Add(this.pb_Graph);
            this.Controls.Add(this.tb_Graph);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Graph";
            this.Text = "Graph";
            this.Load += new System.EventHandler(this.Graph_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Graph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Graph;
        private System.Windows.Forms.TextBox tb_Graph;
    }
}