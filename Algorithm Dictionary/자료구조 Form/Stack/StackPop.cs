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
    public partial class StackPop : Form
    {

        public StackPop()
        {
            InitializeComponent();
        }

        private void StackPop_Load(object sender, EventArgs e)
        {
            tb_pop.AppendText("//스택의 pop 연산" + Environment.NewLine);
            tb_pop.AppendText("int index = 0;" + Environment.NewLine);
            tb_pop.AppendText("//스택이 비었다면 더이상 삭제할 데이터가 없다." + Environment.NewLine);
            tb_pop.AppendText("if (SIsEmpty(pstack))" + Environment.NewLine);
            tb_pop.AppendText("// 메모리 Error 표현" + Environment.NewLine);
            tb_pop.AppendText("printf(Stack Memory Error!);" + Environment.NewLine);
            tb_pop.AppendText("exit(-1);" + Environment.NewLine);
            tb_pop.AppendText("//삭제할 데이터가 저장된 인덱스 값 저장" + Environment.NewLine);
            tb_pop.AppendText("index = pstack->topIndex;" + Environment.NewLine);
            tb_pop.AppendText("//pop 연산의 결과로 topIndex값 1 감소" + Environment.NewLine);
            tb_pop.AppendText("pstack->topIndex -= 1;" + Environment.NewLine);
            tb_pop.AppendText("//삭제되는 데이터값 반환" + Environment.NewLine);
            tb_pop.AppendText("return pstack->stackArr[index];" + Environment.NewLine);
        }
    }
}
