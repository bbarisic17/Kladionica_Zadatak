using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kladionica.Enumerations
{
    public enum VrstaSporta
    { 
        Nogomet = 1,
        Kosarka,
        Rukomet        
    }

    public static class VrstaSportaFormat
    { 
        public static string ToString(this VrstaSporta obj, int dummy)
        {
            string vrstaSporta = String.Empty;
            if (obj == VrstaSporta.Nogomet)
                vrstaSporta = "Nogomet";
            else if (obj == VrstaSporta.Kosarka)
                vrstaSporta = "Košarka";
            else if (obj == VrstaSporta.Rukomet)
                vrstaSporta = "Rukomet";            
            return vrstaSporta;            
        }
    }
}
