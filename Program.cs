using System;
using System.Security.Cryptography.X509Certificates;
namespace EvolucaoTestes.IRPF;

class Program
{
    static void Main(string[] args)
    {
        NumContribuintes();
    }

    private static void NumContribuintes()
    {
        Console.Write("\nOlá! Quantos contribuintes iremos calcular? ");
        try
        {
            if (double.TryParse(Console.ReadLine(), out double numContribuintes) && numContribuintes > 0)
            {
                for (int i = 0; i < numContribuintes; i++)
                {
                    var nome = receberNome();

                    var salario = receberSalario();

                    CalculoImpostoRenda calculo = new CalculoImpostoRenda();
                    calculo.CalcularImpostoRenda(salario.SalBruto);

                    Console.WriteLine($"\nNome: {nome.Nome}");
                    Console.WriteLine($"Salário bruto: {salario.SalBruto.ToString("C2")}");
                    Console.WriteLine($"Desconto: {calculo.Desconto.ToString("C2")}");
                    Console.WriteLine($"Salário líquido: {calculo.SalLiquido.ToString("C2")}");
                    Novamente();
                }
            }
            else
            {
                Console.WriteLine("\nDigite um valor válido.");
                NumContribuintes();
            }
        }
        catch
        {
            Console.WriteLine("Erro inesperado. Procure o administrador do sistema");
            Console.ReadLine();
            NumContribuintes();
        }
    }

    private static AnalisarNome receberNome()
    {
        Console.WriteLine("Qual seu nome? ");
        string? nome = Console.ReadLine();
        AnalisarNome novoNome = new AnalisarNome(nome);
        try
        {
            novoNome.ReceberNome(nome);
        }
        catch (ArgumentNullException aNe)
        {
            Console.WriteLine(aNe.Message);
            novoNome = receberNome();
        }
        catch
        {
            Console.WriteLine("Erro inesperado. Procure o administrador do sistema");
            Console.ReadLine();
            novoNome = receberNome();
        }
        return novoNome;
    }

    private static AnalisarSalario receberSalario()
    {
        Console.WriteLine("Qual seu salário bruto? ");
        string? salBruto = Console.ReadLine();
        AnalisarSalario salario = new AnalisarSalario();
        try
        {
            salario.ReceberSalario(salBruto);
        }
        catch (ArgumentNullException aEx)
        {
            Console.WriteLine(aEx.Message);
            salario = receberSalario();
        }
        catch
        {
            Console.WriteLine("Erro inesperado. Procure o administrador do sistema");
            Console.ReadLine();
            salario = receberSalario();
        }
        return salario;
    }
    private static void Novamente()
    {
        System.Console.WriteLine("Deseja calcular novamente? Digite 'S'.");
        try
        {
            string? resposta = Console.ReadLine();
            if (resposta == "S")
                NumContribuintes();
            
            else Console.WriteLine("Até mais.");            
        }
        catch
        {
            Console.WriteLine("Erro inesperado. Procure o administrador do sistema");
            Console.ReadLine();
            Novamente();
        }
    }

}