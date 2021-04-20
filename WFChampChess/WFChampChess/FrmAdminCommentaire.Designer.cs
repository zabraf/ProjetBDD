namespace WFChampChess
{
    partial class FrmAdminCommentaire
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.clhAuteur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhUtilisateur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhNote = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhNombreReport = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhAccepter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhRefuser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhAuteur,
            this.clhUtilisateur,
            this.clhNote,
            this.clhMessage,
            this.clhNombreReport,
            this.clhAccepter,
            this.clhRefuser});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(519, 237);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // clhAuteur
            // 
            this.clhAuteur.Text = "l\'auteur";
            this.clhAuteur.Width = 75;
            // 
            // clhUtilisateur
            // 
            this.clhUtilisateur.Text = "Utilsateur";
            this.clhUtilisateur.Width = 81;
            // 
            // clhNote
            // 
            this.clhNote.Text = "Note";
            this.clhNote.Width = 48;
            // 
            // clhMessage
            // 
            this.clhMessage.Text = "Message";
            this.clhMessage.Width = 131;
            // 
            // clhNombreReport
            // 
            this.clhNombreReport.Text = "Nombre de Report";
            this.clhNombreReport.Width = 56;
            // 
            // clhAccepter
            // 
            this.clhAccepter.Text = "";
            // 
            // clhRefuser
            // 
            this.clhRefuser.Text = "";
            // 
            // FrmAdminCommentaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 261);
            this.Controls.Add(this.listView1);
            this.MinimumSize = new System.Drawing.Size(559, 300);
            this.Name = "FrmAdminCommentaire";
            this.ShowIcon = false;
            this.Text = "Gerer commentaire";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAdminCommentaire_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader clhAuteur;
        private System.Windows.Forms.ColumnHeader clhUtilisateur;
        private System.Windows.Forms.ColumnHeader clhNote;
        private System.Windows.Forms.ColumnHeader clhMessage;
        private System.Windows.Forms.ColumnHeader clhNombreReport;
        private System.Windows.Forms.ColumnHeader clhAccepter;
        private System.Windows.Forms.ColumnHeader clhRefuser;
    }
}