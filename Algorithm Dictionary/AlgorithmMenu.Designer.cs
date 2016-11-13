namespace Algorithm_Dictionary
{
    partial class AlgorithmMenu
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
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lb_menu = new System.Windows.Forms.ListBox();
            this.pb_Main = new System.Windows.Forms.PictureBox();
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Search
            // 
            this.tb_Search.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_Search.Location = new System.Drawing.Point(93, 36);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(307, 29);
            this.tb_Search.TabIndex = 1;
            this.tb_Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_search);
            // 
            // btn_Search
            // 
            this.btn_Search.AllowDrop = true;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Search.Location = new System.Drawing.Point(418, 36);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(87, 29);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "검색";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            this.btn_Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Key_Enter);
            // 
            // lb_menu
            // 
            this.lb_menu.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_menu.FormattingEnabled = true;
            this.lb_menu.ItemHeight = 19;
            this.lb_menu.Items.AddRange(new object[] {
            "스택",
            "연결리스트",
            "큐",
            "크루스칼 알고리즘",
            "프림 알고리즘",
            "깊이우선탐색",
            "너비우선탐색",
            "이진탐색트리",
            "삽입정렬",
            "선택정렬",
            "쉘정렬",
            "버블정렬",
            "힙정렬",
            "퀵정렬",
            "카운팅정렬",
            "기수정렬",
            "버킷정렬",
            "머지정렬"});
            this.lb_menu.Location = new System.Drawing.Point(12, 93);
            this.lb_menu.Name = "lb_menu";
            this.lb_menu.Size = new System.Drawing.Size(495, 270);
            this.lb_menu.TabIndex = 20;
            this.lb_menu.SelectedIndexChanged += new System.EventHandler(this.lb_menu_SelectedIndexChanged);
            this.lb_menu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lb_Enter);
            // 
            // pb_Main
            // 
            this.pb_Main.BackColor = System.Drawing.Color.White;
            this.pb_Main.Image = global::Algorithm_Dictionary.Properties.Resources.AlgorithmDictionary_아이콘;
            this.pb_Main.Location = new System.Drawing.Point(12, 12);
            this.pb_Main.Name = "pb_Main";
            this.pb_Main.Size = new System.Drawing.Size(75, 75);
            this.pb_Main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Main.TabIndex = 21;
            this.pb_Main.TabStop = false;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.SystemColors.Window;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_exit.Location = new System.Drawing.Point(475, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(31, 26);
            this.btn_exit.TabIndex = 22;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // AlgorithmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(517, 379);
            this.ControlBox = false;
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.pb_Main);
            this.Controls.Add(this.lb_menu);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tb_Search);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AlgorithmMenu";
            this.Text = "알고리즘 종류";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ListBox lb_menu;
        private System.Windows.Forms.PictureBox pb_Main;
        private System.Windows.Forms.Button btn_exit;
    }
}