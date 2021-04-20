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
    public partial class FrmTournois : Form
    {
        private static FrmTournois _main;
        private FrmTournois()
        {
            InitializeComponent();
            _main = this;
        }

        public static FrmTournois getInstance()
        {
            if (_main == null)
                new FrmTournois();
            return _main;
        }
        private void FrmTournois_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
