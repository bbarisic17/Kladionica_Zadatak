using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kladionica.Model;
using Kladionica.Services;

namespace Kladionica.Forms
{
    public partial class frmListici : Form
    {
        #region Fields
        private List<Listic> _odigraniListici;
        DohvatPodataka dohvatPodataka = new DohvatPodataka();
        #endregion
        #region Constructor
        public frmListici()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        private void frmListici_Load(object sender, EventArgs e)
        {
            _odigraniListici = dohvatPodataka.DohvatiListice();
            grdListici.AutoGenerateColumns = false;
            grdListici.DataSource = _odigraniListici.ToList();
        }
        private void grdListici_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow selectedRow = grdListici.Rows[rowIndex];
            Listic odabraniListic = (Listic)grdListici.CurrentRow.DataBoundItem;
            if (odabraniListic != null)
            {
                frmPodaciIzabranogListica podaci = new frmPodaciIzabranogListica(odabraniListic);
                podaci.ShowDialog();
            }
        }
        #endregion        
    }
}
