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
    public partial class LinkedList_Malloclist : Form
    {
        public LinkedList_Malloclist()
        {
            InitializeComponent();
        }

        private void LinkedList_Malloclist_Load(object sender, EventArgs e)
        {
            tb_malloclist.AppendText("//연결리스트 동적생성" + Environment.NewLine);
            tb_malloclist.AppendText("LinkedList *New_LinkedList()" + Environment.NewLine);
            tb_malloclist.AppendText("{" + Environment.NewLine);
            tb_malloclist.AppendText("LinkedList *linkedlist = 0;" + Environment.NewLine);
            tb_malloclist.AppendText("//LinkedList 동적으로 메모리를 할당한다." + Environment.NewLine);
            tb_malloclist.AppendText("linkedlist = (LinkedList*)malloc(sizeof(LinkedList));" + Environment.NewLine);
            tb_malloclist.AppendText("//head와 tail을 더미노드로 생성해준다." + Environment.NewLine);
            tb_malloclist.AppendText("linkedlist->head = New_Node(0);" + Environment.NewLine);
            tb_malloclist.AppendText("linkedlist->tail = New_Node(0);" + Environment.NewLine);
            tb_malloclist.AppendText("//head의 next링크를 tail을 가리키게 하고 tail의 prev 링크를 head를 가르키게 합니다." + Environment.NewLine);
            tb_malloclist.AppendText("linkedlist->head->next = linkedlist->tail;" + Environment.NewLine);
            tb_malloclist.AppendText("linkedlist->tail->prev = linkedlist->head;" + Environment.NewLine);
            tb_malloclist.AppendText("//저장소 0으로 초기화" + Environment.NewLine);
            tb_malloclist.AppendText("linkedlist->usage = 0;"+Environment.NewLine);
            tb_malloclist.AppendText("return linkedlist;" + Environment.NewLine);
            tb_malloclist.AppendText("}" + Environment.NewLine);
        }
    }
}
