using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithm_Dictionary.자료구조_Form.이진탐색트리
{
    public partial class BinarySearchTree : Form
    {
        AlgorithmMenu am;
        BinarySearchTreeNewNode bstn;
        BinarySearchTreeNode bstNewNode;
        BinarySearchTreeInsert bsti;
        BinarySearchTreeFree bstf;

        public BinarySearchTree()
        {
            InitializeComponent();
        }

        private void BinarySearchTree_Load(object sender, EventArgs e)
        {
            tb_description.AppendText("이진탐색트리는 각 노드가 최대 2개의 child node를 갖는 이진트리의 특수한 형태입니다.\r\n이진탐색트리는 데이터를 정렬된 형태로 보관하기 때문에 효율적으로 탐색 연산을 수행할 수 있습니다.\r\n평균적으로 이진 탐색 트리에서 탐색 연산의 시간복잡도는 O(log2 n)입니다.\r\n그러나 이진 탐색 트리는 입력되는 값의 순서에 따라 트리의 구성이 달라지기 때문에 트리가 한쪽으로 기울어진 평향 이진 트리가 생성될수 있습니다.\r\n이러한 경우에는 탐색 연산의 시간복잡도가 O(n)으로 급증합니다.\r\n이진탐색 트리의 정의로는 각 노드는 최대 2개의 child node만을 가질수 있고, 노드의 왼쪽 subtree는 그 노드의 값보다 작은 값들을 지닌 노드들로 이루어 집니다.\r\n그리고 노드의 오른쪽 subtree는 그 노드의 값보다 큰 값들을 지닌 노드들로 이루어 지고 좌우 subtree는 각각이 다시 이진 탐색 트리입니다.\r\n그리고 각 노드의 값은 중복을 허용하지 않는 다는 특징이 있습니다.");

            tb_NewNode.AppendText("다음은 이진탐색트리의 초기화를 나타내주는 함수 입니다.\r\n함수 이름 그대로 트리를 초기화 해주는 것으로서 트리값을 NULL로 초기화 해주면 됩니다.\r\n코드를 보고싶으시면 아래 코드보기 버튼을 눌러주세요.");

            tb_Node.AppendText("다음은 이진탐색트리의 노드생성을 해주는 함수입니다.\r\n하나의 노드 변수를 만들어서 동적으로 할당해주고 나서 각 노드의 값들을 초기 NULL값으로 초기화 해주는 작업을 이 함수에서 해줍니다.\r\n함수의 코드를 보고싶으시면 코드보기 버튼을 눌러주세요.");

           tb_insert.AppendText("다음은 이진탐색트리의 노드 삽입 함수입니다.\r\n여기서는 초기에 노드를 삽입해주는 코드를 시작으로 같은 값이 존재하는지 검사를 하고 또 데이터의 크기들을 비교해주면서 그 조건이 충족이 될 때에만 노드가 삽입 될 수 있게끔 해주는 함수입니다.\r\n이것의 자세한 코드를 보고 싶으시면 아래 코드보기 버튼을 눌러주세요.");

            tb_free.AppendText("다음은 이진탐색트리의 트리를 해제해 주는 함수입니다.\r\n여기서는 먼저 Dispose라고 해서 해제화 함수를 따로 만들어서 거기서 right와 left를 해제해주고 그리고 나서 node를 해제해주는 식으로 해서 함수를 구성하였습니다.\r\n이 함수의 코드를 보고싶으시다면 아래 코드보기 버튼을 눌러주세요.");
        }

        private void btn_New_Node_Click(object sender, EventArgs e)
        {
            bstn = new BinarySearchTreeNewNode();
            bstn.FormClosed += Bstn_FormClosed;
            bstn.Show();
        }

        private void Bstn_FormClosed(object sender, FormClosedEventArgs e)
        {
            bstn = null;
        }

        private void btn_malloclist_Click(object sender, EventArgs e)
        {
            bstNewNode = new BinarySearchTreeNode();
            bstNewNode.FormClosed += BstNewNode_FormClosed;
            bstNewNode.Show();
        }

        private void BstNewNode_FormClosed(object sender, FormClosedEventArgs e)
        {
            bstNewNode = null;
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            bsti = new BinarySearchTreeInsert();
            bsti.FormClosed += Bsti_FormClosed;
            bsti.Show();
        }

        private void Bsti_FormClosed(object sender, FormClosedEventArgs e)
        {
            bsti = null;
        }

        private void btn_free_Click(object sender, EventArgs e)
        {
            bstf = new BinarySearchTreeFree();
            bstf.FormClosed += Bstf_FormClosed;
            bstf.Show();
        }

        private void Bstf_FormClosed(object sender, FormClosedEventArgs e)
        {
            bstf = null;
        }

        private void pb_back_Click(object sender, EventArgs e)
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
    }
}
