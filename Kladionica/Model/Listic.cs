using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kladionica.Model
{
    public class Listic
    {
        #region Fields
        private uint _id;
        private string _sifra;
        private decimal _uplaceniIznos;
        private decimal _ukupnaKvotaListica;
        private decimal _ukupniDobitakListica;
        private List<Par> _paroviNaListicu;
        private bool _provjereniRezultati;
        private bool _dobitak;
        #endregion
        #region Constructor
        public Listic()
        {
            _paroviNaListicu = new List<Par>();
        }
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
        public string Sifra
        {
            get { return _sifra; }
            set
            {
                if (_sifra == value)
                    return;
                _sifra = value;
            }
        }

        public decimal UplaceniIznos
        {
            get { return _uplaceniIznos; }
            set
            {
                if (_uplaceniIznos == value)
                    return;
                _uplaceniIznos = value;
            }
        }
        public decimal UkupnaKvotaListica
        {
            get { return _ukupnaKvotaListica; }
            set
            {
                if (_ukupnaKvotaListica == value)
                    return;
                _ukupnaKvotaListica = value;
            }
        }
        public decimal UkupniDobitakListica
        {
            get { return _ukupniDobitakListica; }
            set
            {
                if (_ukupniDobitakListica == value)
                    return;
                _ukupniDobitakListica = value;
            }
        }
        public List<Par> ParoviNaListicu
        {
            get { return _paroviNaListicu; }
            set
            {
                if (_paroviNaListicu == value)
                    return;
                _paroviNaListicu = value;
            }
        }
        public bool ProvjereniRezultati
        {
            get { return _provjereniRezultati; }
            set
            {
                if (_provjereniRezultati == value)
                    return;
                _provjereniRezultati = value;
            }
        }
        public bool Dobitak
        {
            get { return _dobitak; }
            set
            {
                if (_dobitak == value)
                    return;
                _dobitak = value;
            }
        }
        #endregion
    }
}
