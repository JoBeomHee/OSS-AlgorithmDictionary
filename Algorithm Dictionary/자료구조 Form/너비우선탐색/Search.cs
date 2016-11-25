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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            tb_Search.AppendText("뿌리노드를 4로 시작하겠습니다.\r\n");
            tb_Search.AppendText("int visit[7 + 1];\r\n");
            tb_Search.AppendText("int queue[100]; \r\n");
            tb_Search.AppendText("// 너비우선에서 큐는 큐에 같은 레벨의 노드들이 쌓이게 되면\r\n");
            tb_Search.AppendText("// head는 차례대로 스택을 검사해 나가면서 갈수있는 길들을 파악하게 된다\r\n\r\n");
            tb_Search.AppendText(" // for문 안에서의 tail값과 do뒤에 head값을 잘 생각해두고 있을것!\r\n");
            tb_Search.AppendText("void search()\r\n");
            tb_Search.AppendText("{\r\n");
            tb_Search.AppendText("    int i, j;\r\n");
            tb_Search.AppendText("    int head = 0;\r\n");
            tb_Search.AppendText("    int tail = 0;\r\n");
            tb_Search.AppendText("    visit[4] = 1;    // 4노드를 방문했다고 설정\r\n"); 
            tb_Search.AppendText("    queue[tail++] = 4;  // 뿌리노드(queue[0])를 4로 설정과 함께 tail = 0에서부터 1씩 증가\r\n");
            tb_Search.AppendText("    do  // do ~ while문 시작\r\n");
            tb_Search.AppendText("    {\r\n");
            tb_Search.AppendText("        i = queue[head++];   // i = queue[0] = 4로 첫 시작 설정과 함께 head = 0에서부터 1씩 증가\r\n");
            tb_Search.AppendText("        for (j = 1; j <= N; j++) // 현재노드에 있는 모든 자식노드를 방문할 반복문\r\n");
            tb_Search.AppendText("        {\r\n");
            tb_Search.AppendText("           if (bfs[i][j] == 1 && visit[j] == 0)   //그래프간의 간선이 존재하고 방문하지 않은 노드일때\r\n");
            tb_Search.AppendText("           {\r\n");
            tb_Search.AppendText("              queue[tail++] = j;\r\n");
            tb_Search.AppendText("               visit[j] = 1;    //방문한곳은 1\r\n");
            tb_Search.AppendText("               printf("+" % d-> % d로 이동\n"+ ", i, j);    //그 노드로 이동\r\n");
            tb_Search.AppendText("           }\r\n");
            tb_Search.AppendText("       }\r\n");
            tb_Search.AppendText("   } while (head < tail);     // 마지막 노드일때까지 반복\r\n");
        }

    }
}
