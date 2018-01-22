using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolosP5
{
    class WycieczkaKraj: Wycieczka
    {
        private bool vip;

        public WycieczkaKraj(string kierunek, double cena, bool vip) {
        
        }
        public override string ToString()
        {
            return "WycieczkaKraj: {1}, cena {2}"+ kierunek + cena;
        }
           public double Rabat()
        {
            return cena * 3/5;
        }
    }
}
