using System;
using System.IO;
namespace readwriteapp
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                StreamWriter sw = new StreamWriter("C:/Users/dcedi/source/repos/Formularios Intento 2/Texto.txt");
                sw.WriteLine("DOOM fue lanzado en 1993.");
                sw.WriteLine("Es un juego de disparos en primera persona.");
                sw.WriteLine("Cuenta con cuatro capítulos de nueve niveles cada uno.");
                sw.WriteLine("El Doom original pesaba 11MB, comprimido en 4 disquetes.");
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Finalizando.");
            }
        }
    }
}