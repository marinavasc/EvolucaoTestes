namespace EvolucaoTestes.IRPF;
using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Olá! Quantos contribuintes iremos calcular? ");
        int num = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < num; i++)
        { 

        double salBruto = 0;
        string nome = "";

        ReceberDados();

        void ReceberDados()
        {
            Console.Write("\nQual seu nome? ");
            try
            {
                    nome = Console.ReadLine()!;

                    if (System.Text.RegularExpressions.Regex.IsMatch(nome, @"^[a-zA-Z]+$"))
                {
                    Console.Write("E qual seu salário bruto? ");
                    string salBrutoString = Console.ReadLine()!;

                    try
                    {
                        salBruto = double.Parse(salBrutoString);
                        if (salBruto <= 0)
                        {
                            throw new Exception("Digite um valor válido.");
                        }
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
                else if (nome == "")
                {
                    System.Console.WriteLine("\nDigite um nome válido. \nDigite qualquer tecla para voltar.");
                    Console.ReadKey();
                    Console.Clear();
                    ReceberDados();
                }
                else
                {
                    System.Console.WriteLine("\nDigite um nome válido. \nDigite qualquer tecla para voltar.");
                    Console.ReadKey();
                    Console.Clear();
                    ReceberDados();
                }

            }
            catch 
            {
                System.Console.WriteLine("\nDigite um nome válido. \nDigite qualquer tecla para voltar.");
                Console.ReadKey();
                Console.Clear();
                ReceberDados();
            }
            
        }

        CalcularImpostoRenda(salBruto, nome);

        void CalcularImpostoRenda(double salBruto, string nome)
            {
                double parteTributavel = 0;
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
                    parteTributavel = 2826.65 - 1903.98;
                    aliquota = 0.075;
                    deducao = 142.80;
                    desconto = parteTributavel * aliquota - deducao;
                    salLiquido = salBruto - desconto;
                }
                else if (salBruto <= 3751.05)
                {
                    parteTributavel = 3751.05 - 2826.65;
                    aliquota = 0.15;
                    deducao = 354.80;
                    desconto = parteTributavel * aliquota - deducao;
                    salLiquido = salBruto - desconto;
                }
                else if (salBruto <= 4664.68)
                {
                    parteTributavel = 4664.68 - 3751.05;
                    aliquota = 0.225;
                    deducao = 636.13;
                    desconto = parteTributavel * aliquota - deducao;
                    salLiquido = salBruto - desconto;
                }
                else
                {
                    aliquota = 0.275;
                    deducao = 869.36;
                    desconto = parteTributavel * aliquota - deducao;
                    salLiquido = salBruto - desconto;
                }

                Console.WriteLine("\nNome do contribuinte: " + nome);
                Console.WriteLine("Salário bruto: " + salBruto);
                System.Console.WriteLine("Desconto: " + desconto);
                Console.WriteLine("Salário líquido: " + salLiquido);
                
                ReceberDados();
               
            }
        }
    }
}