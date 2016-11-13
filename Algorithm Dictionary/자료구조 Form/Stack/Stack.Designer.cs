namespace Algorithm_Dictionary
{
    partial class Stack
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
            this.tb_description = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_push = new System.Windows.Forms.TextBox();
            this.btn_stack = new System.Windows.Forms.Button();
            this.tb_pop = new System.Windows.Forms.TextBox();
            this.btn_pop = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.pb_Stack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Stack)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_description
            // 
            this.tb_description.BackColor = System.Drawing.SystemColors.Window;
            this.tb_description.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_description.Location = new System.Drawing.Point(18, 57);
            this.tb_description.Multiline = true;
            this.tb_description.Name = "tb_description";
            this.tb_description.ReadOnly = true;
            this.tb_description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_description.Size = new System.Drawing.Size(773, 111);
            this.tb_description.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Stack 설명";
            // 
            // tb_push
            // 
            this.tb_push.BackColor = System.Drawing.SystemColors.Window;
            this.tb_push.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_push.Location = new System.Drawing.Point(18, 445);
            this.tb_push.Multiline = true;
            this.tb_push.Name = "tb_push";
            this.tb_push.ReadOnly = true;
            this.tb_push.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_push.Size = new System.Drawing.Size(773, 76);
            this.tb_push.TabIndex = 3;
            // 
            // btn_stack
            // 
            this.btn_stack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_stack.FlatAppearance.BorderSize = 0;
            this.btn_stack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stack.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_stack.Location = new System.Drawing.Point(698, 527);
            this.btn_stack.Name = "btn_stack";
            this.btn_stack.Size = new System.Drawing.Size(93, 36);
            this.btn_stack.TabIndex = 4;
            this.btn_stack.Text = "삽입코드보기";
            this.btn_stack.UseVisualStyleBackColor = true;
            this.btn_stack.Click += new System.EventHandler(this.btn_stack_Click);
            // 
            // tb_pop
            // 
            this.tb_pop.BackColor = System.Drawing.SystemColors.Window;
            this.tb_pop.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_pop.Location = new System.Drawing.Point(18, 584);
            this.tb_pop.Multiline = true;
            this.tb_pop.Name = "tb_pop";
            this.tb_pop.ReadOnly = true;
            this.tb_pop.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_pop.Size = new System.Drawing.Size(773, 76);
            this.tb_pop.TabIndex = 5;
            // 
            // btn_pop
            // 
            this.btn_pop.FlatAppearance.BorderSize = 0;
            this.btn_pop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pop.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_pop.Location = new System.Drawing.Point(704, 666);
            this.btn_pop.Name = "btn_pop";
            this.btn_pop.Size = new System.Drawing.Size(93, 36);
            this.btn_pop.TabIndex = 6;
            this.btn_pop.Text = "삭제코드보기";
            this.btn_pop.UseVisualStyleBackColor = true;
            this.btn_pop.Click += new System.EventHandler(this.btn_pop_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(19, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Stack 삽입";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(19, 560);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Stack 삭제";
            // 
            // btn_back
            // 
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("굴림", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_back.Location = new System.Drawing.Point(710, -3);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(81, 54);
            this.btn_back.TabIndex = 19;
            this.btn_back.Text = "←";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // pb_Stack
            // 
            this.pb_Stack.Image = global::Algorithm_Dictionary.Properties.Resources.스택;
            this.pb_Stack.Location = new System.Drawing.Point(18, 183);
            this.pb_Stack.Name = "pb_Stack";
            this.pb_Stack.Size = new System.Drawing.Size(768, 227);
            this.pb_Stack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Stack.TabIndex = 20;
            this.pb_Stack.TabStop = false;
            // 
            // Stack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(809, 725);
            this.ControlBox = false;
            this.Controls.Add(this.pb_Stack);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_pop);
            this.Controls.Add(this.tb_pop);
            this.Controls.Add(this.btn_stack);
            this.Controls.Add(this.tb_push);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_description);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Stack";
            this.Text = "스택";
            this.Load += new System.EventHandler(this.Stack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Stack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_push;
        private System.Windows.Forms.Button btn_stack;
        private System.Windows.Forms.TextBox tb_pop;
        private System.Windows.Forms.Button btn_pop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.PictureBox pb_Stack;
    }
}