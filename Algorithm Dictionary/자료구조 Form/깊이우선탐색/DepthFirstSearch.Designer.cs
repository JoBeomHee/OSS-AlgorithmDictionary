namespace Algorithm_Dictionary.자료구조_Form.깊이우선탐색
{
    partial class DepthFirstSearch
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_New_Node = new System.Windows.Forms.Button();
            this.tb_New_Node = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_description = new System.Windows.Forms.TextBox();
            this.tb_New = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(7, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "깊이우선탐색 동적생성";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(7, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "깊이우선탐색 생성함수";
            // 
            // btn_New_Node
            // 
            this.btn_New_Node.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_New_Node.FlatAppearance.BorderSize = 0;
            this.btn_New_Node.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_New_Node.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_New_Node.Location = new System.Drawing.Point(350, 302);
            this.btn_New_Node.Name = "btn_New_Node";
            this.btn_New_Node.Size = new System.Drawing.Size(104, 36);
            this.btn_New_Node.TabIndex = 21;
            this.btn_New_Node.Text = "Node생성함수 ";
            this.btn_New_Node.UseVisualStyleBackColor = true;
            // 
            // tb_New_Node
            // 
            this.tb_New_Node.BackColor = System.Drawing.SystemColors.Window;
            this.tb_New_Node.Font = new System.Drawing.Font("한컴바탕확장", 12F, System.Drawing.FontStyle.Bold);
            this.tb_New_Node.Location = new System.Drawing.Point(11, 214);
            this.tb_New_Node.Multiline = true;
            this.tb_New_Node.Name = "tb_New_Node";
            this.tb_New_Node.ReadOnly = true;
            this.tb_New_Node.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_New_Node.Size = new System.Drawing.Size(444, 76);
            this.tb_New_Node.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(2, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 37);
            this.label1.TabIndex = 19;
            this.label1.Text = "깊이우선탐색 설명";
            // 
            // tb_description
            // 
            this.tb_description.BackColor = System.Drawing.SystemColors.Window;
            this.tb_description.Font = new System.Drawing.Font("한컴바탕확장", 12F, System.Drawing.FontStyle.Bold);
            this.tb_description.Location = new System.Drawing.Point(10, 59);
            this.tb_description.Multiline = true;
            this.tb_description.Name = "tb_description";
            this.tb_description.ReadOnly = true;
            this.tb_description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_description.Size = new System.Drawing.Size(444, 111);
            this.tb_description.TabIndex = 18;
            // 
            // tb_New
            // 
            this.tb_New.BackColor = System.Drawing.SystemColors.Window;
            this.tb_New.Font = new System.Drawing.Font("한컴바탕확장", 12F, System.Drawing.FontStyle.Bold);
            this.tb_New.Location = new System.Drawing.Point(9, 362);
            this.tb_New.Multiline = true;
            this.tb_New.Name = "tb_New";
            this.tb_New.ReadOnly = true;
            this.tb_New.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_New.Size = new System.Drawing.Size(444, 76);
            this.tb_New.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(349, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 36);
            this.button1.TabIndex = 25;
            this.button1.Text = "성동적생함수 ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_back
            // 
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("굴림", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_back.Location = new System.Drawing.Point(902, -1);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(81, 54);
            this.btn_back.TabIndex = 26;
            this.btn_back.Text = "←";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // DepthFirstSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(983, 585);
            this.ControlBox = false;
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_New);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_New_Node);
            this.Controls.Add(this.tb_New_Node);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_description);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DepthFirstSearch";
            this.Text = "DepthFirstSearch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_New_Node;
        private System.Windows.Forms.TextBox tb_New_Node;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_description;
        private System.Windows.Forms.TextBox tb_New;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_back;
    }
}