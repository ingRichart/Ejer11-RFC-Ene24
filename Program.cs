// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;
using Ejer11;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World! --- RFC ");

        var rfc = new RFC(new DateTime(1979,7,22), "Ricardo Arturo", "Elizalde", "Hernandez");

        Console.WriteLine(rfc.ObtenerRFC());

    }
}