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
        AlgorithmMenu am;
        public Main()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            am = new AlgorithmMenu();
            am.FormClosed += Ad_FormClosed;
            am.Show();
        }

        private void Ad_FormClosed(object sender, FormClosedEventArgs e)
        {
            am = null;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            string message = "정말로 종료하시겠습니까?";
            string caption = "Exit";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if(result == System.Windows.Forms.DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
