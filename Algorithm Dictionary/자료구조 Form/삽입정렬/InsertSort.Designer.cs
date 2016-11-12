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
            this.btn_return = new System.Windows.Forms.Button();
            this.lb_sort = new System.Windows.Forms.Label();
            this.btn_sort = new System.Windows.Forms.Button();
            this.tb_sort = new System.Windows.Forms.TextBox();
            this.lb_description = new System.Windows.Forms.Label();
            this.tb_description = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(317, 16);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(114, 33);
            this.btn_return.TabIndex = 18;
            this.btn_return.Text = "되돌아가기";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
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
            this.btn_sort.Location = new System.Drawing.Point(9, 374);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(93, 36);
            this.btn_sort.TabIndex = 13;
            this.btn_sort.Text = "정렬코드보기";
            this.btn_sort.UseVisualStyleBackColor = true;
            // 
            // tb_sort
            // 
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
            this.tb_description.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_description.Location = new System.Drawing.Point(9, 61);
            this.tb_description.Multiline = true;
            this.tb_description.Name = "tb_description";
            this.tb_description.ReadOnly = true;
            this.tb_description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_description.Size = new System.Drawing.Size(423, 111);
            this.tb_description.TabIndex = 10;
            // 
            // InsertSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(443, 432);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.lb_sort);
            this.Controls.Add(this.btn_sort);
            this.Controls.Add(this.tb_sort);
            this.Controls.Add(this.lb_description);
            this.Controls.Add(this.tb_description);
            this.Name = "InsertSort";
            this.Text = "삽입정렬";
            this.Load += new System.EventHandler(this.InsertSort_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Label lb_sort;
        private System.Windows.Forms.Button btn_sort;
        private System.Windows.Forms.TextBox tb_sort;
        private System.Windows.Forms.Label lb_description;
        private System.Windows.Forms.TextBox tb_description;
    }
}