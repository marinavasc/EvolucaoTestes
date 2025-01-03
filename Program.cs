using System;
namespace EvolucaoTestes.IRPF;

class Program
{
    static void Main(string[] args)
    {
        ReceberContribuintes();
    }

    private static void ReceberContribuintes()
    {
        try
        {
            Contribuinte contribuinte = receberNumeroContribuinte();

            for (int i = 0; i < contribuinte.NumeroContribuintes; i++)
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
            novamente();
        }
        catch
        {
            Console.WriteLine("Erro inesperado. Procure o administrador do sistema");
            Console.ReadLine();
            ReceberContribuintes();
        }
    }


    private static Contribuinte receberNumeroContribuinte()
    {
        Console.Write("Quantos contribuintes iremos calcular? ");
        string? numeroContribuintes = Console.ReadLine();
        Contribuinte contribuinte = new Contribuinte();
        try
        {
            contribuinte.ReceberNumeroContribuintes(numeroContribuintes);
        }
        catch (ArgumentNullException aNe)
        {
            Console.WriteLine(aNe.Message);
            contribuinte = receberNumeroContribuinte();
        }
        catch
        {
            Console.WriteLine("Erro inesperado. Procure o administrador do sistema");
            Console.ReadLine();
        }
        return contribuinte;
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
    private static void novamente()
    {
        System.Console.WriteLine("Deseja calcular novamente? Digite 'S'.");
        try
        {
            string? resposta = Console.ReadLine();
            if (resposta == "S")
                ReceberContribuintes();

            else Console.WriteLine("Até mais.");
        }
        catch
        {
            Console.WriteLine("Erro inesperado. Procure o administrador do sistema");
            Console.ReadLine();
        }
    }

}