namespace Kladionica.Forms
{
    partial class frmListici
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
            this.grdListici = new System.Windows.Forms.DataGridView();
            this.colSifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUkupnaKvota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUlog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDobitak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDobitni = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colOdigraneUtakmice = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdListici)).BeginInit();
            this.SuspendLayout();
            // 
            // grdListici
            // 
            this.grdListici.AllowUserToAddRows = false;
            this.grdListici.AllowUserToDeleteRows = false;
            this.grdListici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSifra,
            this.colUkupnaKvota,
            this.colUlog,
            this.colDobitak,
            this.colDobitni,
            this.colOdigraneUtakmice});
            this.grdListici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdListici.Location = new System.Drawing.Point(0, 0);
            this.grdListici.Name = "grdListici";
            this.grdListici.Size = new System.Drawing.Size(646, 262);
            this.grdListici.TabIndex = 12;
            this.grdListici.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdListici_CellDoubleClick);
            // 
            // colSifra
            // 
            this.colSifra.DataPropertyName = "Sifra";
            this.colSifra.HeaderText = "Šifra";
            this.colSifra.Name = "colSifra";
            this.colSifra.ReadOnly = true;
            // 
            // colUkupnaKvota
            // 
            this.colUkupnaKvota.DataPropertyName = "UkupnaKvotaListica";
            this.colUkupnaKvota.HeaderText = "Kvota";
            this.colUkupnaKvota.Name = "colUkupnaKvota";
            this.colUkupnaKvota.ReadOnly = true;
            // 
            // colUlog
            // 
            this.colUlog.DataPropertyName = "UplaceniIznos";
            this.colUlog.HeaderText = "Ulog";
            this.colUlog.Name = "colUlog";
            this.colUlog.ReadOnly = true;
            // 
            // colDobitak
            // 
            this.colDobitak.DataPropertyName = "UkupniDobitakListica";
            this.colDobitak.HeaderText = "Iznos listića";
            this.colDobitak.Name = "colDobitak";
            this.colDobitak.ReadOnly = true;
            // 
            // colDobitni
            // 
            this.colDobitni.DataPropertyName = "Dobitak";
            this.colDobitni.HeaderText = "Dobitak";
            this.colDobitni.Name = "colDobitni";
            this.colDobitni.ReadOnly = true;
            this.colDobitni.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDobitni.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colOdigraneUtakmice
            // 
            this.colOdigraneUtakmice.DataPropertyName = "ProvjereniRezultati";
            this.colOdigraneUtakmice.HeaderText = "Završeno";
            this.colOdigraneUtakmice.Name = "colOdigraneUtakmice";
            // 
            // frmListici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 262);
            this.Controls.Add(this.grdListici);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmListici";
            this.Text = "Odigrani listići";
            this.Load += new System.EventHandler(this.frmListici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdListici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdListici;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUkupnaKvota;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUlog;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDobitak;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colDobitni;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colOdigraneUtakmice;
    }
}