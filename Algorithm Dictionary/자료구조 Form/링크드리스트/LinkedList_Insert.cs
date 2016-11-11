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
    public partial class LinkedList_Insert : Form
    {
        public LinkedList_Insert()
        {
            InitializeComponent();
        }

        private void LinkedList_Insert_Load(object sender, EventArgs e)
        {
            tb_insert.AppendText("//원하는 노드앞에 삽입" + Environment.NewLine);
            tb_insert.AppendText("void LinkedList_Insert(LinkedList *linkedlist, Link pos, Element data)" + Environment.NewLine);
            tb_insert.AppendText("{" + Environment.NewLine);
            tb_insert.AppendText("//자료를 보관하는 노드 생성" + Environment.NewLine);
            tb_insert.AppendText("Link link = New_Node(data);" + Environment.NewLine);
            tb_insert.AppendText("//그리고 입력 인자로 받은 노드 앞에 새로 생성한 노드를 연결합니다.이 부분은 별도의 함수로 작성합니다." + Environment.NewLine);
            tb_insert.AppendText("HangNode(link, pos);" + Environment.NewLine);
            tb_insert.AppendText("//보관한 자료의 개수를 1 증가합니다." + Environment.NewLine);
            tb_insert.AppendText("linkedlist->usage++;" + Environment.NewLine);
            tb_insert.AppendText("}" + Environment.NewLine);
        }
    }
}
