using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithm_Dictionary.자료구조_Form.큐
{
    public partial class EnQueue : Form
    {
        public EnQueue()
        {
            InitializeComponent();
        }

        private void EnQueue_Load(object sender, EventArgs e)
        {
            tb_enqueue.AppendText("//큐에 데이터 삽입 함수"+Environment.NewLine);
            tb_enqueue.AppendText("void Enqueue(Queue *queue, int data)" + Environment.NewLine);
            tb_enqueue.AppendText("{" + Environment.NewLine);
            tb_enqueue.AppendText("//큐가 꽉 찼을 때" + Environment.NewLine);
            tb_enqueue.AppendText("if (IsFull(queue))" + Environment.NewLine);
            tb_enqueue.AppendText("{" + Environment.NewLine);
            tb_enqueue.AppendText("printf(큐가 꽉 찼음\n);" + Environment.NewLine);
            tb_enqueue.AppendText("return;" + Environment.NewLine);
            tb_enqueue.AppendText("}" + Environment.NewLine);
            tb_enqueue.AppendText("//rear 인덱스에 데이터 보관" + Environment.NewLine);
            tb_enqueue.AppendText("queue->buf[queue->rear] = data;" + Environment.NewLine);
            tb_enqueue.AppendText(" //rear를 다음 위치로 설정" + Environment.NewLine);
            tb_enqueue.AppendText("queue->rear = NEXT(queue->rear, queue->qsize); " + Environment.NewLine);
            tb_enqueue.AppendText("//보관 개수를 1 증가" + Environment.NewLine);
            tb_enqueue.AppendText("queue->count++;" + Environment.NewLine);
            tb_enqueue.AppendText("}" + Environment.NewLine);
        }
    }
}
