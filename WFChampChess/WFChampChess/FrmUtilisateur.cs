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
    public partial class FrmUtilisateur : Form
    {
        private static FrmUtilisateur _main;
        private FrmUtilisateur()
        {
            InitializeComponent();
            _main = this;
        }
        public static FrmUtilisateur getInstance()
        {
            if (_main == null)
                _main = new FrmUtilisateur();
            return _main;
        }

        private void FrmUtilisateur_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
