
namespace WFChampChess
{
    partial class FrmRejoindreMatch
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
            this.tbxId = new System.Windows.Forms.TextBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnRejoindre = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxId
            // 
            this.tbxId.Location = new System.Drawing.Point(12, 27);
            this.tbxId.Name = "tbxId";
            this.tbxId.Size = new System.Drawing.Size(371, 20);
            this.tbxId.TabIndex = 1;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(221, 66);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(162, 23);
            this.btnAnnuler.TabIndex = 4;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnRejoindre
            // 
            this.btnRejoindre.Location = new System.Drawing.Point(12, 66);
            this.btnRejoindre.Name = "btnRejoindre";
            this.btnRejoindre.Size = new System.Drawing.Size(162, 23);
            this.btnRejoindre.TabIndex = 3;
            this.btnRejoindre.Text = "Rejoindre";
            this.btnRejoindre.UseVisualStyleBackColor = true;
            this.btnRejoindre.Click += new System.EventHandler(this.btnRejoindre_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(9, 11);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(71, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id de la partie";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(12, 50);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(29, 13);
            this.lblError.TabIndex = 2;
            this.lblError.Text = "Error";
            // 
            // FrmRejoindreMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 98);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.tbxId);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnRejoindre);
            this.Controls.Add(this.lblId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRejoindreMatch";
            this.ShowIcon = false;
            this.Text = "Rejoindre un match";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnRejoindre;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblError;
    }
}