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
    public partial class LinkedList_PushBack : Form
    {
        public LinkedList_PushBack()
        {
            InitializeComponent();
        }

        private void LinkedList_PushBack_Load(object sender, EventArgs e)
        {
            tb_PushBack.AppendText("//링크드리스트 순차보관 함수"+Environment.NewLine);
            tb_PushBack.AppendText("void LinkedList_PushBack(LinkedList *linkedlist, Element data)" +Environment.NewLine);
            tb_PushBack.AppendText("{"+Environment.NewLine);
            tb_PushBack.AppendText("//tail 앞에 자료를 보관하면 순차적으로 보관할 수 있습니다." + Environment.NewLine);
            tb_PushBack.AppendText("LinkedList_Insert(linkedlist, linkedlist->tail, data);" + Environment.NewLine);
            tb_PushBack.AppendText("}" + Environment.NewLine);
        }
    }
}
