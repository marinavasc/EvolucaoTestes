using System;
using Xunit;
namespace EvolucaoTestes.IRPF;

    public class TesteReceberNomeContribuinte
    {
        [Fact]
        public void Test1()
        {
            //arrange
            var contribuinte = new Contribuinte();
            contribuinte = null;

            //act
            //fazer o act

            //assert
            Assert.Null(contribuinte);
            
        }
    }