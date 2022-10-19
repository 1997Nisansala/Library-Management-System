using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System_New
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnnewst_Click(object sender, EventArgs e)
        {
            Managestud fr = new Managestud();
            fr.Show();
            this.Dispose();
        }

        private void btnnewbk_Click(object sender, EventArgs e)
        {
            Managebooks fn = new Managebooks();
            fn.Show();
            this.Dispose(false);
        }

        private void btnstat_Click(object sender, EventArgs e)
        {
            store fn = new store();
            fn.Show();
            this.Dispose(false);
        }

        private void btnissue_Click(object sender, EventArgs e)
        {
            IssueBooks fb = new IssueBooks();
            fb.Show();
            this.Dispose();
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            ReturnBooks rb = new ReturnBooks();
            rb.Show();
            this.Dispose();
        }
    }
}
