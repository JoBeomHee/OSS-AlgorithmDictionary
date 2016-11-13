namespace Algorithm_Dictionary.자료구조_Form.삽입정렬
{
    partial class InsertSort
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
            this.lb_sort = new System.Windows.Forms.Label();
            this.btn_sort = new System.Windows.Forms.Button();
            this.tb_sort = new System.Windows.Forms.TextBox();
            this.lb_description = new System.Windows.Forms.Label();
            this.tb_description = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.pb_insertSort = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_insertSort)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_sort
            // 
            this.lb_sort.AutoSize = true;
            this.lb_sort.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_sort.ForeColor = System.Drawing.Color.Teal;
            this.lb_sort.Location = new System.Drawing.Point(10, 195);
            this.lb_sort.Name = "lb_sort";
            this.lb_sort.Size = new System.Drawing.Size(194, 21);
            this.lb_sort.TabIndex = 16;
            this.lb_sort.Text = "삽입정렬 함수설명";
            // 
            // btn_sort
            // 
            this.btn_sort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sort.FlatAppearance.BorderSize = 0;
            this.btn_sort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sort.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_sort.Location = new System.Drawing.Point(339, 374);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(93, 36);
            this.btn_sort.TabIndex = 13;
            this.btn_sort.Text = "정렬코드보기";
            this.btn_sort.UseVisualStyleBackColor = true;
            this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // tb_sort
            // 
            this.tb_sort.BackColor = System.Drawing.SystemColors.Window;
            this.tb_sort.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_sort.Location = new System.Drawing.Point(9, 222);
            this.tb_sort.Multiline = true;
            this.tb_sort.Name = "tb_sort";
            this.tb_sort.ReadOnly = true;
            this.tb_sort.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_sort.Size = new System.Drawing.Size(423, 146);
            this.tb_sort.TabIndex = 12;
            // 
            // lb_description
            // 
            this.lb_description.AutoSize = true;
            this.lb_description.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_description.ForeColor = System.Drawing.Color.Teal;
            this.lb_description.Location = new System.Drawing.Point(3, 13);
            this.lb_description.Name = "lb_description";
            this.lb_description.Size = new System.Drawing.Size(258, 37);
            this.lb_description.TabIndex = 11;
            this.lb_description.Text = "삽입정렬 설명";
            // 
            // tb_description
            // 
            this.tb_description.BackColor = System.Drawing.SystemColors.Window;
            this.tb_description.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_description.Location = new System.Drawing.Point(9, 61);
            this.tb_description.Multiline = true;
            this.tb_description.Name = "tb_description";
            this.tb_description.ReadOnly = true;
            this.tb_description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_description.Size = new System.Drawing.Size(423, 111);
            this.tb_description.TabIndex = 10;
            // 
            // btn_back
            // 
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("굴림", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_back.Location = new System.Drawing.Point(900, 1);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(81, 54);
            this.btn_back.TabIndex = 19;
            this.btn_back.Text = "←";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // pb_insertSort
            // 
            this.pb_insertSort.Image = global::Algorithm_Dictionary.Properties.Resources.삽입정렬;
            this.pb_insertSort.Location = new System.Drawing.Point(450, 61);
            this.pb_insertSort.Name = "pb_insertSort";
            this.pb_insertSort.Size = new System.Drawing.Size(531, 395);
            this.pb_insertSort.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_insertSort.TabIndex = 20;
            this.pb_insertSort.TabStop = false;
            // 
            // InsertSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(988, 468);
            this.ControlBox = false;
            this.Controls.Add(this.pb_insertSort);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lb_sort);
            this.Controls.Add(this.btn_sort);
            this.Controls.Add(this.tb_sort);
            this.Controls.Add(this.lb_description);
            this.Controls.Add(this.tb_description);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "InsertSort";
            this.Text = "삽입정렬";
            this.Load += new System.EventHandler(this.InsertSort_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_insertSort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_sort;
        private System.Windows.Forms.Button btn_sort;
        private System.Windows.Forms.TextBox tb_sort;
        private System.Windows.Forms.Label lb_description;
        private System.Windows.Forms.TextBox tb_description;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.PictureBox pb_insertSort;
    }
}