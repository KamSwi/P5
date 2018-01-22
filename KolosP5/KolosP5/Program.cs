using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolosP5
{
    class Program 
    {
        static void Main(string[] args)
        {
            List<Wycieczka> biuroPodrozy = new List<Wycieczka>();
            biuroPodrozy.Add(new Wycieczka("Luskemburg", 22000));
            biuroPodrozy.Add(new Wycieczka("Belgia", 12000));
            biuroPodrozy.Add(new Wycieczka("Francja", 2200));
            biuroPodrozy.Add(new Wycieczka("Krakow", 200));
            biuroPodrozy.Add(new Wycieczka("Warszawa", 100));
            biuroPodrozy.Add(new Wycieczka("Mazury", 300));
            foreach (var item in biuroPodrozy)
            {
                item.rabat();
                Console.WriteLine(item);
            }
            Console.WriteLine(biuroPodrozy);
            biuroPodrozy.Sort();
            Console.WriteLine(biuroPodrozy);
            

            Dictionary<string, float> hotel = new Dictionary<string, float>();
            hotel.Add("Bursztynowy", 4);
            hotel.Add("Piaskowy", 3);
            hotel.Add("Grand", 5);
            hotel.Add("Hiszpania", 4);
            hotel.Add("Tani", 2);
            foreach (var item in hotel)
            {
                Console.WriteLine(item);
            }
            Queue <string> pensjonat = new Queue<string>();
            

        }
    }
}
