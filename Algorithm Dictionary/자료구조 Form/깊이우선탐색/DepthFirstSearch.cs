using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithm_Dictionary.자료구조_Form.깊이우선탐색
{
    public partial class DepthFirstSearch : Form
    {
        AlgorithmMenu am;
        Graph gp;
        Search sh;

        public DepthFirstSearch()
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
            System.Diagnostics.Process.Start("http://ehclub.co.kr/1564");
        }

        private void DepthFirstSearch_Load(object sender, EventArgs e)
        {
            tb_description.AppendText("그래프 탐색 방법 중의 하나로서 한 정점을 방문한 후에 그에 인접하고, 아직 방문하지 않은 한 정점을 선택하여 이로부터 다시 위 과정을 반복하는 방법이다.\r\n그래프는 소스코드로 이해하기 힘들기 때문에 그림으로 전면적으로 설명 하겠습니다.\r\n만약에 노드에 대한 개념이 아직 없는 상태라면 이진탐색트리에서 먼저 이해한 후에 공부할것을 추천합니다.");
            tb_Graph.AppendText("다음은 깊이우선탐색의 그래프 입니다.\r\n이미 그래프가 그려져 있다는 가정하에 2차원 배열로 그래프를 표현해 보았습니다.");
            tb_Search.AppendText("다음은 깊이우선탐색의 탐색 함수입니다.\r\n깊이우선탐색이 어떤순으로 그래프를 방문하고 방문하지 않은 정점을 찾아가는지에 대해 설명하겠습니다.");
            
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
