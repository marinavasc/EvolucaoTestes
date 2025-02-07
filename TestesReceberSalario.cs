using System;
using System.Security.Cryptography.X509Certificates;
using Xunit;
namespace EvolucaoTestes.IRPF;

public class TesteReceberSalario
{
    [Theory]
    [InlineData("5000", 5000)]
    [InlineData("3000", 3000)]
    public void TesteReceberSalarioBruto(string salarioBruto, double salarioEsperado)
    {
        var salario = new Salario();

        salario.ReceberSalario(salarioBruto);

        Assert.Equal(salarioEsperado, salario.SalarioBruto);
    }

    [Theory]
    [InlineData(null, "Salário obrigatório. Digite novamente.")]
    [InlineData("", "Salário obrigatório. Digite novamente.")]
    [InlineData(" ", "Salário obrigatório. Digite novamente.")]
    [InlineData("0", "Salário obrigatório. Digite novamente.")]
    public void TesteReceberSalarioBrutoInvalido(string salarioBruto, string mensagemEsperada)
    {
        var salario = new Salario();

        var ex = Assert.Throws<ArgumentNullException>(() => salario.ReceberSalario(salarioBruto));

        Assert.Contains(mensagemEsperada, ex.Message);
    }

}