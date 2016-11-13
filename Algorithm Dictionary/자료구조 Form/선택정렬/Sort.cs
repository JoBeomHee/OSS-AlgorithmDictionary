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
    public partial class Sort : Form
    {
        public Sort()
        {
            InitializeComponent();
        }

        private void Sort_Load(object sender, EventArgs e)
        {
            tb_sort.AppendText("//선택정렬 함수"+Environment.NewLine);
            tb_sort.AppendText("void SelectionSort(int arr[], int MAX)" + Environment.NewLine);
            tb_sort.AppendText("{" + Environment.NewLine);
            tb_sort.AppendText("int i, j;" + Environment.NewLine);
            tb_sort.AppendText("int min, temp;" + Environment.NewLine);
            tb_sort.AppendText("for (i=0; i<MAX-1; i++)" + Environment.NewLine);
            tb_sort.AppendText("{" + Environment.NewLine);
            tb_sort.AppendText("min=i;" + Environment.NewLine);
            tb_sort.AppendText("for(j=i+1; j<MAX; j++)" + Environment.NewLine);
            tb_sort.AppendText("{"+Environment.NewLine);
            tb_sort.AppendText("if (arr[j] < arr[min])" + Environment.NewLine);
            tb_sort.AppendText("min = j;" + Environment.NewLine);
            tb_sort.AppendText("}" + Environment.NewLine);
            tb_sort.AppendText("//스왑 해준다." + Environment.NewLine);
            tb_sort.AppendText("temp=arr[i];" + Environment.NewLine);
            tb_sort.AppendText("arr[i]=arr[min];" + Environment.NewLine);
            tb_sort.AppendText("arr[min]=temp;" + Environment.NewLine);
            tb_sort.AppendText("}" + Environment.NewLine);
            tb_sort.AppendText("}" + Environment.NewLine);

        }
    }
}
