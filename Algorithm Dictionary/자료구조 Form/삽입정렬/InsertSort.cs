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
    public partial class InsertSort : Form
    {
        AlgorithmMenu am;
        public InsertSort()
        {
            InitializeComponent();
        }

        private void btn_return_Click(object sender, EventArgs e)
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

        private void InsertSort_Load(object sender, EventArgs e)
        {
            tb_description.AppendText("삽입정렬은 이름에서 알 수 있듯이 삽입을 통해 정렬을 완성하는 알고리즘 입니다. 상입정렬은 모든 데이터를 앞에서부터 차례로 비교하여 자신의 위치에 삽일을 통해 정렬을 수행합니다. 배열이 길어질수록 효율이 떨어지지만 구현이 간단하다는 장점이 있습니다.");
        }
    }
}
