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
    public partial class LinkedList_New_Node : Form
    {
        public LinkedList_New_Node()
        {
            InitializeComponent();
        }

        private void LinkedList_New_Node_Load(object sender, EventArgs e)
        {
            tb_New_Node.AppendText(" //노드를 생성하는 함수" + Environment.NewLine);
            tb_New_Node.AppendText("Link New_Node(Element data)" + Environment.NewLine);
            tb_New_Node.AppendText("{" + Environment.NewLine);
            tb_New_Node.AppendText("//먼저 Node 형식 크기의 메모리를 할당합니다." + Environment.NewLine);
            tb_New_Node.AppendText("Link link = (Link)malloc(sizeof(Node));" + Environment.NewLine);
            tb_New_Node.AppendText("link->data = data;" + Environment.NewLine);
            tb_New_Node.AppendText("link->next = 0;" + Environment.NewLine);
            tb_New_Node.AppendText("link->prev = 0;" + Environment.NewLine);
            tb_New_Node.AppendText("//초기 링크설정 완료 후 반환" + Environment.NewLine);
            tb_New_Node.AppendText("return linnk;" + Environment.NewLine);
            tb_New_Node.AppendText("}" + Environment.NewLine);
        }
    }
}
