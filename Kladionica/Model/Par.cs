using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kladionica.Enumerations;

namespace Kladionica.Model
{
    public class Par
    {
        #region Fields
        private uint _id;
        private string _domacin;
        private string _gost;
        private VrstaSporta _vrstaSporta;
        private decimal _kvotaPobjedaDomacina;
        private decimal _kvotaPobjedaGosta;
        private decimal _kvotaNerijeseno;
        private bool _izborPobjedaDomacina = false;
        private bool _izborPobjedaGosta = false;
        private bool _izborNerijeseno = false;
        private int? _brojGolovaDomaci;
        private int? _brojGolovaGosti;
        #endregion

        #region Properties
        public uint Id
        {
            get { return _id; }
            set
            {
                if (_id == value)
                    return;
                _id = value;
            }
        }

        public string Domacin
        {
            get { return _domacin; }
            set
            {
                if (_domacin == value)
                    return;
                _domacin = value;
            }
        }
        public string Gost
        {
            get { return _gost; }
            set
            {
                if (_gost == value)
                    return;
                _gost = value;
            }
        }
        public VrstaSporta VrstaSporta
        {
            get { return _vrstaSporta; }
            set
            {
                if (_vrstaSporta == value)
                    return;
                _vrstaSporta = value;
            }
        }
        public decimal KvotaPobjedaDomacina
        {
            get { return _kvotaPobjedaDomacina; }
            set
            {
                if (_kvotaPobjedaDomacina == value)
                    return;
                _kvotaPobjedaDomacina = value;
            }
        }
        public decimal KvotaPobjedaGosta
        {
            get { return _kvotaPobjedaGosta; }
            set
            {
                if (_kvotaPobjedaGosta == value)
                    return;
                _kvotaPobjedaGosta = value;
            }
        }
        public decimal KvotaNerijeseno
        {
            get { return _kvotaNerijeseno; }
            set
            {
                if (_kvotaNerijeseno == value)
                    return;
                _kvotaNerijeseno = value;
            }
        }
        public string VrstaSportaText
        {
            get
            {
                return VrstaSporta.ToString(1);
            }
        }
        public bool IzborPobjedaDomacina
        {
            get { return _izborPobjedaDomacina; }
            set
            {
                if (_izborPobjedaDomacina == value)
                    return;
                _izborPobjedaDomacina = value;
            }
        }
        public bool IzborPobjedaGosta
        {
            get { return _izborPobjedaGosta; }
            set
            {
                if (_izborPobjedaGosta == value)
                    return;
                _izborPobjedaGosta = value;
            }
        }
        public bool IzborNerijeseno
        {
            get { return _izborNerijeseno; }
            set
            {
                if (_izborNerijeseno == value)
                    return;
                _izborNerijeseno = value;
            }
        }
        public int? BrojGolovaDomaci
        {
            get { return _brojGolovaDomaci; }
            set
            {
                if (_brojGolovaDomaci == value)
                    return;
                _brojGolovaDomaci = value;
            }

        }
        public int? BrojGolovaGosti
        {
            get { return _brojGolovaGosti; }
            set
            {
                if (_brojGolovaGosti == value)
                    return;
                _brojGolovaGosti = value;
            }
        }
        public string ParText
        {
            get
            {
                return Domacin + " - " + Gost;
            }
        }
        public string GoloviText
        {
            get {
                string textTemp = "";
                if (BrojGolovaDomaci.HasValue && BrojGolovaGosti.HasValue)
                    textTemp = BrojGolovaDomaci.Value + ":" + BrojGolovaGosti.ToString();
                return textTemp; 
            }
        }
        #endregion
    }
}
