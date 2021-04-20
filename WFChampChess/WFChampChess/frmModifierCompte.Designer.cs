
namespace WFChampChess
{
    partial class FrmModifierCompte
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
            this.tbxNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.tbxPrenom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbxConfirmationMotDePasse = new System.Windows.Forms.TextBox();
            this.lblConfirmationMotDePasse = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.tbxMotDePasse = new System.Windows.Forms.TextBox();
            this.tbxPseudonyme = new System.Windows.Forms.TextBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnChangerInformations = new System.Windows.Forms.Button();
            this.lblMotDePasse = new System.Windows.Forms.Label();
            this.lblPseudonyme = new System.Windows.Forms.Label();
            this.tbxAncienMotDePasse = new System.Windows.Forms.TextBox();
            this.lblAncienMotDePasse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxNom
            // 
            this.tbxNom.Location = new System.Drawing.Point(15, 259);
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(371, 20);
            this.tbxNom.TabIndex = 13;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(12, 243);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(27, 13);
            this.lblNom.TabIndex = 12;
            this.lblNom.Text = "nom";
            // 
            // tbxPrenom
            // 
            this.tbxPrenom.Location = new System.Drawing.Point(15, 220);
            this.tbxPrenom.Name = "tbxPrenom";
            this.tbxPrenom.Size = new System.Drawing.Size(371, 20);
            this.tbxPrenom.TabIndex = 11;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(12, 204);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(43, 13);
            this.lblPrenom.TabIndex = 10;
            this.lblPrenom.Text = "Prenom";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(15, 180);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(371, 20);
            this.tbxEmail.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 164);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 13);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email*";
            // 
            // tbxConfirmationMotDePasse
            // 
            this.tbxConfirmationMotDePasse.Location = new System.Drawing.Point(15, 141);
            this.tbxConfirmationMotDePasse.Name = "tbxConfirmationMotDePasse";
            this.tbxConfirmationMotDePasse.PasswordChar = '*';
            this.tbxConfirmationMotDePasse.ReadOnly = true;
            this.tbxConfirmationMotDePasse.Size = new System.Drawing.Size(371, 20);
            this.tbxConfirmationMotDePasse.TabIndex = 7;
            // 
            // lblConfirmationMotDePasse
            // 
            this.lblConfirmationMotDePasse.AutoSize = true;
            this.lblConfirmationMotDePasse.Location = new System.Drawing.Point(12, 125);
            this.lblConfirmationMotDePasse.Name = "lblConfirmationMotDePasse";
            this.lblConfirmationMotDePasse.Size = new System.Drawing.Size(128, 13);
            this.lblConfirmationMotDePasse.TabIndex = 6;
            this.lblConfirmationMotDePasse.Text = "Confirmer le mot de passe";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(12, 284);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(29, 13);
            this.lblError.TabIndex = 14;
            this.lblError.Text = "Error";
            // 
            // tbxMotDePasse
            // 
            this.tbxMotDePasse.Location = new System.Drawing.Point(15, 101);
            this.tbxMotDePasse.Name = "tbxMotDePasse";
            this.tbxMotDePasse.PasswordChar = '*';
            this.tbxMotDePasse.ReadOnly = true;
            this.tbxMotDePasse.Size = new System.Drawing.Size(371, 20);
            this.tbxMotDePasse.TabIndex = 5;
            // 
            // tbxPseudonyme
            // 
            this.tbxPseudonyme.Location = new System.Drawing.Point(15, 25);
            this.tbxPseudonyme.Name = "tbxPseudonyme";
            this.tbxPseudonyme.Size = new System.Drawing.Size(371, 20);
            this.tbxPseudonyme.TabIndex = 1;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(224, 300);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(162, 23);
            this.btnAnnuler.TabIndex = 16;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click_1);
            // 
            // btnChangerInformations
            // 
            this.btnChangerInformations.Location = new System.Drawing.Point(12, 300);
            this.btnChangerInformations.Name = "btnChangerInformations";
            this.btnChangerInformations.Size = new System.Drawing.Size(162, 23);
            this.btnChangerInformations.TabIndex = 15;
            this.btnChangerInformations.Text = "Changer les informations";
            this.btnChangerInformations.UseVisualStyleBackColor = true;
            this.btnChangerInformations.Click += new System.EventHandler(this.btnChangerInformations_Click);
            // 
            // lblMotDePasse
            // 
            this.lblMotDePasse.AutoSize = true;
            this.lblMotDePasse.Location = new System.Drawing.Point(12, 85);
            this.lblMotDePasse.Name = "lblMotDePasse";
            this.lblMotDePasse.Size = new System.Drawing.Size(71, 13);
            this.lblMotDePasse.TabIndex = 4;
            this.lblMotDePasse.Text = "Mot de passe";
            // 
            // lblPseudonyme
            // 
            this.lblPseudonyme.AutoSize = true;
            this.lblPseudonyme.Location = new System.Drawing.Point(12, 9);
            this.lblPseudonyme.Name = "lblPseudonyme";
            this.lblPseudonyme.Size = new System.Drawing.Size(72, 13);
            this.lblPseudonyme.TabIndex = 0;
            this.lblPseudonyme.Text = "Pseudonyme*";
            // 
            // tbxAncienMotDePasse
            // 
            this.tbxAncienMotDePasse.Location = new System.Drawing.Point(15, 62);
            this.tbxAncienMotDePasse.Name = "tbxAncienMotDePasse";
            this.tbxAncienMotDePasse.PasswordChar = '*';
            this.tbxAncienMotDePasse.Size = new System.Drawing.Size(371, 20);
            this.tbxAncienMotDePasse.TabIndex = 3;
            this.tbxAncienMotDePasse.TextChanged += new System.EventHandler(this.tbxAncienMotDePasse_TextChanged);
            // 
            // lblAncienMotDePasse
            // 
            this.lblAncienMotDePasse.AutoSize = true;
            this.lblAncienMotDePasse.Location = new System.Drawing.Point(12, 46);
            this.lblAncienMotDePasse.Name = "lblAncienMotDePasse";
            this.lblAncienMotDePasse.Size = new System.Drawing.Size(106, 13);
            this.lblAncienMotDePasse.TabIndex = 2;
            this.lblAncienMotDePasse.Text = "Ancien mot de passe";
            // 
            // FrmModifierCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 337);
            this.Controls.Add(this.tbxAncienMotDePasse);
            this.Controls.Add(this.lblAncienMotDePasse);
            this.Controls.Add(this.tbxNom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.tbxPrenom);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.tbxConfirmationMotDePasse);
            this.Controls.Add(this.lblConfirmationMotDePasse);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.tbxMotDePasse);
            this.Controls.Add(this.tbxPseudonyme);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnChangerInformations);
            this.Controls.Add(this.lblMotDePasse);
            this.Controls.Add(this.lblPseudonyme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmModifierCompte";
            this.ShowIcon = false;
            this.Text = "Modifier mon compte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox tbxPrenom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbxConfirmationMotDePasse;
        private System.Windows.Forms.Label lblConfirmationMotDePasse;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox tbxMotDePasse;
        private System.Windows.Forms.TextBox tbxPseudonyme;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnChangerInformations;
        private System.Windows.Forms.Label lblMotDePasse;
        private System.Windows.Forms.Label lblPseudonyme;
        private System.Windows.Forms.TextBox tbxAncienMotDePasse;
        private System.Windows.Forms.Label lblAncienMotDePasse;
    }
}