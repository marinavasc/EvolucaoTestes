using System;
namespace EvolucaoTestes.IRPF;

public class Salario
{
    public double SalarioBruto { get; set; }

    public void ReceberSalario(string salarioBruto)
    {
        if (string.IsNullOrWhiteSpace(salarioBruto)) throw new ArgumentNullException("Salário", "Salário obrigatório. Digite novamente.");

        else if (salarioBruto == "0") throw new ArgumentNullException("Salário", "Salário obrigatório. Digite novamente.");

        else if (double.TryParse(salarioBruto, out double _salarioBruto)) SalarioBruto = _salarioBruto;

        else throw new ArgumentNullException("Salário", "Salário inválido. Digite novamente.");
    }
}