using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WFChampChess
{
    
    public partial class FrmCreerCompte : Form
    {
       

        private const string TEXT_CHAMP_MANQUANT = "certain champs obligatoire ne sont pas remplie";
        private FrmLogin _login;
        public FrmCreerCompte(FrmLogin login)
        {
            InitializeComponent();
            _login = login;
            lblError.Text = String.Empty;
        }

        private void btnCreerCompte_Click(object sender, EventArgs e)
        {
            lblPseudonyme.ForeColor = Color.Black;
            lblMotDePasse.ForeColor = Color.Black;
            lblConfirmationMotDePasse.ForeColor = Color.Black;
            lblEmail.ForeColor = Color.Black;
            lblError.Text = String.Empty;

            if (tbxPseudonyme.Text == String.Empty)
            {
                lblPseudonyme.ForeColor = Color.Red;
                lblError.Text = TEXT_CHAMP_MANQUANT;
            }
            if (tbxMotDePasse.Text == String.Empty)
            {
                lblMotDePasse.ForeColor = Color.Red;
                lblError.Text = TEXT_CHAMP_MANQUANT;
            }
            if (tbxConfirmationMotDePasse.Text == String.Empty)
            {
                lblConfirmationMotDePasse.ForeColor = Color.Red;
                lblError.Text = TEXT_CHAMP_MANQUANT;
            }
            if (tbxEmail.Text == String.Empty)
            {
                lblEmail.ForeColor = Color.Red;
                lblError.Text = TEXT_CHAMP_MANQUANT;
            }
            else
            {
                Regex regexEmail = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
                Match match = regexEmail.Match(tbxEmail.Text);
                if (!match.Success)
                {
                    lblEmail.ForeColor = Color.Red;
                    lblError.Text = "Email non valide";
                }
            }
            if(tbxMotDePasse.Text.Length > 8)
            { 
                if (tbxMotDePasse.Text != tbxConfirmationMotDePasse.Text && lblError.Text == String.Empty )
                {
                    lblError.Text = "les mots de passe ne sont pas similaire";
                    lblMotDePasse.ForeColor = Color.Red;
                    lblConfirmationMotDePasse.ForeColor = Color.Red;
                }
                else
                {
                    //hash mot de passe
                    string mdpHash = HashSha256.TransformeSha256(tbxMotDePasse.Text);
                }
            }
            else
            {
                lblError.Text = "le mots de passe doit faire moins de 8 charactère";
                lblMotDePasse.ForeColor = Color.Red;
            }
           
          
            if (lblError.Text == string.Empty)
            {
                FrmMain.getInstance().Utilisateur = 1; //a changer par la db
                _login.Close();
                this.Close();
            }

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
