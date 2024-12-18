namespace EvolucaoTestes.IRPF;
using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args, double salBruto)
    {
        ReceberDados();

        void ReceberDados()
        {
        Console.Write("Olá! Qual seu nome? ");
        string nome = Console.ReadLine()!;
        if (nome == "")
        {
            System.Console.WriteLine("Digite um nome válido. Digite qualquer tecla para voltar.");
            Console.ReadKey();
            Console.Clear();
            ReceberDados();
        }
        Console.Write("E qual seu salário bruto? ");
        string salBrutoString = Console.ReadLine()!;
         if (salBrutoString == "")
        {
            System.Console.WriteLine("Digite um valor válido. Digite qualquer tecla para voltar.");
            Console.ReadKey();
            Console.Clear();
            ReceberDados();
        }
        double salBruto = double.Parse(salBrutoString)!;
        }

        CalcularImpostoRenda(salBruto);
        
            void CalcularImpostoRenda(double salBruto)
        {
            double imposto = 0;
            double salLiquido = 0;

            if (salBruto <= 1903.98) 
        {
            imposto = 0;
            salLiquido = salBruto;
        }
            else if (salBruto <= 2826.65)
        {
            imposto = salBruto * 0.075; 
            salLiquido = salBruto - imposto;
        }
            else if (salBruto <= 3751.05)
        {
            imposto = salBruto * 0.15; 
            salLiquido = salBruto - imposto;
        }
             else if (salBruto <= 4664.68)
        {
            imposto = salBruto * 0.225;
            salLiquido = salBruto - imposto; 
        }
             else
        {
            imposto = salBruto * 0.275; 
            salLiquido = salBruto - imposto;
        }

        Console.WriteLine("\nSalário bruto: " + salBruto);
        System.Console.WriteLine("\nImposto: " + imposto);
        Console.WriteLine("\nSalário líquido: " + salLiquido);
        }
    }
}