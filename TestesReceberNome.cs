using System;
using Xunit;
namespace EvolucaoTestes.IRPF;

public class TesteReceberNome
{
    [Fact]
    public void TesteReceberNomeContribuinte()
    {
        //arrange
        var nome = new Nome();
        nome.NomeContribuinte = "";
        
        //act
        var resultado = nome.NomeContribuinte;
        
        //assert
        Assert.Equal("", resultado);
    }
}