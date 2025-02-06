using System;
using System.Security.Cryptography.X509Certificates;
using Xunit;
namespace EvolucaoTestes.IRPF;

public class TesteImpostoRenda
{
    [Theory]
    [InlineData(1500, 0)]
    [InlineData(2500, 44.70)]
    [InlineData(3500, 170.20)]
    [InlineData(4500, 376.37)]
    [InlineData(5500, 643.14)]
    public void TesteImposto(double salarioBruto, double resultado)
    {
        var impostoRenda = new ImpostoRenda();

        impostoRenda.CalcularImpostoRenda(salarioBruto);

        Assert.Equal(resultado, impostoRenda.Desconto);
    }

    [Theory]
    [InlineData(null, "Salário obrigatório. Digite novamente.")]
    [InlineData(0, "Salário inválido. Digite novamente.")]
    public void TesteImpostoRendaInvalido(double? salarioBruto, string mensagemEsperada)
    {
        var impostoRenda2 = new ImpostoRenda();

        var ex = Assert.Throws<ArgumentNullException>(() => impostoRenda2.CalcularImpostoRenda(salarioBruto));

        Assert.Contains(mensagemEsperada, ex.Message);

    } 
}