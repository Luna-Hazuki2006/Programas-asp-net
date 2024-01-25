using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Hola mundo :3");
        int.TryParse(Console.ReadLine(), out int numero);
        System.Console.WriteLine(numero);
    }
}