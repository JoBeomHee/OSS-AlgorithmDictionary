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
    public partial class LinkedList_Delete : Form
    {
        public LinkedList_Delete()
        {
            InitializeComponent();
        }

        private void LinkedList_Delete_Load(object sender, EventArgs e)
        {
            tb_Delete.AppendText("//연결리스트 해제화" + Environment.NewLine);
            tb_Delete.AppendText("void Delete_LinkedList(LinkedList *linkedlist)" +Environment.NewLine);
            tb_Delete.AppendText("{" + Environment.NewLine);
            tb_Delete.AppendText("/*연결리스트를 해제화하는 함수에서는 head에서 링크를 따라가면서 tail이 가리키는 노드를 해제한 후에 자신을 해제해야 합니다.*/ "+Environment.NewLine);
            tb_Delete.AppendText("Link seek = linkedlist->head;"+Environment.NewLine);
            tb_Delete.AppendText("while (seek != linkedlist->tail)" + Environment.NewLine);
            tb_Delete.AppendText("{" + Environment.NewLine);
            tb_Delete.AppendText("seek = seek->next;" + Environment.NewLine);
            tb_Delete.AppendText("free(seek);" + Environment.NewLine);
            tb_Delete.AppendText("}"+Environment.NewLine);
            tb_Delete.AppendText("/*위의 반복문에서는 마지막 노드는 제거하지 않은 상태입니다.따라서 tail이 가르키는 노드를 제거한 후에 자신의 메모리를 해제합니다.*/" + Environment.NewLine);
            tb_Delete.AppendText("free(linkedlist->tail);" + Environment.NewLine);
            tb_Delete.AppendText("free(linkedlist);" + Environment.NewLine);
            tb_Delete.AppendText("}" + Environment.NewLine);
        }
    }
}
