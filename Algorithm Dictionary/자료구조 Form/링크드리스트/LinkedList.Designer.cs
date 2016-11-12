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
            this.lb_Delete = new System.Windows.Forms.Label();
            this.tb_Delete = new System.Windows.Forms.TextBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.lb_PushBack = new System.Windows.Forms.Label();
            this.tb_PushBack = new System.Windows.Forms.TextBox();
            this.btn_PushBack = new System.Windows.Forms.Button();
            this.lb_HangNode = new System.Windows.Forms.Label();
            this.tb_HangNode = new System.Windows.Forms.TextBox();
            this.btn_HangNode = new System.Windows.Forms.Button();
            this.lb_insert = new System.Windows.Forms.Label();
            this.tb_insert = new System.Windows.Forms.TextBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.lb_Erase = new System.Windows.Forms.Label();
            this.tb_Erase = new System.Windows.Forms.TextBox();
            this.btn_Erase = new System.Windows.Forms.Button();
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
            // lb_Delete
            // 
            this.lb_Delete.AutoSize = true;
            this.lb_Delete.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Delete.ForeColor = System.Drawing.Color.Teal;
            this.lb_Delete.Location = new System.Drawing.Point(4, 537);
            this.lb_Delete.Name = "lb_Delete";
            this.lb_Delete.Size = new System.Drawing.Size(178, 21);
            this.lb_Delete.TabIndex = 19;
            this.lb_Delete.Text = "LinkedList 해제화";
            // 
            // tb_Delete
            // 
            this.tb_Delete.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_Delete.Location = new System.Drawing.Point(6, 561);
            this.tb_Delete.Multiline = true;
            this.tb_Delete.Name = "tb_Delete";
            this.tb_Delete.ReadOnly = true;
            this.tb_Delete.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Delete.Size = new System.Drawing.Size(423, 76);
            this.tb_Delete.TabIndex = 20;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(6, 643);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(93, 36);
            this.btn_Delete.TabIndex = 21;
            this.btn_Delete.Text = "리스트해제화";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // lb_PushBack
            // 
            this.lb_PushBack.AutoSize = true;
            this.lb_PushBack.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_PushBack.ForeColor = System.Drawing.Color.Teal;
            this.lb_PushBack.Location = new System.Drawing.Point(4, 699);
            this.lb_PushBack.Name = "lb_PushBack";
            this.lb_PushBack.Size = new System.Drawing.Size(222, 21);
            this.lb_PushBack.TabIndex = 22;
            this.lb_PushBack.Text = "LinkedList 순차적보관";
            // 
            // tb_PushBack
            // 
            this.tb_PushBack.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_PushBack.Location = new System.Drawing.Point(6, 723);
            this.tb_PushBack.Multiline = true;
            this.tb_PushBack.Name = "tb_PushBack";
            this.tb_PushBack.ReadOnly = true;
            this.tb_PushBack.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_PushBack.Size = new System.Drawing.Size(423, 76);
            this.tb_PushBack.TabIndex = 23;
            // 
            // btn_PushBack
            // 
            this.btn_PushBack.Location = new System.Drawing.Point(6, 805);
            this.btn_PushBack.Name = "btn_PushBack";
            this.btn_PushBack.Size = new System.Drawing.Size(93, 36);
            this.btn_PushBack.TabIndex = 24;
            this.btn_PushBack.Text = "순차보관함수";
            this.btn_PushBack.UseVisualStyleBackColor = true;
            this.btn_PushBack.Click += new System.EventHandler(this.btn_PushBack_Click);
            // 
            // lb_HangNode
            // 
            this.lb_HangNode.AutoSize = true;
            this.lb_HangNode.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_HangNode.ForeColor = System.Drawing.Color.Teal;
            this.lb_HangNode.Location = new System.Drawing.Point(4, 870);
            this.lb_HangNode.Name = "lb_HangNode";
            this.lb_HangNode.Size = new System.Drawing.Size(200, 21);
            this.lb_HangNode.TabIndex = 25;
            this.lb_HangNode.Text = "LinkedList 노드연결";
            // 
            // tb_HangNode
            // 
            this.tb_HangNode.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_HangNode.Location = new System.Drawing.Point(7, 894);
            this.tb_HangNode.Multiline = true;
            this.tb_HangNode.Name = "tb_HangNode";
            this.tb_HangNode.ReadOnly = true;
            this.tb_HangNode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_HangNode.Size = new System.Drawing.Size(423, 76);
            this.tb_HangNode.TabIndex = 26;
            // 
            // btn_HangNode
            // 
            this.btn_HangNode.Location = new System.Drawing.Point(6, 976);
            this.btn_HangNode.Name = "btn_HangNode";
            this.btn_HangNode.Size = new System.Drawing.Size(93, 36);
            this.btn_HangNode.TabIndex = 27;
            this.btn_HangNode.Text = "노드연결함수";
            this.btn_HangNode.UseVisualStyleBackColor = true;
            this.btn_HangNode.Click += new System.EventHandler(this.btn_HangNode_Click);
            // 
            // lb_insert
            // 
            this.lb_insert.AutoSize = true;
            this.lb_insert.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_insert.ForeColor = System.Drawing.Color.Teal;
            this.lb_insert.Location = new System.Drawing.Point(4, 1034);
            this.lb_insert.Name = "lb_insert";
            this.lb_insert.Size = new System.Drawing.Size(156, 21);
            this.lb_insert.TabIndex = 28;
            this.lb_insert.Text = "LinkedList 삽입";
            // 
            // tb_insert
            // 
            this.tb_insert.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_insert.Location = new System.Drawing.Point(6, 1058);
            this.tb_insert.Multiline = true;
            this.tb_insert.Name = "tb_insert";
            this.tb_insert.ReadOnly = true;
            this.tb_insert.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_insert.Size = new System.Drawing.Size(423, 76);
            this.tb_insert.TabIndex = 29;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(6, 1140);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(93, 36);
            this.btn_insert.TabIndex = 30;
            this.btn_insert.Text = "노드삽입함수";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // lb_Erase
            // 
            this.lb_Erase.AutoSize = true;
            this.lb_Erase.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Erase.ForeColor = System.Drawing.Color.Teal;
            this.lb_Erase.Location = new System.Drawing.Point(4, 1195);
            this.lb_Erase.Name = "lb_Erase";
            this.lb_Erase.Size = new System.Drawing.Size(252, 21);
            this.lb_Erase.TabIndex = 31;
            this.lb_Erase.Text = "LinkedList 특정 노드제거";
            // 
            // tb_Erase
            // 
            this.tb_Erase.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_Erase.Location = new System.Drawing.Point(7, 1228);
            this.tb_Erase.Multiline = true;
            this.tb_Erase.Name = "tb_Erase";
            this.tb_Erase.ReadOnly = true;
            this.tb_Erase.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Erase.Size = new System.Drawing.Size(423, 76);
            this.tb_Erase.TabIndex = 32;
            // 
            // btn_Erase
            // 
            this.btn_Erase.Location = new System.Drawing.Point(8, 1310);
            this.btn_Erase.Name = "btn_Erase";
            this.btn_Erase.Size = new System.Drawing.Size(93, 36);
            this.btn_Erase.TabIndex = 33;
            this.btn_Erase.Text = "노드제거함수";
            this.btn_Erase.UseVisualStyleBackColor = true;
            this.btn_Erase.Click += new System.EventHandler(this.btn_Erase_Click);
            // 
            // LinkedList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(445, 547);
            this.Controls.Add(this.btn_Erase);
            this.Controls.Add(this.tb_Erase);
            this.Controls.Add(this.lb_Erase);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.tb_insert);
            this.Controls.Add(this.lb_insert);
            this.Controls.Add(this.btn_HangNode);
            this.Controls.Add(this.tb_HangNode);
            this.Controls.Add(this.lb_HangNode);
            this.Controls.Add(this.btn_PushBack);
            this.Controls.Add(this.tb_PushBack);
            this.Controls.Add(this.lb_PushBack);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.tb_Delete);
            this.Controls.Add(this.lb_Delete);
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
            this.Text = "링크드리스트";
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
        private System.Windows.Forms.Label lb_Delete;
        private System.Windows.Forms.TextBox tb_Delete;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label lb_PushBack;
        private System.Windows.Forms.TextBox tb_PushBack;
        private System.Windows.Forms.Button btn_PushBack;
        private System.Windows.Forms.Label lb_HangNode;
        private System.Windows.Forms.TextBox tb_HangNode;
        private System.Windows.Forms.Button btn_HangNode;
        private System.Windows.Forms.Label lb_insert;
        private System.Windows.Forms.TextBox tb_insert;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Label lb_Erase;
        private System.Windows.Forms.TextBox tb_Erase;
        private System.Windows.Forms.Button btn_Erase;
    }
}