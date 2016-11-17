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
    public partial class LinkedList : Form
    {
        AlgorithmMenu am;
        LinkedList_New_Node lnn;
        LinkedList_Malloclist lml;
        LinkedList_Delete ld;
        LinkedList_PushBack lp;
        LinkedList_HangNode lh;
        LinkedList_Insert li;
        LinkedList_Erase le;

        public LinkedList()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            am = new AlgorithmMenu();
            am.FormClosed += Am_FormClosed;
            am.Show();
            this.Close();
        }

        private void Am_FormClosed(object sender, FormClosedEventArgs e)
        {
            am = null;
        }

        private void LinkedList_Load(object sender, EventArgs e)
        {
            tb_description.AppendText("연결리스트는 노드의 선형 집합니다.\r\n노드란 데이터와 링크의 조합으로 하나의 데이터를 보관하는 작은 저장소입니다. 그리고 링크는 노드의 위치 정보입니다.\r\n이렇게 각 노드들이 링크를 통해서 각각 연결되어있는 리스트를 링크드 리스트라고 합니다.\r\n그중 이중연결리스트를 가지고 코드 설명을 하도록 하겠습니다.");

            tb_New_Node.AppendText("제일 먼저 링크드 리스트에서 먼저 노드를 생성하는 함수를 알아보도록 하겠습니다.\r\n노드에는 총 3개의 정보들이 있는데 이전 노드의 위치 정보와 보관된 데이터 그리고 다음 노드의 위치 정도가 들어있습니다.\r\n노드 생성 함수의 내부를 보고싶으시면 아래 코드보기 버튼을 눌러주세요.");

            tb_mallocList.AppendText("다음으로는 연결리스트 동적생성을 하는 함수입니다.\r\n이 함수는 Linkedlist 동적으로 먼저 메모리를 할당 받은 다음 head와 tail의 더미노드를 생성하고 head와 tail이 각각 가리키게끔 링크를 성정한 후 마지막 저장소 0으로 초기화를 해주는 함수입니다.\r\n연결리스트 동적생성 함수 코드를 보고싶으시면 코드보기 버튼을 눌러주세요.");

            tb_Delete.AppendText("다음으로는 연결리스트 해제화 함수입니다.\r\n연결리스트를 해제화 하는 함수에서는 head에서 링크를 따라가면서 tail이 가리키는 노드를 해제한 후에 자신을 해제해야 합니다.\r\n그리고 이 작업을 반복하면서 마지막 노드를 제거해야 합니다.\r\n따라서 tail이 가리키는 노드를 제거한 후에 자신의 메모리를 해제해줍니다.\r\n리스트 해제화 함수 코드를 보고싶으시면 아래 코드보기 버튼을 눌러주세요.");

            tb_PushBack.AppendText("다음으로는 링크드리스트 순차보관하는 함수입니다.\r\n링크드리스트에서 순차보관을 하려면 tail 앞에 자료를 보관하면 순차적으로 보관할 수 있습니다.\r\n순차보관하는 함수의 코드를 보고싶으시면 아래 코드보기 버튼을 눌러주세요.");

            tb_HangNode.AppendText("다음으로는 노드연결 함수입니다.\r\n새로운 노드 now의 prev를 pos의 prev로 설정합니다. 그리고 now의 next를 pos로 설정합니다.\r\n또한 pos의 prev 노드의 next를 now로 설정합니다.\r\n그리고 마지막으로 pos의 prev를 now로 설정합니다.\r\n이 함수 코드를 보고싶으시면 아래 코드보기 버튼을 눌러주세요.");

            tb_insert.AppendText("다음으로는 원하는 노드앞에 삽입하는 함수입니다.\r\n먼저 자료를 보관하는 노드를 생성해야 하고 입력 인자로 받은 노드 앞에 새로 생성한 노드를 연결해 줍니다.\r\n그리고 나서 마지막으로 보관한 자료의 개수를 1 증가해주면 됩니다.\r\n자세한 코드를 보고 싶으시면 아래 코드보기 버튼을 눌러주세요.");

            tb_Erase.AppendText("다음으로는 특정위치의 노드제거를 하는 함수입니다.\r\n먼저 제거하기 전에 리스트 연결을 끊어 줘야합니다.\r\n그리고 노드를 위해 할당한 메모리를 해제하고 보관한 자료 개수를 -1 해주면 함수는 끝납니다.\r\n이 함수 코드를 보고싶으시면 아래 코드보기 버튼을 눌러주세요.");
        }

        private void btn_New_Node_Click(object sender, EventArgs e)
        {
            lnn = new LinkedList_New_Node();
            lnn.FormClosed += Lnn_FormClosed;
            lnn.Show();
        }

        private void Lnn_FormClosed(object sender, FormClosedEventArgs e)
        {
            lnn = null;
        }

        private void btn_malloclist_Click(object sender, EventArgs e)
        {
            lml = new LinkedList_Malloclist();
            lml.FormClosed += Lml_FormClosed;
            lml.Show();
        }

        private void Lml_FormClosed(object sender, FormClosedEventArgs e)
        {
            lml = null;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            ld = new LinkedList_Delete();
            ld.FormClosed += Ld_FormClosed;
            ld.Show();
        }

        private void Ld_FormClosed(object sender, FormClosedEventArgs e)
        {
            ld = null;
        }

        private void btn_PushBack_Click(object sender, EventArgs e)
        {
            lp = new LinkedList_PushBack();
            lp.FormClosed += Lp_FormClosed;
            lp.Show();
        }

        private void Lp_FormClosed(object sender, FormClosedEventArgs e)
        {
            lp = null;
        }

        private void btn_HangNode_Click(object sender, EventArgs e)
        {
            lh = new LinkedList_HangNode();
            lh.FormClosed += Lh_FormClosed;
            lh.Show();
        }

        private void Lh_FormClosed(object sender, FormClosedEventArgs e)
        {
            lh = null;
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            li = new LinkedList_Insert();
            li.FormClosed += Li_FormClosed;
            li.Show();
        }

        private void Li_FormClosed(object sender, FormClosedEventArgs e)
        {
            li.Show();
        }

        private void btn_Erase_Click(object sender, EventArgs e)
        {
            le = new LinkedList_Erase();
            le.FormClosed += Le_FormClosed;
            le.Show();
        }

        private void Le_FormClosed(object sender, FormClosedEventArgs e)
        {
            le = null;
        }
    }
}
