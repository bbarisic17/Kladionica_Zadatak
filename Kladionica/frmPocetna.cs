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
using Kladionica.Forms;

namespace Kladionica
{
    public partial class frmPocetna : Form
    {
        #region Constructor
        public frmPocetna()
        {
            InitializeComponent();
        }        
        #endregion

        #region Fields
        private List<Par> _parovi;
        private DohvatPodataka dohvatPodataka = new DohvatPodataka();
        private SpremanjePodatakaService spremanjePodataka = new SpremanjePodatakaService();
        private Novcanik _novcanik;                
        Listic _odigraniListic;
        #endregion

        #region Events
        private void frmPocetna_Load(object sender, EventArgs e)
        {
            spremanjePodataka.UnosTestnihPodataka();
            PostaviPocetnePodatke();                                                  
        }                             
        private void grdNogomet_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int rowIndex = e.RowIndex;
            int colIndex = e.ColumnIndex;
            IzborPara(grdNogomet, rowIndex, colIndex);
            /*DataGridViewRow selectedRow = grdNogomet.Rows[rowIndex];
            Par odabraniPar = (Par)grdNogomet.CurrentRow.DataBoundItem;
            if (odabraniPar == null)
                return;
                       
            if (grdNogomet.Columns[e.ColumnIndex].Name == "Izbor1" && (bool)selectedRow.Cells[e.ColumnIndex].Value)
            {
                odabraniPar.IzborNerijeseno = false;
                odabraniPar.IzborPobjedaGosta = false;
                
                selectedRow.Cells["Izbor2"].Value = false;
                selectedRow.Cells["IzborX"].Value = false; 
               
                selectedRow.DefaultCellStyle.BackColor = Color.Aqua;
            }
            else if (grdNogomet.Columns[e.ColumnIndex].Name == "Izbor2" && (bool)selectedRow.Cells[e.ColumnIndex].Value)
            {
                selectedRow.Cells["Izbor1"].Value = false;
                selectedRow.Cells["IzborX"].Value = false;
                
                odabraniPar.IzborPobjedaDomacina = false;
                odabraniPar.IzborNerijeseno = false;
                selectedRow.DefaultCellStyle.BackColor = Color.Aqua;
            }
            else if (grdNogomet.Columns[e.ColumnIndex].Name == "IzborX" && (bool)selectedRow.Cells[e.ColumnIndex].Value)
            {
                selectedRow.Cells["Izbor1"].Value = false;
                selectedRow.Cells["Izbor2"].Value = false;
                
                odabraniPar.IzborPobjedaDomacina = false;
                odabraniPar.IzborPobjedaGosta = false;
                selectedRow.DefaultCellStyle.BackColor = Color.Aqua;
            }
            else
                selectedRow.DefaultCellStyle.BackColor = Color.White;
            ProvjeriStanjeListeIzabranihParova(odabraniPar);
            IzracunajUkupnuKvotuDobitak();*/
        }               
        private void grdNogomet_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            grdNogomet.EndEdit();
        }
        private void textBoxUlog_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (Keys)e.KeyChar != Keys.Back && e.KeyChar != ',')
            {
                e.Handled = true;
            }            
        }
        private void textBoxUlog_TextChanged(object sender, EventArgs e)
        {
            IzracunajUkupnuKvotuDobitak();
        }
        private void btnMojiListici_Click(object sender, EventArgs e)
        {
            frmListici listici = new frmListici();
            listici.ShowDialog();
        }
        private void btnNoviListic_Click(object sender, EventArgs e)
        {
            PostaviPocetnePodatke();
        }
        private void btnPregledajRezultate_Click(object sender, EventArgs e)
        {
            frmRezultatiListica rezultati = new frmRezultatiListica(_novcanik);
            rezultati.Show();
            textBoxStanjeRacuna.Text = _novcanik.TrenutniIznos.ToString("F");
            DozvoljenoResetiranjeIznosaNovcanika();
        }
        private void btnResetirajStanjeNovcanika_Click(object sender, EventArgs e)
        {
            _novcanik.TrenutniIznos = 100;
            spremanjePodataka.SpremiStanjeNovcanika(_novcanik);
            textBoxStanjeRacuna.Text = _novcanik.TrenutniIznos.ToString("F");
        }
        private void grdKosarka_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            grdKosarka.EndEdit();
        }
        private void grdKosarka_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int rowIndex = e.RowIndex;
            int colIndex = e.ColumnIndex;
            IzborPara(grdKosarka, rowIndex, colIndex);
        }
        private void grdRukomet_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            grdRukomet.EndEdit();
        }
        private void grdRukomet_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int rowIndex = e.RowIndex;
            int colIndex = e.ColumnIndex;
            IzborPara(grdRukomet, rowIndex, colIndex);
        }
        #endregion

        #region Methods
        private void ProvjeriStanjeListeIzabranihParova(Par odabraniPar)
        {
            var parUListiIzabranihParova = _odigraniListic.ParoviNaListicu.FirstOrDefault(item => item.Id == odabraniPar.Id);
            if (parUListiIzabranihParova == null)
            {
                if (odabraniPar.IzborPobjedaDomacina || odabraniPar.IzborPobjedaGosta || odabraniPar.IzborNerijeseno)
                    _odigraniListic.ParoviNaListicu.Add(odabraniPar);
            }
            else if (parUListiIzabranihParova != null)
            {
                if (odabraniPar.IzborPobjedaDomacina || odabraniPar.IzborPobjedaGosta || odabraniPar.IzborNerijeseno)
                    parUListiIzabranihParova = odabraniPar;
                else
                    _odigraniListic.ParoviNaListicu.Remove(odabraniPar);
            }
        }
        private void IzracunajUkupnuKvotuDobitak()
        {
            _odigraniListic.UkupnaKvotaListica = 0m;
            _odigraniListic.UkupniDobitakListica = 0m;
            int brojacVrstaSporta = 0;
            Dictionary<int, int> brojParovaIzSporta = new Dictionary<int, int>();
            if (_odigraniListic.ParoviNaListicu != null)
            {
                foreach (var par in _odigraniListic.ParoviNaListicu)
                {
                    if (par.IzborPobjedaDomacina)
                        _odigraniListic.UkupnaKvotaListica += par.KvotaPobjedaDomacina;
                    else if (par.IzborPobjedaGosta)
                        _odigraniListic.UkupnaKvotaListica += par.KvotaPobjedaGosta;
                    else if (par.IzborNerijeseno)
                        _odigraniListic.UkupnaKvotaListica += par.KvotaNerijeseno;

                    if (brojParovaIzSporta.ContainsKey((int)par.VrstaSporta))                    
                        brojParovaIzSporta[(int)par.VrstaSporta] = brojParovaIzSporta[(int)par.VrstaSporta] + 1;
                    
                    else
                        brojParovaIzSporta.Add((int)par.VrstaSporta, 1);
                }
                foreach (var brojParova in brojParovaIzSporta)
                {
                    if (brojParova.Value >= 3)
                        _odigraniListic.UkupnaKvotaListica += 5;
                }
                brojacVrstaSporta = Enum.GetNames(typeof(Enumerations.VrstaSporta)).Length;

                if (brojacVrstaSporta == brojParovaIzSporta.Count)
                    _odigraniListic.UkupnaKvotaListica += 10;
            }
            if (!String.IsNullOrWhiteSpace(textBoxUlog.Text))
            {
                _odigraniListic.UplaceniIznos = decimal.Parse(textBoxUlog.Text.ToString());
                _odigraniListic.UkupniDobitakListica = _odigraniListic.UplaceniIznos * _odigraniListic.UkupnaKvotaListica;                
            }
            else
            {
                _odigraniListic.UplaceniIznos = 0;
                _odigraniListic.UkupniDobitakListica = 0;
            }

            PrikaziPodatke();            
        }
        private void btnSpremiListic_Click(object sender, EventArgs e)
        {
            if (_odigraniListic != null)
            {
                if (_novcanik.TrenutniIznos <= 0)
                    MessageBox.Show("Nemate novaca na računu!");

                else if (_odigraniListic.UplaceniIznos > _novcanik.TrenutniIznos)
                    MessageBox.Show("Ulog ne smije biti veći od stanja na računu");

                else if (_odigraniListic.ParoviNaListicu.Count == 0)
                    MessageBox.Show("Morate odabrati parove za listić!");

                else if (_odigraniListic.UplaceniIznos <= 0)
                    MessageBox.Show("Morate unijeti ulog!");

                else
                {
                    _novcanik.TrenutniIznos -= _odigraniListic.UplaceniIznos;
                    spremanjePodataka.SpremiStanjeNovcanika(_novcanik);

                    spremanjePodataka.SpremiOdigraniListic(_odigraniListic);

                    PostaviPocetnePodatke();
                }
            }
        }
        private void PrikaziPodatke()
        {
            textBoxUkupnaKvota.Text = _odigraniListic.UkupnaKvotaListica.ToString("F");
            textBoxUkupniDobitak.Text = _odigraniListic.UkupniDobitakListica.ToString("F");
            textBoxStanjeRacuna.Text = _novcanik.TrenutniIznos.ToString("F");
            DozvoljenoResetiranjeIznosaNovcanika();
        }
        private void PostaviPocetnePodatke()
        {
            _odigraniListic = new Listic();
            _parovi = dohvatPodataka.DohvatiParove();
            _novcanik = dohvatPodataka.DohvatiNovcanik();
            DozvoljenoResetiranjeIznosaNovcanika();

            textBoxUkupnaKvota.Text = _odigraniListic.UkupnaKvotaListica.ToString("F");
            textBoxUkupniDobitak.Text = _odigraniListic.UkupniDobitakListica.ToString("F");
            textBoxStanjeRacuna.Text = _novcanik.TrenutniIznos.ToString("F");
            textBoxUlog.Text = _odigraniListic.UplaceniIznos.ToString();
            grdNogomet.AutoGenerateColumns = false;
            grdKosarka.AutoGenerateColumns = false;
            grdRukomet.AutoGenerateColumns = false;
            grdNogomet.DataSource = _parovi.Where(item => item.VrstaSporta == Enumerations.VrstaSporta.Nogomet).ToList();
            grdKosarka.DataSource = _parovi.Where(item => item.VrstaSporta == Enumerations.VrstaSporta.Kosarka).ToList();
            grdRukomet.DataSource = _parovi.Where(item => item.VrstaSporta == Enumerations.VrstaSporta.Rukomet).ToList();
        }
        private void IzborPara(DataGridView grid, int indexR, int indexC)
        {
            if (indexR < 0)
                return;

            DataGridViewRow selectedRow = grid.Rows[indexR];
            Par odabraniPar = (Par)grid.CurrentRow.DataBoundItem;
            if (odabraniPar == null)
                return;

            if (grid.Columns[indexC].Name == "Izbor1" && (bool)selectedRow.Cells[indexC].Value)
            {
                odabraniPar.IzborNerijeseno = false;
                odabraniPar.IzborPobjedaGosta = false;

                selectedRow.Cells["Izbor2"].Value = false;
                selectedRow.Cells["IzborX"].Value = false;

                selectedRow.DefaultCellStyle.BackColor = Color.Aqua;
            }
            else if (grid.Columns[indexC].Name == "Izbor2" && (bool)selectedRow.Cells[indexC].Value)
            {
                selectedRow.Cells["Izbor1"].Value = false;
                selectedRow.Cells["IzborX"].Value = false;

                odabraniPar.IzborPobjedaDomacina = false;
                odabraniPar.IzborNerijeseno = false;
                selectedRow.DefaultCellStyle.BackColor = Color.Aqua;
            }
            else if (grid.Columns[indexC].Name == "IzborX" && (bool)selectedRow.Cells[indexC].Value)
            {
                selectedRow.Cells["Izbor1"].Value = false;
                selectedRow.Cells["Izbor2"].Value = false;

                odabraniPar.IzborPobjedaDomacina = false;
                odabraniPar.IzborPobjedaGosta = false;
                selectedRow.DefaultCellStyle.BackColor = Color.Aqua;
            }
            else if (grid.Columns[indexC].Name == "Izbor1_1" && (bool)selectedRow.Cells[indexC].Value)
            {
                odabraniPar.IzborNerijeseno = false;
                odabraniPar.IzborPobjedaGosta = false;

                selectedRow.Cells["Izbor2_1"].Value = false;
                selectedRow.Cells["IzborX_1"].Value = false;

                selectedRow.DefaultCellStyle.BackColor = Color.Aqua;
            }
            else if (grid.Columns[indexC].Name == "Izbor2_1" && (bool)selectedRow.Cells[indexC].Value)
            {
                selectedRow.Cells["Izbor1_1"].Value = false;
                selectedRow.Cells["IzborX_1"].Value = false;

                odabraniPar.IzborPobjedaDomacina = false;
                odabraniPar.IzborNerijeseno = false;
                selectedRow.DefaultCellStyle.BackColor = Color.Aqua;
            }
            else if (grid.Columns[indexC].Name == "IzborX_1" && (bool)selectedRow.Cells[indexC].Value)
            {
                selectedRow.Cells["Izbor1_1"].Value = false;
                selectedRow.Cells["Izbor2_1"].Value = false;

                odabraniPar.IzborPobjedaDomacina = false;
                odabraniPar.IzborPobjedaGosta = false;
                selectedRow.DefaultCellStyle.BackColor = Color.Aqua;
            }
            else if (grid.Columns[indexC].Name == "Izbor1_2" && (bool)selectedRow.Cells[indexC].Value)
            {
                odabraniPar.IzborNerijeseno = false;
                odabraniPar.IzborPobjedaGosta = false;

                selectedRow.Cells["Izbor2_2"].Value = false;
                selectedRow.Cells["IzborX_2"].Value = false;

                selectedRow.DefaultCellStyle.BackColor = Color.Aqua;
            }
            else if (grid.Columns[indexC].Name == "Izbor2_2" && (bool)selectedRow.Cells[indexC].Value)
            {
                selectedRow.Cells["Izbor1_2"].Value = false;
                selectedRow.Cells["IzborX_2"].Value = false;

                odabraniPar.IzborPobjedaDomacina = false;
                odabraniPar.IzborNerijeseno = false;
                selectedRow.DefaultCellStyle.BackColor = Color.Aqua;
            }
            else if (grid.Columns[indexC].Name == "IzborX_2" && (bool)selectedRow.Cells[indexC].Value)
            {
                selectedRow.Cells["Izbor1_2"].Value = false;
                selectedRow.Cells["Izbor2_2"].Value = false;

                odabraniPar.IzborPobjedaDomacina = false;
                odabraniPar.IzborPobjedaGosta = false;
                selectedRow.DefaultCellStyle.BackColor = Color.Aqua;
            }
            else
                selectedRow.DefaultCellStyle.BackColor = Color.White;
            ProvjeriStanjeListeIzabranihParova(odabraniPar);
            IzracunajUkupnuKvotuDobitak();
        }
        private void DozvoljenoResetiranjeIznosaNovcanika()
        {
            if (_novcanik.TrenutniIznos == 0m)
                btnResetirajStanjeNovcanika.Visible = true;
            else
                btnResetirajStanjeNovcanika.Visible = false;
        }
        #endregion                              
    }
}
