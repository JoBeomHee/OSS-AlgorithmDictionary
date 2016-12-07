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
    public partial class Graph : Form
    {
        public Graph()
        {
            InitializeComponent();
        }

        private void Graph_Load(object sender, EventArgs e)
        {
            tb_Graph.AppendText("//다익스트라 알고리즘의 그래프\r\n");
            tb_Graph.AppendText("int cost[NODES][NODES] =\r\n");
            tb_Graph.AppendText("{\r\n");
            tb_Graph.AppendText("     //  0,   1,     2,      3,      4,      5,      6\r\n");
            tb_Graph.AppendText("       { 0,    7,     INF,   INF,   3,     10,    INF },  // 0 노드\r\n");
            tb_Graph.AppendText("       { 7,    0,       4,   10,    2,     6,     INF },  // 1 노드\r\n");
            tb_Graph.AppendText("       { INF,  4,       0,   2,     INF,   INF,   INF },  // 2 노드\r\n");
            tb_Graph.AppendText("       { INF,  10,      2,   0,     11,    9,     4 },  // 3 노드\r\n");
            tb_Graph.AppendText("       { 3,    2,     INF,   11,    0,     INF,   5 },  // 4 노드\r\n");
            tb_Graph.AppendText("       { 10,   6,     INF,   9,     INF,   0,     INF },  // 5 노드\r\n");
            tb_Graph.AppendText("       { INF,  INF,   INF,   4,     5,     INF,   0 }  // 6 노드\r\n");
            tb_Graph.AppendText("};\r\n");
        }
    }
}
