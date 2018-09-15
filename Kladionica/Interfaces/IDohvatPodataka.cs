using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kladionica.Model;

namespace Kladionica.Interfaces
{
    public interface IDohvatPodataka
    {
        Novcanik DohvatiNovcanik();
        List<Par> DohvatiParove();
        List<Listic> DohvatiListice();
    }
}
