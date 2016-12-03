using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithm_Dictionary.자료구조_Form.머지정렬
{
    public partial class MergeSort : Form
    {
        AlgorithmMenu am;
        Sort sort;
        public MergeSort()
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
            System.Diagnostics.Process.Start("http://ehclub.co.kr/2971");
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

        private void MergeSort_Load(object sender, EventArgs e)
        {
            tb_description.AppendText("병합정렬이란 해당 정렬원소가 많을수록 비교 및 삽입연산이 많이 발생합니다. 따라서 그 연산을 최소화하기 위하여 정렬하고자 하는 해당 배열을 하나의 단위로 분할한 후 거꾸로 합병하면서 정렬을 하여 최종적으로 전체 배열의 정렬을 하는 방식이 병합정렬(MergeSort)입니다.");
            tb_sort.AppendText("다음으로는 병합정렬의 핵심인 Sort 함수입니다. 첫 번째로는 분할을 합니다. 분할을 할 때에는 배열 집합을 하나의 원소 단위로 각각 분할을 해줍니다. 두 번째로는 병합니다. 병합에서는 분할된 각각의 원소에 대해 서로의 쌍을 비교하여 sorting후 병합을 합니다. 세 번째로는 sorting과정으로서 병합시의 우선 병합하려고 하는 크기의 메모리를 할당하고 두개의 원소에 대해 각각을 비교하여 할당된 메모리에 집어넣으면 됩니다. 이 과정들을 C코드로 보고 싶으시다면 아래 코드보기 버튼을 클릭해 주세요.");
        }
    }
}
