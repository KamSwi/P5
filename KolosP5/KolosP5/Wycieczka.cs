using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolosP5
{
    class Wycieczka
    {
        public string kierunek;
        public double cena;
        public Wycieczka(){}
        public Wycieczka(string kierunek, double cena)
        {
            this.kierunek = kierunek;
            this.cena = cena;
        }
        public override string ToString()
        {
            return "Wycieczka: {1}, cena {2}"+ this.kierunek + this.cena;
        }
        public double rabat()
        {
            return this.cena / 2;
        }

    }
}
