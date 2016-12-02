using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithm_Dictionary.자료구조_Form.다익스트라
{
    public partial class Dijkstra : Form
    {
        AlgorithmMenu am;
        public Dijkstra()
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
            System.Diagnostics.Process.Start("http://ehclub.co.kr/1583");
        }
    }
}
