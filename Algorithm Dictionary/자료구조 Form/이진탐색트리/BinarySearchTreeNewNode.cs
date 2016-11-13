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
    public partial class BinarySearchTreeNewNode : Form
    {
        public BinarySearchTreeNewNode()
        {
            InitializeComponent();
        }

        private void BinarySearchTreeNewNode_Load(object sender, EventArgs e)
        {
            tb_NewNode.AppendText("//트리 초기화"+Environment.NewLine);
            tb_NewNode.AppendText("void InitTree(Tree *tree)" + Environment.NewLine);
            tb_NewNode.AppendText("{" + Environment.NewLine);
            tb_NewNode.AppendText("*tree = NULL" + Environment.NewLine);
            tb_NewNode.AppendText("}" + Environment.NewLine);
        }
    }
}
