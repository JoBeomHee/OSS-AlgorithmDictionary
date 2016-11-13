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
    public partial class BinarySearchTreeFree : Form
    {
        public BinarySearchTreeFree()
        {
            InitializeComponent();
        }

        private void BinarySearchTreeFree_Load(object sender, EventArgs e)
        {
            tb_free.AppendText("//해제화" + Environment.NewLine);
            tb_free.AppendText("void Dispose(Node *node)" + Environment.NewLine);
            tb_free.AppendText("{" + Environment.NewLine);
            tb_free.AppendText("if (node)" + Environment.NewLine);
            tb_free.AppendText("{" + Environment.NewLine);
            tb_free.AppendText("Dispose(node->left);" + Environment.NewLine);
            tb_free.AppendText("Dispose(node->right);" + Environment.NewLine);
            tb_free.AppendText("free(node);" + Environment.NewLine);
            tb_free.AppendText("}" + Environment.NewLine);
            tb_free.AppendText("}" + Environment.NewLine);

            tb_free.AppendText("void ClearTree(Tree *tree) //트리 해제" + Environment.NewLine);
            tb_free.AppendText("{" + Environment.NewLine);
            tb_free.AppendText("Dispose(*tree);" + Environment.NewLine);
            tb_free.AppendText("*tree = 0;" + Environment.NewLine);
            tb_free.AppendText("}" + Environment.NewLine);
        }
    }
}
