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
   
    public partial class FrmMain : Form
    {
        private static FrmMain _main;
        private bool _estAdminstrateur;
        private int? _utilisateurId;
        public int? Utilisateur { get => _utilisateurId; set => _utilisateurId = value; }
        public bool EstAdminstrateur { get => _estAdminstrateur; set => _estAdminstrateur = value; }

        private FrmMain()
        {
            InitializeComponent();
            _main = this;
            FrmLogin formLogin = new FrmLogin();
            formLogin.ShowDialog();
            //verification utilisateur / is admin / existe
            if(_utilisateurId == 1)
                _estAdminstrateur = true;
            else
                _estAdminstrateur = false;
            if (!_estAdminstrateur)
            {
                tsmAdministrateur.Visible = false;
                tsmCreerTournois.Visible = false;
            }
            if (_utilisateurId == null) //utilisateur n'a pas été set par la form login ou creerCompte
            {
                this.Close(); 
            }
           
        }

       
        public static FrmMain getInstance()
        {
            if(_main == null)
               new FrmMain();
            return _main;
        }
        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProfile profile = new FrmProfile(_utilisateurId);
            profile.MdiParent = this;
            profile.Show();
        }

        private void msiCreerMatch_Click(object sender, EventArgs e)
        {
            FrmCreerMatch creerMatch = new FrmCreerMatch();
            creerMatch.ShowDialog();
        }

        private void msiRejoindre_Click(object sender, EventArgs e)
        {
            FrmRejoindreMatch regader = new FrmRejoindreMatch(false);
            regader.Show();
        }

        private void regarderUnMatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRejoindreMatch regader = new FrmRejoindreMatch(true);
            regader.Show();
        }

        private void msiChercher_Click(object sender, EventArgs e)
        {
            //requete qui cherche le nom avec tsbChercher.Text et retourne id
            int idRechercher = 2;
            // a remplacer par if exist in database
            if (tsbChercher.Text == "Unknown")
            {
                MessageBox.Show("l'utilisateur n'existe pas");
            }
            else
            {
                tsbChercher.Text = String.Empty;
                FrmProfile profile = new FrmProfile(idRechercher);
                profile.MdiParent = this;
                profile.Show();
            }
            
        }

        private void tsmModifierProfile_Click(object sender, EventArgs e)
        {
            FrmModifierCompte modifierCompte = new FrmModifierCompte(_utilisateurId);
            modifierCompte.ShowDialog();
        }

        private void afficherUtilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUtilisateur formUtilisateur = FrmUtilisateur.getInstance();
            formUtilisateur.MdiParent = this;
            if(!formUtilisateur.Visible)
            {
                formUtilisateur.Show();
            }
            else
            {
                formUtilisateur.BringToFront();
            }
               
        }

        private void afficherCommentaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdminCommentaire formUtilisateur = FrmAdminCommentaire.getInstance();
            formUtilisateur.MdiParent = this;
            if (!formUtilisateur.Visible)
            {
                formUtilisateur.Show();
            }
            else
            {
                formUtilisateur.BringToFront();
            }

        }

        private void tsmCreerTournois_Click(object sender, EventArgs e)
        {
            FrmCreerTournoi tournois = new FrmCreerTournoi();
            tournois.ShowDialog();
        }

        private void tsmRejoindreTournois_Click(object sender, EventArgs e)
        {
            FrmTournois formTournois = FrmTournois.getInstance();
            formTournois.MdiParent = this;
            if (!formTournois.Visible)
            {
                formTournois.Show();
            }
            else
            {
                formTournois.BringToFront();
            }
            
        }
    }
}
