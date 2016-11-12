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
    public partial class Sort : Form
    {
        public Sort()
        {
            InitializeComponent();
        }

        private void Sort_Load(object sender, EventArgs e)
        {
            tb_sort.AppendText("//삽입정렬 함수"+Environment.NewLine);
            tb_sort.AppendText("void insertionSort(int list[], int Size)" + Environment.NewLine);
            tb_sort.AppendText("{" + Environment.NewLine);

            tb_sort.AppendText("int i, j, sort, temp;" + Environment.NewLine);
            tb_sort.AppendText("printf(\n정렬할 원소: );" + Environment.NewLine);
            tb_sort.AppendText("//list배열 안의 정렬하고자 하는 원소들 출력" + Environment.NewLine);
            tb_sort.AppendText("for (sort = 0; sort < Size; sort++)" + Environment.NewLine);
            tb_sort.AppendText("{" + Environment.NewLine);
            tb_sort.AppendText("printf(% 3d, list[sort]);" + Environment.NewLine);
            tb_sort.AppendText("}" + Environment.NewLine);

            tb_sort.AppendText("//삽입정렬 수행"+Environment.NewLine);
            tb_sort.AppendText("for (i = 1; i < Size; i++)" + Environment.NewLine);
            tb_sort.AppendText("{" + Environment.NewLine);
            tb_sort.AppendText("temp = list[i];" + Environment.NewLine);
            tb_sort.AppendText("j = i;" + Environment.NewLine);
            tb_sort.AppendText("while ((j > 0) && (list[j - 1] > temp))" + Environment.NewLine);
            tb_sort.AppendText("{" + Environment.NewLine);
            tb_sort.AppendText("list[j] = list[j - 1];" + Environment.NewLine);
            tb_sort.AppendText("j = j - 1;" + Environment.NewLine);
            tb_sort.AppendText("}" + Environment.NewLine);

            tb_sort.AppendText("list[j] = temp;" + Environment.NewLine);
            tb_sort.AppendText("for (sort = 0; sort <Size; sort++) printf( % 3d, list[sort]);" + Environment.NewLine);
            tb_sort.AppendText("}" + Environment.NewLine);

        }
    }
}
