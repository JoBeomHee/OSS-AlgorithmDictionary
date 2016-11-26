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
    public partial class Sort : Form
    {
        public Sort()
        {
            InitializeComponent();
        }

        private void Sort_Load(object sender, EventArgs e)
        {
            tb_sort.AppendText("void HeapSort(int *list, int n)"+Environment.NewLine);
            tb_sort.AppendText("{" + Environment.NewLine);
            tb_sort.AppendText("int i, temp;" + Environment.NewLine);
            tb_sort.AppendText("// 초기 히프" + Environment.NewLine);
            tb_sort.AppendText("for (i = (n / 2); i >= 1; i--)" + Environment.NewLine);
            tb_sort.AppendText("adjust(list, i, n);" + Environment.NewLine);
            tb_sort.AppendText("for (i = (n - 1); i >= 1; i--)" + Environment.NewLine);
            tb_sort.AppendText("{" + Environment.NewLine);
            tb_sort.AppendText("temp = list[i + 1];" + Environment.NewLine);
            tb_sort.AppendText("list[i + 1] = list[1];" + Environment.NewLine);
            tb_sort.AppendText("list[1] = temp;" + Environment.NewLine);
            tb_sort.AppendText("adjust(list, 1, i);" + Environment.NewLine);
            tb_sort.AppendText("}" + Environment.NewLine);
            tb_sort.AppendText("}" + Environment.NewLine);

            tb_sort.AppendText(Environment.NewLine);
            tb_sort.AppendText(Environment.NewLine);
            tb_sort.AppendText(Environment.NewLine);

            tb_sort.AppendText("void adjust(int *list, int i, int n)" + Environment.NewLine);
            tb_sort.AppendText("{" + Environment.NewLine);
            tb_sort.AppendText("int j, k, done;" + Environment.NewLine);
            tb_sort.AppendText("done = 0;" + Environment.NewLine);
            tb_sort.AppendText("k = list[i];" + Environment.NewLine);
            tb_sort.AppendText("j = 2 * i;" + Environment.NewLine);
            tb_sort.AppendText("while ((j <= n) && (!done))" + Environment.NewLine);
            tb_sort.AppendText("{" + Environment.NewLine);
            tb_sort.AppendText("if (j<n)" + Environment.NewLine);
            tb_sort.AppendText("if (list[j] < list[j + 1])" + Environment.NewLine);
            tb_sort.AppendText("// 자식노드들 중 큰 노드를 선택" + Environment.NewLine);
            tb_sort.AppendText("j++;" + Environment.NewLine);
            tb_sort.AppendText("if (k >= list[j])" + Environment.NewLine);
            tb_sort.AppendText("// 자식 노드보다 크므로 중단" + Environment.NewLine);
            tb_sort.AppendText("done = 1;" + Environment.NewLine);
            tb_sort.AppendText("else" + Environment.NewLine);
            tb_sort.AppendText("{" + Environment.NewLine);
            tb_sort.AppendText("list[j / 2] = list[j];" + Environment.NewLine);
            tb_sort.AppendText("j *= 2;" + Environment.NewLine);
            tb_sort.AppendText("}" + Environment.NewLine);
            tb_sort.AppendText("}" + Environment.NewLine);
            tb_sort.AppendText("}" + Environment.NewLine);
            tb_sort.AppendText(" //처음 저장한 노드의 값을 저장" + Environment.NewLine);
            tb_sort.AppendText("list[j / 2] = k; " + Environment.NewLine);
            tb_sort.AppendText("}" + Environment.NewLine);
        }
    }
}
