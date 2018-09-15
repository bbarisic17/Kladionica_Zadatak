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
using Kladionica.Servis;

namespace Kladionica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DohvatPodataka dohvat = new DohvatPodataka();
            
            
            Novcanik n = dohvat.DohvatiNovcanik();
            //SpremanjePodataka spremanjePodataka = new SpremanjePodataka();
            //spremanjePodataka.SpremiStanjeNovcanika(novcanik);
        }
    }
}
