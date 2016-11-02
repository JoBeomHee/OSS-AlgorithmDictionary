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
    public partial class Main : Form
    {
        AlgorithmDictionary ad;
        public Main()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            ad = new AlgorithmDictionary();
            ad.FormClosed += Ad_FormClosed;
            ad.Show();
        }

        private void Ad_FormClosed(object sender, FormClosedEventArgs e)
        {
            ad = null;
        }
    }
}
