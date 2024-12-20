using System;
using System.Security.Cryptography.X509Certificates;
using testeEvolucao;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Olá! Quantos contribuintes iremos calcular? ");
        int num = int.Parse(Console.ReadLine()!);
        if (num <= 0)
        {
            Console.WriteLine("Digite um valor válido.");
        }
        else if (!int.TryParse(Console.ReadLine()!, out _))
        {
            Console.WriteLine("Digite um valor válido.");
        }
        else
        {
            for (int i = 0; i < num; i++)
            {
                
            }
        } 
    }
}