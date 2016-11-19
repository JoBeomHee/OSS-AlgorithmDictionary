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
            this.lb_menu = new System.Windows.Forms.ListBox();
            this.pb_exit = new System.Windows.Forms.PictureBox();
            this.pb_Search = new System.Windows.Forms.PictureBox();
            this.pb_Main = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Search
            // 
            this.tb_Search.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_Search.Location = new System.Drawing.Point(93, 36);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(307, 29);
            this.tb_Search.TabIndex = 0;
            this.tb_Search.TextChanged += new System.EventHandler(this.tb_Search_TextChanged);
            this.tb_Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_search);
            // 
            // lb_menu
            // 
            this.lb_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_menu.FormattingEnabled = true;
            this.lb_menu.ItemHeight = 24;
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
            this.lb_menu.Size = new System.Drawing.Size(443, 268);
            this.lb_menu.TabIndex = 1;
            this.lb_menu.SelectedIndexChanged += new System.EventHandler(this.lb_menu_SelectedIndexChanged);
            this.lb_menu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lb_Enter);
            // 
            // pb_exit
            // 
            this.pb_exit.BackColor = System.Drawing.Color.White;
            this.pb_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_exit.Image = global::Algorithm_Dictionary.Properties.Resources.끄기;
            this.pb_exit.Location = new System.Drawing.Point(418, 5);
            this.pb_exit.Name = "pb_exit";
            this.pb_exit.Size = new System.Drawing.Size(36, 25);
            this.pb_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_exit.TabIndex = 24;
            this.pb_exit.TabStop = false;
            this.pb_exit.Click += new System.EventHandler(this.pb_exit_Click);
            // 
            // pb_Search
            // 
            this.pb_Search.BackColor = System.Drawing.Color.White;
            this.pb_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Search.Image = global::Algorithm_Dictionary.Properties.Resources.검색이미지;
            this.pb_Search.Location = new System.Drawing.Point(405, 36);
            this.pb_Search.Name = "pb_Search";
            this.pb_Search.Size = new System.Drawing.Size(49, 29);
            this.pb_Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Search.TabIndex = 23;
            this.pb_Search.TabStop = false;
            this.pb_Search.Click += new System.EventHandler(this.pb_Search_Click);
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
            // AlgorithmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(467, 379);
            this.ControlBox = false;
            this.Controls.Add(this.pb_exit);
            this.Controls.Add(this.pb_Search);
            this.Controls.Add(this.pb_Main);
            this.Controls.Add(this.lb_menu);
            this.Controls.Add(this.tb_Search);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AlgorithmMenu";
            this.Text = "알고리즘 종류";
            this.Load += new System.EventHandler(this.AlgorithmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.ListBox lb_menu;
        private System.Windows.Forms.PictureBox pb_Main;
        private System.Windows.Forms.PictureBox pb_Search;
        private System.Windows.Forms.PictureBox pb_exit;
    }
}