using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kladionica.Model;

namespace Kladionica.Forms
{
    public partial class frmPodaciIzabranogListica : Form
    {
        #region Fields
        Listic _listic;
        #endregion
        #region Constructor
        public frmPodaciIzabranogListica(Listic listic)
        {
            _listic = listic;
            InitializeComponent();
        }
        #endregion
        #region Events
        private void frmPodaciIzabranogListica_Load(object sender, EventArgs e)
        {
            if (_listic != null)
            {
                grdParovi.AutoGenerateColumns = false;
                grdParovi.DataSource = _listic.ParoviNaListicu.ToList();
                textBoxUlog.Text = _listic.UplaceniIznos.ToString();
                textBoxUkupnaKvota.Text = _listic.UkupnaKvotaListica.ToString();
                textBoxUkupniDobitak.Text = _listic.UkupniDobitakListica.ToString();
            }            
        }
        #endregion
    }
}
