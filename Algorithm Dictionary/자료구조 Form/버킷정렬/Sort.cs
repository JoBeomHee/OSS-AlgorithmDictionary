using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithm_Dictionary.자료구조_Form.버킷정렬
{
    public partial class Sort : Form
    {
        public Sort()
        {
            InitializeComponent();
        }

        private void Sort_Load(object sender, EventArgs e)
        {
            tb_sort.AppendText("void BucketSort(int* arr, int n)" + Environment.NewLine);
            tb_sort.AppendText("{" + Environment.NewLine);
            tb_sort.AppendText("int i, j = 0;" + Environment.NewLine);
            tb_sort.AppendText("int* count = (int*)malloc(sizeof(int)*n);" + Environment.NewLine);
            tb_sort.AppendText("	//초기 카운터 설정" + Environment.NewLine);
            tb_sort.AppendText("for (i = 0; i < n; i++)	" + Environment.NewLine);
            tb_sort.AppendText("count[i] = 0;" + Environment.NewLine);
            tb_sort.AppendText("// 배열 넘버 카운트" + Environment.NewLine);
            tb_sort.AppendText("for (i = 0; i < n; i++)" + Environment.NewLine);
            tb_sort.AppendText("count[arr[i]]++;" + Environment.NewLine);
            tb_sort.AppendText("	// 배열순서 변경" + Environment.NewLine);
            tb_sort.AppendText("for (i = 0; i < n; i++)" + Environment.NewLine);
            tb_sort.AppendText("{" + Environment.NewLine);
            tb_sort.AppendText("for (; count[i] > 0; count[i]--)" + Environment.NewLine);
            tb_sort.AppendText("{" + Environment.NewLine);
            tb_sort.AppendText("arr[j++] = i;" + Environment.NewLine);
            tb_sort.AppendText("}" + Environment.NewLine);
            tb_sort.AppendText("}" + Environment.NewLine);
            tb_sort.AppendText("}" + Environment.NewLine);
        }
    }
}
