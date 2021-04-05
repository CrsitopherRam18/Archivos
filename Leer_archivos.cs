sing System;
using System.IO;
namespace Archivos
{
    class Program
    {
        static void Main(string[] args)
        {
            //leer un archivo
             TextReader Leer_Archivo = new StreamReader("Archivo.txt");
              Console.WriteLine(Leer_Archivo.ReadToEnd());
              Leer_Archivo.Close(); 
        }
    }
}
