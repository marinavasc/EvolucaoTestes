using System;
using System.Security.Cryptography.X509Certificates;
namespace EvolucaoTestes.IRPF;

public class AnalisarSalario
{
    public double SalBruto { get; set; }

    public void ReceberSalario(string salBruto)
    {
        if (string.IsNullOrWhiteSpace(salBruto))
            throw new ArgumentNullException("Salário","Salário obrigatório. Digite novamente.");

        if (double.TryParse(salBruto, out double _salBruto))
            SalBruto = _salBruto;
        else
            throw new ArgumentNullException("Salário","Salário inválido. Digite novamente.");

    }
}
