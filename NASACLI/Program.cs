
namespace NASACLI
{
    public class Program
    {
        public static List<Kuldetes> kuldetesek = new List<Kuldetes>();
        static void Main(string[] args)
        {
            Beolvas();
            Feladat3();
            Feladat4();
            Feladat5();
            Feladat6();
            //MaxTeher();
        }

        private static void MaxTeher() {
            double max = kuldetesek[0].HasznosTeher;
            int index = 0;
            foreach (var item in kuldetesek)
            {
                if (item.HasznosTeher > max)
                {
                    max = item.HasznosTeher;
                    index = kuldetesek.IndexOf(item);
                }
            }
            Console.WriteLine($"\n6.Feladat: A legnagyobb hasznos teher: {kuldetesek[index].HasznosTeher} kg ({kuldetesek[index].Nev})");
        }

        private static void Feladat6() {
            double min = kuldetesek[0].HasznosTeher;
            int index = 0;
            foreach (var item in kuldetesek)
            {
                if (item.HasznosTeher < min)
                {
                    min = item.HasznosTeher;
                    index = kuldetesek.IndexOf(item);
                }
            }
            Console.WriteLine($"\n6.Feladat: A legkisebb hasznos teher: {kuldetesek[index].HasznosTeher} kg ({kuldetesek[index].Nev})");
        }

        private static void Feladat5() {
            Console.WriteLine("5.Feladat: Küldetések kockázati szintjei:");
            foreach (var kuldetes in kuldetesek)
            {
                if (kuldetes.KockazatiSzint() == "Magas")
                {
                    Console.WriteLine($"{kuldetes.Nev} - Kockázati szint: {kuldetes.KockazatiSzint()}");
                }
            }
        }

        private static void Feladat4() {
            string keresettReszlet;
            Kuldetes keresett = null;
            do
            {
                Console.Write($"4.Feladat: Adja meg egy küldetés nevének részletét: ");
                keresettReszlet = Console.ReadLine();
                keresett = kuldetesek.LastOrDefault(k => k.Nev.ToUpper().Contains(keresettReszlet.ToUpper()));
            }
            while (keresett == null);
            Console.WriteLine($"Talált küldetés: {keresett.Nev}, {keresett.Ev}, {keresett.Celpont}, {(keresett.Sikeres == true?"Sikeres":"Sikertelen")}\n");

            
        }

        private static void Feladat3() {
            Console.WriteLine($"3.Feladat: {kuldetesek.Count} küldetés található az állományban.\n");
        }

        public static void Beolvas() {
            StreamReader sr = new StreamReader("NASAmissions.txt");
            sr.ReadLine();
            while (!sr.EndOfStream) {
                kuldetesek.Add(new Kuldetes(sr.ReadLine()));
            }
        }
    }
}
