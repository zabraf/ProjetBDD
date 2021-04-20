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
    public partial class FrmRejoindreMatch : Form
    {
        private bool _vaRegarder;
        public FrmRejoindreMatch(bool vaRegarder)
        {
            _vaRegarder = vaRegarder;
            InitializeComponent();
            lblError.Text = String.Empty;
            if (vaRegarder)
            {
                this.Text = "Regarder un match";
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRejoindre_Click(object sender, EventArgs e)
        {
            lblError.ForeColor = Color.Black;
            lblError.Text = String.Empty;
            int tempsSeconde;
            int secondeAjouter;
            int id;
            Joueur joueur;
            if (tbxId.Text == string.Empty)
            {
                lblError.Text = "veuillez remplire le champs id";
                lblError.ForeColor = Color.Red;

            }
            else if (!int.TryParse(tbxId.Text, out id))
            {
                lblError.Text = "ceci n'est pas un chiffre";
                lblError.ForeColor = Color.Red;
            }
            //changer quand db pour verfier si la game existe dans la db
            else if (true == false)
            {
                lblError.Text = "id de la partie n'existe pas";
                lblError.ForeColor = Color.Red;
            }
            else
            {
                //changer en fonction de la db
                tempsSeconde = 10;
                secondeAjouter = 10;

                if (_vaRegarder)
                {
                    joueur = Joueur.Specateur;
                }
                else
                {
                    //changer en fonction de la db
                    joueur = Joueur.Noir;
                }
                if (lblError.Text == string.Empty)
                {
                    //
                    FrmMatch match = new FrmMatch(id,joueur, tempsSeconde, secondeAjouter);
                    match.MdiParent = FrmMain.getInstance();
                    match.Show();
                    this.Close();
                }
            }

        }
    }
}
