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
    public partial class QueueInit : Form
    {
        public QueueInit()
        {
            InitializeComponent();
        }

        private void QueueInit_Load(object sender, EventArgs e)
        {
            tb_Init.AppendText("//큐 초기화" + Environment.NewLine);
            tb_Init.AppendText("void InitQueue(Queue *queue, int qsize)" + Environment.NewLine);
            tb_Init.AppendText("{" + Environment.NewLine);
            tb_Init.AppendText(" //큐를 동적으로 저장소 생성" + Environment.NewLine);
            tb_Init.AppendText("queue->buf = (int *)malloc(sizeof(int)*qsize);" + Environment.NewLine);
            tb_Init.AppendText("queue->qsize = qsize;" + Environment.NewLine);
            tb_Init.AppendText("//front와 rear를 0으로 설정" + Environment.NewLine);
            tb_Init.AppendText("queue->front = queue->rear = 0;" + Environment.NewLine);
            tb_Init.AppendText("//보관 개수를 0으로 설정" + Environment.NewLine);
            tb_Init.AppendText("}" + Environment.NewLine);
        }
    }
}
