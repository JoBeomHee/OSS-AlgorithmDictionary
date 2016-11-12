namespace Algorithm_Dictionary
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.pb_tree = new System.Windows.Forms.PictureBox();
            this.pb_linkedlist = new System.Windows.Forms.PictureBox();
            this.pb_MainIcon = new System.Windows.Forms.PictureBox();
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_linkedlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_MainIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Algorithm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(91, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 53);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dictionary";
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.SystemColors.Window;
            this.btn_start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_start.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_start.FlatAppearance.BorderSize = 0;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_start.ForeColor = System.Drawing.Color.Teal;
            this.btn_start.Location = new System.Drawing.Point(100, 337);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(209, 71);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "시작하기";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // pb_tree
            // 
            this.pb_tree.Image = global::Algorithm_Dictionary.Properties.Resources.트리_아이콘;
            this.pb_tree.Location = new System.Drawing.Point(136, 240);
            this.pb_tree.Name = "pb_tree";
            this.pb_tree.Size = new System.Drawing.Size(127, 85);
            this.pb_tree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_tree.TabIndex = 5;
            this.pb_tree.TabStop = false;
            // 
            // pb_linkedlist
            // 
            this.pb_linkedlist.Image = global::Algorithm_Dictionary.Properties.Resources.링크드리스트_아이콘;
            this.pb_linkedlist.Location = new System.Drawing.Point(31, 166);
            this.pb_linkedlist.Name = "pb_linkedlist";
            this.pb_linkedlist.Size = new System.Drawing.Size(336, 68);
            this.pb_linkedlist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_linkedlist.TabIndex = 4;
            this.pb_linkedlist.TabStop = false;
            // 
            // pb_MainIcon
            // 
            this.pb_MainIcon.Image = global::Algorithm_Dictionary.Properties.Resources.AlgorithmDictionary_아이콘;
            this.pb_MainIcon.Location = new System.Drawing.Point(273, 20);
            this.pb_MainIcon.Name = "pb_MainIcon";
            this.pb_MainIcon.Size = new System.Drawing.Size(62, 65);
            this.pb_MainIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_MainIcon.TabIndex = 3;
            this.pb_MainIcon.TabStop = false;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.SystemColors.Window;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_exit.Location = new System.Drawing.Point(366, 394);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(41, 26);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(409, 420);
            this.ControlBox = false;
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.pb_tree);
            this.Controls.Add(this.pb_linkedlist);
            this.Controls.Add(this.pb_MainIcon);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Algorithm Dictionary";
            ((System.ComponentModel.ISupportInitialize)(this.pb_tree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_linkedlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_MainIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.PictureBox pb_MainIcon;
        private System.Windows.Forms.PictureBox pb_linkedlist;
        private System.Windows.Forms.PictureBox pb_tree;
        private System.Windows.Forms.Button btn_exit;
    }
}

