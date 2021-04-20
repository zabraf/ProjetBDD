namespace WFChampChess
{
    partial class FrmUtilisateur
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
            this.lsvUtilisateur = new System.Windows.Forms.ListView();
            this.clhPseudonyme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhPrenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhNom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhAdmin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhSupprimer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lsvUtilisateur
            // 
            this.lsvUtilisateur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvUtilisateur.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhPseudonyme,
            this.clhEmail,
            this.clhPrenom,
            this.clhNom,
            this.clhAdmin,
            this.clhSupprimer});
            this.lsvUtilisateur.HideSelection = false;
            this.lsvUtilisateur.Location = new System.Drawing.Point(12, 12);
            this.lsvUtilisateur.Name = "lsvUtilisateur";
            this.lsvUtilisateur.Size = new System.Drawing.Size(519, 237);
            this.lsvUtilisateur.TabIndex = 0;
            this.lsvUtilisateur.UseCompatibleStateImageBehavior = false;
            this.lsvUtilisateur.View = System.Windows.Forms.View.Details;
            // 
            // clhPseudonyme
            // 
            this.clhPseudonyme.Text = "Pseudonyme";
            this.clhPseudonyme.Width = 90;
            // 
            // clhEmail
            // 
            this.clhEmail.Text = "Email";
            this.clhEmail.Width = 78;
            // 
            // clhPrenom
            // 
            this.clhPrenom.Text = "Prenom";
            // 
            // clhNom
            // 
            this.clhNom.Text = "Nom";
            // 
            // clhAdmin
            // 
            this.clhAdmin.Text = "Admin";
            this.clhAdmin.Width = 113;
            // 
            // clhSupprimer
            // 
            this.clhSupprimer.Text = "Supprimer";
            this.clhSupprimer.Width = 170;
            // 
            // FrmUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 261);
            this.Controls.Add(this.lsvUtilisateur);
            this.MinimumSize = new System.Drawing.Size(559, 300);
            this.Name = "FrmUtilisateur";
            this.ShowIcon = false;
            this.Text = "Gerer Utilisateur";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmUtilisateur_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvUtilisateur;
        private System.Windows.Forms.ColumnHeader clhPseudonyme;
        private System.Windows.Forms.ColumnHeader clhEmail;
        private System.Windows.Forms.ColumnHeader clhPrenom;
        private System.Windows.Forms.ColumnHeader clhNom;
        private System.Windows.Forms.ColumnHeader clhAdmin;
        private System.Windows.Forms.ColumnHeader clhSupprimer;
    }
}