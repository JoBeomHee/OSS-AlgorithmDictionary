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
    public partial class Sort : Form
    {
        public Sort()
        {
            InitializeComponent();
        }

        private void Sort_Load(object sender, EventArgs e)
        {
            tb_sort.AppendText("void CountingSort(int *array, int n, int min, int max)" + Environment.NewLine);
            tb_sort.AppendText("{" + Environment.NewLine);
            tb_sort.AppendText("int i, j, z;" + Environment.NewLine);
            tb_sort.AppendText("int range = max - min + 1;" + Environment.NewLine);
            tb_sort.AppendText("//최대값 크기만큼 임시 메모리 할당" + Environment.NewLine);
            tb_sort.AppendText("int *count = (int *)malloc(range * sizeof(*array));" + Environment.NewLine);
            tb_sort.AppendText("for (i = 0; i < range; i++)" + Environment.NewLine);
            tb_sort.AppendText("count[i] = 0;" + Environment.NewLine);
            tb_sort.AppendText("for (i = 0; i < n; i++)"+Environment.NewLine);
            tb_sort.AppendText("count[array[i] - min]++;" + Environment.NewLine);
            tb_sort.AppendText("//카운트 누적" + Environment.NewLine);
            tb_sort.AppendText("for (i = min, z = 0; i <= max; i++)"+Environment.NewLine);
            tb_sort.AppendText("{" + Environment.NewLine);
            tb_sort.AppendText("for (j = 0; j < count[i - min]; j++)"+ Environment.NewLine);
            tb_sort.AppendText("{" + Environment.NewLine);
            tb_sort.AppendText("array[z++] = i;" + Environment.NewLine);
            tb_sort.AppendText("}" + Environment.NewLine);
            tb_sort.AppendText("}" + Environment.NewLine);
            tb_sort.AppendText("//임시 메모리 삭제" + Environment.NewLine);
            tb_sort.AppendText("free(count);" + Environment.NewLine);
            tb_sort.AppendText("}" + Environment.NewLine);

            tb_sort.AppendText(Environment.NewLine);
            tb_sort.AppendText(Environment.NewLine);

            tb_sort.AppendText("void Counting_Sort(int *array, int n)" + Environment.NewLine);
            tb_sort.AppendText("{" + Environment.NewLine);
            tb_sort.AppendText("int i, min, max;" + Environment.NewLine);
            tb_sort.AppendText("min = max = array[0];" + Environment.NewLine);
            tb_sort.AppendText("for (i = 1; i < n; i++)" + Environment.NewLine);
            tb_sort.AppendText("{" + Environment.NewLine);
            tb_sort.AppendText("if (array[i] < min)" + Environment.NewLine);
            tb_sort.AppendText("{" + Environment.NewLine);
            tb_sort.AppendText("min = array[i];" + Environment.NewLine);
            tb_sort.AppendText("}" + Environment.NewLine);
            tb_sort.AppendText("else if (array[i] > max)" + Environment.NewLine);
            tb_sort.AppendText("{" + Environment.NewLine);
            tb_sort.AppendText("max = array[i];" + Environment.NewLine);
            tb_sort.AppendText("}" + Environment.NewLine);
            tb_sort.AppendText("}" + Environment.NewLine);
            tb_sort.AppendText("}" + Environment.NewLine);
        }
    }
}
