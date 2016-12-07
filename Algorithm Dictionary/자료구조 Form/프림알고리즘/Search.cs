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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            tb_Search.AppendText("void prim(int s, int n)\r\n");
            tb_Search.AppendText("{\r\n");
            tb_Search.AppendText("    int i, u, v, min = 0;\r\n");
            tb_Search.AppendText("    // i = 정점의 번호\r\n");
            tb_Search.AppendText("    // u = 방문한 정점\r\n");
            tb_Search.AppendText("    // v = 방문할 정점\r\n");
            tb_Search.AppendText("    // min = 최소거리들의 합\r\n");
            tb_Search.AppendText("    for (u = 0; u < n; u++)\r\n");
            tb_Search.AppendText("    {\r\n");
            tb_Search.AppendText("        dist[u] = INF; // 최소값들 초기화\r\n");
            tb_Search.AppendText("    }\r\n");
            tb_Search.AppendText("    dist[s] = 0; // 첫 정점의 방문거리 0\r\n");
            tb_Search.AppendText("    for (i = 0; i < n; i++)\r\n");
            tb_Search.AppendText("    {\r\n");
            tb_Search.AppendText("        u = get_min_vertex(n);\r\n");
            tb_Search.AppendText("        selected[u] = TRUE; // 방문표시\r\n");
            tb_Search.AppendText("        if (dist[u] == INF)\r\n");
            tb_Search.AppendText("        {\r\n");
            tb_Search.AppendText("            return;\r\n");
            tb_Search.AppendText("        }\r\n");
            tb_Search.AppendText("        min += dist[u]; // 방문거리 더하기\r\n");
            tb_Search.AppendText("        printf("+"\n\t %d번째  %c방문  거리=%d, 최소 비용=%d \n"+", i, u + 65, dist[u], min);\r\n");
            tb_Search.AppendText("        for (v = 0; v < n; v++)\r\n");
            tb_Search.AppendText("        {\r\n");
            tb_Search.AppendText("            if (adj_mat[u][v] != INF) // 방문한 정점중에서 주위에 방문하지 않은 정점이 있고 간선이 있는경우\r\n");
            tb_Search.AppendText("            {\r\n");
            tb_Search.AppendText("                if (!selected[v] && adj_mat[u][v] < dist[v]) // 방문하지 않은 정점이면서, 더 짧은 간선이 존재하는 경우\r\n");
            tb_Search.AppendText("                {\r\n");
            tb_Search.AppendText("                    dist[v] = adj_mat[u][v];\r\n");
            tb_Search.AppendText("                }\r\n");
            tb_Search.AppendText("            }\r\n");
            tb_Search.AppendText("        }\r\n");
            tb_Search.AppendText("    }\r\n");
            tb_Search.AppendText("    printf("+"\n"+");\r\n");
            tb_Search.AppendText("}\r\n");

            tb_Search.AppendText("int get_min_vertex(int n) // 최소 dist[v] 값을 갖는 정점을 반환\r\n");
            tb_Search.AppendText("{\r\n");
            tb_Search.AppendText("     int v, i;\r\n");
            tb_Search.AppendText("     // v = i의 인접 정점\r\n");
            tb_Search.AppendText("     // i = 방문한 정점\r\n");
            tb_Search.AppendText("    for (i = 0; i < n; i++)\r\n");
            tb_Search.AppendText("    {\r\n");
            tb_Search.AppendText("        if (!selected[i]) // 방문하지 않은 정점을 찾는 작업\r\n");
            tb_Search.AppendText("        {\r\n");
            tb_Search.AppendText("           v = i;\r\n");
            tb_Search.AppendText("           break;\r\n");
            tb_Search.AppendText("        }\r\n");
            tb_Search.AppendText("     }\r\n");
            tb_Search.AppendText("     for (i = 0; i < n; i++)\r\n");
            tb_Search.AppendText("     {\r\n");
            tb_Search.AppendText("         if (!selected[i] && (dist[i] < dist[v])) // 방문하지 않은 정점중에서 거리가 가장 짧은 정점 찾는 작업\r\n");
            tb_Search.AppendText("         {\r\n");
            tb_Search.AppendText("             v = i;\r\n");
            tb_Search.AppendText("         }\r\n");
            tb_Search.AppendText("      }\r\n");
            tb_Search.AppendText("  return (v);\r\n");
            tb_Search.AppendText("}\r\n");
        }
    }
}
