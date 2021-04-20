using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFChampChess
{
    public partial class FrmModifierCompte : Form
    {
        private string _pseudonyme;
        private string _motDePasse;
        private string _email;
        private string _prenom;
        private string _nom;
        private const string TEXT_CHAMP_MANQUANT = "certain champs sont vide";
        public FrmModifierCompte(int? userId)
        {
            InitializeComponent();
            //recuperer les informations depuis la db + enlever les information en dur
            _pseudonyme = "zabraf";
            _motDePasse = "Class123";
            _email = "raphael.lopes@etu.hesge.ch";
            _prenom = "Raphaël";
            _nom = "Lopes";
            tbxPseudonyme.Text = _pseudonyme;
            tbxEmail.Text = _email;
            tbxPrenom.Text = _prenom;
            tbxNom.Text = _nom;
            lblError.Text = String.Empty; 

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChangerInformations_Click(object sender, EventArgs e)
        {
            lblPseudonyme.ForeColor = Color.Black;
            lblEmail.ForeColor = Color.Black;
            lblAncienMotDePasse.ForeColor = Color.Black;
            if (tbxPseudonyme.Text != _pseudonyme)
            {
                if (tbxPseudonyme.Text == String.Empty)
                {
                    lblPseudonyme.ForeColor = Color.Red;
                    lblError.Text = TEXT_CHAMP_MANQUANT;
                }
            }

            if (tbxEmail.Text != _email)
            {
                //ajouter email dans update
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
            }
            if (tbxMotDePasse.Text != String.Empty)
            {
                if (_motDePasse == HashSha256.TransformeSha256(tbxAncienMotDePasse.Text))
                {
                    if (tbxMotDePasse.Text.Length > 8)
                    {
                        if (tbxMotDePasse.Text != tbxConfirmationMotDePasse.Text && lblError.Text == String.Empty)
                        {
                            lblError.Text = "les mots de passe ne sont pas similaire";
                            lblMotDePasse.ForeColor = Color.Red;
                            lblConfirmationMotDePasse.ForeColor = Color.Red;
                        }
                        //hash mot de passe
                        string mdpHash = HashSha256.TransformeSha256(tbxMotDePasse.Text);
                    }
                    else
                    {
                        lblError.Text = "le mots de passe doit faire moins de 8 charactère";
                        lblMotDePasse.ForeColor = Color.Red;
                    }
                }
                else
                {
                    lblError.Text = "le mot de passe est incorrect";
                    lblAncienMotDePasse.ForeColor = Color.Red;
                }
            }
            if(_nom != tbxNom.Text)
            {
                //ajouter nom dans update
            }
            if (_prenom != tbxPrenom.Text)
            {
                //ajouter prenom dans update
            }
            if(lblError.Text == String.Empty)
            {
                //update avec tout les champs 
                this.Close();
            }
           
        }

        private void btnAnnuler_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbxAncienMotDePasse_TextChanged(object sender, EventArgs e)
        {
            if(tbxAncienMotDePasse.Text.Length > 0)
            {
                tbxMotDePasse.ReadOnly = true;
                tbxMotDePasse.ReadOnly = true;
            }
            else
            {
                tbxMotDePasse.ReadOnly = false;
                tbxMotDePasse.ReadOnly = false;
            }
        }
    }
}
