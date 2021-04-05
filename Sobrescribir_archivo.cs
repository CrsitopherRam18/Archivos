using System;
using System.IO;
namespace Archivos
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter archivo = File.AppendText("Archivo.txt");
            String mensaje;
            mensaje = Console.ReadLine();
            archivo.WriteLine(mensaje);
            archivo.Close();
        }
    }
}
