using System;
using Xunit;
namespace EvolucaoTestes.IRPF;

    public class TesteReceberNomeContribuinte
    {

        [Fact]
        public void TesteContribuinteNulo()
        {
            // Arrange
            var contribuinte = new Contribuinte();
            contribuinte = null;

            // Act
            var result = contribuinte; 
            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void TesteNumeroContribuintesValidos()
        {
            // Arrange
            var contribuinte = new Contribuinte();
            string entradaValida = "5";

            // Act
            contribuinte.TestarReceberNumeroContribuintes(entradaValida);

            // Assert
            Assert.Equal(5, contribuinte.NumeroContribuintes);
        }

        [Fact]
        public void TesteNumeroContribuintesInvalidos()
        {
            // Arrange
            var contribuinte = new Contribuinte();
            string entradaInvalida = "abc";

            // Act & Assert
            Assert.Throws<FormatException>(() => contribuinte.TestarReceberNumeroContribuintes(entradaInvalida));
        }
    }
