using System;
using Desafio3Lib;
using Xunit;

namespace Desafio3Test {
    public class UnitTest1 {
        [Fact]
        public void Test1 () {
            string[] res = { "1:0", "2:0", "3:0", "4:0", "2:1", "3:1", "4:1", "3:2", "4:2", "4:3" };
            Assert.Equal (30, Desafio3.points (res, true));
        }

        [Fact]
        public void Test2 () {
            string[] res = { "1:1", "2:2", "3:3", "4:4", "2:2", "3:3", "4:4", "3:3", "4:4", "4:4" };
            Assert.Equal (10, Desafio3.points (res, true));
        }

        [Fact]
        public void Test3 () {
            string[] res = { "0:1", "0:2", "0:3", "0:4", "1:2", "1:3", "1:4", "2:3", "2:4", "3:4" };
            Assert.Equal (0, Desafio3.points (res, true));
        }

        [Fact]
        public void Test4 () {
            string[] res = { "1:0", "2:0", "3:0", "4:0", "2:1", "1:3", "1:4", "2:3", "2:4", "3:4" };
            Assert.Equal (15, Desafio3.points (res, true));
        }

        [Fact]
        public void Test5 () {
            string[] res = { "1:0", "2:0", "3:0", "4:4", "2:2", "3:3", "1:4", "2:3", "2:4", "3:4" };
            Assert.Equal (12, Desafio3.points (res, true));
        }

        [Fact]
        public void Test6 () {
            string[] res = { "1:0", "2:0", "3:0", "4:0", "2:1", "3:1", "4:1", "3:2", "4:2", "4:3" };
            Assert.Equal (15, Desafio3.points (res, false));
        }
    }
}