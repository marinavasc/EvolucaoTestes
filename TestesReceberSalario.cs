using System;
using System.Security.Cryptography.X509Certificates;
using Xunit;
namespace EvolucaoTestes.IRPF;

public class TesteReceberSalario 
{
    [Fact]
    public void TesteReceberSalarioBruto()
    {
        //arrange
        var salario = new Salario();
        salario.SalarioBruto = 5000; //teste

        //act
        var resultado = salario.SalarioBruto;

        //assert
        Assert.Equal(5000, resultado);
    }
}