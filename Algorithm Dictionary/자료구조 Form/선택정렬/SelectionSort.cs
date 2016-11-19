using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithm_Dictionary.자료구조_Form.선택정렬
{
    public partial class SelectionSort : Form
    {
        AlgorithmMenu am;
        Sort sort;

        public SelectionSort()
        {
            InitializeComponent();
        }

        private void SelectionSort_Load(object sender, EventArgs e)
        {
            tb_description.AppendText("선택정렬의 정의는 정렬되지 않은 데이터들에 대해 가장 작은 데이터를 찾아 가장 앞의 데이터와 교환해나가는 방식입니다.\r\n첫번째 값부터 기준으로 설정하고 기준으로 설정된 값과 두 번째 위치,… n 번째위치의 값과 비교하면서 정렬합니다.\r\n가장 작은 값을 찾아서 제일 앞에 놓고, 이 다음 작은 값을 찾아 앞에 놓는 방법을 반복해서 가장 먼저 오는 값을 찾아서 제일 앞에 놓습니다.\r\n다음에 올 수 있는 값을 두 번째에 놓고하는 작업을 반복하여 n개의 값들을 정리합니다.");

            tb_sort.AppendText("다음으로는 선택정렬의 정렬 함수에 대한 설명입니다.\r\n위의 정의에서도 나타나 있듯이 첫 번째 값부터 기준으로 설정하고 기준으로 설정된 값과 두 번째 위치,… n 번째 위치의 값과 비교하면서 정렬합니다.\r\n이 다음 작은 값을 찾아 앞에 놓는 방법을 반복해서 가장 먼저 오는 값을 찾아서 제일 앞에 놓는 방식입니다.\r\n이것이 선택정렬입니다. 위의 설명을 코드로 보고 싶으시면 코드보기 버튼을 눌러주세요. ");
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
    }
}
