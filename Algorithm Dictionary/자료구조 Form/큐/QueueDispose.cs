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
    public partial class QueueDispose : Form
    {
        public QueueDispose()
        {
            InitializeComponent();
        }

        private void QueueDispose_Load(object sender, EventArgs e)
        {
            tb_dispose.AppendText("//큐 해제화 함수" + Environment.NewLine);
            tb_dispose.AppendText("void DisposeQueue(Queue *queue)" + Environment.NewLine);
            tb_dispose.AppendText("{" + Environment.NewLine);
            tb_dispose.AppendText("free(queue->buf);" + Environment.NewLine);
            tb_dispose.AppendText("}" + Environment.NewLine);
        }
    }
}
