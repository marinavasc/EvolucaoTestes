using System;
namespace EvolucaoTestes.IRPF;

class Program
{
    static void Main(string[] args)
    {
        RecebendoContribuintes();
    }

    private static void RecebendoContribuintes()
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

                    ImpostoRenda calculo = new ImpostoRenda();
                    calculo.CalcularImpostoRenda(salario.SalarioBruto);

                    Console.WriteLine($"\nNome: {nome.Nome}");
                    Console.WriteLine($"Salário bruto: {salario.SalarioBruto.ToString("C2")}");
                    Console.WriteLine($"Desconto: {calculo.Desconto.ToString("C2")}");
                    Console.WriteLine($"Salário líquido: {calculo.SalarioLiquido.ToString("C2")}");
                }
                Novamente();
            }
            else
            {
                Console.WriteLine("\nDigite um valor válido.");
                RecebendoContribuintes();
            }
        }
        catch
        {
            Console.WriteLine("Erro inesperado. Procure o administrador do sistema");
            Console.ReadLine();
            RecebendoContribuintes();
        }
    }

    private static Contribuinte receberNumeroContribuinte()
    {
        Console.WriteLine("Quantos contribuintes iremos calcular? ");
        string? contribuinte = Console.ReadLine();
        Contribuinte novoNome = new Contribuinte(contribuinte);
        try
        {
            novoNome.ReceberNumeroContribuintes(contribuinte);
        }
        catch (ArgumentNullException aNe)
        {
            Console.WriteLine(aNe.Message);
            novoNome = receberNumeroContribuinte();
        }
        catch
        {
            Console.WriteLine("Erro inesperado. Procure o administrador do sistema");
            Console.ReadLine();
        }
        return novoNome;
    }

    private static Pessoa receberNome()
    {
        Console.WriteLine("Qual seu nome? ");
        string? nome = Console.ReadLine();
        Pessoa novoNome = new Pessoa(nome);
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
        }
        return novoNome;
    }

    private static Salario receberSalario()
    {
        Console.WriteLine("Qual seu salário bruto? ");
        string? salarioBruto = Console.ReadLine();
        Salario salario = new Salario();
        try
        {
            salario.ReceberSalario(salarioBruto);
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
                RecebendoContribuintes();
            
            else Console.WriteLine("Até mais.");            
        }
        catch
        {
            Console.WriteLine("Erro inesperado. Procure o administrador do sistema");
            Console.ReadLine();
        }
    }

}