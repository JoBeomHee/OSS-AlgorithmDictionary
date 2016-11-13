﻿using Algorithm_Dictionary.자료구조_Form.링크드리스트;
using Algorithm_Dictionary.자료구조_Form.삽입정렬;
using Algorithm_Dictionary.자료구조_Form.선택정렬;
using Algorithm_Dictionary.자료구조_Form.이진탐색트리;
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
        InsertSort Is;
        SelectionSort ss;
        BinarySearchTree bst;

        public AlgorithmMenu()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

            if (tb_Search.Text.ToString() == "스택")
            {
                stack = new Stack();
                stack.FormClosed += Stack_FormClosed;
                stack.Show();
                this.Close();
            }
            if (tb_Search.Text.ToString() == "연결리스트")
            {
                ll = new LinkedList();
                ll.FormClosed += Ll_FormClosed;
                ll.Show();
                this.Close();
            }
            if (tb_Search.Text.ToString() == "삽입정렬")
            {
                Is = new InsertSort();
                Is.FormClosed += Is_FormClosed;
                Is.Show();
                this.Close();
            }
            if(tb_Search.Text.ToString() == "선택정렬")
            {
                ss = new SelectionSort();
                ss.FormClosed += Ss_FormClosed;
                ss.Show();
                this.Close();
            }
            if(tb_Search.Text.ToString() == "이진탐색트리")
            {
                bst = new BinarySearchTree();
                bst.FormClosed += Bst_FormClosed;
                bst.Show();
                this.Close();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            tb_Search.Text = tb_Search.Text;
        }

        private void Bst_FormClosed(object sender, FormClosedEventArgs e)
        {
            bst = null;
        }

        private void Ss_FormClosed(object sender, FormClosedEventArgs e)
        {
            ss = null;
        }

        private void Is_FormClosed(object sender, FormClosedEventArgs e)
        {
            Is = null;
        }

        private void Ll_FormClosed(object sender, FormClosedEventArgs e)
        {
            ll = null;
        }

        private void Stack_FormClosed(object sender, FormClosedEventArgs e)
        {
            stack = null;
        }

        private void Key_Enter(object sender, KeyPressEventArgs e) //엔터키 눌렀을 때 검색
        {
            if (e.KeyChar == '\r')
            {
                btn_Search_Click(sender, e);

            }
        }

        private void tb_search(object sender, KeyPressEventArgs e) //엔터키 눌렀을 때 검색
        {
            if (e.KeyChar == '\r')
            {
                btn_Search_Click(sender, e);

            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
