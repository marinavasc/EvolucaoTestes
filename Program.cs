namespace EvolucaoTestes.IRPF;
using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        double salBruto = 0;
        string nome = "";

        ReceberDados();

        void ReceberDados()
        {
            Console.Write("Olá! Qual seu nome? ");
            string nome = Console.ReadLine()!;
            if (nome == "")
            {
                System.Console.WriteLine("\nDigite um nome válido. \nDigite qualquer tecla para voltar.");
                Console.ReadKey();
                Console.Clear();
                ReceberDados();
            }
            Console.Write("E qual seu salário bruto? ");
            string salBrutoString = Console.ReadLine()!;

            try
            {
                salBruto = double.Parse(salBrutoString);
                if (salBruto <= 0)
                {
                    throw new Exception("Digite um valor válido.");
                }
                CalcularImpostoRenda(salBruto, nome);
            }
            catch
            {
                Console.WriteLine("\nValor inválido. ");
                Console.WriteLine("Digite qualquer tecla para voltar.");
                Console.ReadKey();
                Console.Clear();
                ReceberDados();
            }
        }

        CalcularImpostoRenda(salBruto, nome);

        void CalcularImpostoRenda(double salBruto, string nome)
        {
            double desconto = 0;
            double salLiquido = 0;
            double aliquota = 0;
            double deducao = 0;

            if (salBruto <= 1903.98)
            {
                desconto = 0;
                salLiquido = salBruto;
            }
            else if (salBruto <= 2826.65)
            {
                aliquota = 0.075;
                deducao = 142.80;
                desconto = salBruto * aliquota - deducao;
                salLiquido = salBruto - desconto;
            }
            else if (salBruto <= 3751.05)
            {
                aliquota = 0.15;
                deducao = 354.80;
                desconto = salBruto * aliquota - deducao;
                salLiquido = salBruto - desconto;
            }
            else if (salBruto <= 4664.68)
            {
                aliquota = 0.225;
                deducao = 636.13;
                desconto = salBruto * aliquota - deducao;
                salLiquido = salBruto - desconto;
            }
            else
            {
                aliquota = 0.275;
                deducao = 869.36;
                desconto = salBruto * aliquota - deducao;
                salLiquido = salBruto - desconto;
            }

            Console.WriteLine("\nNome do contribuinte: " + nome);
            Console.WriteLine("Salário bruto: " + salBruto);
            System.Console.WriteLine("Desconto: " + desconto);
            Console.WriteLine("Salário líquido: " + salLiquido);
            
            
        }
    }
}