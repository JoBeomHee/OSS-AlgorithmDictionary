using Algorithm_Dictionary.자료구조_Form.Stack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithm_Dictionary
{
    public partial class Stack : Form
    {
        AlgorithmMenu am;
        StackPush push;
        StackPop pop;
        public Stack()
        {
            InitializeComponent();
        }

        private void Stack_Load(object sender, EventArgs e)
        {
            tb_description.AppendText("스택은 쉽게 말해서 쌓아 올려진 상자더미나 쟁반 위에 쌓인 접시가 아닐까 생각합니다.\r\n즉, 스택은 한쪽은 막히고 한쪽은 뚫려있는 초코볼 통에 비유할 수 있습니다.\r\n그리고 이렇듯 한쪽만 뚫리다 보니 다음과 같은 특성을 지니게 됩니다.\r\n먼저 들어간 것이 나중에 나온다!\r\n즉, 스택은 나중에 들어간 것이 먼저 나오는 구조이다 보니 후입선출 방식의 자료구조 라고 불리고 영어로 LIFO(Last-In, First-Out) 구조의 자료구조 라고도 불린다.");

            tb_push.AppendText("다음은 Stack의 데이터를 삽입하는 함수입니다.\r\n함수의 이름은 PUSH라고 하고 이것의 함수 시그니처를 보게되면\r\nvoid SPush(Stack * pstack, Data data) 이렇게 됩니다.\r\n이것의 전체 코드를 보고 싶으시면 아래 코드보기 버튼을 누르시면 SPush 함수의 코드가 나오게 됩니다.");

            tb_pop.AppendText("다음은 Stack의 데이터를 삭제하는 함수입니다.\r\n함수의 이름은 POP라고 하고 이것의 함수 시그니처를 보게되면 Data SPop(Stack *pstack) 이렇게 됩니다.\r\n이것의 전체 코드를 보고 싶으시면 아래 코드보기 버튼을 누르시면 SPop 함수의 코드가 나오게 됩니다.");
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            am = new AlgorithmMenu();
            am.FormClosed += Am_FormClosed;
            am.Show();
            this.Close();
        }

        private void Am_FormClosed(object sender, FormClosedEventArgs e)
        {
            am = null;
        }

        private void btn_stack_Click(object sender, EventArgs e)
        {
            push = new StackPush();
            push.FormClosed += Push_FormClosed;
            push.Show();
        }

        private void Push_FormClosed(object sender, FormClosedEventArgs e)
        {
            push = null;
        }

        private void btn_pop_Click(object sender, EventArgs e)
        {
            pop = new StackPop();
            pop.FormClosed += Pop_FormClosed;
            pop.Show();
        }

        private void Pop_FormClosed(object sender, FormClosedEventArgs e)
        {
            pop = null;
        }
    }
}
