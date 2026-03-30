using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Interop;

namespace NasaWPF
{
    //Az emberes és ember nélküli küldetések számát.
    //A küldetések költségének átlagát
    //és hasznos terhének átlagát.Két tizedesre kerekítse, illetve a mértékegységet
    //jelenítse meg a minta szerint.
    internal class Statisztika
    {
        public Statisztika(string kategoria, int darab, string atlagTeher, string atlagKoltseg)
        {
            Kategoria = kategoria;
            Darab = darab;
            AtlagTeher = atlagTeher;
            AtlagKoltseg = atlagKoltseg;
        }

        public string Kategoria { get; set; }
        public int Darab { get; set; }
        public string AtlagTeher { get; set; }
        public string AtlagKoltseg { get; set; }
    }
}
