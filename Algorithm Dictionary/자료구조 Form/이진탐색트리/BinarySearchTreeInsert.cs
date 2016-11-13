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
    public partial class BinarySearchTreeInsert : Form
    {
        public BinarySearchTreeInsert()
        {
            InitializeComponent();
        }

        private void BinarySearchTreeInsert_Load(object sender, EventArgs e)
        {
            tb_insert.AppendText("//노드 삽입"+Environment.NewLine);
            tb_insert.AppendText("int InsertNode(Tree *tree, int data)" + Environment.NewLine);
            tb_insert.AppendText("{" + Environment.NewLine);
            tb_insert.AppendText("Node *seek = *tree;" + Environment.NewLine);
            tb_insert.AppendText("if (seek == NULL) // 초기노드 삽입" + Environment.NewLine);
            tb_insert.AppendText("{" + Environment.NewLine);
            tb_insert.AppendText("(*tree) = NewNode(data);" + Environment.NewLine);
            tb_insert.AppendText("return 1;" + Environment.NewLine);
            tb_insert.AppendText("}" + Environment.NewLine);
            tb_insert.AppendText("while (1)" + Environment.NewLine);
            tb_insert.AppendText("{" + Environment.NewLine);
            tb_insert.AppendText("if (seek->data == data) // 같은값 존재" + Environment.NewLine);
            tb_insert.AppendText("{" + Environment.NewLine);
            tb_insert.AppendText("return 0; //삽입 실패" + Environment.NewLine);
            tb_insert.AppendText("}" + Environment.NewLine);
            tb_insert.AppendText("if (seek->data > data) // 기존값이 더 클때" + Environment.NewLine);
            tb_insert.AppendText("{" + Environment.NewLine);
            tb_insert.AppendText("if (seek->left) //왼쪽에 자식이 이미 있으면" + Environment.NewLine);
            tb_insert.AppendText("{" + Environment.NewLine);
            tb_insert.AppendText("seek = seek->left; //seek를 왼쪽 자식으로 설정" + Environment.NewLine);
            tb_insert.AppendText("}" + Environment.NewLine);
            tb_insert.AppendText("else" + Environment.NewLine);
            tb_insert.AppendText("{" + Environment.NewLine);
            tb_insert.AppendText("seek->left = NewNode(data); //왼쪽 자식으로 새로운 노드를 설정" + Environment.NewLine);
            tb_insert.AppendText("return 1; //삽입 성공" + Environment.NewLine);
            tb_insert.AppendText("}" + Environment.NewLine);
            tb_insert.AppendText("}" + Environment.NewLine);
            tb_insert.AppendText("else //기존 데이터가 작을 때" + Environment.NewLine);
            tb_insert.AppendText("{" + Environment.NewLine);
            tb_insert.AppendText("if (seek->right) //오른쪽에 자식이 이미 있으면" + Environment.NewLine);
            tb_insert.AppendText("{" + Environment.NewLine);
            tb_insert.AppendText("seek = seek->right; //seek를 오른쪽 자식으로 설정" + Environment.NewLine);
            tb_insert.AppendText("}" + Environment.NewLine);
            tb_insert.AppendText("else" + Environment.NewLine);
            tb_insert.AppendText("{" + Environment.NewLine);
            tb_insert.AppendText("seek->right = NewNode(data); //오른쪽 자식으로 새로운 노드를 설정" + Environment.NewLine);
            tb_insert.AppendText("return 1; //삽입 성공" + Environment.NewLine);
            tb_insert.AppendText("}" + Environment.NewLine);
            tb_insert.AppendText("}" + Environment.NewLine);
            tb_insert.AppendText("}" + Environment.NewLine);
        }
    }
}
