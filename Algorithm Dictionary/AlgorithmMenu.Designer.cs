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
            ((System.ComponentModel.ISupportInitialize)(this.pb_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Search
            // 
            this.tb_Search.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_Search.Location = new System.Drawing.Point(12, 12);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(307, 29);
            this.tb_Search.TabIndex = 18;
            // 
            // btn_Search
            // 
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Search.Location = new System.Drawing.Point(325, 12);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(97, 29);
            this.btn_Search.TabIndex = 19;
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
            "링크드리스트",
            "큐",
            "크루스칼 알고리즘",
            "프림 알고리즘",
            "깊이우선탐색",
            "너비우선탐색",
            "트리",
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
            this.lb_menu.Location = new System.Drawing.Point(12, 52);
            this.lb_menu.Name = "lb_menu";
            this.lb_menu.Size = new System.Drawing.Size(410, 232);
            this.lb_menu.TabIndex = 20;
            // 
            // pb_Main
            // 
            this.pb_Main.Image = global::Algorithm_Dictionary.Properties.Resources.AlgorithmDictionary_아이콘;
            this.pb_Main.Location = new System.Drawing.Point(428, 12);
            this.pb_Main.Name = "pb_Main";
            this.pb_Main.Size = new System.Drawing.Size(148, 125);
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
            this.ClientSize = new System.Drawing.Size(588, 304);
            this.Controls.Add(this.pb_Main);
            this.Controls.Add(this.lb_menu);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tb_Search);
            this.DoubleBuffered = true;
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
    }
}