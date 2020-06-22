using System;
using Desafio2Lib;
using Xunit;

namespace Desafio2Test {
    public class UnitTest1 {
        [Fact]
        public void Test1 () {
            string res = Desafio2.order ("is2  Thi1s T4est 3a");
            Assert.Equal ("Thi1s is2 3a T4est", res);
        }

        [Fact]
        public void Test2 () {
            string res = Desafio2.order ("4of Fo1r pe6ople g3ood th5e the2");
            Assert.Equal ("Fo1r the2 g3ood 4of th5e pe6ople", res);
        }

        [Fact]
        public void Test3 () {
            string res = Desafio2.order ("");
            Assert.Equal ("", res);
        }

        [Fact]
        public void Test4 () {
            string res = Desafio2.order ("9of Fo1r pe6ople g3ood th5e the2");
            Assert.Equal ("Fo1r the2 g3ood th5e pe6ople 9of", res);
        }

        [Fact]
        public void Test5 () {
            string res = Desafio2.order ("    the    is2  Thi1s T4est 3a    ");
            Assert.Equal ("Thi1s is2 3a T4est", res);
        }
    }
}