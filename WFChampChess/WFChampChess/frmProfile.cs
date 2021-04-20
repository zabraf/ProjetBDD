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
    public partial class FrmProfile : Form
    {
        public FrmProfile(int? userId)
        {
            InitializeComponent();
            //verifier si utilisateur = utilisateur pour afficher ou non le button commentaire
            //afficher profile du userId
            lblNom.Text = "Zabraf";
            
        }

        private void btnCommentaire_Click(object sender, EventArgs e)
        {
            FrmCommentaire commentaire = new FrmCommentaire();
            commentaire.ShowDialog();
        }

        private void FrmProfile_Resize(object sender, EventArgs e)
        {
            int offset = 10;
            int posYTop = lsvMatch.Location.Y;
            int PosYBot = lsvCommentaire.Location.Y + lsvCommentaire.Size.Height;
            int LengthY = this.Height - posYTop - btnCommentaire.Size.Height - offset;
            int middle = LengthY / 2;
            lsvMatch.Size = new Size(lsvMatch.Width, middle - offset);
            
            lsvCommentaire.Location = new Point(lsvCommentaire.Location.X, posYTop + middle + offset);
            lsvCommentaire.Size = new Size(lsvMatch.Width, middle - btnCommentaire.Size.Height - offset*3);

        }
    }
}
