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
            tb_sort.AppendText("먼저 버킷을 큐로 구성하여 사용하므로 큐에 대한 연산을 정의합니다. 그리고 기수정렬 함수 안에서는 배열 list에 있는 n개의 원소에 대해서 기수 정렬을 수행하는 연산을 수행합니다. 여기 안에서는 정렬할 자료의 기수, 즉 RADIX에 따라 10개의 버킷을 큐로 생성하고 키값의 자릿수만큼 반복 수행해 정렬을 해 나갑니다. 이 과정을 코드로 자세히 보고 싶으시다면 코드보기 버튼을 눌러주세요.");
        }
    }
}
