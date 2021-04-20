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
    public enum Joueur
    {
        Blanc,
        Noir,
        Specateur
    }
    public partial class FrmMatch : Form
    {
        private int _id;
        private Joueur _joueur;
        private int _temps;
        private int _tempsAdversaire;
        private int _TempsAjouterSeconde;
        public FrmMatch(int id,Joueur joueur,int tempsTotalSeconde,int tempsAjouterSeconde)
        {
            InitializeComponent();
            _id = id;
            this.Text = "Match N°" + _id;
            _joueur = joueur;
            _temps = _tempsAdversaire = tempsTotalSeconde;
            _TempsAjouterSeconde = tempsAjouterSeconde;
            lblTempsAdversaire.Text = lblTempsJoueur.Text = tranformerTemps(tempsTotalSeconde);
            switch (joueur)
            {
                case Joueur.Blanc:
                    picEchequier.Image = (Image)Properties.Resources.ResourceManager.GetObject("Blanc");
                    break;
                case Joueur.Noir:
                    picEchequier.Image = (Image)Properties.Resources.ResourceManager.GetObject("Noir");
                    break;
                case Joueur.Specateur:
                    picEchequier.Image = (Image)Properties.Resources.ResourceManager.GetObject("Blanc");
                    BtnJoue.Visible = false;
                    tbxJoue.Visible = false;
                    btnAbandonner.Visible = false;
                    btnNul.Visible = false;
                    break;
                default:
                    break;
            }
            BtnJoue.Enabled = false;
            /*on desactive les buttons qui soit en blanc ou noir
             * pour le joueur noir car le blanc va jouer d'abords
             * pour le joueur blanc car on doit attendre le joueur noir avant de jouer
             * */
            //quand la partie commence faire lancerPartie();
        }
        private void lancerPartie()
        {
            if (_joueur == Joueur.Noir)
            {

            }
            else
            {
                BtnJoue.Enabled = true;
            };
            tmrTemps.Start();
        }
        private string tranformerTemps(int tempsEnSeconde)
        {
            return string.Format("{0:d2}:{1:d2}", (int)(tempsEnSeconde / 60), (int)(tempsEnSeconde % 60));
        }
        private void BtnJoue_Click(object sender, EventArgs e)
        {
            tbxJoue.ForeColor = Color.Black;
            //regex qui vérfie si le move en terme de notation est correcte
            Regex rxMove = new Regex(@"^([KQBNR]?[a-h][0-8][a-h][0-8])$|^(O-O|O-O-O)$|([a-h][18]=[KQBNR])$");
            Match match = rxMove.Match(tbxJoue.Text);
            if (match.Success)
            {
                //envoyer au serveur
                BtnJoue.Enabled = false;
                _temps += _TempsAjouterSeconde;
            }
            else
            {
                tbxJoue.ForeColor = Color.Red;
            }
        }

        private void tmrTemps_Tick(object sender, EventArgs e)
        {
            if (BtnJoue.Enabled)
            {
                _temps--;
                lblTempsJoueur.Text = tranformerTemps(_temps);
            }
            else
            {
                _tempsAdversaire--;
                lblTempsAdversaire.Text = tranformerTemps(_tempsAdversaire);
            }
        }

        private void FrmMatch_Resize(object sender, EventArgs e)
        {
            int offset = 10;
            int sizeMiddle = this.Size.Width / 2;
            picEchequier.Size = new Size(this.Size.Width / 2 - offset, (lblTempsJoueur.Location.Y - picEchequier.Location.Y) - offset);

            tbxJoue.Size = new Size(sizeMiddle - offset, tbxJoue.Size.Height);
            btnAbandonner.Size = new Size(sizeMiddle - offset, btnAbandonner.Size.Height);
            btnNul.Size = new Size(sizeMiddle - offset, btnNul.Size.Height);
            BtnJoue.Size = new Size(sizeMiddle - offset, BtnJoue.Size.Height);

            lsvMouvement.Location = new Point(sizeMiddle + offset, lsvMouvement.Location.Y);
            lsvMouvement.Size = new Size(sizeMiddle - offset * 3, lsvMouvement.Height);
        }
    }
}
