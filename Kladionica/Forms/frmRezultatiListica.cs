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
    public partial class frmRezultatiListica : Form
    {
        #region Fields
        private List<Listic> _odigraniListici;
        private Novcanik _stanjeNovcanika;
        DohvatPodataka dohvatPodataka = new DohvatPodataka();
        SpremanjePodatakaService spremanjePodataka = new SpremanjePodatakaService();
        private decimal dobiveniIznos = 0m;
        #endregion

        #region Constructor
        public frmRezultatiListica(Novcanik novcanik)
        {
            _stanjeNovcanika = novcanik;
            InitializeComponent();
        }
        #endregion

        #region Methods
        private void GenerirajRezultate()
        {
            Random randomInt = new Random();
            foreach (var listic in _odigraniListici)
            {
                foreach (var par in listic.ParoviNaListicu)
                {
                    if (par.VrstaSporta == Enumerations.VrstaSporta.Nogomet)
                    {
                        if ((par.KvotaPobjedaDomacina <= par.KvotaNerijeseno) && (par.KvotaPobjedaDomacina <= par.KvotaPobjedaGosta))
                        {
                            if (par.KvotaNerijeseno < par.KvotaPobjedaGosta)
                            {
                                par.BrojGolovaDomaci = randomInt.Next(2, 5);
                                par.BrojGolovaGosti = randomInt.Next(1, 3);
                            }
                            else if (par.KvotaPobjedaGosta <= par.KvotaNerijeseno)
                            {
                                par.BrojGolovaDomaci = randomInt.Next(1, 5);
                                par.BrojGolovaGosti = randomInt.Next(1, 3);
                            }
                        }
                        else if ((par.KvotaNerijeseno <= par.KvotaPobjedaDomacina) && (par.KvotaNerijeseno <= par.KvotaPobjedaGosta))
                        {
                            if (par.KvotaPobjedaDomacina <= par.KvotaPobjedaGosta)
                            {
                                par.BrojGolovaDomaci = randomInt.Next(1, 3);
                                par.BrojGolovaGosti = randomInt.Next(1, 2);
                            }
                            else if (par.KvotaPobjedaGosta < par.KvotaPobjedaDomacina)
                            {
                                par.BrojGolovaDomaci = randomInt.Next(1, 3);
                                par.BrojGolovaGosti = randomInt.Next(1, 4);
                            }
                        }
                        else if ((par.KvotaPobjedaGosta <= par.KvotaPobjedaDomacina) && (par.KvotaPobjedaGosta <= par.KvotaNerijeseno))
                        {
                            if (par.KvotaPobjedaDomacina <= par.KvotaNerijeseno)
                            {
                                par.BrojGolovaDomaci = randomInt.Next(1, 3);
                                par.BrojGolovaGosti = randomInt.Next(2, 5);
                            }
                            else if (par.KvotaNerijeseno < par.KvotaPobjedaDomacina)
                            {
                                par.BrojGolovaDomaci = randomInt.Next(1, 2);
                                par.BrojGolovaGosti = randomInt.Next(1, 4);
                            }
                        }
                    }
                    else if (par.VrstaSporta == Enumerations.VrstaSporta.Kosarka)
                    {
                        if ((par.KvotaPobjedaDomacina <= par.KvotaNerijeseno) && (par.KvotaPobjedaDomacina <= par.KvotaPobjedaGosta))
                        {
                            par.BrojGolovaDomaci = randomInt.Next(70, 110);
                            par.BrojGolovaGosti = randomInt.Next(60, 80);                                                                                        
                        }                        
                        else if ((par.KvotaPobjedaGosta <= par.KvotaPobjedaDomacina) && (par.KvotaPobjedaGosta <= par.KvotaNerijeseno))
                        {
                            par.BrojGolovaDomaci = randomInt.Next(60, 80);
                            par.BrojGolovaGosti = randomInt.Next(70, 110);                           
                        }
                    }
                    else if (par.VrstaSporta == Enumerations.VrstaSporta.Rukomet)
                    {
                        if ((par.KvotaPobjedaDomacina <= par.KvotaNerijeseno) && (par.KvotaPobjedaDomacina <= par.KvotaPobjedaGosta))
                        {
                            if (par.KvotaNerijeseno < par.KvotaPobjedaGosta)
                            {
                                par.BrojGolovaDomaci = randomInt.Next(25, 35);
                                par.BrojGolovaGosti = randomInt.Next(20, 30);
                            }
                            else if (par.KvotaPobjedaGosta <= par.KvotaNerijeseno)
                            {
                                par.BrojGolovaDomaci = randomInt.Next(25, 35);
                                par.BrojGolovaGosti = randomInt.Next(23, 30);
                            }
                        }
                        else if ((par.KvotaNerijeseno <= par.KvotaPobjedaDomacina) && (par.KvotaNerijeseno <= par.KvotaPobjedaGosta))
                        {
                            if (par.KvotaPobjedaDomacina <= par.KvotaPobjedaGosta)
                            {
                                par.BrojGolovaDomaci = randomInt.Next(20, 30);
                                par.BrojGolovaGosti = randomInt.Next(20, 25);
                            }
                            else if (par.KvotaPobjedaGosta < par.KvotaPobjedaDomacina)
                            {
                                par.BrojGolovaDomaci = randomInt.Next(20, 25);
                                par.BrojGolovaGosti = randomInt.Next(20, 30);
                            }
                        }
                        else if ((par.KvotaPobjedaGosta <= par.KvotaPobjedaDomacina) && (par.KvotaPobjedaGosta <= par.KvotaNerijeseno))
                        {
                            if (par.KvotaPobjedaDomacina <= par.KvotaNerijeseno)
                            {
                                par.BrojGolovaDomaci = randomInt.Next(25, 27);
                                par.BrojGolovaGosti = randomInt.Next(25, 30);
                            }
                            else if (par.KvotaNerijeseno < par.KvotaPobjedaDomacina)
                            {
                                par.BrojGolovaDomaci = randomInt.Next(28, 32);
                                par.BrojGolovaGosti = randomInt.Next(30, 35);
                            }
                        }
                    }
                }
            }
        }        
        private void PrikaziRezultate()
        {
            foreach (var listic in _odigraniListici)
            {
                bool dobitak = true;
                var nodeRoot = treeListRezultati.Nodes.Add("Šifra listića:" + listic.Sifra.ToString());                
                foreach (var par in listic.ParoviNaListicu)
                {
                    string izborTemp = "";
                    if (par.IzborPobjedaDomacina)
                        izborTemp = "1";
                    else if (par.IzborNerijeseno)
                        izborTemp = "X";
                    else if (par.IzborPobjedaGosta)
                        izborTemp = "2";

                    string nodeText = "Vrsta sporta:" + par.VrstaSportaText;
                    nodeText += "   " + "Par:" + par.ParText;
                    nodeText += "   " + "Vaš izbor:" + izborTemp;
                    nodeText += "   " + "Rezultat:" + par.GoloviText;
                    var childNode = nodeRoot.Nodes.Add(nodeText);

                    if (par.IzborPobjedaDomacina && par.BrojGolovaDomaci > par.BrojGolovaGosti)
                        childNode.BackColor = Color.GreenYellow;
                    else if (par.IzborNerijeseno && par.BrojGolovaDomaci == par.BrojGolovaGosti)
                        childNode.BackColor = Color.GreenYellow;
                    else if (par.IzborPobjedaGosta && par.BrojGolovaDomaci < par.BrojGolovaGosti)
                        childNode.BackColor = Color.GreenYellow;

                    else
                    {
                        childNode.BackColor = Color.OrangeRed;
                        dobitak = false;
                    }                        
                }
                if (dobitak)
                {
                    nodeRoot.Text += "  " + "Status listića:Dobitak";
                    dobiveniIznos += listic.UkupniDobitakListica;
                    listic.Dobitak = true;
                }
                else
                {
                    nodeRoot.Text += "  " + "Status listića:Gubitak";
                    listic.Dobitak = false;
                }                    
            }
        }
        #endregion

        #region Events
        private void frmRezultatiListica_Load(object sender, EventArgs e)
        {
            _odigraniListici = dohvatPodataka.DohvatiListice().Where(item => !item.ProvjereniRezultati).ToList();
            if (_odigraniListici.Count == 0)
            {
                MessageBox.Show("Nemate aktualnih listića!");
                this.Close();
            }
            GenerirajRezultate();
            PrikaziRezultate();
            textBoxUkupniDobitak.Text = dobiveniIznos.ToString("F");
            spremanjePodataka.SpremiRezultateUtakmica(_odigraniListici);
            if (dobiveniIznos > 0m)
            {
                _stanjeNovcanika.TrenutniIznos += dobiveniIznos;
                spremanjePodataka.SpremiStanjeNovcanika(_stanjeNovcanika);
            }
        }
        #endregion
    }
}
