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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            tb_Search.AppendText("뿌리노드를 1로 시작하겠습니다.\r\n");
            tb_Search.AppendText("int visit[7 + 1];\r\n");
            tb_Search.AppendText("void search(int i)\r\n");
            tb_Search.AppendText("{\r\n");
            tb_Search.AppendText("    int j;\r\n");
            tb_Search.AppendText("    visit[i] = 1;     // 방문한곳은 1\r\n");
            tb_Search.AppendText("    for (j = 1; j <= N; j++)     // 뿌리노드1부터 마지막노드까지\r\n");
            tb_Search.AppendText("    {\r\n");
            tb_Search.AppendText("        if (dfs[i][j] == 1 && visit[j] == 0)    // 그래프간의 간선이 존재하고 방문하지 않은 노드일때\r\n");
            tb_Search.AppendText("        {\r\n");
            tb_Search.AppendText("            printf("+" % d -> %d로 이동\n"+ ", i, j);    //그 노드로 이동\r\n");
            tb_Search.AppendText("            search(j);    // 다음노드 탐색\r\n");
            tb_Search.AppendText("        }\r\n");
            tb_Search.AppendText("    }\r\n");
            tb_Search.AppendText("}\r\n");
        }
    }
}
