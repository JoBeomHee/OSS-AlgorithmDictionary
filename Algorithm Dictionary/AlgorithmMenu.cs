using Algorithm_Dictionary.자료구조_Form.링크드리스트;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithm_Dictionary
{
    public partial class AlgorithmMenu : Form
    {
        Stack stack;
        LinkedList ll;
        public AlgorithmMenu()
        {
            InitializeComponent();
        }

        private void btn_stack_Click(object sender, EventArgs e)
        {
            stack = new Stack();
            stack.FormClosed += Stack_FormClosed;
            stack.Show();
            this.Close();
        }

        private void Stack_FormClosed(object sender, FormClosedEventArgs e)
        {
            stack = null;
        }

        private void btn_LinkedList_Click(object sender, EventArgs e)
        {
            ll = new LinkedList();
            ll.FormClosed += Ll_FormClosed;
            ll.Show();
            this.Close();
        }

        private void Ll_FormClosed(object sender, FormClosedEventArgs e)
        {
            ll = null;
        }
    }
}
