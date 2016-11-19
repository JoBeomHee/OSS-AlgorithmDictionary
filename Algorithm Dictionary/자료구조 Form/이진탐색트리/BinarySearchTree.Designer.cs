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
            this.pb_binarySearchTree = new System.Windows.Forms.PictureBox();
            this.pb_back = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_link = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_binarySearchTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_back)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_newNode
            // 
            this.lb_newNode.AutoSize = true;
            this.lb_newNode.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_newNode.ForeColor = System.Drawing.Color.Teal;
            this.lb_newNode.Location = new System.Drawing.Point(8, 352);
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
            this.btn_malloclist.Location = new System.Drawing.Point(392, 460);
            this.btn_malloclist.Name = "btn_malloclist";
            this.btn_malloclist.Size = new System.Drawing.Size(155, 36);
            this.btn_malloclist.TabIndex = 24;
            this.btn_malloclist.Text = "이진탐색트리 노드생성";
            this.btn_malloclist.UseVisualStyleBackColor = true;
            this.btn_malloclist.Click += new System.EventHandler(this.btn_malloclist_Click);
            // 
            // tb_Node
            // 
            this.tb_Node.BackColor = System.Drawing.SystemColors.Window;
            this.tb_Node.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tb_Node.Location = new System.Drawing.Point(11, 378);
            this.tb_Node.Multiline = true;
            this.tb_Node.Name = "tb_Node";
            this.tb_Node.ReadOnly = true;
            this.tb_Node.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Node.Size = new System.Drawing.Size(536, 76);
            this.tb_Node.TabIndex = 23;
            // 
            // btn_New_Node
            // 
            this.btn_New_Node.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_New_Node.FlatAppearance.BorderSize = 0;
            this.btn_New_Node.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_New_Node.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_New_Node.Location = new System.Drawing.Point(407, 306);
            this.btn_New_Node.Name = "btn_New_Node";
            this.btn_New_Node.Size = new System.Drawing.Size(140, 36);
            this.btn_New_Node.TabIndex = 22;
            this.btn_New_Node.Text = "이진탐색트리 초기화";
            this.btn_New_Node.UseVisualStyleBackColor = true;
            this.btn_New_Node.Click += new System.EventHandler(this.btn_New_Node_Click);
            // 
            // tb_NewNode
            // 
            this.tb_NewNode.BackColor = System.Drawing.SystemColors.Window;
            this.tb_NewNode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tb_NewNode.Location = new System.Drawing.Point(11, 224);
            this.tb_NewNode.Multiline = true;
            this.tb_NewNode.Name = "tb_NewNode";
            this.tb_NewNode.ReadOnly = true;
            this.tb_NewNode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_NewNode.Size = new System.Drawing.Size(536, 76);
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
            this.tb_description.BackColor = System.Drawing.SystemColors.Window;
            this.tb_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tb_description.Location = new System.Drawing.Point(11, 63);
            this.tb_description.Multiline = true;
            this.tb_description.Name = "tb_description";
            this.tb_description.ReadOnly = true;
            this.tb_description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_description.Size = new System.Drawing.Size(536, 111);
            this.tb_description.TabIndex = 19;
            // 
            // lb_insert
            // 
            this.lb_insert.AutoSize = true;
            this.lb_insert.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_insert.ForeColor = System.Drawing.Color.Teal;
            this.lb_insert.Location = new System.Drawing.Point(578, 62);
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
            this.btn_insert.Location = new System.Drawing.Point(961, 207);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(155, 36);
            this.btn_insert.TabIndex = 29;
            this.btn_insert.Text = "이진탐색트리 노드삽입";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // tb_insert
            // 
            this.tb_insert.BackColor = System.Drawing.SystemColors.Window;
            this.tb_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tb_insert.Location = new System.Drawing.Point(581, 88);
            this.tb_insert.Multiline = true;
            this.tb_insert.Name = "tb_insert";
            this.tb_insert.ReadOnly = true;
            this.tb_insert.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_insert.Size = new System.Drawing.Size(535, 113);
            this.tb_insert.TabIndex = 28;
            // 
            // lb_free
            // 
            this.lb_free.AutoSize = true;
            this.lb_free.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_free.ForeColor = System.Drawing.Color.Teal;
            this.lb_free.Location = new System.Drawing.Point(8, 487);
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
            this.btn_free.Location = new System.Drawing.Point(408, 606);
            this.btn_free.Name = "btn_free";
            this.btn_free.Size = new System.Drawing.Size(139, 36);
            this.btn_free.TabIndex = 32;
            this.btn_free.Text = "이진탐색트리 해제화";
            this.btn_free.UseVisualStyleBackColor = true;
            this.btn_free.Click += new System.EventHandler(this.btn_free_Click);
            // 
            // tb_free
            // 
            this.tb_free.BackColor = System.Drawing.SystemColors.Window;
            this.tb_free.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tb_free.Location = new System.Drawing.Point(12, 524);
            this.tb_free.Multiline = true;
            this.tb_free.Name = "tb_free";
            this.tb_free.ReadOnly = true;
            this.tb_free.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_free.Size = new System.Drawing.Size(535, 76);
            this.tb_free.TabIndex = 31;
            // 
            // pb_binarySearchTree
            // 
            this.pb_binarySearchTree.Image = global::Algorithm_Dictionary.Properties.Resources.이진탐색트리2;
            this.pb_binarySearchTree.Location = new System.Drawing.Point(582, 253);
            this.pb_binarySearchTree.Name = "pb_binarySearchTree";
            this.pb_binarySearchTree.Size = new System.Drawing.Size(533, 274);
            this.pb_binarySearchTree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_binarySearchTree.TabIndex = 34;
            this.pb_binarySearchTree.TabStop = false;
            // 
            // pb_back
            // 
            this.pb_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_back.Image = global::Algorithm_Dictionary.Properties.Resources.돌아가기;
            this.pb_back.Location = new System.Drawing.Point(1047, 4);
            this.pb_back.Name = "pb_back";
            this.pb_back.Size = new System.Drawing.Size(68, 48);
            this.pb_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_back.TabIndex = 39;
            this.pb_back.TabStop = false;
            this.pb_back.Click += new System.EventHandler(this.pb_back_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(861, 544);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 12);
            this.label4.TabIndex = 46;
            this.label4.Text = "참고 사이트 :";
            // 
            // lb_link
            // 
            this.lb_link.AutoSize = true;
            this.lb_link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_link.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_link.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb_link.Location = new System.Drawing.Point(950, 544);
            this.lb_link.Name = "lb_link";
            this.lb_link.Size = new System.Drawing.Size(165, 12);
            this.lb_link.TabIndex = 45;
            this.lb_link.Text = "http://ehclub.co.kr/1499";
            this.lb_link.Click += new System.EventHandler(this.lb_link_Click);
            // 
            // BinarySearchTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1133, 643);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_link);
            this.Controls.Add(this.pb_back);
            this.Controls.Add(this.pb_binarySearchTree);
            this.Controls.Add(this.lb_free);
            this.Controls.Add(this.btn_free);
            this.Controls.Add(this.tb_free);
            this.Controls.Add(this.lb_insert);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.tb_insert);
            this.Controls.Add(this.lb_newNode);
            this.Controls.Add(this.lb_init);
            this.Controls.Add(this.btn_malloclist);
            this.Controls.Add(this.tb_Node);
            this.Controls.Add(this.btn_New_Node);
            this.Controls.Add(this.tb_NewNode);
            this.Controls.Add(this.lb_description);
            this.Controls.Add(this.tb_description);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BinarySearchTree";
            this.Text = "이진탐색트리";
            this.Load += new System.EventHandler(this.BinarySearchTree_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_binarySearchTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.PictureBox pb_binarySearchTree;
        private System.Windows.Forms.PictureBox pb_back;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_link;
    }
}