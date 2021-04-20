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
    public partial class FrmLogin : Form
    {
        
        public FrmLogin()
        {
            InitializeComponent();
            lblError.Text = String.Empty;
            /*valeur par defaut (tbx.text) dans le login et mot de passe a enlever pour l'application finale
            (rajouter pour eviter d'écrire a chaque fois que je run l'application pour tester)*/
            tbxLogin.Text = "Admin";
            tbxMotDePasse.Text = "Class123";
        }

        private void btnCreerCompte_Click(object sender, EventArgs e)
        {
            FrmCreerCompte frmCompte = new FrmCreerCompte(this);
            frmCompte.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblError.Text = string.Empty;
            if (tbxMotDePasse.Text == String.Empty)
            {
                lblMotDePasse.ForeColor = Color.Red;
                lblError.Text = "il a un/des champs non remplie";
            }
            else
            {
                lblMotDePasse.ForeColor = Color.Black;
            }
            if(tbxLogin.Text == String.Empty)
            {
                lblNomUtilisateur.ForeColor = Color.Red;
                lblError.Text = "il a un/des champs non remplie";
            }
            else
            {
                lblNomUtilisateur.ForeColor = Color.Black;
            }
            //verfifation utilisateur
            //aficher message d'erreur
            if(lblError.Text == string.Empty)
            { 
                if(tbxLogin.Text =="Admin")
                    FrmMain.getInstance().Utilisateur = 1; //a changer
                else
                    FrmMain.getInstance().Utilisateur = 2; //a changer
                this.Close();
            }

        }

    }
}
