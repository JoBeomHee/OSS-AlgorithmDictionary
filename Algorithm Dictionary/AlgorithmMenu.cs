using Algorithm_Dictionary.자료구조_Form.링크드리스트;
using Algorithm_Dictionary.자료구조_Form.삽입정렬;
using Algorithm_Dictionary.자료구조_Form.선택정렬;
using Algorithm_Dictionary.자료구조_Form.이진탐색트리;
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
    public partial class AlgorithmMenu : Form
    {
        Stack stack;
        LinkedList ll;
        InsertSort Is;
        SelectionSort ss;
        BinarySearchTree bst;

        public AlgorithmMenu()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

            if (tb_Search.Text.ToString() == "스택")
            {
                stack = new Stack();
                stack.FormClosed += Stack_FormClosed;
                stack.Show();
                this.Close();
            }
            if (tb_Search.Text.ToString() == "연결리스트")
            {
                ll = new LinkedList();
                ll.FormClosed += Ll_FormClosed;
                ll.Show();
                this.Close();
            }
            if (tb_Search.Text.ToString() == "삽입정렬")
            {
                Is = new InsertSort();
                Is.FormClosed += Is_FormClosed;
                Is.Show();
                this.Close();
            }
            if(tb_Search.Text.ToString() == "선택정렬")
            {
                ss = new SelectionSort();
                ss.FormClosed += Ss_FormClosed;
                ss.Show();
                this.Close();
            }
            if(tb_Search.Text.ToString() == "이진탐색트리")
            {
                bst = new BinarySearchTree();
                bst.FormClosed += Bst_FormClosed;
                bst.Show();
                this.Close();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            tb_Search.Text = tb_Search.Text;
        }

        private void Bst_FormClosed(object sender, FormClosedEventArgs e)
        {
            bst = null;
        }

        private void Ss_FormClosed(object sender, FormClosedEventArgs e)
        {
            ss = null;
        }

        private void Is_FormClosed(object sender, FormClosedEventArgs e)
        {
            Is = null;
        }

        private void Ll_FormClosed(object sender, FormClosedEventArgs e)
        {
            ll = null;
        }

        private void Stack_FormClosed(object sender, FormClosedEventArgs e)
        {
            stack = null;
        }

        private void Key_Enter(object sender, KeyPressEventArgs e) //엔터키 눌렀을 때 검색
        {
            if (e.KeyChar == '\r')
            {
                btn_Search_Click(sender, e);

            }
        }

        private void tb_search(object sender, KeyPressEventArgs e) //엔터키 눌렀을 때 검색
        {
            if (e.KeyChar == '\r')
            {
                btn_Search_Click(sender, e);

            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lb_menu_SelectedIndexChanged(object sender, EventArgs e) // 리스트 박스 선택
        {
            if(lb_menu.SelectedIndex == 0)
            {
                tb_Search.Text = "스택";
            }
            if (lb_menu.SelectedIndex == 1)
            {
                tb_Search.Text = "연결리스트";
            }
            if (lb_menu.SelectedIndex == 2)
            {
                tb_Search.Text = "큐";
            }
            if (lb_menu.SelectedIndex == 3)
            {
                tb_Search.Text = "크루스칼 알고리즘";
            }
            if (lb_menu.SelectedIndex == 4)
            {
                tb_Search.Text = "프림 알고리즘";
            }
            if (lb_menu.SelectedIndex == 5)
            {
                tb_Search.Text = "깊이우선탐색";
            }
            if (lb_menu.SelectedIndex == 6)
            {
                tb_Search.Text = "너비우선탐색";
            }
            if (lb_menu.SelectedIndex == 7)
            {
                tb_Search.Text = "이진탐색트리";
            }
            if (lb_menu.SelectedIndex == 8)
            {
                tb_Search.Text = "삽입정렬";
            }
            if (lb_menu.SelectedIndex == 9)
            {
                tb_Search.Text = "선택정렬";
            }
            if (lb_menu.SelectedIndex == 10)
            {
                tb_Search.Text = "쉘정렬";
            }
            if (lb_menu.SelectedIndex == 11)
            {
                tb_Search.Text = "버블정렬";
            }
            if (lb_menu.SelectedIndex == 12)
            {
                tb_Search.Text = "힙정렬";
            }
            if (lb_menu.SelectedIndex == 13)
            {
                tb_Search.Text = "퀵정렬";
            }
            if (lb_menu.SelectedIndex == 14)
            {
                tb_Search.Text = "카운팅정렬";
            }
            if (lb_menu.SelectedIndex == 15)
            {
                tb_Search.Text = "기수정렬";
            }
            if (lb_menu.SelectedIndex == 16)
            {
                tb_Search.Text = "버킷정렬";
            }
            if (lb_menu.SelectedIndex == 17)
            {
                tb_Search.Text = "머지정렬";
            }
        }

        private void lb_Enter(object sender, KeyPressEventArgs e)  //엔터키 눌렀을 때 적용
        {
            if (e.KeyChar == '\r')
            {
                btn_Search_Click(sender, e);

            }
        }
    }
}
