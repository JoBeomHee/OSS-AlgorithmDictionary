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
    public partial class LinkedList_HangNode : Form
    {
        public LinkedList_HangNode()
        {
            InitializeComponent();
        }

        private void LinkedList_HangNode_Load(object sender, EventArgs e)
        {
            tb_HangNode.AppendText("//노드연결 함수" + Environment.NewLine);
            tb_HangNode.AppendText("void HangNode(Link now, Link pos)" + Environment.NewLine);
            tb_HangNode.AppendText("{" + Environment.NewLine);
            tb_HangNode.AppendText("//저 새로운 now의 prev를 pos의 prev로 설정합니다. 그리고 now의 next를 pos로 설정합니다." + Environment.NewLine);
            tb_HangNode.AppendText("now->prev = pos->prev;" + Environment.NewLine);
            tb_HangNode.AppendText("now->next = pos;" + Environment.NewLine);
            tb_HangNode.AppendText("// 그리고 pos의 prev 노드의 next를 now로 설정합니다." + Environment.NewLine);
            tb_HangNode.AppendText("pos->prev->next = now;" + Environment.NewLine);
            tb_HangNode.AppendText("//마지막으로 pos의 prev를 now로 설정합니다." + Environment.NewLine);
            tb_HangNode.AppendText("pos->prev = now;" + Environment.NewLine);
            tb_HangNode.AppendText("}" + Environment.NewLine);
        }
    }
}
