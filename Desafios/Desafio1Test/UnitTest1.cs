using System;
using Xunit;
using Desafio1Lib;

namespace Desafio1Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Desafio desafio = new Desafio(20);
            desafio.run();

            int mult3 = desafio.getBig3Count();
            int mult5 = desafio.getBig5Count();
            Assert.Equal(6, mult3);
            Assert.Equal(4, mult5);
        }

        [Fact]
        public void Test2()
        {
            Desafio desafio = new Desafio(1);
            desafio.run();

            int mult3 = desafio.getBig3Count();
            int mult5 = desafio.getBig5Count();
            Assert.Equal(0, mult3);
            Assert.Equal(0, mult5);
        }

        [Fact]
        public void Test3()
        {
            Desafio desafio = new Desafio(50);
            desafio.run();

            int mult3 = desafio.getBig3Count();
            int mult5 = desafio.getBig5Count();
            Assert.Equal(16, mult3);
            Assert.Equal(10, mult5);
        }
    }
}
