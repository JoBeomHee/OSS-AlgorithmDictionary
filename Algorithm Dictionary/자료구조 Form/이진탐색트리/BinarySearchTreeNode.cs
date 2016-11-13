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
    public partial class BinarySearchTreeNode : Form
    {
        public BinarySearchTreeNode()
        {
            InitializeComponent();
        }

        private void BinarySearchTreeNode_Load(object sender, EventArgs e)
        {
            tb_newNode.AppendText("//노드생성 함수"+Environment.NewLine);
            tb_newNode.AppendText("Node *NewNode(int data)"+Environment.NewLine);
            tb_newNode.AppendText("{" + Environment.NewLine);
            tb_newNode.AppendText("Node *now = (Node *)malloc(sizeof(Node));" + Environment.NewLine);
            tb_newNode.AppendText("now->data = data;" + Environment.NewLine);
            tb_newNode.AppendText("now->left = now->right = NULL;" + Environment.NewLine);
            tb_newNode.AppendText("return now;" + Environment.NewLine);
            tb_newNode.AppendText("}" + Environment.NewLine);
        }
    }
}
