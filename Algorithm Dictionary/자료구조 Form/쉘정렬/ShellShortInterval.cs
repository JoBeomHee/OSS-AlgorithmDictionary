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
    public partial class ShellShortInterval : Form
    {
        public ShellShortInterval()
        {
            InitializeComponent();
        }

        private void ShellShortInterval_Load(object sender, EventArgs e)
        {
            tb_sort.AppendText(" //비교 및 정렬함수" + Environment.NewLine);
            tb_sort.AppendText("void intervalSort(int a[], int begin, int end, int interval)" + Environment.NewLine);
            tb_sort.AppendText("{" + Environment.NewLine);
            tb_sort.AppendText("int i, j, num;" + Environment.NewLine);
            tb_sort.AppendText("for (i = begin + interval; i <= end; i = i + interval)" + Environment.NewLine);
            tb_sort.AppendText("{" + Environment.NewLine);
            tb_sort.AppendText("num = a[i];" + Environment.NewLine);
            tb_sort.AppendText("for (j = i - interval; j >= begin && num<a[j]; j = j - interval)" + Environment.NewLine);
            tb_sort.AppendText("{" + Environment.NewLine);
            tb_sort.AppendText("//앞에 것이 클때" + Environment.NewLine);
            tb_sort.AppendText("a[j + interval] = a[j];" + Environment.NewLine);
            tb_sort.AppendText("count++;" + Environment.NewLine);
            tb_sort.AppendText("}" + Environment.NewLine);
            tb_sort.AppendText("//앞에 것이 작을때"+Environment.NewLine);
            tb_sort.AppendText("[j + interval] = num;" + Environment.NewLine);
            tb_sort.AppendText("}" + Environment.NewLine);
            tb_sort.AppendText("count++" + Environment.NewLine);
            tb_sort.AppendText("}" + Environment.NewLine);

            tb_sort.AppendText(Environment.NewLine);
            tb_sort.AppendText(Environment.NewLine);
            tb_sort.AppendText(Environment.NewLine);

            tb_sort.AppendText("//간격을 나누는 함수" + Environment.NewLine);
            tb_sort.AppendText("void ShellSort(int a[], int size)" + Environment.NewLine);
            tb_sort.AppendText("{" + Environment.NewLine);
            tb_sort.AppendText("int i, t, interval;" + Environment.NewLine);
            tb_sort.AppendText("for (t = 0; t < size; t++)" + Environment.NewLine);
            tb_sort.AppendText("printf( % d \n, a[t]);" + Environment.NewLine);
            tb_sort.AppendText(" //간격을 나눔" + Environment.NewLine);
            tb_sort.AppendText("interval = size / 2;" + Environment.NewLine);
            tb_sort.AppendText("while (interval >= 1)" + Environment.NewLine);
            tb_sort.AppendText("{" + Environment.NewLine);
            tb_sort.AppendText("for (i = 0; i < interval; i++)" + Environment.NewLine);
            tb_sort.AppendText(" //간격을 나누는 함수 호출" + Environment.NewLine);
            tb_sort.AppendText("intervalSort(a, i, size - 1, interval);" + Environment.NewLine);
            tb_sort.AppendText("printf(interval = % d >> , interval);" + Environment.NewLine);
            tb_sort.AppendText("for (t = 0; t < size; t++)" + Environment.NewLine);
            tb_sort.AppendText("printf( % d \n, a[t]);" + Environment.NewLine);
            tb_sort.AppendText("interval = interval / 2;" + Environment.NewLine);
            tb_sort.AppendText("}" + Environment.NewLine);
            tb_sort.AppendText("//비교횟수 출력" + Environment.NewLine);
            tb_sort.AppendText("printf(\n[총 데이터 비교 횟수: % d번]\n, count); "+Environment.NewLine);
            tb_sort.AppendText("}" + Environment.NewLine);
            tb_sort.AppendText("}" + Environment.NewLine);

        }
    }
}
