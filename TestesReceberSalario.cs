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
    salario.SalarioBruto = 5000; 

    //act
    var resultado = salario.SalarioBruto;

    //assert
    Assert.Equal(5000, resultado);
}

[Fact]
public void TesteReceberSalarioBrutoLetras()
{
    // Arrange
    var salario = new Salario();

    // Act e Assert
    Assert.Throws<FormatException>(() =>
    {
        salario.SalarioBruto = Convert.ToDouble("abc");
    });
}

[Fact]
public void TesteReceberSalarioBrutoVazio()
{
    // Arrange
    var salario = new Salario();

    // Act e Assert
    Assert.Throws<FormatException>(() =>
    {
        salario.SalarioBruto = Convert.ToDouble("");
    });
}
}