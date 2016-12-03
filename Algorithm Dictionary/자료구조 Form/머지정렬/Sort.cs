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
    public partial class Sort : Form
    {
        public Sort()
        {
            InitializeComponent();
        }

        private void Sort_Load(object sender, EventArgs e)
        {
            tb_sort.AppendText("// Array를 두개의 덩어리로 분할" + Environment.NewLine);
            tb_sort.AppendText("void merge_sort(int num[], int start, int end) {" + Environment.NewLine);
            tb_sort.AppendText("// 중간값 설정" + Environment.NewLine);
            tb_sort.AppendText("int median = (start + end) / 2;" + Environment.NewLine);
            tb_sort.AppendText("// 덩어리의 원소가 하나일 때까지" + Environment.NewLine);
            tb_sort.AppendText("if (start < end) {" + Environment.NewLine);
            tb_sort.AppendText("merge_sort(num, start, median);" + Environment.NewLine);
            tb_sort.AppendText("// 각각의 덩어리로 재귀함수 호출 " + Environment.NewLine);
            tb_sort.AppendText("merge_sort(num, median + 1, end);" + Environment.NewLine);
            tb_sort.AppendText(" // 각각의 덩어리를 묶으면서 정렬" + Environment.NewLine);
            tb_sort.AppendText("merge(num, start, median, end); " + Environment.NewLine);
            tb_sort.AppendText("}" + Environment.NewLine);
            tb_sort.AppendText("}" + Environment.NewLine);

            tb_sort.AppendText(Environment.NewLine);
            tb_sort.AppendText(Environment.NewLine);

            tb_sort.AppendText("void merge(int num[], int start, int median, int end) {" + Environment.NewLine);
            tb_sort.AppendText("int i, j, k, m, n;" + Environment.NewLine);
            tb_sort.AppendText(" // 임시로 데이터를 저장할 배열" + Environment.NewLine);
            tb_sort.AppendText("int tempArr[LEN];" + Environment.NewLine);
            tb_sort.AppendText("// 앞의 덩어리의 시작 Index" + Environment.NewLine);
            tb_sort.AppendText("i = start;" + Environment.NewLine);
            tb_sort.AppendText("// 뒤의 덩어리의 시작 Index" + Environment.NewLine);
            tb_sort.AppendText("j = median + 1;" + Environment.NewLine);
            tb_sort.AppendText(" // 임시 배열의 시작 Index" + Environment.NewLine);
            tb_sort.AppendText("k = start;" + Environment.NewLine);
            tb_sort.AppendText("while (i <= median && j <= end) {" + Environment.NewLine);
            tb_sort.AppendText(" //작은 숫자를 찾아 임시 배열에 넣는다. 어느쪽 덩어리든 Index의 끝에 닿으면 빠져나온다." + Environment.NewLine);
            tb_sort.AppendText("tempArr[k++] = (num[i] > num[j]) ? num[j++] : num[i++];" + Environment.NewLine);
            tb_sort.AppendText("}" + Environment.NewLine);
            tb_sort.AppendText(" // 아직 배열에 속하지 못한 부분들을 넣기 위한 부분" + Environment.NewLine);
            tb_sort.AppendText("// 아직 원소가 남아있는 덩어리가 어디인지 파악" + Environment.NewLine);
            tb_sort.AppendText("m = (i > median) ? j : i;"+Environment.NewLine);
            tb_sort.AppendText(" // 마찬가지로, for문의 끝 Index를 정하기 위함" + Environment.NewLine);
            tb_sort.AppendText("n = (i > median) ? end : median; " + Environment.NewLine);
            tb_sort.AppendText("// 앞에서 구한 m, n으로 배열에 속하지 못한 원소들을 채움" + Environment.NewLine);
            tb_sort.AppendText("for (; m <= n; m++) {" + Environment.NewLine);
            tb_sort.AppendText("tempArr[k++] = num[m];" + Environment.NewLine);
            tb_sort.AppendText("}" + Environment.NewLine);
            tb_sort.AppendText("for (m = start; m <= end; m++) {" + Environment.NewLine);
            tb_sort.AppendText("// 임시 배열에서 원래 배열로 데이터 옮기기" + Environment.NewLine);
            tb_sort.AppendText("num[m] = tempArr[m];" + Environment.NewLine);
            tb_sort.AppendText("}" + Environment.NewLine);
            tb_sort.AppendText("tracer(num, LEN);" + Environment.NewLine);
            tb_sort.AppendText("}" + Environment.NewLine);

            tb_sort.AppendText(Environment.NewLine);
            tb_sort.AppendText(Environment.NewLine);

            tb_sort.AppendText("void tracer(int num[], int len) {" + Environment.NewLine);
            tb_sort.AppendText("int i;" + Environment.NewLine);
            tb_sort.AppendText("for (i = 0; i<len; i++) {" + Environment.NewLine);
            tb_sort.AppendText("printf( % d\t, num[i]);" + Environment.NewLine);
            tb_sort.AppendText("}" + Environment.NewLine);
            tb_sort.AppendText("}" + Environment.NewLine);
        }
    }
}
