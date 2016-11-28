using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithm_Dictionary.자료구조_Form.버블정렬
{
    public partial class BubbleSort : Form
    {
        AlgorithmMenu am;
        Sort sort;
        public BubbleSort()
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

        private void lb_link_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://ehclub.co.kr/2844");
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

        private void BubbleSort_Load(object sender, EventArgs e)
        {
            tb_description.AppendText("버블정렬(Bubble Sort) : 인접한 두 개의 원소를 비교하여 자리를 교환하는 방식 첫 번째 원소부터 마지막 원소까지 반복하면 가장 큰 원소가 마지막 자리에 온다. 첫 번째 원소부터 인접한 원소끼리 계속 자리를 교환하면서 맨 마지막 자리로 이동하는 모습이 물 속에서 물 위로 올라오는 물방울 모양과 같다고 해서 버블정렬이라고 칭함");
            tb_sort.AppendText("다음으로는 버블정렬의 함수입니다. 여기서는 인접한 두 개의 원소를 비교하여 자리를 교환합니다. 함수 설명은 위에 버블정렬 정의에서 말한 그대로 첫 번째 원소부터 마지막 원소까지 반복하면서 가장 큰 원소가 마지막 자리에 올 때까지 반복을 하는 것 입니다. 이것을 코드로 보고 싶으시다면 코드보기 버튼을 눌러주세요.");
        }
    }
}
