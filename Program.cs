using System.Text.Json;

namespace BUTOROK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string file = File.ReadAllText("butorok.json");
                Gyoker gy = JsonSerializer.Deserialize<Gyoker>(file);
                //1.Feladat
                foreach (var t in gy.targyak)
                {
                    if (t.anyag.ToLower().Contains("fa"))
                    {
                        Console.WriteLine(t);
                    }
                }
                Console.WriteLine();
                //2.Feladat
                Targyak max = gy.targyak[0];
                foreach (var targy in gy.targyak)
                {
                    if (targy.terfogat() > max.terfogat())
                    {
                        max = targy;
                    }
                }
                Console.WriteLine("Legnagyobb: " + max);
                Console.WriteLine();
                //3.Feladat
                int osszar = 0;
                foreach (var targy in gy.targyak)
                {
                    if (targy.keszleten)
                    {
                        osszar += targy.ar;
                    }
                }
                Console.WriteLine($"Készleten lévők összára: {osszar} Ft");


            }
            catch (JsonException ex)
            {
                Console.WriteLine("Json fájl feldolgozási hiba: " + ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Könyvtári hiba: " + ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Fájl elérési hiba: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fájlkezelési hiba: " + ex.Message);
            }



        }
    }
}
