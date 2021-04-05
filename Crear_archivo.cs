using System;
using System.IO;
namespace Archivos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un archivo
            TextWriter Archivo = new StreamWriter("Archivo.txt");
            String Texto = Console.ReadLine();
            Archivo.WriteLine(Texto);
            Archivo.Close();
            Console.Clear();
            Console.ReadKey(); 
            Archivo.Close();
        }
    }
}
