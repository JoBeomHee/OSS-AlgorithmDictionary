namespace Algorithm_Dictionary.자료구조_Form.큐
{
    partial class QUeue
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
            this.lb_decription = new System.Windows.Forms.Label();
            this.tb_description = new System.Windows.Forms.TextBox();
            this.lb_ = new System.Windows.Forms.Label();
            this.tb_Init = new System.Windows.Forms.TextBox();
            this.btn_stack = new System.Windows.Forms.Button();
            this.lb_FullEmpty = new System.Windows.Forms.Label();
            this.tb_FullEmpty = new System.Windows.Forms.TextBox();
            this.btn_FullEmpty = new System.Windows.Forms.Button();
            this.btn_Enqueue = new System.Windows.Forms.Button();
            this.tb_Enqueue = new System.Windows.Forms.TextBox();
            this.lb_EnQueue = new System.Windows.Forms.Label();
            this.btn_Dequeue = new System.Windows.Forms.Button();
            this.tb_DeQueue = new System.Windows.Forms.TextBox();
            this.lb_DeQueue = new System.Windows.Forms.Label();
            this.btn_dispose = new System.Windows.Forms.Button();
            this.tb_dispose = new System.Windows.Forms.TextBox();
            this.lb_Dispose = new System.Windows.Forms.Label();
            this.pb_Queue = new System.Windows.Forms.PictureBox();
            this.pb_back = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_link = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Queue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_back)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_decription
            // 
            this.lb_decription.AutoSize = true;
            this.lb_decription.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_decription.ForeColor = System.Drawing.Color.Teal;
            this.lb_decription.Location = new System.Drawing.Point(6, 18);
            this.lb_decription.Name = "lb_decription";
            this.lb_decription.Size = new System.Drawing.Size(211, 37);
            this.lb_decription.TabIndex = 21;
            this.lb_decription.Text = "Queue설명";
            // 
            // tb_description
            // 
            this.tb_description.BackColor = System.Drawing.SystemColors.Window;
            this.tb_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tb_description.Location = new System.Drawing.Point(12, 66);
            this.tb_description.Multiline = true;
            this.tb_description.Name = "tb_description";
            this.tb_description.ReadOnly = true;
            this.tb_description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_description.Size = new System.Drawing.Size(558, 111);
            this.tb_description.TabIndex = 20;
            // 
            // lb_
            // 
            this.lb_.AutoSize = true;
            this.lb_.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_.ForeColor = System.Drawing.Color.Teal;
            this.lb_.Location = new System.Drawing.Point(12, 199);
            this.lb_.Name = "lb_";
            this.lb_.Size = new System.Drawing.Size(146, 21);
            this.lb_.TabIndex = 23;
            this.lb_.Text = "Queue 초기화";
            // 
            // tb_Init
            // 
            this.tb_Init.BackColor = System.Drawing.SystemColors.Window;
            this.tb_Init.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tb_Init.Location = new System.Drawing.Point(13, 233);
            this.tb_Init.Multiline = true;
            this.tb_Init.Name = "tb_Init";
            this.tb_Init.ReadOnly = true;
            this.tb_Init.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Init.Size = new System.Drawing.Size(557, 111);
            this.tb_Init.TabIndex = 24;
            // 
            // btn_stack
            // 
            this.btn_stack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_stack.FlatAppearance.BorderSize = 0;
            this.btn_stack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stack.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_stack.Location = new System.Drawing.Point(477, 351);
            this.btn_stack.Name = "btn_stack";
            this.btn_stack.Size = new System.Drawing.Size(93, 36);
            this.btn_stack.TabIndex = 25;
            this.btn_stack.Text = "초기화 함수";
            this.btn_stack.UseVisualStyleBackColor = true;
            this.btn_stack.Click += new System.EventHandler(this.btn_stack_Click);
            // 
            // lb_FullEmpty
            // 
            this.lb_FullEmpty.AutoSize = true;
            this.lb_FullEmpty.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_FullEmpty.ForeColor = System.Drawing.Color.Teal;
            this.lb_FullEmpty.Location = new System.Drawing.Point(12, 402);
            this.lb_FullEmpty.Name = "lb_FullEmpty";
            this.lb_FullEmpty.Size = new System.Drawing.Size(198, 21);
            this.lb_FullEmpty.TabIndex = 26;
            this.lb_FullEmpty.Text = "Queue 저장소 함수";
            // 
            // tb_FullEmpty
            // 
            this.tb_FullEmpty.BackColor = System.Drawing.SystemColors.Window;
            this.tb_FullEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tb_FullEmpty.Location = new System.Drawing.Point(12, 426);
            this.tb_FullEmpty.Multiline = true;
            this.tb_FullEmpty.Name = "tb_FullEmpty";
            this.tb_FullEmpty.ReadOnly = true;
            this.tb_FullEmpty.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_FullEmpty.Size = new System.Drawing.Size(558, 111);
            this.tb_FullEmpty.TabIndex = 27;
            // 
            // btn_FullEmpty
            // 
            this.btn_FullEmpty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_FullEmpty.FlatAppearance.BorderSize = 0;
            this.btn_FullEmpty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FullEmpty.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_FullEmpty.Location = new System.Drawing.Point(487, 543);
            this.btn_FullEmpty.Name = "btn_FullEmpty";
            this.btn_FullEmpty.Size = new System.Drawing.Size(105, 36);
            this.btn_FullEmpty.TabIndex = 28;
            this.btn_FullEmpty.Text = "큐 저장소 함수";
            this.btn_FullEmpty.UseVisualStyleBackColor = true;
            this.btn_FullEmpty.Click += new System.EventHandler(this.btn_FullEmpty_Click);
            // 
            // btn_Enqueue
            // 
            this.btn_Enqueue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Enqueue.FlatAppearance.BorderSize = 0;
            this.btn_Enqueue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Enqueue.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Enqueue.Location = new System.Drawing.Point(1030, 183);
            this.btn_Enqueue.Name = "btn_Enqueue";
            this.btn_Enqueue.Size = new System.Drawing.Size(105, 36);
            this.btn_Enqueue.TabIndex = 31;
            this.btn_Enqueue.Text = "EnQueue함수";
            this.btn_Enqueue.UseVisualStyleBackColor = true;
            this.btn_Enqueue.Click += new System.EventHandler(this.btn_Enqueue_Click);
            // 
            // tb_Enqueue
            // 
            this.tb_Enqueue.BackColor = System.Drawing.SystemColors.Window;
            this.tb_Enqueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tb_Enqueue.Location = new System.Drawing.Point(598, 66);
            this.tb_Enqueue.Multiline = true;
            this.tb_Enqueue.Name = "tb_Enqueue";
            this.tb_Enqueue.ReadOnly = true;
            this.tb_Enqueue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Enqueue.Size = new System.Drawing.Size(537, 111);
            this.tb_Enqueue.TabIndex = 30;
            // 
            // lb_EnQueue
            // 
            this.lb_EnQueue.AutoSize = true;
            this.lb_EnQueue.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_EnQueue.ForeColor = System.Drawing.Color.Teal;
            this.lb_EnQueue.Location = new System.Drawing.Point(598, 42);
            this.lb_EnQueue.Name = "lb_EnQueue";
            this.lb_EnQueue.Size = new System.Drawing.Size(218, 21);
            this.lb_EnQueue.TabIndex = 29;
            this.lb_EnQueue.Text = "Queue EnQueue 함수";
            // 
            // btn_Dequeue
            // 
            this.btn_Dequeue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Dequeue.FlatAppearance.BorderSize = 0;
            this.btn_Dequeue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dequeue.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Dequeue.Location = new System.Drawing.Point(1030, 351);
            this.btn_Dequeue.Name = "btn_Dequeue";
            this.btn_Dequeue.Size = new System.Drawing.Size(105, 36);
            this.btn_Dequeue.TabIndex = 34;
            this.btn_Dequeue.Text = "DeQueue함수";
            this.btn_Dequeue.UseVisualStyleBackColor = true;
            this.btn_Dequeue.Click += new System.EventHandler(this.btn_Dequeue_Click);
            // 
            // tb_DeQueue
            // 
            this.tb_DeQueue.BackColor = System.Drawing.SystemColors.Window;
            this.tb_DeQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tb_DeQueue.Location = new System.Drawing.Point(598, 233);
            this.tb_DeQueue.Multiline = true;
            this.tb_DeQueue.Name = "tb_DeQueue";
            this.tb_DeQueue.ReadOnly = true;
            this.tb_DeQueue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_DeQueue.Size = new System.Drawing.Size(537, 111);
            this.tb_DeQueue.TabIndex = 33;
            // 
            // lb_DeQueue
            // 
            this.lb_DeQueue.AutoSize = true;
            this.lb_DeQueue.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_DeQueue.ForeColor = System.Drawing.Color.Teal;
            this.lb_DeQueue.Location = new System.Drawing.Point(598, 209);
            this.lb_DeQueue.Name = "lb_DeQueue";
            this.lb_DeQueue.Size = new System.Drawing.Size(220, 21);
            this.lb_DeQueue.TabIndex = 32;
            this.lb_DeQueue.Text = "Queue DeQueue 함수";
            // 
            // btn_dispose
            // 
            this.btn_dispose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dispose.FlatAppearance.BorderSize = 0;
            this.btn_dispose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dispose.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_dispose.Location = new System.Drawing.Point(465, 732);
            this.btn_dispose.Name = "btn_dispose";
            this.btn_dispose.Size = new System.Drawing.Size(105, 36);
            this.btn_dispose.TabIndex = 37;
            this.btn_dispose.Text = "큐 해제화 함수";
            this.btn_dispose.UseVisualStyleBackColor = true;
            this.btn_dispose.Click += new System.EventHandler(this.btn_dispose_Click);
            // 
            // tb_dispose
            // 
            this.tb_dispose.BackColor = System.Drawing.SystemColors.Window;
            this.tb_dispose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tb_dispose.Location = new System.Drawing.Point(12, 614);
            this.tb_dispose.Multiline = true;
            this.tb_dispose.Name = "tb_dispose";
            this.tb_dispose.ReadOnly = true;
            this.tb_dispose.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_dispose.Size = new System.Drawing.Size(558, 111);
            this.tb_dispose.TabIndex = 36;
            // 
            // lb_Dispose
            // 
            this.lb_Dispose.AutoSize = true;
            this.lb_Dispose.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Dispose.ForeColor = System.Drawing.Color.Teal;
            this.lb_Dispose.Location = new System.Drawing.Point(12, 590);
            this.lb_Dispose.Name = "lb_Dispose";
            this.lb_Dispose.Size = new System.Drawing.Size(198, 21);
            this.lb_Dispose.TabIndex = 35;
            this.lb_Dispose.Text = "Queue 해제화 함수";
            // 
            // pb_Queue
            // 
            this.pb_Queue.Image = global::Algorithm_Dictionary.Properties.Resources.큐;
            this.pb_Queue.Location = new System.Drawing.Point(598, 393);
            this.pb_Queue.Name = "pb_Queue";
            this.pb_Queue.Size = new System.Drawing.Size(537, 345);
            this.pb_Queue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Queue.TabIndex = 38;
            this.pb_Queue.TabStop = false;
            // 
            // pb_back
            // 
            this.pb_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_back.Image = global::Algorithm_Dictionary.Properties.Resources.돌아가기;
            this.pb_back.Location = new System.Drawing.Point(1067, 12);
            this.pb_back.Name = "pb_back";
            this.pb_back.Size = new System.Drawing.Size(68, 48);
            this.pb_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_back.TabIndex = 40;
            this.pb_back.TabStop = false;
            this.pb_back.Click += new System.EventHandler(this.pb_back_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(881, 744);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 12);
            this.label4.TabIndex = 48;
            this.label4.Text = "참고 사이트 :";
            // 
            // lb_link
            // 
            this.lb_link.AutoSize = true;
            this.lb_link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_link.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_link.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb_link.Location = new System.Drawing.Point(970, 744);
            this.lb_link.Name = "lb_link";
            this.lb_link.Size = new System.Drawing.Size(165, 12);
            this.lb_link.TabIndex = 47;
            this.lb_link.Text = "http://ehclub.co.kr/2559";
            this.lb_link.Click += new System.EventHandler(this.lb_link_Click);
            // 
            // Queue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1147, 780);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_link);
            this.Controls.Add(this.pb_back);
            this.Controls.Add(this.pb_Queue);
            this.Controls.Add(this.btn_dispose);
            this.Controls.Add(this.tb_dispose);
            this.Controls.Add(this.lb_Dispose);
            this.Controls.Add(this.btn_Dequeue);
            this.Controls.Add(this.tb_DeQueue);
            this.Controls.Add(this.lb_DeQueue);
            this.Controls.Add(this.btn_Enqueue);
            this.Controls.Add(this.tb_Enqueue);
            this.Controls.Add(this.lb_EnQueue);
            this.Controls.Add(this.btn_FullEmpty);
            this.Controls.Add(this.tb_FullEmpty);
            this.Controls.Add(this.lb_FullEmpty);
            this.Controls.Add(this.btn_stack);
            this.Controls.Add(this.tb_Init);
            this.Controls.Add(this.lb_);
            this.Controls.Add(this.lb_decription);
            this.Controls.Add(this.tb_description);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Queue";
            this.Text = "Queue";
            this.Load += new System.EventHandler(this.Queue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Queue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_decription;
        private System.Windows.Forms.TextBox tb_description;
        private System.Windows.Forms.Label lb_;
        private System.Windows.Forms.TextBox tb_Init;
        private System.Windows.Forms.Button btn_stack;
        private System.Windows.Forms.Label lb_FullEmpty;
        private System.Windows.Forms.TextBox tb_FullEmpty;
        private System.Windows.Forms.Button btn_FullEmpty;
        private System.Windows.Forms.Button btn_Enqueue;
        private System.Windows.Forms.TextBox tb_Enqueue;
        private System.Windows.Forms.Label lb_EnQueue;
        private System.Windows.Forms.Button btn_Dequeue;
        private System.Windows.Forms.TextBox tb_DeQueue;
        private System.Windows.Forms.Label lb_DeQueue;
        private System.Windows.Forms.Button btn_dispose;
        private System.Windows.Forms.TextBox tb_dispose;
        private System.Windows.Forms.Label lb_Dispose;
        private System.Windows.Forms.PictureBox pb_Queue;
        private System.Windows.Forms.PictureBox pb_back;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_link;
    }
}