using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithm_Dictionary.자료구조_Form.프림알고리즘
{
    public partial class Prim : Form
    {
        AlgorithmMenu am;
        Graph gp;
        Search sh;

        public Prim()
        {
            InitializeComponent();
        }

        private void lb_link_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://ehclub.co.kr/1655");
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

        private void Prim_Load(object sender, EventArgs e)
        {
            tb_description.AppendText("그래프 탐색 방법 중의 하나로서, 프림 알고리즘은 시작 정점에서부터 출발하여 신장 트리 집합을 단계적으로 확장해나가는 방법이다.\r\n시작 단계에서는 시작 정점만이 신장 트리 집합에 포함된다.\r\n프림알고리즘의 방법은 신장트리집합에, 인접한 정점들 중에서 최저간선으로 연결된 정점을 선택하여 트리를 확장한다.\r\n이 과정은 트리가 n - 1개의 간선을 가질때까지 계속된다.");
            tb_Graph.AppendText("다음은 프림 알고리즘의 그래프 입니다.\r\n이미 그래프가 그려져 있다는 가정하에 2차원 배열로 그래프를 표현해 보았습니다.");
            tb_Search.AppendText("다음은 프림 알고리즘의 탐색 함수입니다.\r\n 프림 알고리즘이 어떻게 원하는 최저간선으로 연결된 정점을 선택하여 트리를 확장해 가는지에 대해 설명하겠습니다.");
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
