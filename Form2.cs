using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibSys_IMDB
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBook fBook = new frmBook();
            fBook.ShowDialog();
        }
    }
}
