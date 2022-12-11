using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONSave
{
    internal class Uczen
    {
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public string klasa { get; set; }

        public Uczen(string imie, string nazwisko, string klasa)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.klasa = klasa;
        }
    }
}
