namespace Kladionica.Forms
{
    partial class frmPodaciIzabranogListica
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
            this.grdParovi = new System.Windows.Forms.DataGridView();
            this.textBoxUlog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUkupnaKvota = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUkupniDobitak = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Sport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kvota1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KvotaX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kvota2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Izbor1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IzborX = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Izbor2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colRezultat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdParovi)).BeginInit();
            this.SuspendLayout();
            // 
            // grdParovi
            // 
            this.grdParovi.AllowUserToAddRows = false;
            this.grdParovi.AllowUserToDeleteRows = false;
            this.grdParovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdParovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sport,
            this.Column1,
            this.Gost,
            this.Kvota1,
            this.KvotaX,
            this.Kvota2,
            this.Izbor1,
            this.IzborX,
            this.Izbor2,
            this.colRezultat});
            this.grdParovi.Location = new System.Drawing.Point(2, 2);
            this.grdParovi.MultiSelect = false;
            this.grdParovi.Name = "grdParovi";
            this.grdParovi.Size = new System.Drawing.Size(771, 291);
            this.grdParovi.TabIndex = 1;
            // 
            // textBoxUlog
            // 
            this.textBoxUlog.Enabled = false;
            this.textBoxUlog.Location = new System.Drawing.Point(40, 299);
            this.textBoxUlog.Name = "textBoxUlog";
            this.textBoxUlog.Size = new System.Drawing.Size(100, 20);
            this.textBoxUlog.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ulog:";
            // 
            // textBoxUkupnaKvota
            // 
            this.textBoxUkupnaKvota.Enabled = false;
            this.textBoxUkupnaKvota.Location = new System.Drawing.Point(275, 299);
            this.textBoxUkupnaKvota.Name = "textBoxUkupnaKvota";
            this.textBoxUkupnaKvota.Size = new System.Drawing.Size(100, 20);
            this.textBoxUkupnaKvota.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ukupna kvota:";
            // 
            // textBoxUkupniDobitak
            // 
            this.textBoxUkupniDobitak.Enabled = false;
            this.textBoxUkupniDobitak.Location = new System.Drawing.Point(512, 299);
            this.textBoxUkupniDobitak.Name = "textBoxUkupniDobitak";
            this.textBoxUkupniDobitak.Size = new System.Drawing.Size(100, 20);
            this.textBoxUkupniDobitak.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ukupni dobitak:";
            // 
            // Sport
            // 
            this.Sport.DataPropertyName = "VrstaSportaText";
            this.Sport.HeaderText = "Sport";
            this.Sport.Name = "Sport";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Domacin";
            this.Column1.HeaderText = "Domaći";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Gost
            // 
            this.Gost.DataPropertyName = "Gost";
            this.Gost.HeaderText = "Gost";
            this.Gost.Name = "Gost";
            this.Gost.ReadOnly = true;
            // 
            // Kvota1
            // 
            this.Kvota1.DataPropertyName = "KvotaPobjedaDomacina";
            this.Kvota1.HeaderText = "Kvota 1";
            this.Kvota1.Name = "Kvota1";
            this.Kvota1.ReadOnly = true;
            this.Kvota1.Width = 70;
            // 
            // KvotaX
            // 
            this.KvotaX.DataPropertyName = "KvotaNerijeseno";
            this.KvotaX.HeaderText = "Kvota X";
            this.KvotaX.Name = "KvotaX";
            this.KvotaX.ReadOnly = true;
            this.KvotaX.Width = 70;
            // 
            // Kvota2
            // 
            this.Kvota2.DataPropertyName = "KvotaPobjedaGosta";
            this.Kvota2.HeaderText = "Kvota 2";
            this.Kvota2.Name = "Kvota2";
            this.Kvota2.ReadOnly = true;
            this.Kvota2.Width = 70;
            // 
            // Izbor1
            // 
            this.Izbor1.DataPropertyName = "IzborPobjedaDomacina";
            this.Izbor1.HeaderText = "1";
            this.Izbor1.Name = "Izbor1";
            this.Izbor1.ReadOnly = true;
            this.Izbor1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Izbor1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Izbor1.Width = 50;
            // 
            // IzborX
            // 
            this.IzborX.DataPropertyName = "IzborNerijeseno";
            this.IzborX.HeaderText = "X";
            this.IzborX.Name = "IzborX";
            this.IzborX.ReadOnly = true;
            this.IzborX.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IzborX.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IzborX.Width = 50;
            // 
            // Izbor2
            // 
            this.Izbor2.DataPropertyName = "IzborPobjedaGosta";
            this.Izbor2.HeaderText = "2";
            this.Izbor2.Name = "Izbor2";
            this.Izbor2.ReadOnly = true;
            this.Izbor2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Izbor2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Izbor2.Width = 50;
            // 
            // colRezultat
            // 
            this.colRezultat.DataPropertyName = "GoloviText";
            this.colRezultat.HeaderText = "Rezultat";
            this.colRezultat.Name = "colRezultat";
            // 
            // frmPodaciIzabranogListica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 324);
            this.Controls.Add(this.textBoxUkupniDobitak);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxUkupnaKvota);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxUlog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdParovi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPodaciIzabranogListica";
            this.Text = "Podaci izabranog listića";
            this.Load += new System.EventHandler(this.frmPodaciIzabranogListica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdParovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdParovi;
        private System.Windows.Forms.TextBox textBoxUlog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUkupnaKvota;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUkupniDobitak;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kvota1;
        private System.Windows.Forms.DataGridViewTextBoxColumn KvotaX;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kvota2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Izbor1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IzborX;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Izbor2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRezultat;
    }
}