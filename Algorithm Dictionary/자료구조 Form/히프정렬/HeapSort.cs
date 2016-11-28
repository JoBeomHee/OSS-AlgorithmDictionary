using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithm_Dictionary.자료구조_Form.히프정렬
{
    public partial class HeapSort : Form
    {
        AlgorithmMenu am;
        Sort sort;

        public HeapSort()
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
            System.Diagnostics.Process.Start("http://ehclub.co.kr/1552");
        }

        private void HeapSort_Load(object sender, EventArgs e)
        {
            tb_description.AppendText("힙정렬: 우선 순위 큐인 힙을 이용하여, 모든 원소를 힙에 집어넣었다가 빼는 방식으로 정렬을 하는 알고리즘입니다.");
            tb_sort.AppendText("다음은 힙 정렬 함수의 설명입니다.\r\n첫 번째로 n개의 노드에 대한 완전 이진 트리를 구성합니다.\r\n그리고 나서 두 번째로 최대 힙을 구성합니다.\r\n세 번째로는 가장 큰 수(루트에 위치)를 가장 작은 수와 교환을 합니다.\r\n네 번째로는 두 번째와 세 번째를 반복합니다.\r\n이것이 힙 정렬의 핵심입니다.\r\n이 것을 C코드로 보고 싶으시다면 아래 코드보기 버튼을 클릭해 주세요.");
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
