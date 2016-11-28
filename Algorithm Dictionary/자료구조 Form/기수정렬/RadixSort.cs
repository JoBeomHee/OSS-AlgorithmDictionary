using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithm_Dictionary.자료구조_Form.기수정렬
{
    public partial class RadixSort : Form
    {
        AlgorithmMenu am;
        Sort sort;

        public RadixSort()
        {
            InitializeComponent();
        }

        private void pb_back_Click(object sender, EventArgs e)
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

        private void btn_sort_Click(object sender, EventArgs e)
        {
            sort = new Sort();
            sort.FormClosed += Sort_FormClosed;
            sort.Show();
        }

        private void Sort_FormClosed(object sender, FormClosedEventArgs e)
        {
            sort = null;
        }

        private void lb_link_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://blog.naver.com/PostView.nhn?blogId=redwave102&logNo=80075364360");
        }

        private void RadixSort_Load(object sender, EventArgs e)
        {
            tb_description.AppendText("간단히 기수정렬의 개념을 얘기하자면 입력이 모두 K이하의 자리 수를 가진 특수한 경우에(자연구가 아닌 제한된 종류를 가진 알파벳 등도 해당)사용할 수 있는 방법이다.");
        }
    }
}
