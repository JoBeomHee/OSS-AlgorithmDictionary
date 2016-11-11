using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithm_Dictionary.자료구조_Form.링크드리스트
{
    public partial class LinkedList_Erase : Form
    {
        public LinkedList_Erase()
        {
            InitializeComponent();
        }

        private void LinkedList_Erase_Load(object sender, EventArgs e)
        {
            tb_Erase.AppendText("//특정 위치의 노드 제거"+Environment.NewLine);
            tb_Erase.AppendText("void LinkedList_Erase(LinkedList *linkedlist, Link pos)" + Environment.NewLine);
            tb_Erase.AppendText("{" + Environment.NewLine);
            tb_Erase.AppendText("//먼저 연결을 끊습니다. 이 부분은 별도의 함수로 작성합니다.");
            tb_Erase.AppendText("DisconnectNode(pos);" + Environment.NewLine);
            tb_Erase.AppendText("//그리고 노드를 위해 할당한 메모리를 해제하고 보관한 자료 개수를 1 감소합니다." + Environment.NewLine);
            tb_Erase.AppendText("free(pos);" + Environment.NewLine);
            tb_Erase.AppendText("linkedlist->usage--;" + Environment.NewLine);
            tb_Erase.AppendText("}" + Environment.NewLine);

            tb_Erase.AppendText("void DisconnectNode(Link pos)" + Environment.NewLine);
            tb_Erase.AppendText("{"+Environment.NewLine);
            tb_Erase.AppendText("//연결을 끊을 노드의 이전(prev) 노드의 next를 연결을 끊을 노드의 이후(next) 노드로 설정합니다." + Environment.NewLine);
            tb_Erase.AppendText("pos->prev->next = pos->next;" + Environment.NewLine);
            tb_Erase.AppendText("//연결을 끊을 노드의 이후(next) 노드의 prev를 연견을 끊을 노드의 이전(prev) 노드로 설정합니다." + Environment.NewLine);
            tb_Erase.AppendText("pos->next->prev = pos->prev;" + Environment.NewLine);
            tb_Erase.AppendText("}"+Environment.NewLine);
        }
    }
}
