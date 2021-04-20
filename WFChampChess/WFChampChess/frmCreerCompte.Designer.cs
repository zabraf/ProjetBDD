
namespace WFChampChess
{
    partial class FrmCreerCompte
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
            this.lblError = new System.Windows.Forms.Label();
            this.tbxMotDePasse = new System.Windows.Forms.TextBox();
            this.tbxPseudonyme = new System.Windows.Forms.TextBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnCreerCompte = new System.Windows.Forms.Button();
            this.lblMotDePasse = new System.Windows.Forms.Label();
            this.lblPseudonyme = new System.Windows.Forms.Label();
            this.tbxConfirmationMotDePasse = new System.Windows.Forms.TextBox();
            this.lblConfirmationMotDePasse = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbxPrenom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.tbxNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(12, 254);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(29, 13);
            this.lblError.TabIndex = 12;
            this.lblError.Text = "Error";
            // 
            // tbxMotDePasse
            // 
            this.tbxMotDePasse.Location = new System.Drawing.Point(15, 71);
            this.tbxMotDePasse.Name = "tbxMotDePasse";
            this.tbxMotDePasse.PasswordChar = '*';
            this.tbxMotDePasse.Size = new System.Drawing.Size(371, 20);
            this.tbxMotDePasse.TabIndex = 3;
            // 
            // tbxPseudonyme
            // 
            this.tbxPseudonyme.Location = new System.Drawing.Point(15, 29);
            this.tbxPseudonyme.Name = "tbxPseudonyme";
            this.tbxPseudonyme.Size = new System.Drawing.Size(371, 20);
            this.tbxPseudonyme.TabIndex = 1;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(224, 270);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(162, 23);
            this.btnAnnuler.TabIndex = 14;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnCreerCompte
            // 
            this.btnCreerCompte.Location = new System.Drawing.Point(12, 270);
            this.btnCreerCompte.Name = "btnCreerCompte";
            this.btnCreerCompte.Size = new System.Drawing.Size(162, 23);
            this.btnCreerCompte.TabIndex = 13;
            this.btnCreerCompte.Text = "Creer un compte";
            this.btnCreerCompte.UseVisualStyleBackColor = true;
            this.btnCreerCompte.Click += new System.EventHandler(this.btnCreerCompte_Click);
            // 
            // lblMotDePasse
            // 
            this.lblMotDePasse.AutoSize = true;
            this.lblMotDePasse.Location = new System.Drawing.Point(12, 55);
            this.lblMotDePasse.Name = "lblMotDePasse";
            this.lblMotDePasse.Size = new System.Drawing.Size(128, 13);
            this.lblMotDePasse.TabIndex = 2;
            this.lblMotDePasse.Text = "Mot de passe (obligatoire)";
            // 
            // lblPseudonyme
            // 
            this.lblPseudonyme.AutoSize = true;
            this.lblPseudonyme.Location = new System.Drawing.Point(12, 13);
            this.lblPseudonyme.Name = "lblPseudonyme";
            this.lblPseudonyme.Size = new System.Drawing.Size(125, 13);
            this.lblPseudonyme.TabIndex = 0;
            this.lblPseudonyme.Text = "Pseudonyme (obligatoire)";
            // 
            // tbxConfirmationMotDePasse
            // 
            this.tbxConfirmationMotDePasse.Location = new System.Drawing.Point(15, 111);
            this.tbxConfirmationMotDePasse.Name = "tbxConfirmationMotDePasse";
            this.tbxConfirmationMotDePasse.PasswordChar = '*';
            this.tbxConfirmationMotDePasse.Size = new System.Drawing.Size(371, 20);
            this.tbxConfirmationMotDePasse.TabIndex = 5;
            // 
            // lblConfirmationMotDePasse
            // 
            this.lblConfirmationMotDePasse.AutoSize = true;
            this.lblConfirmationMotDePasse.Location = new System.Drawing.Point(12, 95);
            this.lblConfirmationMotDePasse.Name = "lblConfirmationMotDePasse";
            this.lblConfirmationMotDePasse.Size = new System.Drawing.Size(188, 13);
            this.lblConfirmationMotDePasse.TabIndex = 4;
            this.lblConfirmationMotDePasse.Text = "Confirmer le mot de passe  (obligatoire)";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(15, 150);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(371, 20);
            this.tbxEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 134);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(92, 13);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email  (obligatoire)";
            // 
            // tbxPrenom
            // 
            this.tbxPrenom.Location = new System.Drawing.Point(15, 190);
            this.tbxPrenom.Name = "tbxPrenom";
            this.tbxPrenom.Size = new System.Drawing.Size(371, 20);
            this.tbxPrenom.TabIndex = 9;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(12, 174);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(43, 13);
            this.lblPrenom.TabIndex = 8;
            this.lblPrenom.Text = "Prenom";
            // 
            // tbxNom
            // 
            this.tbxNom.Location = new System.Drawing.Point(15, 229);
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(371, 20);
            this.tbxNom.TabIndex = 11;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(12, 213);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(27, 13);
            this.lblNom.TabIndex = 10;
            this.lblNom.Text = "nom";
            // 
            // frmCreerCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 306);
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
            this.Controls.Add(this.btnCreerCompte);
            this.Controls.Add(this.lblMotDePasse);
            this.Controls.Add(this.lblPseudonyme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCreerCompte";
            this.ShowIcon = false;
            this.Text = "Creer un compte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox tbxMotDePasse;
        private System.Windows.Forms.TextBox tbxPseudonyme;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnCreerCompte;
        private System.Windows.Forms.Label lblMotDePasse;
        private System.Windows.Forms.Label lblPseudonyme;
        private System.Windows.Forms.TextBox tbxConfirmationMotDePasse;
        private System.Windows.Forms.Label lblConfirmationMotDePasse;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbxPrenom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox tbxNom;
        private System.Windows.Forms.Label lblNom;
    }
}