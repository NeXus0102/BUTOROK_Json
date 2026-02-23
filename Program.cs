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
