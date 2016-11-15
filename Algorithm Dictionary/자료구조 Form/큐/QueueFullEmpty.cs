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
    public partial class QueueFullEmpty : Form
    {
        public QueueFullEmpty()
        {
            InitializeComponent();
        }

        private void QueueFullEmpty_Load(object sender, EventArgs e)
        {
            tb_FullEmpty.AppendText("//큐가 꽉 찼는지 확인하는 함수" + Environment.NewLine);
            tb_FullEmpty.AppendText("int IsFull(Queue *queue)" + Environment.NewLine);
            tb_FullEmpty.AppendText("{" + Environment.NewLine);
            tb_FullEmpty.AppendText("//보관 개수가 qsize와 같으면 꽉 찬 상태" + Environment.NewLine);
            tb_FullEmpty.AppendText("return queue->count == queue->qsize;" + Environment.NewLine);
            tb_FullEmpty.AppendText("}" + Environment.NewLine);
            tb_FullEmpty.AppendText("//큐가 비었는지 확인하는 함수" + Environment.NewLine);
            tb_FullEmpty.AppendText("int IsEmpty(Queue *queue)" + Environment.NewLine);
            tb_FullEmpty.AppendText("{" + Environment.NewLine);
            tb_FullEmpty.AppendText("//보관 개수가 0이면 빈 상태" + Environment.NewLine);
            tb_FullEmpty.AppendText("return queue->count == 0;" + Environment.NewLine);
            tb_FullEmpty.AppendText("}" + Environment.NewLine);
        }
    }
}
