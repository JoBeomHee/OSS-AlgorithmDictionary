using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithm_Dictionary.자료구조_Form.계수정렬
{
    public partial class CountingSort : Form
    {
        AlgorithmMenu am;
        Sort sort;

        public CountingSort()
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
            System.Diagnostics.Process.Start("http://bowbowbow.tistory.com/8");
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

        private void CountingSort_Load(object sender, EventArgs e)
        {
            tb_description.AppendText("카운팅 정렬을 항복들의 순서를 결정하기 위해 집합에 각 항목이 몇 개씩 있는지 작업을 하면서 선형 시간에 정렬하는 효율적인 알고리즘입니다. 또한, 속도가 빠르면서 안정적입니다. 시간 복잡도 O(n)을 가지는 알고리즘입니다.하지만 제한 사항이 있습니다. 정수나 정수로 표현할 수 있는 자료에 대해서만 동작을 한다는 제한이 있습니다. 카운트들을 위한 충분한 공간을 할당하려면 집합내의 큰 정수를 알아야합니다.");
            tb_sort.AppendText("다음은 카운팅정렬의 수행과정입니다. 첫 번째로는 최대값만큼 배열을 만듭니다. 입력받은 값을 세서 만든 배열에 넣고 누적합니다. 세 번째로는 입력받은 배열의 인덱스 값들을 순서대로 배열의 인덱스로 가게 합니다. 마지막으로는 배열의 인덱스의 값을 하나 감소시킨 값을 정렬 시킬 배열에 넣어줌으로 정렬이 끝이 납니다. 이 과정들을 C 코드로 보고 싶으시다면 아래 코드보기 버튼을 눌러주세요.");
        }
    }
}
