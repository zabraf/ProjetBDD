
namespace WFChampChess
{
    partial class FrmCreerMatch
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
            this.cboType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblTempsTotal = new System.Windows.Forms.Label();
            this.nudTempsMinutes = new System.Windows.Forms.NumericUpDown();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblSeconde = new System.Windows.Forms.Label();
            this.nudTempsSeconde = new System.Windows.Forms.NumericUpDown();
            this.lblTempsAjouter = new System.Windows.Forms.Label();
            this.nudAjouterSeconde = new System.Windows.Forms.NumericUpDown();
            this.btnCreer = new System.Windows.Forms.Button();
            this.btnAnnuller = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.lblJoueur = new System.Windows.Forms.Label();
            this.cboJoueur = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudTempsMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTempsSeconde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAjouterSeconde)).BeginInit();
            this.SuspendLayout();
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(15, 33);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(267, 21);
            this.cboType.TabIndex = 1;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(12, 17);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Type";
            // 
            // lblTempsTotal
            // 
            this.lblTempsTotal.AutoSize = true;
            this.lblTempsTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempsTotal.Location = new System.Drawing.Point(12, 64);
            this.lblTempsTotal.Name = "lblTempsTotal";
            this.lblTempsTotal.Size = new System.Drawing.Size(62, 13);
            this.lblTempsTotal.TabIndex = 2;
            this.lblTempsTotal.Text = "Temps total";
            // 
            // nudTempsMinutes
            // 
            this.nudTempsMinutes.Location = new System.Drawing.Point(15, 93);
            this.nudTempsMinutes.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudTempsMinutes.Name = "nudTempsMinutes";
            this.nudTempsMinutes.Size = new System.Drawing.Size(112, 20);
            this.nudTempsMinutes.TabIndex = 4;
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Location = new System.Drawing.Point(12, 77);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(44, 13);
            this.lblMinutes.TabIndex = 3;
            this.lblMinutes.Text = "Minutes";
            // 
            // lblSeconde
            // 
            this.lblSeconde.AutoSize = true;
            this.lblSeconde.Location = new System.Drawing.Point(164, 77);
            this.lblSeconde.Name = "lblSeconde";
            this.lblSeconde.Size = new System.Drawing.Size(55, 13);
            this.lblSeconde.TabIndex = 5;
            this.lblSeconde.Text = "Secondes";
            // 
            // nudTempsSeconde
            // 
            this.nudTempsSeconde.Location = new System.Drawing.Point(167, 93);
            this.nudTempsSeconde.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudTempsSeconde.Name = "nudTempsSeconde";
            this.nudTempsSeconde.Size = new System.Drawing.Size(112, 20);
            this.nudTempsSeconde.TabIndex = 6;
            // 
            // lblTempsAjouter
            // 
            this.lblTempsAjouter.AutoSize = true;
            this.lblTempsAjouter.Location = new System.Drawing.Point(12, 127);
            this.lblTempsAjouter.Name = "lblTempsAjouter";
            this.lblTempsAjouter.Size = new System.Drawing.Size(75, 13);
            this.lblTempsAjouter.TabIndex = 7;
            this.lblTempsAjouter.Text = "Temps Ajouter";
            // 
            // nudAjouterSeconde
            // 
            this.nudAjouterSeconde.Location = new System.Drawing.Point(15, 143);
            this.nudAjouterSeconde.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudAjouterSeconde.Name = "nudAjouterSeconde";
            this.nudAjouterSeconde.Size = new System.Drawing.Size(112, 20);
            this.nudAjouterSeconde.TabIndex = 8;
            // 
            // btnCreer
            // 
            this.btnCreer.Location = new System.Drawing.Point(9, 223);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(131, 23);
            this.btnCreer.TabIndex = 12;
            this.btnCreer.Text = "Creer un match";
            this.btnCreer.UseVisualStyleBackColor = true;
            this.btnCreer.Click += new System.EventHandler(this.btnCreer_Click);
            // 
            // btnAnnuller
            // 
            this.btnAnnuller.Location = new System.Drawing.Point(148, 223);
            this.btnAnnuller.Name = "btnAnnuller";
            this.btnAnnuller.Size = new System.Drawing.Size(131, 23);
            this.btnAnnuller.TabIndex = 13;
            this.btnAnnuller.Text = "Annuler";
            this.btnAnnuller.UseVisualStyleBackColor = true;
            this.btnAnnuller.Click += new System.EventHandler(this.btnAnnuller_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(12, 207);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(29, 13);
            this.lblError.TabIndex = 11;
            this.lblError.Text = "Error";
            // 
            // lblJoueur
            // 
            this.lblJoueur.AutoSize = true;
            this.lblJoueur.Location = new System.Drawing.Point(9, 167);
            this.lblJoueur.Name = "lblJoueur";
            this.lblJoueur.Size = new System.Drawing.Size(96, 13);
            this.lblJoueur.TabIndex = 9;
            this.lblJoueur.Text = "Jouer en tant que :";
            // 
            // cboJoueur
            // 
            this.cboJoueur.FormattingEnabled = true;
            this.cboJoueur.Location = new System.Drawing.Point(12, 183);
            this.cboJoueur.Name = "cboJoueur";
            this.cboJoueur.Size = new System.Drawing.Size(267, 21);
            this.cboJoueur.TabIndex = 10;
            // 
            // FrmCreerMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 258);
            this.Controls.Add(this.lblJoueur);
            this.Controls.Add(this.cboJoueur);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnAnnuller);
            this.Controls.Add(this.btnCreer);
            this.Controls.Add(this.nudAjouterSeconde);
            this.Controls.Add(this.lblTempsAjouter);
            this.Controls.Add(this.nudTempsSeconde);
            this.Controls.Add(this.lblSeconde);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.nudTempsMinutes);
            this.Controls.Add(this.lblTempsTotal);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cboType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCreerMatch";
            this.ShowIcon = false;
            this.Text = "Creer un match";
            ((System.ComponentModel.ISupportInitialize)(this.nudTempsMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTempsSeconde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAjouterSeconde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblTempsTotal;
        private System.Windows.Forms.NumericUpDown nudTempsMinutes;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblSeconde;
        private System.Windows.Forms.NumericUpDown nudTempsSeconde;
        private System.Windows.Forms.Label lblTempsAjouter;
        private System.Windows.Forms.NumericUpDown nudAjouterSeconde;
        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.Button btnAnnuller;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblJoueur;
        private System.Windows.Forms.ComboBox cboJoueur;
    }
}