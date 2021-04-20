
namespace WFChampChess
{
    partial class FrmProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRank = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lsvMatch = new System.Windows.Forms.ListView();
            this.clhJoueurBlanc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhJoueurNoir = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvCommentaire = new System.Windows.Forms.ListView();
            this.clhUtilisateur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhNote = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhCommentaire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhButtonReport = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCommentaire = new System.Windows.Forms.Button();
            this.picExempleGraph = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picExempleGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRank
            // 
            this.lblRank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRank.AutoSize = true;
            this.lblRank.Location = new System.Drawing.Point(414, 29);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(39, 13);
            this.lblRank.TabIndex = 4;
            this.lblRank.Text = "Rank :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(12, 29);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(107, 33);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "lblNom";
            // 
            // lsvMatch
            // 
            this.lsvMatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvMatch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhJoueurBlanc,
            this.clhJoueurNoir,
            this.clhDate,
            this.clhType});
            this.lsvMatch.HideSelection = false;
            this.lsvMatch.Location = new System.Drawing.Point(12, 195);
            this.lsvMatch.Name = "lsvMatch";
            this.lsvMatch.Size = new System.Drawing.Size(776, 97);
            this.lsvMatch.TabIndex = 1;
            this.lsvMatch.UseCompatibleStateImageBehavior = false;
            this.lsvMatch.View = System.Windows.Forms.View.Details;
            // 
            // clhJoueurBlanc
            // 
            this.clhJoueurBlanc.Text = "Joueur Blanc";
            this.clhJoueurBlanc.Width = 209;
            // 
            // clhJoueurNoir
            // 
            this.clhJoueurNoir.Text = "Joueur Noir";
            this.clhJoueurNoir.Width = 183;
            // 
            // clhDate
            // 
            this.clhDate.Text = "Date";
            this.clhDate.Width = 166;
            // 
            // clhType
            // 
            this.clhType.Text = "Type";
            this.clhType.Width = 211;
            // 
            // lsvCommentaire
            // 
            this.lsvCommentaire.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvCommentaire.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhUtilisateur,
            this.clhNote,
            this.clhCommentaire,
            this.clhButtonReport});
            this.lsvCommentaire.HideSelection = false;
            this.lsvCommentaire.Location = new System.Drawing.Point(12, 315);
            this.lsvCommentaire.Name = "lsvCommentaire";
            this.lsvCommentaire.Size = new System.Drawing.Size(776, 97);
            this.lsvCommentaire.TabIndex = 2;
            this.lsvCommentaire.UseCompatibleStateImageBehavior = false;
            this.lsvCommentaire.View = System.Windows.Forms.View.Details;
            // 
            // clhUtilisateur
            // 
            this.clhUtilisateur.Text = "Utilisateur";
            this.clhUtilisateur.Width = 121;
            // 
            // clhNote
            // 
            this.clhNote.Text = "Note";
            this.clhNote.Width = 72;
            // 
            // clhCommentaire
            // 
            this.clhCommentaire.Text = "Commentaire";
            this.clhCommentaire.Width = 417;
            // 
            // clhButtonReport
            // 
            this.clhButtonReport.Text = "";
            this.clhButtonReport.Width = 151;
            // 
            // btnCommentaire
            // 
            this.btnCommentaire.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCommentaire.Location = new System.Drawing.Point(12, 415);
            this.btnCommentaire.Name = "btnCommentaire";
            this.btnCommentaire.Size = new System.Drawing.Size(776, 23);
            this.btnCommentaire.TabIndex = 3;
            this.btnCommentaire.Text = "Ajouter un commentaire";
            this.btnCommentaire.UseVisualStyleBackColor = true;
            this.btnCommentaire.Click += new System.EventHandler(this.btnCommentaire_Click);
            // 
            // picExempleGraph
            // 
            this.picExempleGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picExempleGraph.Image = global::WFChampChess.Properties.Resources.graph;
            this.picExempleGraph.Location = new System.Drawing.Point(417, 45);
            this.picExempleGraph.Name = "picExempleGraph";
            this.picExempleGraph.Size = new System.Drawing.Size(340, 125);
            this.picExempleGraph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExempleGraph.TabIndex = 0;
            this.picExempleGraph.TabStop = false;
            // 
            // FrmProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCommentaire);
            this.Controls.Add(this.lsvCommentaire);
            this.Controls.Add(this.lsvMatch);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblRank);
            this.Controls.Add(this.picExempleGraph);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FrmProfile";
            this.ShowIcon = false;
            this.Text = "Profile";
            this.Resize += new System.EventHandler(this.FrmProfile_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picExempleGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picExempleGraph;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.ListView lsvMatch;
        private System.Windows.Forms.ColumnHeader clhJoueurBlanc;
        private System.Windows.Forms.ColumnHeader clhJoueurNoir;
        private System.Windows.Forms.ListView lsvCommentaire;
        private System.Windows.Forms.ColumnHeader clhDate;
        private System.Windows.Forms.ColumnHeader clhType;
        private System.Windows.Forms.Button btnCommentaire;
        private System.Windows.Forms.ColumnHeader clhUtilisateur;
        private System.Windows.Forms.ColumnHeader clhNote;
        private System.Windows.Forms.ColumnHeader clhCommentaire;
        private System.Windows.Forms.ColumnHeader clhButtonReport;
    }
}