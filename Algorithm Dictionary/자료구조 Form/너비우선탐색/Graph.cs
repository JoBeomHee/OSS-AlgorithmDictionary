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
    public partial class Graph : Form
    {
        public Graph()
        {
            InitializeComponent();
        }

        private void Graph_Load(object sender, EventArgs e)
        {
            tb_Graph.AppendText("//너비우선탐색 알고리즘의 그래프\r\n");
            tb_Graph.AppendText("int dfs[7 + 1][7 + 1] =\r\n");
            tb_Graph.AppendText("{\r\n");
            tb_Graph.AppendText("     { 0,0,0,0,0,0,0,0 },   // 0\r\n");
            tb_Graph.AppendText("     { 0,0,1,1,0,0,0,0 },   // 1노드\r\n");
            tb_Graph.AppendText("     { 0,1,0,0,1,1,1,0 },   // 2노드\r\n");
            tb_Graph.AppendText("     { 0,1,0,0,0,0,0,0 },   // 3노드\r\n");
            tb_Graph.AppendText("     { 0,0,1,0,0,0,0,0 },   // 4노드\r\n");
            tb_Graph.AppendText("     { 0,0,1,0,0,0,0,1 },   // 5노드\r\n");
            tb_Graph.AppendText("     { 0,0,1,0,0,0,0,0 },   // 6노드\r\n");
            tb_Graph.AppendText("     { 0,0,0,0,0,1,0,0 }   // 7노드\r\n");
            tb_Graph.AppendText(" };\r\n");
        }
    }
}
