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
            tb_description.AppendText("연결리스트는 노드의 선형 집합니다. 노드란 데이터와 링크의 조합으로 하나의 데이터를 보관하는 작은 저장소입니다. 그리고 링크는 노드의 위치 정보입니다. 이렇게 각 노드들이 링크를 통해서 각각 연결되어있는 리스트를 링크드 리스트라고 합니다. 그중 이중연결리스트를 가지고 코드 설명을 하도록 하겠습니다.");

            tb_New_Node.AppendText("제일 먼저 링크드 리스트에서 먼저 노드를 생성하는 함수를 알아보도록 하겠습니다. 노드에는 총 3개의 정보들이 있는데 이전 노드의 위치 정보와 보관된 데이터 그리고 다음 노드의 위치 정도가 들어있습니다. 노드 생성 함수의 내부를 보고싶으시면 아래 코드보기 버튼을 눌러주세요.");

            tb_mallocList.AppendText("다음으로는 연결리스트 동적생성을 하는 함수입니다. 이 함수는 Linkedlist 동적으로 먼저 메모리를 할당 받은 다음 head와 tail의 더미노드를 생성하고 head와 tail이 각각 가리키게끔 링크를 성정한 후 마지막 저장소 0으로 초기화를 해주는 함수입니다. 연결리스트 동적생성 함수 코드를 보고싶으시면 코드보기 버튼을 눌러주세요.");
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
    }
}
