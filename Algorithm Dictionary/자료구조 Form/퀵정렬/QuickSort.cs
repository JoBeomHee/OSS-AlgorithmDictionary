using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithm_Dictionary.자료구조_Form.퀵정렬
{
    public partial class QuickSort : Form
    {
        AlgorithmMenu am;
        Sort sort;

        public QuickSort()
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
            System.Diagnostics.Process.Start("http://ehclub.co.kr/1550");
        }

        private void QuickSort_Load(object sender, EventArgs e)
        {
            tb_description.AppendText("퀵정렬(Quick Sort) : 정렬할 전체 원소에 대해서 정렬을 수행하지 않고 기준값을 중심으로 왼쪽 부분집합과 오른쪽 부분집합으로 분할. 왼쪽 부분집합에는 기준값보다 작은 원소들을 이동시키고, 오른쪽 부분집합에는 기준값보다 큰 원소들을 이동시킨다. 이때 사용하는 기준값을 피봇(Pivot)이라고 하는데, 일반적으로 전체 원소 중에서 가운데에 위치한 원소를 피봇으로 선택. 퀵 정렬은 다음의 2가지 기본 작업을 반복 수행하여 완성한다. (1) 분할(Divide) : 정렬할 자료들을 기준값을 중심으로 2개의 부분집합으로 분할. (2) 정복(Conquer) : 부분집합의 원소들 중에서 기준값보다 작은 원소들은 왼쪽 부분집합으로, 기준값보다 큰 원소들은 오른쪽 부분집합으로 정렬한다.부분집합의 크기가 1이하로 충분히 작지 않으면 순환 호출을 이용하여 다시 분할");
            tb_sort.AppendText("다음으로는 정렬함수 입니다. 먼저 부분집합을 선언해 그 부분집합 안에서 피복의 위치를 찾아 확정하는 연산을 만듭니다. 그리고 분할 작업을 순환적으로 반복하면서 피봇의 왼쪽 부분집합과 오른쪽 부분집합을 정렬하는 방법으로 전체 원소들을 정렬합니다. 그리고 중간에 위치한 자료를 피봇 원소로 선택합니다. 다음으로  Left 와 Right원소를 교환하여, 결과적으로 피봇 원소의 위치가 변경된 경우에 하나하나 정렬해서 출력해 줍니다. 이 과정을 소스코드로 보고 싶으시다면 아래 코드보기 버튼을 눌러주세요. ");
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
    }
}
