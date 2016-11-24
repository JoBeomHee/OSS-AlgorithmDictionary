using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithm_Dictionary.자료구조_Form.너비우선탐색
{
    public partial class BreadthFirstSearch : Form
    {
        AlgorithmMenu am;
        Graph gp;
        Search sh;

        public BreadthFirstSearch()
        {
            InitializeComponent();
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

        private void lb_link_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://ehclub.co.kr/1580");
        }

        private void BreadthFirstSearch_Load(object sender, EventArgs e)
        {
            tb_description.AppendText("");
            tb_Graph.AppendText("");
            tb_Search.AppendText("");
        }
        private void btn_Graph_Click(object sender, EventArgs e)
        {
            gp = new Graph();
            gp.FormClosed += Gp_FormClosed;
            gp.Show();
        }

        private void Gp_FormClosed(object sender, FormClosedEventArgs e)
        {
            gp = null;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            sh = new Search();
            sh.FormClosed += Sh_FormClosed;
            sh.Show();
        }

        private void Sh_FormClosed(object sender, FormClosedEventArgs e)
        {
            sh = null;
        }

    }
}
