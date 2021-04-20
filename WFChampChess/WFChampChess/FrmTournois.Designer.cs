
namespace WFChampChess
{
    partial class FrmTournois
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
            this.lsvTournois = new System.Windows.Forms.ListView();
            this.clhNom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhMargeMin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhMargeMax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhBtnRejoindre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lsvTournois
            // 
            this.lsvTournois.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvTournois.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhNom,
            this.clhDate,
            this.clhMargeMin,
            this.clhMargeMax,
            this.clhBtnRejoindre});
            this.lsvTournois.HideSelection = false;
            this.lsvTournois.Location = new System.Drawing.Point(12, 12);
            this.lsvTournois.Name = "lsvTournois";
            this.lsvTournois.Size = new System.Drawing.Size(776, 426);
            this.lsvTournois.TabIndex = 0;
            this.lsvTournois.UseCompatibleStateImageBehavior = false;
            this.lsvTournois.View = System.Windows.Forms.View.Details;
            // 
            // clhNom
            // 
            this.clhNom.Text = "nom Tournois";
            this.clhNom.Width = 194;
            // 
            // clhDate
            // 
            this.clhDate.Text = "Date du tournois";
            this.clhDate.Width = 100;
            // 
            // clhMargeMin
            // 
            this.clhMargeMin.Text = "Rang minimume";
            this.clhMargeMin.Width = 100;
            // 
            // clhMargeMax
            // 
            this.clhMargeMax.Text = "Rang maximume";
            this.clhMargeMax.Width = 100;
            // 
            // clhBtnRejoindre
            // 
            this.clhBtnRejoindre.Text = "";
            this.clhBtnRejoindre.Width = 150;
            // 
            // FrmTournois
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lsvTournois);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTournois";
            this.ShowIcon = false;
            this.Text = "Tournois";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTournois_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvTournois;
        private System.Windows.Forms.ColumnHeader clhNom;
        private System.Windows.Forms.ColumnHeader clhDate;
        private System.Windows.Forms.ColumnHeader clhMargeMin;
        private System.Windows.Forms.ColumnHeader clhMargeMax;
        private System.Windows.Forms.ColumnHeader clhBtnRejoindre;
    }
}