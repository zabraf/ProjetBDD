
namespace WFChampChess
{
    partial class FrmMatch
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
            this.components = new System.ComponentModel.Container();
            this.lblTempsAdversaire = new System.Windows.Forms.Label();
            this.lblTempsJoueur = new System.Windows.Forms.Label();
            this.tbxJoue = new System.Windows.Forms.TextBox();
            this.BtnJoue = new System.Windows.Forms.Button();
            this.lsvMouvement = new System.Windows.Forms.ListView();
            this.clhTour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhCoupBlanc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhCoupNoir = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.picEchequier = new System.Windows.Forms.PictureBox();
            this.tmrTemps = new System.Windows.Forms.Timer(this.components);
            this.btnNul = new System.Windows.Forms.Button();
            this.btnAbandonner = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picEchequier)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTempsAdversaire
            // 
            this.lblTempsAdversaire.AutoSize = true;
            this.lblTempsAdversaire.Location = new System.Drawing.Point(12, 9);
            this.lblTempsAdversaire.Name = "lblTempsAdversaire";
            this.lblTempsAdversaire.Size = new System.Drawing.Size(34, 13);
            this.lblTempsAdversaire.TabIndex = 0;
            this.lblTempsAdversaire.Text = "00:00";
            // 
            // lblTempsJoueur
            // 
            this.lblTempsJoueur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTempsJoueur.AutoSize = true;
            this.lblTempsJoueur.Location = new System.Drawing.Point(12, 310);
            this.lblTempsJoueur.Name = "lblTempsJoueur";
            this.lblTempsJoueur.Size = new System.Drawing.Size(34, 13);
            this.lblTempsJoueur.TabIndex = 1;
            this.lblTempsJoueur.Text = "00:00";
            // 
            // tbxJoue
            // 
            this.tbxJoue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxJoue.Location = new System.Drawing.Point(12, 333);
            this.tbxJoue.Name = "tbxJoue";
            this.tbxJoue.Size = new System.Drawing.Size(309, 20);
            this.tbxJoue.TabIndex = 2;
            // 
            // BtnJoue
            // 
            this.BtnJoue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnJoue.Location = new System.Drawing.Point(15, 359);
            this.BtnJoue.Name = "BtnJoue";
            this.BtnJoue.Size = new System.Drawing.Size(306, 23);
            this.BtnJoue.TabIndex = 3;
            this.BtnJoue.Text = "&Jouer";
            this.BtnJoue.UseVisualStyleBackColor = true;
            this.BtnJoue.Click += new System.EventHandler(this.BtnJoue_Click);
            // 
            // lsvMouvement
            // 
            this.lsvMouvement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvMouvement.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhTour,
            this.clhCoupBlanc,
            this.clhCoupNoir});
            this.lsvMouvement.HideSelection = false;
            this.lsvMouvement.Location = new System.Drawing.Point(339, 9);
            this.lsvMouvement.Name = "lsvMouvement";
            this.lsvMouvement.Size = new System.Drawing.Size(285, 431);
            this.lsvMouvement.TabIndex = 6;
            this.lsvMouvement.UseCompatibleStateImageBehavior = false;
            this.lsvMouvement.View = System.Windows.Forms.View.Details;
            // 
            // clhTour
            // 
            this.clhTour.Text = "N°";
            // 
            // clhCoupBlanc
            // 
            this.clhCoupBlanc.Text = "Coup blanc";
            this.clhCoupBlanc.Width = 93;
            // 
            // clhCoupNoir
            // 
            this.clhCoupNoir.Text = "Coup Noir";
            this.clhCoupNoir.Width = 90;
            // 
            // picEchequier
            // 
            this.picEchequier.Location = new System.Drawing.Point(12, 25);
            this.picEchequier.MinimumSize = new System.Drawing.Size(309, 282);
            this.picEchequier.Name = "picEchequier";
            this.picEchequier.Size = new System.Drawing.Size(309, 282);
            this.picEchequier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEchequier.TabIndex = 2;
            this.picEchequier.TabStop = false;
            this.picEchequier.Resize += new System.EventHandler(this.FrmMatch_Resize);
            // 
            // tmrTemps
            // 
            this.tmrTemps.Interval = 1000;
            this.tmrTemps.Tick += new System.EventHandler(this.tmrTemps_Tick);
            // 
            // btnNul
            // 
            this.btnNul.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNul.Location = new System.Drawing.Point(15, 388);
            this.btnNul.Name = "btnNul";
            this.btnNul.Size = new System.Drawing.Size(306, 23);
            this.btnNul.TabIndex = 4;
            this.btnNul.Text = "Propser &nul";
            this.btnNul.UseVisualStyleBackColor = true;
            // 
            // btnAbandonner
            // 
            this.btnAbandonner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAbandonner.Location = new System.Drawing.Point(15, 417);
            this.btnAbandonner.Name = "btnAbandonner";
            this.btnAbandonner.Size = new System.Drawing.Size(306, 23);
            this.btnAbandonner.TabIndex = 5;
            this.btnAbandonner.Text = "&Abandonner";
            this.btnAbandonner.UseVisualStyleBackColor = true;
            // 
            // FrmMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 450);
            this.Controls.Add(this.btnAbandonner);
            this.Controls.Add(this.btnNul);
            this.Controls.Add(this.lsvMouvement);
            this.Controls.Add(this.BtnJoue);
            this.Controls.Add(this.tbxJoue);
            this.Controls.Add(this.picEchequier);
            this.Controls.Add(this.lblTempsJoueur);
            this.Controls.Add(this.lblTempsAdversaire);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(652, 489);
            this.Name = "FrmMatch";
            this.ShowIcon = false;
            this.Text = "Match N°";
            this.Resize += new System.EventHandler(this.FrmMatch_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picEchequier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTempsAdversaire;
        private System.Windows.Forms.Label lblTempsJoueur;
        private System.Windows.Forms.PictureBox picEchequier;
        private System.Windows.Forms.TextBox tbxJoue;
        private System.Windows.Forms.Button BtnJoue;
        private System.Windows.Forms.ListView lsvMouvement;
        private System.Windows.Forms.ColumnHeader clhTour;
        private System.Windows.Forms.ColumnHeader clhCoupBlanc;
        private System.Windows.Forms.ColumnHeader clhCoupNoir;
        private System.Windows.Forms.Timer tmrTemps;
        private System.Windows.Forms.Button btnNul;
        private System.Windows.Forms.Button btnAbandonner;
    }
}