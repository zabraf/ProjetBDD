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
    public partial class FrmCreerTournoi : Form
    {
        public FrmCreerTournoi()
        {
            InitializeComponent();
            lblError.Text = String.Empty;
            dtpDate.MinDate = DateTime.Today;
            dtpHeure.MinDate = DateTime.Now.AddHours(2);
            dtpHeure.Value = DateTime.Now.AddHours(3);
            dtpHeure.CustomFormat = "HH:mm";
        }

        private void btnAnnuller_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            lblNom.ForeColor = Color.Black;
            lblDate.ForeColor = Color.Black;

            if (tbxNom.Text == String.Empty)
            {
                lblError.Text = "le nom est vide";
                lblNom.ForeColor = Color.Red;
            }
            else
            {
                if(dtpDate.Value < DateTime.Today)
                {
                    lblError.Text = "le tournois ne peut pas être avant la data d'ajourd'hui";
                    lblDate.ForeColor = Color.Red;
                }
                else
                {
                    if (dtpHeure.Value < DateTime.Now.AddHours(2))
                    {
                        lblError.Text = "le tournois doit ètre au minimume 2 heure après";
                        lblDate.ForeColor = Color.Red;
                    }
                    else
                    {
                        //creer le trounois en database
                        this.Close();
                    }
                   
                }
            }
        }
    }
}
