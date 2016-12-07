namespace Algorithm_Dictionary.자료구조_Form.프림알고리즘
{
    partial class Search
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
            this.pb_Result = new System.Windows.Forms.PictureBox();
            this.pb_Graph = new System.Windows.Forms.PictureBox();
            this.tb_Search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Graph)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Result
            // 
            this.pb_Result.Image = global::Algorithm_Dictionary.Properties.Resources.프림알고리즘_구현;
            this.pb_Result.Location = new System.Drawing.Point(488, 282);
            this.pb_Result.Name = "pb_Result";
            this.pb_Result.Size = new System.Drawing.Size(455, 262);
            this.pb_Result.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Result.TabIndex = 6;
            this.pb_Result.TabStop = false;
            // 
            // pb_Graph
            // 
            this.pb_Graph.Image = global::Algorithm_Dictionary.Properties.Resources.프림알고리즘_그래프_방문후_;
            this.pb_Graph.Location = new System.Drawing.Point(11, 282);
            this.pb_Graph.Name = "pb_Graph";
            this.pb_Graph.Size = new System.Drawing.Size(459, 262);
            this.pb_Graph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Graph.TabIndex = 5;
            this.pb_Graph.TabStop = false;
            // 
            // tb_Search
            // 
            this.tb_Search.BackColor = System.Drawing.SystemColors.Window;
            this.tb_Search.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.tb_Search.Location = new System.Drawing.Point(11, 12);
            this.tb_Search.Multiline = true;
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.ReadOnly = true;
            this.tb_Search.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Search.Size = new System.Drawing.Size(932, 239);
            this.tb_Search.TabIndex = 4;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(955, 556);
            this.Controls.Add(this.pb_Result);
            this.Controls.Add(this.pb_Graph);
            this.Controls.Add(this.tb_Search);
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Graph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Result;
        private System.Windows.Forms.PictureBox pb_Graph;
        private System.Windows.Forms.TextBox tb_Search;
    }
}