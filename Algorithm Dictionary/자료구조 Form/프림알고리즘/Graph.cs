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
    public partial class Graph : Form
    {
        public Graph()
        {
            InitializeComponent();
        }

        private void Graph_Load(object sender, EventArgs e)
        {
            tb_Graph.AppendText("//프림 알고리즘의 그래프\r\n");
            tb_Graph.AppendText("int adj_mat[VERTICES][VERTICES] = // 임의의 그래프\r\n");
            tb_Graph.AppendText("{\r\n");
            tb_Graph.AppendText("    ///  a,   b,    c,   d,   e,   f,   g \r\n");
            tb_Graph.AppendText("        { 0, 29, INF, INF, INF, 10, INF},  // a\r\n");
            tb_Graph.AppendText("        { 29,  0, 16, INF, INF, INF, 15 },  // b\r\n");
            tb_Graph.AppendText("        { INF, 16, 0, 12, INF, INF, INF },  // c\r\n");
            tb_Graph.AppendText("        { INF, INF, 12, 0, 22, INF, 18 },  // d\r\n");
            tb_Graph.AppendText("        { INF, INF, INF, 22, 0, 27, 25 },  // e\r\n");
            tb_Graph.AppendText("        { 10, INF, INF, INF, 27, 0, INF },  // f\r\n");
            tb_Graph.AppendText("        { INF, 15, INF, 18, 25, INF, 0 }  // g\r\n");
            tb_Graph.AppendText(" };\r\n");
        }
    }
}
