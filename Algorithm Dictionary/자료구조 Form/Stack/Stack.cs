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
        StackPush sp;
        StackPop sd;
        public Stack()
        {
            InitializeComponent();
        }

        private void Stack_Load(object sender, EventArgs e)
        {
            tb_description.Text = "스택은 쉽게 말해서 쌓아 올려진 상자더미나 쟁반 위에 쌓인 접시가 아닐까 생각합니다. 즉, 스택은 한쪽은 막히고 한쪽은 뚫려있는 초코볼 통에 비유할 수 있습니다. 그리고 이렇듯 한쪽만 뚫리다 보니 다음과 같은 특성을 지니게 됩니다. 먼저 들어간 것이 나중에 나온다! 즉, 스택은 나중에 들어간 것이 먼저 나오는 구조이다 보니 후입선출 방식의 자료구조 라고 불리고 영어로 LIFO(Last-In, First-Out) 구조의 자료구조 라고도 불린다.";

            tb_push.Text = "다음은 Stack의 데이터를 삽입하는 함수입니다. 함수의 이름은 PUSH라고 하고 이것의 함수 시그니처를 보게되면 void SPush(Stack * pstack, Data data) 이렇게 됩니다. 이것의 전체 코드를 보고 싶으시면 아래 코드보기 버튼을 누르시면 SPush 함수의 코드가 나오게 됩니다.";

            tb_pop.Text = "다음은 Stack의 데이터를 삭제하는 함수입니다. 함수의 이름은 POP라고 하고 이것의 함수 시그니처를 보게되면 Data SPop(Stack *pstack) 이렇게 됩니다. 이것의 전체 코드를 보고 싶으시면 아래 코드보기 버튼을 누르시면 SPop 함수의 코드가 나오게 됩니다.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sp = new StackPush();
            sp.FormClosed += Sp_FormClosed;
            sp.Show();
        }

        private void Sp_FormClosed(object sender, FormClosedEventArgs e)
        {
            sp = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sd = new StackPop();
            sd.FormClosed += Sd_FormClosed;
            sd.Show();
        }

        private void Sd_FormClosed(object sender, FormClosedEventArgs e)
        {
            sd = null;
        }
    }
}
