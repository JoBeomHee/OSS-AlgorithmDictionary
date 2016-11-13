namespace Algorithm_Dictionary.자료구조_Form.이진탐색트리
{
    partial class BinarySearchTree
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
            this.lb_newNode = new System.Windows.Forms.Label();
            this.lb_init = new System.Windows.Forms.Label();
            this.btn_malloclist = new System.Windows.Forms.Button();
            this.tb_Node = new System.Windows.Forms.TextBox();
            this.btn_New_Node = new System.Windows.Forms.Button();
            this.tb_NewNode = new System.Windows.Forms.TextBox();
            this.lb_description = new System.Windows.Forms.Label();
            this.tb_description = new System.Windows.Forms.TextBox();
            this.lb_insert = new System.Windows.Forms.Label();
            this.btn_insert = new System.Windows.Forms.Button();
            this.tb_insert = new System.Windows.Forms.TextBox();
            this.lb_free = new System.Windows.Forms.Label();
            this.btn_free = new System.Windows.Forms.Button();
            this.tb_free = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("굴림", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_back.Location = new System.Drawing.Point(351, 7);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(81, 54);
            this.btn_back.TabIndex = 27;
            this.btn_back.Text = "←";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lb_newNode
            // 
            this.lb_newNode.AutoSize = true;
            this.lb_newNode.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_newNode.ForeColor = System.Drawing.Color.Teal;
            this.lb_newNode.Location = new System.Drawing.Point(8, 367);
            this.lb_newNode.Name = "lb_newNode";
            this.lb_newNode.Size = new System.Drawing.Size(238, 21);
            this.lb_newNode.TabIndex = 26;
            this.lb_newNode.Text = "이진탐색트리 노드생성";
            // 
            // lb_init
            // 
            this.lb_init.AutoSize = true;
            this.lb_init.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_init.ForeColor = System.Drawing.Color.Teal;
            this.lb_init.Location = new System.Drawing.Point(8, 194);
            this.lb_init.Name = "lb_init";
            this.lb_init.Size = new System.Drawing.Size(216, 21);
            this.lb_init.TabIndex = 25;
            this.lb_init.Text = "이진탐색트리 초기화";
            // 
            // btn_malloclist
            // 
            this.btn_malloclist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_malloclist.FlatAppearance.BorderSize = 0;
            this.btn_malloclist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_malloclist.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_malloclist.Location = new System.Drawing.Point(10, 475);
            this.btn_malloclist.Name = "btn_malloclist";
            this.btn_malloclist.Size = new System.Drawing.Size(155, 36);
            this.btn_malloclist.TabIndex = 24;
            this.btn_malloclist.Text = "이진탐색트리 노드생성";
            this.btn_malloclist.UseVisualStyleBackColor = true;
            this.btn_malloclist.Click += new System.EventHandler(this.btn_malloclist_Click);
            // 
            // tb_Node
            // 
            this.tb_Node.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_Node.Location = new System.Drawing.Point(11, 393);
            this.tb_Node.Multiline = true;
            this.tb_Node.Name = "tb_Node";
            this.tb_Node.ReadOnly = true;
            this.tb_Node.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Node.Size = new System.Drawing.Size(423, 76);
            this.tb_Node.TabIndex = 23;
            // 
            // btn_New_Node
            // 
            this.btn_New_Node.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_New_Node.FlatAppearance.BorderSize = 0;
            this.btn_New_Node.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_New_Node.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_New_Node.Location = new System.Drawing.Point(11, 306);
            this.btn_New_Node.Name = "btn_New_Node";
            this.btn_New_Node.Size = new System.Drawing.Size(140, 36);
            this.btn_New_Node.TabIndex = 22;
            this.btn_New_Node.Text = "이진탐색트리 초기화";
            this.btn_New_Node.UseVisualStyleBackColor = true;
            this.btn_New_Node.Click += new System.EventHandler(this.btn_New_Node_Click);
            // 
            // tb_NewNode
            // 
            this.tb_NewNode.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_NewNode.Location = new System.Drawing.Point(11, 224);
            this.tb_NewNode.Multiline = true;
            this.tb_NewNode.Name = "tb_NewNode";
            this.tb_NewNode.ReadOnly = true;
            this.tb_NewNode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_NewNode.Size = new System.Drawing.Size(423, 76);
            this.tb_NewNode.TabIndex = 21;
            // 
            // lb_description
            // 
            this.lb_description.AutoSize = true;
            this.lb_description.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_description.ForeColor = System.Drawing.Color.Teal;
            this.lb_description.Location = new System.Drawing.Point(3, 15);
            this.lb_description.Name = "lb_description";
            this.lb_description.Size = new System.Drawing.Size(334, 37);
            this.lb_description.TabIndex = 20;
            this.lb_description.Text = "이진탐색트리 설명";
            // 
            // tb_description
            // 
            this.tb_description.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_description.Location = new System.Drawing.Point(11, 63);
            this.tb_description.Multiline = true;
            this.tb_description.Name = "tb_description";
            this.tb_description.ReadOnly = true;
            this.tb_description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_description.Size = new System.Drawing.Size(423, 111);
            this.tb_description.TabIndex = 19;
            // 
            // lb_insert
            // 
            this.lb_insert.AutoSize = true;
            this.lb_insert.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_insert.ForeColor = System.Drawing.Color.Teal;
            this.lb_insert.Location = new System.Drawing.Point(7, 518);
            this.lb_insert.Name = "lb_insert";
            this.lb_insert.Size = new System.Drawing.Size(238, 21);
            this.lb_insert.TabIndex = 30;
            this.lb_insert.Text = "이진탐색트리 노드삽입";
            // 
            // btn_insert
            // 
            this.btn_insert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_insert.FlatAppearance.BorderSize = 0;
            this.btn_insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_insert.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_insert.Location = new System.Drawing.Point(9, 626);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(155, 36);
            this.btn_insert.TabIndex = 29;
            this.btn_insert.Text = "이진탐색트리 노드삽입";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // tb_insert
            // 
            this.tb_insert.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_insert.Location = new System.Drawing.Point(10, 544);
            this.tb_insert.Multiline = true;
            this.tb_insert.Name = "tb_insert";
            this.tb_insert.ReadOnly = true;
            this.tb_insert.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_insert.Size = new System.Drawing.Size(423, 76);
            this.tb_insert.TabIndex = 28;
            // 
            // lb_free
            // 
            this.lb_free.AutoSize = true;
            this.lb_free.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_free.ForeColor = System.Drawing.Color.Teal;
            this.lb_free.Location = new System.Drawing.Point(7, 676);
            this.lb_free.Name = "lb_free";
            this.lb_free.Size = new System.Drawing.Size(216, 21);
            this.lb_free.TabIndex = 33;
            this.lb_free.Text = "이진탐색트리 해제화";
            // 
            // btn_free
            // 
            this.btn_free.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_free.FlatAppearance.BorderSize = 0;
            this.btn_free.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_free.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_free.Location = new System.Drawing.Point(12, 795);
            this.btn_free.Name = "btn_free";
            this.btn_free.Size = new System.Drawing.Size(139, 36);
            this.btn_free.TabIndex = 32;
            this.btn_free.Text = "이진탐색트리 해제화";
            this.btn_free.UseVisualStyleBackColor = true;
            this.btn_free.Click += new System.EventHandler(this.btn_free_Click);
            // 
            // tb_free
            // 
            this.tb_free.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_free.Location = new System.Drawing.Point(11, 713);
            this.tb_free.Multiline = true;
            this.tb_free.Name = "tb_free";
            this.tb_free.ReadOnly = true;
            this.tb_free.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_free.Size = new System.Drawing.Size(423, 76);
            this.tb_free.TabIndex = 31;
            // 
            // BinarySearchTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(461, 510);
            this.ControlBox = false;
            this.Controls.Add(this.lb_free);
            this.Controls.Add(this.btn_free);
            this.Controls.Add(this.tb_free);
            this.Controls.Add(this.lb_insert);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.tb_insert);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lb_newNode);
            this.Controls.Add(this.lb_init);
            this.Controls.Add(this.btn_malloclist);
            this.Controls.Add(this.tb_Node);
            this.Controls.Add(this.btn_New_Node);
            this.Controls.Add(this.tb_NewNode);
            this.Controls.Add(this.lb_description);
            this.Controls.Add(this.tb_description);
            this.Name = "BinarySearchTree";
            this.Text = "이진탐색트리";
            this.Load += new System.EventHandler(this.BinarySearchTree_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lb_newNode;
        private System.Windows.Forms.Label lb_init;
        private System.Windows.Forms.Button btn_malloclist;
        private System.Windows.Forms.TextBox tb_Node;
        private System.Windows.Forms.Button btn_New_Node;
        private System.Windows.Forms.TextBox tb_NewNode;
        private System.Windows.Forms.Label lb_description;
        private System.Windows.Forms.TextBox tb_description;
        private System.Windows.Forms.Label lb_insert;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.TextBox tb_insert;
        private System.Windows.Forms.Label lb_free;
        private System.Windows.Forms.Button btn_free;
        private System.Windows.Forms.TextBox tb_free;
    }
}