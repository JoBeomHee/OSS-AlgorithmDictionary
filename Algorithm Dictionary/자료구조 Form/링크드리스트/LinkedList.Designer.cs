namespace Algorithm_Dictionary.자료구조_Form.링크드리스트
{
    partial class LinkedList
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
            this.btn_back = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_malloclist = new System.Windows.Forms.Button();
            this.tb_mallocList = new System.Windows.Forms.TextBox();
            this.btn_New_Node = new System.Windows.Forms.Button();
            this.tb_New_Node = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_description = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(304, 11);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(114, 33);
            this.btn_back.TabIndex = 18;
            this.btn_back.Text = "되돌아가기";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(4, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "LinkedList 동적생성";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(4, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "LinkedList Node 생성함수";
            // 
            // btn_malloclist
            // 
            this.btn_malloclist.Location = new System.Drawing.Point(6, 468);
            this.btn_malloclist.Name = "btn_malloclist";
            this.btn_malloclist.Size = new System.Drawing.Size(93, 36);
            this.btn_malloclist.TabIndex = 15;
            this.btn_malloclist.Text = "동적생성함수";
            this.btn_malloclist.UseVisualStyleBackColor = true;
            this.btn_malloclist.Click += new System.EventHandler(this.btn_malloclist_Click);
            // 
            // tb_mallocList
            // 
            this.tb_mallocList.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_mallocList.Location = new System.Drawing.Point(7, 386);
            this.tb_mallocList.Multiline = true;
            this.tb_mallocList.Name = "tb_mallocList";
            this.tb_mallocList.ReadOnly = true;
            this.tb_mallocList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_mallocList.Size = new System.Drawing.Size(423, 76);
            this.tb_mallocList.TabIndex = 14;
            // 
            // btn_New_Node
            // 
            this.btn_New_Node.Location = new System.Drawing.Point(7, 299);
            this.btn_New_Node.Name = "btn_New_Node";
            this.btn_New_Node.Size = new System.Drawing.Size(92, 36);
            this.btn_New_Node.TabIndex = 13;
            this.btn_New_Node.Text = "Node생성함수 ";
            this.btn_New_Node.UseVisualStyleBackColor = true;
            this.btn_New_Node.Click += new System.EventHandler(this.btn_New_Node_Click);
            // 
            // tb_New_Node
            // 
            this.tb_New_Node.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_New_Node.Location = new System.Drawing.Point(7, 217);
            this.tb_New_Node.Multiline = true;
            this.tb_New_Node.Name = "tb_New_Node";
            this.tb_New_Node.ReadOnly = true;
            this.tb_New_Node.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_New_Node.Size = new System.Drawing.Size(423, 76);
            this.tb_New_Node.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(-1, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "LinkedList 설명";
            // 
            // tb_description
            // 
            this.tb_description.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_description.Location = new System.Drawing.Point(7, 56);
            this.tb_description.Multiline = true;
            this.tb_description.Name = "tb_description";
            this.tb_description.ReadOnly = true;
            this.tb_description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_description.Size = new System.Drawing.Size(423, 111);
            this.tb_description.TabIndex = 10;
            // 
            // LinkedList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(440, 521);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_malloclist);
            this.Controls.Add(this.tb_mallocList);
            this.Controls.Add(this.btn_New_Node);
            this.Controls.Add(this.tb_New_Node);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_description);
            this.Name = "LinkedList";
            this.Text = "LinkedList";
            this.Load += new System.EventHandler(this.LinkedList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_malloclist;
        private System.Windows.Forms.TextBox tb_mallocList;
        private System.Windows.Forms.Button btn_New_Node;
        private System.Windows.Forms.TextBox tb_New_Node;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_description;
    }
}