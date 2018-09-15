using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kladionica.Model
{
    public class Novcanik
    {
        #region Fields
        private uint _id;
        private decimal _trenutniIznos;
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
        public decimal TrenutniIznos
        {
            get { return _trenutniIznos; }
            set
            {
                if (_trenutniIznos == value)
                    return;
                _trenutniIznos = value;
            }
        }

        #endregion
    }
}
