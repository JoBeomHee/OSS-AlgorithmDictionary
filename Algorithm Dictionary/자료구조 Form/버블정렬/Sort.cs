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
    public partial class Sort : Form
    {
        public Sort()
        {
            InitializeComponent();
        }

        private void Sort_Load(object sender, EventArgs e)
        {
            tb_sort.AppendText("// 버블정렬 함수" + Environment.NewLine);
            tb_sort.AppendText("{" + Environment.NewLine);
            tb_sort.AppendText("int i, j, sort, temp;" + Environment.NewLine);
            tb_sort.AppendText("// list배열 안의 정렬하고자 하는 원소들 출력" + Environment.NewLine);
            tb_sort.AppendText("for (sort = 0; sort < Size; sort++)" + Environment.NewLine);
            tb_sort.AppendText("{" + Environment.NewLine);
            tb_sort.AppendText("printf( % 3d, list[sort]);" + Environment.NewLine);
            tb_sort.AppendText("}" + Environment.NewLine);
            tb_sort.AppendText("for (i = Size - 1; i >0; i--) " + Environment.NewLine);
            tb_sort.AppendText("{" + Environment.NewLine);
            tb_sort.AppendText("//  첫번째 원소부터 i번 원소까지 반복수행 for (j = 0; j<=i; j++) 로 나타낼 수 있다 " + Environment.NewLine);
            tb_sort.AppendText("for (j = -1; j<i; j++)" + Environment.NewLine);
            tb_sort.AppendText(" { " + Environment.NewLine);
            tb_sort.AppendText("// 인접한 두 개의 원소를 비교하여 자리를 교환 if (list[j-1] > list[j]) {" + Environment.NewLine);
            tb_sort.AppendText("if (list[j] > list[j+1])" + Environment.NewLine);
            tb_sort.AppendText("{" + Environment.NewLine);
            tb_sort.AppendText("//temp = list[j-1];" + Environment.NewLine);
            tb_sort.AppendText("temp = list[j]; " + Environment.NewLine);
            tb_sort.AppendText("//list[j-1] = list[j]; " + Environment.NewLine);
            tb_sort.AppendText("// list[j] = temp;" + Environment.NewLine);
            tb_sort.AppendText("} " + Environment.NewLine);
            tb_sort.AppendText("for (sort = 0; sort <Size; sort++) printf( % 3d ,list[sort]); // 정렬의 한 단계별로 결과 출력" + Environment.NewLine);
            tb_sort.AppendText("}" + Environment.NewLine);
            tb_sort.AppendText("}" + Environment.NewLine);
        }
    }
}
