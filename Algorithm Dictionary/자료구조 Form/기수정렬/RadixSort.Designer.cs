namespace Algorithm_Dictionary.자료구조_Form.기수정렬
{
    partial class RadixSort
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
            this.lb_sort = new System.Windows.Forms.Label();
            this.btn_sort = new System.Windows.Forms.Button();
            this.tb_sort = new System.Windows.Forms.TextBox();
            this.lb_description = new System.Windows.Forms.Label();
            this.tb_description = new System.Windows.Forms.TextBox();
            this.pb_back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_back)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(342, 521);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 12);
            this.label4.TabIndex = 50;
            this.label4.Text = "참고 사이트 :";
            // 
            // lb_link
            // 
            this.lb_link.AutoSize = true;
            this.lb_link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_link.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_link.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb_link.Location = new System.Drawing.Point(431, 521);
            this.lb_link.Name = "lb_link";
            this.lb_link.Size = new System.Drawing.Size(499, 12);
            this.lb_link.TabIndex = 49;
            this.lb_link.Text = "http://blog.naver.com/PostView.nhn?blogId=redwave102&logNo=80075364360";
            this.lb_link.Click += new System.EventHandler(this.lb_link_Click);
            // 
            // lb_sort
            // 
            this.lb_sort.AutoSize = true;
            this.lb_sort.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_sort.ForeColor = System.Drawing.Color.Teal;
            this.lb_sort.Location = new System.Drawing.Point(15, 191);
            this.lb_sort.Name = "lb_sort";
            this.lb_sort.Size = new System.Drawing.Size(172, 21);
            this.lb_sort.TabIndex = 47;
            this.lb_sort.Text = "기정렬 함수설명";
            // 
            // btn_sort
            // 
            this.btn_sort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sort.FlatAppearance.BorderSize = 0;
            this.btn_sort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sort.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_sort.Location = new System.Drawing.Point(344, 422);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(93, 36);
            this.btn_sort.TabIndex = 46;
            this.btn_sort.Text = "정렬코드보기";
            this.btn_sort.UseVisualStyleBackColor = true;
            this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // tb_sort
            // 
            this.tb_sort.BackColor = System.Drawing.SystemColors.Window;
            this.tb_sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tb_sort.Location = new System.Drawing.Point(14, 218);
            this.tb_sort.Multiline = true;
            this.tb_sort.Name = "tb_sort";
            this.tb_sort.ReadOnly = true;
            this.tb_sort.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_sort.Size = new System.Drawing.Size(423, 198);
            this.tb_sort.TabIndex = 45;
            // 
            // lb_description
            // 
            this.lb_description.AutoSize = true;
            this.lb_description.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_description.ForeColor = System.Drawing.Color.Teal;
            this.lb_description.Location = new System.Drawing.Point(8, 9);
            this.lb_description.Name = "lb_description";
            this.lb_description.Size = new System.Drawing.Size(258, 37);
            this.lb_description.TabIndex = 44;
            this.lb_description.Text = "기수정렬 설명";
            // 
            // tb_description
            // 
            this.tb_description.BackColor = System.Drawing.SystemColors.Window;
            this.tb_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tb_description.Location = new System.Drawing.Point(14, 57);
            this.tb_description.Multiline = true;
            this.tb_description.Name = "tb_description";
            this.tb_description.ReadOnly = true;
            this.tb_description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_description.Size = new System.Drawing.Size(423, 111);
            this.tb_description.TabIndex = 43;
            // 
            // pb_back
            // 
            this.pb_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_back.Image = global::Algorithm_Dictionary.Properties.Resources.돌아가기;
            this.pb_back.Location = new System.Drawing.Point(848, 9);
            this.pb_back.Name = "pb_back";
            this.pb_back.Size = new System.Drawing.Size(68, 48);
            this.pb_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_back.TabIndex = 48;
            this.pb_back.TabStop = false;
            this.pb_back.Click += new System.EventHandler(this.pb_back_Click);
            // 
            // RadixSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(930, 547);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_link);
            this.Controls.Add(this.pb_back);
            this.Controls.Add(this.lb_sort);
            this.Controls.Add(this.btn_sort);
            this.Controls.Add(this.tb_sort);
            this.Controls.Add(this.lb_description);
            this.Controls.Add(this.tb_description);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RadixSort";
            this.Text = "RadixSort";
            this.Load += new System.EventHandler(this.RadixSort_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_link;
        private System.Windows.Forms.PictureBox pb_back;
        private System.Windows.Forms.Label lb_sort;
        private System.Windows.Forms.Button btn_sort;
        private System.Windows.Forms.TextBox tb_sort;
        private System.Windows.Forms.Label lb_description;
        private System.Windows.Forms.TextBox tb_description;
    }
}