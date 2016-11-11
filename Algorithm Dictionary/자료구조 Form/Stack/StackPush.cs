using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithm_Dictionary.자료구조_Form.Stack
{
    public partial class StackPush : Form
    {
        public StackPush()
        {
            InitializeComponent();
        }

        private void StackPush_Load(object sender, EventArgs e)
        {
            tb_push.AppendText("//스택의 push 연산" + Environment.NewLine);
            tb_push.AppendText("void SPush(Stack * pstack, Data data)" + Environment.NewLine);
            tb_push.AppendText("//데이터 추가를 위한 인덱스 추가" + Environment.NewLine);
            tb_push.AppendText("pstack->topIndex += 1" + Environment.NewLine);
            tb_push.AppendText("//추가 전 인덱스의 데이터를 저장" + Environment.NewLine);
            tb_push.AppendText("pstack->stackArr[pstack->topIndex] = data" + Environment.NewLine);
        }
    }
}
