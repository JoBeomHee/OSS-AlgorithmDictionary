namespace Algorithm_Dictionary.자료구조_Form.다익스트라
{
    partial class Dijkstra
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
            this.label4 = new System.Windows.Forms.Label();
            this.lb_link = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Graph = new System.Windows.Forms.Button();
            this.tb_Graph = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_description = new System.Windows.Forms.TextBox();
            this.pb_back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_back)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(339, 511);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 12);
            this.label4.TabIndex = 40;
            this.label4.Text = "참고 사이트 :";
            // 
            // lb_link
            // 
            this.lb_link.AutoSize = true;
            this.lb_link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_link.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_link.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb_link.Location = new System.Drawing.Point(428, 511);
            this.lb_link.Name = "lb_link";
            this.lb_link.Size = new System.Drawing.Size(165, 12);
            this.lb_link.TabIndex = 39;
            this.lb_link.Text = "http://ehclub.co.kr/1583";
            this.lb_link.Click += new System.EventHandler(this.lb_link_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Search.Location = new System.Drawing.Point(521, 443);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(72, 36);
            this.btn_Search.TabIndex = 37;
            this.btn_Search.Text = "탐색 함수 ";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tb_Search
            // 
            this.tb_Search.BackColor = System.Drawing.SystemColors.Window;
            this.tb_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tb_Search.Location = new System.Drawing.Point(8, 361);
            this.tb_Search.Multiline = true;
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.ReadOnly = true;
            this.tb_Search.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Search.Size = new System.Drawing.Size(585, 76);
            this.tb_Search.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(6, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 21);
            this.label3.TabIndex = 35;
            this.label3.Text = "다익스트라 탐색";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(6, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 21);
            this.label2.TabIndex = 34;
            this.label2.Text = "다익스트라 그래프";
            // 
            // btn_Graph
            // 
            this.btn_Graph.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Graph.FlatAppearance.BorderSize = 0;
            this.btn_Graph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Graph.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Graph.Location = new System.Drawing.Point(477, 295);
            this.btn_Graph.Name = "btn_Graph";
            this.btn_Graph.Size = new System.Drawing.Size(116, 36);
            this.btn_Graph.TabIndex = 33;
            this.btn_Graph.Text = "2차원배열 그래프";
            this.btn_Graph.UseVisualStyleBackColor = true;
            this.btn_Graph.Click += new System.EventHandler(this.btn_Graph_Click);
            // 
            // tb_Graph
            // 
            this.tb_Graph.BackColor = System.Drawing.SystemColors.Window;
            this.tb_Graph.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tb_Graph.Location = new System.Drawing.Point(10, 213);
            this.tb_Graph.Multiline = true;
            this.tb_Graph.Name = "tb_Graph";
            this.tb_Graph.ReadOnly = true;
            this.tb_Graph.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Graph.Size = new System.Drawing.Size(583, 76);
            this.tb_Graph.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(1, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 37);
            this.label1.TabIndex = 31;
            this.label1.Text = "다익스트라 설명";
            // 
            // tb_description
            // 
            this.tb_description.BackColor = System.Drawing.SystemColors.Window;
            this.tb_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tb_description.Location = new System.Drawing.Point(9, 58);
            this.tb_description.Multiline = true;
            this.tb_description.Name = "tb_description";
            this.tb_description.ReadOnly = true;
            this.tb_description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_description.Size = new System.Drawing.Size(584, 111);
            this.tb_description.TabIndex = 30;
            // 
            // pb_back
            // 
            this.pb_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_back.Image = global::Algorithm_Dictionary.Properties.Resources.돌아가기;
            this.pb_back.Location = new System.Drawing.Point(525, 4);
            this.pb_back.Name = "pb_back";
            this.pb_back.Size = new System.Drawing.Size(68, 48);
            this.pb_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_back.TabIndex = 38;
            this.pb_back.TabStop = false;
            this.pb_back.Click += new System.EventHandler(this.pb_back_Click);
            // 
            // Dijkstra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(604, 540);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_link);
            this.Controls.Add(this.pb_back);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Graph);
            this.Controls.Add(this.tb_Graph);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_description);
            this.Name = "Dijkstra";
            this.Text = "Dijkstra";
            this.Load += new System.EventHandler(this.Dijkstra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_link;
        private System.Windows.Forms.PictureBox pb_back;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Graph;
        private System.Windows.Forms.TextBox tb_Graph;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_description;
    }
}