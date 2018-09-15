using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kladionica.Enumeracije;

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
        #endregion
    }
}
