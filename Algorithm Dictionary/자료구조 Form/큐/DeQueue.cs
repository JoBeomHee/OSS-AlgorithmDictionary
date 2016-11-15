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
    public partial class DeQueue : Form
    {
        public DeQueue()
        {
            InitializeComponent();
        }

        private void DeQueue_Load(object sender, EventArgs e)
        {
            tb_dqqueue.AppendText("//큐에 데이터 삭제함수" + Environment.NewLine);
            tb_dqqueue.AppendText("int Dequeue(Queue *queue)" + Environment.NewLine);
            tb_dqqueue.AppendText("{" + Environment.NewLine);
            tb_dqqueue.AppendText("int re = 0;" + Environment.NewLine);
            tb_dqqueue.AppendText("//큐가 비었을 때" + Environment.NewLine);
            tb_dqqueue.AppendText("if (IsEmpty(queue))" + Environment.NewLine);
            tb_dqqueue.AppendText("{" + Environment.NewLine);
            tb_dqqueue.AppendText("printf(큐가 비었음\n);" + Environment.NewLine);
            tb_dqqueue.AppendText("return re;" + Environment.NewLine);
            tb_dqqueue.AppendText("}" + Environment.NewLine);
            tb_dqqueue.AppendText("//front 인덱스에 보관한 값을 re에 설정" + Environment.NewLine);
            tb_dqqueue.AppendText("re = queue->buf[queue->front];" + Environment.NewLine);
            tb_dqqueue.AppendText("//front를 다음 위치로 설정" + Environment.NewLine);
            tb_dqqueue.AppendText("queue->front = NEXT(queue->front, queue->qsize);" + Environment.NewLine);
            tb_dqqueue.AppendText("//보관 개수를 1 감소" + Environment.NewLine);
            tb_dqqueue.AppendText("queue->count--;" + Environment.NewLine);
            tb_dqqueue.AppendText("return re;" + Environment.NewLine);
            tb_dqqueue.AppendText("}" + Environment.NewLine);
        }
    }
}
