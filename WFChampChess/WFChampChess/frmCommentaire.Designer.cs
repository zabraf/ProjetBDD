
namespace WFChampChess
{
    partial class FrmCommentaire
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
            this.tbxCommentaire = new System.Windows.Forms.TextBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnCommentaire = new System.Windows.Forms.Button();
            this.lblMotDePasse = new System.Windows.Forms.Label();
            this.lblNomUtilisateur = new System.Windows.Forms.Label();
            this.nudNote = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudNote)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxCommentaire
            // 
            this.tbxCommentaire.Location = new System.Drawing.Point(15, 68);
            this.tbxCommentaire.Multiline = true;
            this.tbxCommentaire.Name = "tbxCommentaire";
            this.tbxCommentaire.Size = new System.Drawing.Size(371, 138);
            this.tbxCommentaire.TabIndex = 3;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(224, 212);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(162, 23);
            this.btnAnnuler.TabIndex = 5;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnCommentaire
            // 
            this.btnCommentaire.Location = new System.Drawing.Point(15, 212);
            this.btnCommentaire.Name = "btnCommentaire";
            this.btnCommentaire.Size = new System.Drawing.Size(162, 23);
            this.btnCommentaire.TabIndex = 4;
            this.btnCommentaire.Text = "Ajouter Commentaire";
            this.btnCommentaire.UseVisualStyleBackColor = true;
            this.btnCommentaire.Click += new System.EventHandler(this.btnCommentaire_Click);
            // 
            // lblMotDePasse
            // 
            this.lblMotDePasse.AutoSize = true;
            this.lblMotDePasse.Location = new System.Drawing.Point(12, 52);
            this.lblMotDePasse.Name = "lblMotDePasse";
            this.lblMotDePasse.Size = new System.Drawing.Size(68, 13);
            this.lblMotDePasse.TabIndex = 2;
            this.lblMotDePasse.Text = "Commentaire";
            // 
            // lblNomUtilisateur
            // 
            this.lblNomUtilisateur.AutoSize = true;
            this.lblNomUtilisateur.Location = new System.Drawing.Point(9, 10);
            this.lblNomUtilisateur.Name = "lblNomUtilisateur";
            this.lblNomUtilisateur.Size = new System.Drawing.Size(30, 13);
            this.lblNomUtilisateur.TabIndex = 0;
            this.lblNomUtilisateur.Text = "Note";
            // 
            // nudNote
            // 
            this.nudNote.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudNote.Location = new System.Drawing.Point(15, 26);
            this.nudNote.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudNote.Name = "nudNote";
            this.nudNote.Size = new System.Drawing.Size(65, 20);
            this.nudNote.TabIndex = 1;
            // 
            // frmCommentaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 245);
            this.Controls.Add(this.nudNote);
            this.Controls.Add(this.tbxCommentaire);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnCommentaire);
            this.Controls.Add(this.lblMotDePasse);
            this.Controls.Add(this.lblNomUtilisateur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCommentaire";
            this.ShowIcon = false;
            this.Text = "frmCommentaire";
            ((System.ComponentModel.ISupportInitialize)(this.nudNote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxCommentaire;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnCommentaire;
        private System.Windows.Forms.Label lblMotDePasse;
        private System.Windows.Forms.Label lblNomUtilisateur;
        private System.Windows.Forms.NumericUpDown nudNote;
    }
}