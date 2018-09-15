using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kladionica.Enumeracije
{
    public enum VrstaSporta
    { 
        Nogomet = 1,
        Kosarka,
        Rukomet,
        Vaterpolo,
        Formula,
        Hokej,
        Odbojka
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
            else if (obj == VrstaSporta.Vaterpolo)
                vrstaSporta = "Vaterpolo";
            else if (obj == VrstaSporta.Formula)
                vrstaSporta = "Formula 1";
            else if (obj == VrstaSporta.Hokej)
                vrstaSporta = "Hokej na ledu";
            else if (obj == VrstaSporta.Odbojka)
                vrstaSporta = "Odbojka";
            return vrstaSporta;

        }
    }
}
