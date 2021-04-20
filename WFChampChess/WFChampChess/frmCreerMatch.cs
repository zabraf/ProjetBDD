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
    public enum Type
    {
        Classic,
        Blitz,
        Bullet,
        Personaliser
    }
    public partial class FrmCreerMatch : Form
    {
        public FrmCreerMatch()
        {
            InitializeComponent();
            lblError.Text = String.Empty;
            foreach(Type type in Enum.GetValues(typeof(Type)))
            {
                cboType.Items.Add(type);
            }
            cboType.SelectedIndex = 0;
            foreach (Joueur typeJoueur in Enum.GetValues(typeof(Joueur)))
            {
                if(typeJoueur != Joueur.Specateur)
                    cboJoueur.Items.Add(typeJoueur);
            }
            cboJoueur.SelectedIndex = 0;
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            int tempsSeconde = (int)nudTempsMinutes.Value * 60 + (int)nudTempsSeconde.Value;
            lblError.Text = String.Empty;
            lblTempsTotal.ForeColor = Color.Black;
            lblMinutes.ForeColor = Color.Black;
            lblSeconde.ForeColor = Color.Black;
            if (tempsSeconde < 30)
            {
                lblError.Text = "Temps Minimume de 30 seconde pour un match";
                lblTempsTotal.ForeColor = Color.Red;
                lblMinutes.ForeColor = Color.Red;
                lblSeconde.ForeColor = Color.Red;
            }
            //creation du match en db + retourn id
            int id = 1;
            FrmMatch match = new FrmMatch(id,(Joueur)cboJoueur.SelectedItem, tempsSeconde, (int)nudAjouterSeconde.Value);
            match.MdiParent = FrmMain.getInstance();
            match.Show();
            this.Close();
        }

        private void btnAnnuller_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((Type)cboType.SelectedItem)
            {
                case Type.Classic:
                    nudAjouterSeconde.Value = 0;
                    nudTempsMinutes.Value = 10;
                    nudTempsSeconde.Value = 0;
                    break;
                case Type.Blitz:
                    nudAjouterSeconde.Value = 0;
                    nudTempsMinutes.Value = 5;
                    nudTempsSeconde.Value = 0;
                    break;
                case Type.Bullet:
                    nudAjouterSeconde.Value = 1;
                    nudTempsMinutes.Value = 1;
                    nudTempsSeconde.Value = 0;
                    break;
                case Type.Personaliser:
                    break;
                default:
                    throw new Exception("error type unknow");
            }
        }
    }
}
