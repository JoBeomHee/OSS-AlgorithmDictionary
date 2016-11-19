using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithm_Dictionary.자료구조_Form.쉘정렬
{
    public partial class ShellSort : Form
    {
        AlgorithmMenu am;
        ShellShortInterval ssi;

        public ShellSort()
        {
            InitializeComponent();
        }

        private void ShellSort_Load(object sender, EventArgs e)
        {
            tb_description.AppendText("쉘 정렬(Shell Sort)이란 Donald L. Shell 이라는 사람이 제안한 방법으로 삽입 정렬이 어느 정도 정렬된 배열에 대해서는 빠르다는 것에 착안한 방법입니다. 삽입 정렬과는 다르게 전체의 리스트를 한번에 정렬하지 않고 먼저 정렬해야 할 리스트를 일정한 기준에 따라 분류하고 연속적이지 않은 여려개의 부분 리스트를 만들고, 각 부분 리스트를 삽입 정렬을 이용하여 정렬하는 방식입니다. 모든 리스트가 정렬되면 쉘 정렬은 다시 전체 리스트를 더 작은 부분 리스트로 만든 후 알고리즘을 반복합니다.(반복은 리스트의 개수가 1이 될 때까지) 이것이 쉘 정렬의 기본 알고리즘 방식입니다. 쉘 정렬리 삽입 정렬에 비해 좋은점은 먼저 교환되는 요소들이 삽입정렬보다 마지막 위치에 있을 가능성이 높다는 것이고, 기본적으로 삽입 정렬을 수행하는 것이지만 삽입 정렬보다 더 빠르게 수행된다는 장점이 있습니다.");

            tb_sort.AppendText("쉘 정렬 함수는 비교 및 정렬해주는 함수와 간격을 나누는 함수 이렇게 두개의 함수가 필요합니다.여기서 정렬을 해주는 함수를 intervalSort라고 선언하고 간격을 나누는 함수를 ShellSort라고 선언해줍니다. 각각의 함수들의 더 사제한 설명은 아래 코드보기 버튼을 클릭하시면 코드와 함께 주석으로 각각의 가능들에 대해서 자세히 볼 수 있습니다.");
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

        private void btn_sort_Click(object sender, EventArgs e)
        {
            ssi = new ShellShortInterval();
            ssi.FormClosed += Ssi_FormClosed;
            ssi.Show();
        }

        private void Ssi_FormClosed(object sender, FormClosedEventArgs e)
        {
            ssi = null;
        }
    }
}
