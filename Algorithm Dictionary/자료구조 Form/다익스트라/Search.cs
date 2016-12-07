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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            tb_Search.AppendText("void shortest_path(int start, int cost[][NODES], int distance[], int n, int found[]) // start : 시작지점, cost: 그래프, distance: 최단경로 거리, n: 노드수, found: 방문한 노드\r\n");
            tb_Search.AppendText("// 기존에 있던 최단거리와 새로운 최단거리를 비교하여 작은수를 저장, distance값을 바꿔주는 함수\r\n");
            tb_Search.AppendText("/* 시작노드 start  */\r\n");
            tb_Search.AppendText("{\r\n");
            tb_Search.AppendText("                int i, u, w;\r\n");
            tb_Search.AppendText("                for (i = 0; i < n; i++) /* 그래프처럼 초기화 */\r\n");
            tb_Search.AppendText("                {\r\n");
            tb_Search.AppendText("                    distance[i] = cost[start][i]; // 경로 초기화\r\n");
            tb_Search.AppendText("                    path[i] = start;\r\n");
            tb_Search.AppendText("                    found[i] = FALSE;\r\n");
            tb_Search.AppendText("                }\r\n");
            tb_Search.AppendText("                found[start] = TRUE;    /* 시작노드 방문 표시 */\r\n");
            tb_Search.AppendText("                distance[start] = 0; // 시작노드 경로거리 0\r\n");
            tb_Search.AppendText("                for (i = 0; i < n; i++)\r\n");
            tb_Search.AppendText("                {\r\n");
            tb_Search.AppendText("                    print_distance();  // 최단 거리를 출력\r\n");
            tb_Search.AppendText("                    u = choose(distance, n, found); // 짧은경로의 노드를 선택\r\n");
            tb_Search.AppendText("                    found[u] = TRUE; // 노드 방문\r\n");
            tb_Search.AppendText("                    for (w = 0; w < n; w++)\r\n");
            tb_Search.AppendText("                    {\r\n");
            tb_Search.AppendText("                        if (!found[w])\r\n");
            tb_Search.AppendText("                        {\r\n");
            tb_Search.AppendText("                            if (distance[u] + cost[u][w] < distance[w]) // \r\n");
            tb_Search.AppendText("                            {\r\n");
            tb_Search.AppendText("                                distance[w] = distance[u] + cost[u][w];\r\n");
            tb_Search.AppendText("                                path[w] = u;         /* 경유노드 저장 */\r\n");
            tb_Search.AppendText("                            }\r\n");
            tb_Search.AppendText("                        }\r\n");
            tb_Search.AppendText("                    }\r\n");
            tb_Search.AppendText("                }\r\n");
            tb_Search.AppendText("}\r\n");

            tb_Search.AppendText("void print_path(int start, int end)   // 경유노드를 출력해주는 함수\r\n");
            tb_Search.AppendText("{\r\n");
            tb_Search.AppendText("    if (path[end] != start)\r\n");
            tb_Search.AppendText("    {\r\n");
            tb_Search.AppendText("        print_path(start, path[end]);\r\n");
            tb_Search.AppendText("    }\r\n");
            tb_Search.AppendText("    printf("+ "\t <% d->% d > \n " + ", path[end], end);\r\n");
            tb_Search.AppendText("}\r\n");

            tb_Search.AppendText("void print_distance()  // 최단 거리를 출력하는 함수\r\n");
            tb_Search.AppendText("{\r\n");
            tb_Search.AppendText("                int i;\r\n");
            tb_Search.AppendText("                for (i = 0; i < NODES; i++)\r\n");
            tb_Search.AppendText("                {\r\n");
            tb_Search.AppendText("                    printf(" +"\tdistance[% d] =% d\n "+", i, distance[i]);\r\n");
            tb_Search.AppendText("                }\r\n");
            tb_Search.AppendText("                printf("+"------------------------------------------"+");\r\n");
            tb_Search.AppendText("                printf("+"\n"+");\r\n");
            tb_Search.AppendText("}\r\n");

            tb_Search.AppendText("int choose(int distance[], int n, int found[])\r\n");
            tb_Search.AppendText("{\r\n");
            tb_Search.AppendText("                int i, min, minpos;\r\n");
            tb_Search.AppendText("                min = INT_MAX;\r\n");
            tb_Search.AppendText("                minpos = -1;\r\n");
            tb_Search.AppendText("                for (i = 0; i < n; i++)\r\n");
            tb_Search.AppendText("                {\r\n");
            tb_Search.AppendText("                    if (distance[i] < min && !found[i]) // 더 경로가 짧고, 방문하지 않은 노드가 있을경우\r\n");
            tb_Search.AppendText("                    {\r\n");
            tb_Search.AppendText("                        min = distance[i];\r\n");
            tb_Search.AppendText("                        minpos = i;\r\n");
            tb_Search.AppendText("                    }\r\n");
            tb_Search.AppendText("                }\r\n");
            tb_Search.AppendText("  return minpos;\r\n");
            tb_Search.AppendText("}\r\n");
        }
    }
}
