using System;
using System.Security.Cryptography.X509Certificates;
using Xunit;
namespace EvolucaoTestes.IRPF;

public class TesteImpostoRenda
{
    [Fact]
    public void TesteImpostoRendaDesconto()
    {
        //arrange
        var impostoRenda = new ImpostoRenda();
        //impostoRenda.Desconto = 500;

        //act
        var resultado = impostoRenda.Desconto;

        //assert
        Assert.Equal(500, resultado);
    }

    [Fact]
    public void TesteImpostoRendaSalarioLiquido()
    {
        //arrange
        var impostoRenda = new ImpostoRenda();
        //impostoRenda.SalarioLiquido = 4500;

        //act
        var resultado = impostoRenda.SalarioLiquido;

        //assert
        Assert.Equal(4500, resultado);
    }
} 