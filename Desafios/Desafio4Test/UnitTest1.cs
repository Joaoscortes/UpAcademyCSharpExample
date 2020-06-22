using System;
using Desafio4Lib;
using Xunit;

namespace Desafio4Test {
    public class UnitTest1 {
        [Fact]
        public void Test1 () {
            Assert.Equal (new int[] { 1, 2, 3, 4 }, Desafio4.ints ("1 2 3 4"));
        }

        [Fact]
        public void Test2 () {
            Assert.Equal (new int[] { 1, 3, 4 }, Desafio4.ints ("1 q2 3 4"));
        }

        [Fact]
        public void Test3 () {
            Assert.Equal (new int[] { }, Desafio4.ints (""));
        }

        [Fact]
        public void Test4 () {
            Assert.Equal (new int[] { 1, 2, 3 }, Desafio4.ints ("Ze 1,2 1 2 3"));
        }
    }
}