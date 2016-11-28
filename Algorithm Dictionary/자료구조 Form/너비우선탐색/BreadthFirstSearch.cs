using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithm_Dictionary.자료구조_Form.너비우선탐색
{
    public partial class BreadthFirstSearch : Form
    {
        AlgorithmMenu am;
        Graph gp;
        Search sh;

        public BreadthFirstSearch()
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

        private void lb_link_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://ehclub.co.kr/1580");
        }

        private void BreadthFirstSearch_Load(object sender, EventArgs e)
        {
            tb_description.AppendText("시작 정점을 방문한 후 시작 정점에 인접한 모든 정점들을 우선 방문하는 방법.\r\n더 이상 방문하지 않은 정점이 없을 때까지 방문하지 않은 모든 정점들에 대해서도 너비우선탐색을 적용한다\r\n");
            tb_Graph.AppendText("다음은 너비우선탐색의 그래프 입니다.\r\n이미 그래프가 그려져 있다는 가정하에 2차원 배열로 그래프를 표현해 보았습니다.");
            tb_Search.AppendText("다음은 너비우선탐색의 탐색 함수입니다.\r\n너비우선탐색이 어떤순으로 그래프를 방문하고 방문하지 않은 정점을 찾아가는지에 대해 설명하겠습니다.");
        }
        private void btn_Graph_Click(object sender, EventArgs e)
        {
            gp = new Graph();
            gp.FormClosed += Gp_FormClosed;
            gp.Show();
        }

        private void Gp_FormClosed(object sender, FormClosedEventArgs e)
        {
            gp = null;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            sh = new Search();
            sh.FormClosed += Sh_FormClosed;
            sh.Show();
        }

        private void Sh_FormClosed(object sender, FormClosedEventArgs e)
        {
            sh = null;
        }

    }
}
