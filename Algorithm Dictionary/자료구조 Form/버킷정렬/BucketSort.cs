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
    public partial class BucketSort : Form
    {
        AlgorithmMenu am;
        Sort sort;

        public BucketSort()
        {
            InitializeComponent();
        }

        private void pb_back_Click(object sender, EventArgs e)
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

        private void btn_sort_Click(object sender, EventArgs e)
        {
            sort = new Sort();
            sort.FormClosed += Sort_FormClosed;
            sort.Show();
            this.Close();
        }

        private void Sort_FormClosed(object sender, FormClosedEventArgs e)
        {
            sort = null;
        }

        private void BucketSort_Load(object sender, EventArgs e)
        {
            tb_description.AppendText("버킷 정렬을 키 값의 범위뿐만이 아니라 그 범위 내에서 키 값이 확률적으로 균등하게 분포된다고 가정할 수 있을 때 적용할 수 있는 방법입니다.");
            tb_sort.AppendText("키 값이 0과 1사이라고 가정할 때, n개의 키가 구간[0,1]을 n등분하고 각각 하나의 버킷으로 합니다. 각 키를 크기에 따라 각 버킷에 분배한다면, 키가 구간 내에서 균등하게 분포한다 가정했으므로 하나의 버킷에는 하나의 키만 있을 확률이 높습니다. 만약 한 버켓에 여러 키가 들어가게 된다면 같은 버킷에 속하는 키끼리는 간단한 정렬 알고리즘으로 정렬합니다. 이 설명을 C코드로 보고 싶으시다면 코드보기 버튼을 눌러주세요.");
        }

        private void lb_link_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://egloos.zum.com/Duckkk/v/668549");
        }
    }
}
