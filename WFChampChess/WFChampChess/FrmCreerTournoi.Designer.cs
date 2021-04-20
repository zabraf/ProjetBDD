
namespace WFChampChess
{
    partial class FrmCreerTournoi
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
            this.lblNom = new System.Windows.Forms.Label();
            this.tbxNom = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.nudRang = new System.Windows.Forms.NumericUpDown();
            this.lblRang = new System.Windows.Forms.Label();
            this.nudMarge = new System.Windows.Forms.NumericUpDown();
            this.lblMarge = new System.Windows.Forms.Label();
            this.btnAnnuller = new System.Windows.Forms.Button();
            this.btnCreer = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.lblHeure = new System.Windows.Forms.Label();
            this.dtpHeure = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.nudRang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMarge)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(12, 9);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(84, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom du tournois";
            // 
            // tbxNom
            // 
            this.tbxNom.Location = new System.Drawing.Point(15, 25);
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(372, 20);
            this.tbxNom.TabIndex = 1;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(15, 71);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(186, 20);
            this.dtpDate.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(12, 55);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            // 
            // nudRang
            // 
            this.nudRang.Location = new System.Drawing.Point(15, 123);
            this.nudRang.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudRang.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRang.Name = "nudRang";
            this.nudRang.Size = new System.Drawing.Size(186, 20);
            this.nudRang.TabIndex = 7;
            this.nudRang.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            // 
            // lblRang
            // 
            this.lblRang.AutoSize = true;
            this.lblRang.Location = new System.Drawing.Point(12, 107);
            this.lblRang.Name = "lblRang";
            this.lblRang.Size = new System.Drawing.Size(33, 13);
            this.lblRang.TabIndex = 6;
            this.lblRang.Text = "Rang";
            // 
            // nudMarge
            // 
            this.nudMarge.Location = new System.Drawing.Point(210, 123);
            this.nudMarge.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudMarge.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMarge.Name = "nudMarge";
            this.nudMarge.Size = new System.Drawing.Size(177, 20);
            this.nudMarge.TabIndex = 9;
            this.nudMarge.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblMarge
            // 
            this.lblMarge.AutoSize = true;
            this.lblMarge.Location = new System.Drawing.Point(207, 107);
            this.lblMarge.Name = "lblMarge";
            this.lblMarge.Size = new System.Drawing.Size(37, 13);
            this.lblMarge.TabIndex = 8;
            this.lblMarge.Text = "Marge";
            // 
            // btnAnnuller
            // 
            this.btnAnnuller.Location = new System.Drawing.Point(210, 162);
            this.btnAnnuller.Name = "btnAnnuller";
            this.btnAnnuller.Size = new System.Drawing.Size(177, 23);
            this.btnAnnuller.TabIndex = 12;
            this.btnAnnuller.Text = "Annuler";
            this.btnAnnuller.UseVisualStyleBackColor = true;
            this.btnAnnuller.Click += new System.EventHandler(this.btnAnnuller_Click);
            // 
            // btnCreer
            // 
            this.btnCreer.Location = new System.Drawing.Point(15, 162);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(186, 23);
            this.btnCreer.TabIndex = 11;
            this.btnCreer.Text = "Creer un tournois";
            this.btnCreer.UseVisualStyleBackColor = true;
            this.btnCreer.Click += new System.EventHandler(this.btnCreer_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(12, 146);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(29, 13);
            this.lblError.TabIndex = 10;
            this.lblError.Text = "Error";
            // 
            // lblHeure
            // 
            this.lblHeure.AutoSize = true;
            this.lblHeure.Location = new System.Drawing.Point(208, 55);
            this.lblHeure.Name = "lblHeure";
            this.lblHeure.Size = new System.Drawing.Size(36, 13);
            this.lblHeure.TabIndex = 4;
            this.lblHeure.Text = "Heure";
            // 
            // dtpHeure
            // 
            this.dtpHeure.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHeure.Location = new System.Drawing.Point(210, 71);
            this.dtpHeure.Name = "dtpHeure";
            this.dtpHeure.Size = new System.Drawing.Size(177, 20);
            this.dtpHeure.TabIndex = 5;
            // 
            // FrmCreerTournoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 197);
            this.Controls.Add(this.dtpHeure);
            this.Controls.Add(this.lblHeure);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnAnnuller);
            this.Controls.Add(this.btnCreer);
            this.Controls.Add(this.lblMarge);
            this.Controls.Add(this.nudMarge);
            this.Controls.Add(this.lblRang);
            this.Controls.Add(this.nudRang);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.tbxNom);
            this.Controls.Add(this.lblNom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCreerTournoi";
            this.ShowIcon = false;
            this.Text = "Creer un tournois";
            ((System.ComponentModel.ISupportInitialize)(this.nudRang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMarge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox tbxNom;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.NumericUpDown nudRang;
        private System.Windows.Forms.Label lblRang;
        private System.Windows.Forms.NumericUpDown nudMarge;
        private System.Windows.Forms.Label lblMarge;
        private System.Windows.Forms.Button btnAnnuller;
        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblHeure;
        private System.Windows.Forms.DateTimePicker dtpHeure;
    }
}