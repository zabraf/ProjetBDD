using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFChampChess
{
    public partial class FrmAdminCommentaire : Form
    {
        private static FrmAdminCommentaire _main;
        private FrmAdminCommentaire()
        {
            InitializeComponent();
            _main = this;
        }
        public static FrmAdminCommentaire getInstance()
        {
            if (_main == null)
                new FrmAdminCommentaire();
            return _main;
        }

        private void FrmAdminCommentaire_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
