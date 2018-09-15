namespace Kladionica.Forms
{
    partial class frmRezultatiListica
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
            this.treeListRezultati = new System.Windows.Forms.TreeView();
            this.textBoxUkupniDobitak = new System.Windows.Forms.TextBox();
            this.lblUkupniDobitak = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeListRezultati
            // 
            this.treeListRezultati.Dock = System.Windows.Forms.DockStyle.Top;
            this.treeListRezultati.Location = new System.Drawing.Point(0, 0);
            this.treeListRezultati.Name = "treeListRezultati";
            this.treeListRezultati.Size = new System.Drawing.Size(630, 397);
            this.treeListRezultati.TabIndex = 0;
            // 
            // textBoxUkupniDobitak
            // 
            this.textBoxUkupniDobitak.Enabled = false;
            this.textBoxUkupniDobitak.Location = new System.Drawing.Point(91, 402);
            this.textBoxUkupniDobitak.Name = "textBoxUkupniDobitak";
            this.textBoxUkupniDobitak.Size = new System.Drawing.Size(100, 20);
            this.textBoxUkupniDobitak.TabIndex = 10;
            // 
            // lblUkupniDobitak
            // 
            this.lblUkupniDobitak.AutoSize = true;
            this.lblUkupniDobitak.Location = new System.Drawing.Point(5, 405);
            this.lblUkupniDobitak.Name = "lblUkupniDobitak";
            this.lblUkupniDobitak.Size = new System.Drawing.Size(82, 13);
            this.lblUkupniDobitak.TabIndex = 9;
            this.lblUkupniDobitak.Text = "Ukupni dobitak:";
            // 
            // frmRezultatiListica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 426);
            this.Controls.Add(this.textBoxUkupniDobitak);
            this.Controls.Add(this.lblUkupniDobitak);
            this.Controls.Add(this.treeListRezultati);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmRezultatiListica";
            this.Text = "frmRezultatiListica";
            this.Load += new System.EventHandler(this.frmRezultatiListica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeListRezultati;
        private System.Windows.Forms.TextBox textBoxUkupniDobitak;
        private System.Windows.Forms.Label lblUkupniDobitak;

    }
}