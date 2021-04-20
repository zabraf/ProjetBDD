
namespace WFChampChess
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.mnsMenu = new System.Windows.Forms.MenuStrip();
            this.tsmMatch = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCreerMatch = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRejoindre = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRegarder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTournois = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCreerTournois = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRejoindreTournois = new System.Windows.Forms.ToolStripMenuItem();
            this.msi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmModifierProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbChercher = new System.Windows.Forms.ToolStripTextBox();
            this.tsmChercher = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAdministrateur = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUtilisateur = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCommentaire = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsMenu
            // 
            this.mnsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMatch,
            this.tsmTournois,
            this.msi,
            this.tsmAdministrateur});
            this.mnsMenu.Location = new System.Drawing.Point(0, 0);
            this.mnsMenu.Name = "mnsMenu";
            this.mnsMenu.Size = new System.Drawing.Size(1052, 24);
            this.mnsMenu.TabIndex = 0;
            this.mnsMenu.Text = "menuStrip1";
            // 
            // tsmMatch
            // 
            this.tsmMatch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCreerMatch,
            this.tsmRejoindre,
            this.tsmRegarder});
            this.tsmMatch.Name = "tsmMatch";
            this.tsmMatch.Size = new System.Drawing.Size(53, 20);
            this.tsmMatch.Text = "&Match";
            // 
            // tsmCreerMatch
            // 
            this.tsmCreerMatch.Name = "tsmCreerMatch";
            this.tsmCreerMatch.Size = new System.Drawing.Size(180, 22);
            this.tsmCreerMatch.Text = "&Creer un match";
            this.tsmCreerMatch.Click += new System.EventHandler(this.msiCreerMatch_Click);
            // 
            // tsmRejoindre
            // 
            this.tsmRejoindre.Name = "tsmRejoindre";
            this.tsmRejoindre.Size = new System.Drawing.Size(180, 22);
            this.tsmRejoindre.Text = "Re&joindre un match";
            this.tsmRejoindre.Click += new System.EventHandler(this.msiRejoindre_Click);
            // 
            // tsmRegarder
            // 
            this.tsmRegarder.Name = "tsmRegarder";
            this.tsmRegarder.Size = new System.Drawing.Size(180, 22);
            this.tsmRegarder.Text = "Re&garder un match";
            this.tsmRegarder.Click += new System.EventHandler(this.regarderUnMatchToolStripMenuItem_Click);
            // 
            // tsmTournois
            // 
            this.tsmTournois.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCreerTournois,
            this.tsmRejoindreTournois});
            this.tsmTournois.Name = "tsmTournois";
            this.tsmTournois.Size = new System.Drawing.Size(64, 20);
            this.tsmTournois.Text = "&Tournois";
            // 
            // tsmCreerTournois
            // 
            this.tsmCreerTournois.Name = "tsmCreerTournois";
            this.tsmCreerTournois.Size = new System.Drawing.Size(180, 22);
            this.tsmCreerTournois.Text = "&Creer Tournois";
            this.tsmCreerTournois.Click += new System.EventHandler(this.tsmCreerTournois_Click);
            // 
            // tsmRejoindreTournois
            // 
            this.tsmRejoindreTournois.Name = "tsmRejoindreTournois";
            this.tsmRejoindreTournois.Size = new System.Drawing.Size(180, 22);
            this.tsmRejoindreTournois.Text = "&Voir tournois";
            this.tsmRejoindreTournois.Click += new System.EventHandler(this.tsmRejoindreTournois_Click);
            // 
            // msi
            // 
            this.msi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmProfile,
            this.tsmModifierProfile,
            this.toolStripSeparator1,
            this.tsbChercher,
            this.tsmChercher});
            this.msi.Name = "msi";
            this.msi.Size = new System.Drawing.Size(90, 20);
            this.msi.Text = "Mon &Compte";
            // 
            // tsmProfile
            // 
            this.tsmProfile.Name = "tsmProfile";
            this.tsmProfile.Size = new System.Drawing.Size(184, 22);
            this.tsmProfile.Text = "&Profile";
            this.tsmProfile.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // tsmModifierProfile
            // 
            this.tsmModifierProfile.Name = "tsmModifierProfile";
            this.tsmModifierProfile.Size = new System.Drawing.Size(184, 22);
            this.tsmModifierProfile.Text = "Mo&difier Mon Profile";
            this.tsmModifierProfile.Click += new System.EventHandler(this.tsmModifierProfile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // tsbChercher
            // 
            this.tsbChercher.Name = "tsbChercher";
            this.tsbChercher.Size = new System.Drawing.Size(100, 23);
            // 
            // tsmChercher
            // 
            this.tsmChercher.Name = "tsmChercher";
            this.tsmChercher.Size = new System.Drawing.Size(184, 22);
            this.tsmChercher.Text = "&Rechercher";
            this.tsmChercher.Click += new System.EventHandler(this.msiChercher_Click);
            // 
            // tsmAdministrateur
            // 
            this.tsmAdministrateur.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmUtilisateur,
            this.tsmCommentaire});
            this.tsmAdministrateur.Name = "tsmAdministrateur";
            this.tsmAdministrateur.Size = new System.Drawing.Size(98, 20);
            this.tsmAdministrateur.Text = "&Administration";
            // 
            // tsmUtilisateur
            // 
            this.tsmUtilisateur.Name = "tsmUtilisateur";
            this.tsmUtilisateur.Size = new System.Drawing.Size(192, 22);
            this.tsmUtilisateur.Text = "Afficher &Utilisateur";
            this.tsmUtilisateur.Click += new System.EventHandler(this.afficherUtilisateurToolStripMenuItem_Click);
            // 
            // tsmCommentaire
            // 
            this.tsmCommentaire.Name = "tsmCommentaire";
            this.tsmCommentaire.Size = new System.Drawing.Size(192, 22);
            this.tsmCommentaire.Text = "Afficher &Commentaire";
            this.tsmCommentaire.Click += new System.EventHandler(this.afficherCommentaireToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 550);
            this.Controls.Add(this.mnsMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnsMenu;
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.Text = "Champ Chess";
            this.mnsMenu.ResumeLayout(false);
            this.mnsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmMatch;
        private System.Windows.Forms.ToolStripMenuItem tsmTournois;
        private System.Windows.Forms.ToolStripMenuItem msi;
        private System.Windows.Forms.ToolStripMenuItem tsmProfile;
        private System.Windows.Forms.ToolStripMenuItem tsmCreerMatch;
        private System.Windows.Forms.ToolStripMenuItem tsmRejoindre;
        private System.Windows.Forms.ToolStripMenuItem tsmRegarder;
        private System.Windows.Forms.ToolStripMenuItem tsmAdministrateur;
        private System.Windows.Forms.ToolStripTextBox tsbChercher;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmChercher;
        private System.Windows.Forms.ToolStripMenuItem tsmRejoindreTournois;
        private System.Windows.Forms.ToolStripMenuItem tsmCreerTournois;
        private System.Windows.Forms.ToolStripMenuItem tsmModifierProfile;
        private System.Windows.Forms.ToolStripMenuItem tsmUtilisateur;
        private System.Windows.Forms.ToolStripMenuItem tsmCommentaire;
    }
}