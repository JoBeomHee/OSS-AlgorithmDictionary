using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithm_Dictionary.자료구조_Form.삽입정렬
{
    public partial class InsertSort : Form
    {
        AlgorithmMenu am;
        Sort sort;
        public InsertSort()
        {
            InitializeComponent();
        }


        private void InsertSort_Load(object sender, EventArgs e)
        {
            tb_description.AppendText("삽입정렬은 이름에서 알 수 있듯이 삽입을 통해 정렬을 완성하는 알고리즘 입니다. 상입정렬은 모든 데이터를 앞에서부터 차례로 비교하여 자신의 위치에 삽일을 통해 정렬을 수행합니다. 배열이 길어질수록 효율이 떨어지지만 구현이 간단하다는 장점이 있습니다.");

            tb_sort.AppendText("삽입 정렬은 하나의 중첩 루프를 돕니다. 바깥 루프 j는 정렬되지 않은 집압의 어느 항목이 현재 정렬된 항목들에 삽입되는지를 제어합니다. 정렬된 집합의 오른쪽에 있는 항목이 항상 다음에 삽입할 항목이므로, j는 자료즤 정렬된 집합과 정렬되지 않은 집합을 구분하는 위치로도 생각할 수 있습니다. 위치 j의 항목에 대해 안쪽 루프 i는 항목의 제 위치를 찾을 때까지 정렬된 항목들의 집합을 따라 뒤로 순환하는 데 사용됩니다. 집합을 따라 뒤로 이동하면서 삽일을 위한 공간을 만들기 위해 위치 i의 항목은 오른쪽으로 복사가 됩니다. j가 정렬되지 않은 집합의 끝에 도달하면 data는 정렬됩니다. 이것의 코드를 보시고 싶으시면 정렬코드보기 버튼을 클릭해 주세요.");
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
    }
}
