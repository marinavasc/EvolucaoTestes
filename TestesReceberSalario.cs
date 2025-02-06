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
    // Arrange
    var salario = new Salario();

    // Act
    salario.ReceberSalario(salarioBruto); 

    // Assert
    Assert.Equal(salarioEsperado, salario.SalarioBruto);
}
}