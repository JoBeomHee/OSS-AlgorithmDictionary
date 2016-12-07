using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithm_Dictionary.자료구조_Form.다익스트라
{
    public partial class Dijkstra : Form
    {
        AlgorithmMenu am;
        Graph gp;
        Search sh;

        public Dijkstra()
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
            System.Diagnostics.Process.Start("http://ehclub.co.kr/1583");
        }

        private void Dijkstra_Load(object sender, EventArgs e)
        {
            tb_description.AppendText("그래프 탐색 방법 중의 하나로서, 다익스트라 알고리즘은 최단경로를 찾는 알고리즘이다.\r\n다익스트라의 최단 경로 알고리즘은 네트위크에서 하나의 시작 정점으로부터 모든 다른 정점까지의 최단 경로를 찾는 알고리즘이다.\r\n최단 경로는 경로의 길이순으로 구해진다.");
            tb_Graph.AppendText("다음은 다익스트라 알고리즘의 그래프 입니다.\r\n이미 그래프가 그려져 있다는 가정하에 2차원 배열로 그래프를 표현해 보았습니다.");
            tb_Search.AppendText("다음은 다익스트라 알고리즘의 탐색 함수입니다.\r\n 다익스트라의 알고리즘이 어떻게 원하는 정점까지 최단경로를 찾아 가는지에 대해 설명하겠습니다.");
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
            sh.Show();
        }
    }
}
