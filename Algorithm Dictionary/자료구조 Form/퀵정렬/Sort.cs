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
    public partial class Sort : Form
    {
        public Sort()
        {
            InitializeComponent();
        }

        private void Sort_Load(object sender, EventArgs e)
        {
            tb_sort.AppendText("// 부분집합 안에서 피봇의 위치를 찾아 확정하는 연산" + Environment.NewLine);
            tb_sort.AppendText("int partition(int List[], int begin, int end) " + Environment.NewLine);
            tb_sort.AppendText("{" + Environment.NewLine);
            tb_sort.AppendText("// 분할 작업을 순환적으로 반복하면서 피봇의 왼쪽 부분집합과 오른쪽 부분집합을 정렬하는 방법으로 전체 원소들을 정렬." + Environment.NewLine);
            tb_sort.AppendText("// 부분집합으로 분할하기 위해서 L과 R을 사용." + Environment.NewLine);
            tb_sort.AppendText("L = begin;" + Environment.NewLine);
            tb_sort.AppendText("R = end;" + Environment.NewLine);
            tb_sort.AppendText("// 중간에 위치한 자료를 피봇 원소로 선택" + Environment.NewLine);
            tb_sort.AppendText("pivot = (int)floor((begin + end) / 2);" + Environment.NewLine);
            tb_sort.AppendText("printf(\n[pivot =% d]\n, List[pivot]);" + Environment.NewLine);
            tb_sort.AppendText("while (L < R)" + Environment.NewLine);
            tb_sort.AppendText("{" + Environment.NewLine);
            tb_sort.AppendText("while ((List[L] <= List[pivot]) && (L <= R)) L++;" + Environment.NewLine);
            tb_sort.AppendText("while ((List[R] > List[pivot]) && (L <= R)) R--;" + Environment.NewLine);
            tb_sort.AppendText("if (L <= R)" + Environment.NewLine);
            tb_sort.AppendText("{" + Environment.NewLine);
            tb_sort.AppendText("temp = List[L];" + Environment.NewLine);
            tb_sort.AppendText("List[L] = List[R];" + Environment.NewLine);
            tb_sort.AppendText("List[R] = temp;" + Environment.NewLine);
            tb_sort.AppendText("// L과 R원소를 교환하여, 결과적으로 피봇 원소의 위치가 변경된 경우" + Environment.NewLine);
            tb_sort.AppendText("if (R == pivot)" + Environment.NewLine);
            tb_sort.AppendText("for (sort = 0; sort < size; sort++)" + Environment.NewLine);
            tb_sort.AppendText("{" + Environment.NewLine);
            tb_sort.AppendText("printf( % d, List[sort]);" + Environment.NewLine);
            tb_sort.AppendText("}" + Environment.NewLine);
            tb_sort.AppendText("printf(\n);" + Environment.NewLine);
            tb_sort.AppendText("return L;" + Environment.NewLine);
            tb_sort.AppendText("}" + Environment.NewLine);
            tb_sort.AppendText("}" + Environment.NewLine);
            tb_sort.AppendText("}" + Environment.NewLine);
            tb_sort.AppendText("//  while (L < R)" + Environment.NewLine);
            tb_sort.AppendText("//		(L > R)이 된 경우" + Environment.NewLine);
            tb_sort.AppendText("temp = List[pivot];" + Environment.NewLine);
            tb_sort.AppendText("List[pivot] = List[R];" + Environment.NewLine);
            tb_sort.AppendText("List[R] = temp;" + Environment.NewLine);
            tb_sort.AppendText("//for (sort = 0; sort < size; sort++) printf( % d, List[sort]); // 현재의 정렬 상태 출력" + Environment.NewLine);
            tb_sort.AppendText("printf(\n);" + Environment.NewLine);
            tb_sort.AppendText("return R;" + Environment.NewLine);
            tb_sort.AppendText("}" + Environment.NewLine);

            tb_sort.AppendText(Environment.NewLine);
            tb_sort.AppendText(Environment.NewLine);
            tb_sort.AppendText(Environment.NewLine);

            tb_sort.AppendText("//퀵 정렬 함수"+Environment.NewLine);
            tb_sort.AppendText("void quickSort(int List[], int begin, int end) " + Environment.NewLine);
            tb_sort.AppendText("{" + Environment.NewLine);
            tb_sort.AppendText("if (begin < end) " + Environment.NewLine);
            tb_sort.AppendText("{" + Environment.NewLine);
            tb_sort.AppendText("int p_operation;" + Environment.NewLine);
            tb_sort.AppendText("p_operation = partition(List, begin, end);" + Environment.NewLine);
            tb_sort.AppendText("for (int i = 0; i < 8; i++) " + Environment.NewLine);
            tb_sort.AppendText("{" + Environment.NewLine);
            tb_sort.AppendText("printf( % d , List[i]);" + Environment.NewLine);
            tb_sort.AppendText("}" + Environment.NewLine);
            tb_sort.AppendText("printf(\n);" + Environment.NewLine);
            tb_sort.AppendText("// 피봇의 왼쪽 부분집합에 대해 퀵 정렬 재귀호출" + Environment.NewLine);
            tb_sort.AppendText("quickSort(List, begin, p_operation - 1);" + Environment.NewLine);
            tb_sort.AppendText("// 피봇의 오른쪽 부분집합에 대해 퀵 정렬 재귀호출" + Environment.NewLine);
            tb_sort.AppendText("quickSort(List, p_operation + 1, end); " + Environment.NewLine);
        }
    }
}
