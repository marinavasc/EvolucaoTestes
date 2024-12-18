namespace EvolucaoTestes.IRPF;
using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        ReceberDados();

        void ReceberDados()
        {
        Console.Write("Olá! Qual seu nome? ");
        string nome = Console.ReadLine()!;
        if (nome == "")
        {
            System.Console.WriteLine("Digite um nome válido.");
        }
        Console.Write("E qual seu salário bruto? ");
        string salBrutoString = Console.ReadLine()!;
        double salBruto = double.Parse(salBrutoString)!;
        if (salBrutoString == "")
        {
            System.Console.WriteLine("Digite um valor válido.");
        }
        
        }

    }
}