using System;
using System.Collections.Generic;
using Desafio5Lib;
using Xunit;

namespace Desafio5Test {
    public class UnitTest1 {
        // [Fact]
        // public void TestRegexConverter () {
        //     string[] res = { "10", "01", "2020" };
        //     Assert.Equal (res, Desafio5.regexStringToStringArray ("10 01 2020"));
        //     Assert.Equal (res, Desafio5.regexStringToStringArray ("10/01/2020"));
        //     Assert.Equal (res, Desafio5.regexStringToStringArray ("10,01,2020"));
        //     Assert.Equal (res, Desafio5.regexStringToStringArray ("10-01-2020"));
        // }

        // [Fact]
        // public void TestConverterStringArrayToDoubleArray () {
        //     double[] res = { 10, 01, 2020 };
        //     Assert.Equal (res, Desafio5.convertStringArrayToDoubleArray (new string[] { "10", "01", "2020" }));
        //     InvalidOperationException ex = Assert.Throws<InvalidOperationException> (() => Desafio5.convertStringArrayToDoubleArray (new string[] { "10", "O1", "2020" }));
        //     Assert.Equal ("Invalid Date.", ex.Message);
        // }

        // [Fact]
        // public void TestConverterStringToDoubleArray () {
        //     double[] res = { 10, 01, 2020 };
        //     Assert.Equal (res, Desafio5.convertStringToDoubleArray ("10 01 2020"));
        // }

        // [Fact]
        // public void TestLeapYear () {
        //     // Assert.Equal (true, Desafio5.isLeapYear (2020));
        //     Assert.False (Desafio5.isLeapYear (2019));
        //     Assert.True (Desafio5.isLeapYear (2020));
        // }

        // [Fact]
        // public void TestMonthDays () {
        //     Assert.Equal (28, Desafio5.monthDays (2, 2019));
        //     Assert.Equal (29, Desafio5.monthDays (2, 2020));
        //     Assert.Equal (31, Desafio5.monthDays (1, 2020));
        // }

        // [Fact]
        // public void TestStringArrayToList () {
        //     Assert.Equal (new List<int> { 10, 01, 2019 }, Desafio5.stringArrayToListInt (new string[] { "10", "01", "2019" }));
        // }

        [Fact]
        public void Test1 () {
            Assert.Equal (31, Desafio5.countDays ("01/01/2019", "01/02/2019"));
        }

        [Fact]
        public void Test2 () {
            Assert.Equal (4, Desafio5.countDays ("01/01/2019", "05/01/2019"));
        }

        [Fact]
        public void Test3 () {
            Assert.Equal (365, Desafio5.countDays ("01/01/2019", "01/01/2020"));
        }

        [Fact]
        public void Test4 () {
            Assert.Equal (366, Desafio5.countDays ("01/01/2016", "01/01/2017"));
        }

        [Fact]
        public void Test5 () {
            Assert.Equal (-31, Desafio5.countDays ("01/02/2019", "01/01/2019"));
        }

        [Fact]
        public void Test6 () {
            Assert.Equal (-4, Desafio5.countDays ("05/01/2019", "01/01/2019"));
        }

        [Fact]
        public void Test7 () {
            Assert.Equal (-366, Desafio5.countDays ("01/01/2017", "01/01/2016"));
        }

        [Fact]
        public void Test8 () {
            Assert.Equal (-365, Desafio5.countDays ("01/01/2020", "01/01/2019"));
        }

        [Fact]
        public void Test1IFNormalize () {
            Assert.Equal (-365, Desafio5.countDays ("01 01 2020", "01-01-2019"));
        }

        [Fact]
        public void Test2IFNormalize () {
            Assert.Equal (-365, Desafio5.countDays ("01,01,2020", "01:01:2019"));
        }

        // [Fact]
        // public void Test1IfException () {
        //     InvalidOperationException ex = Assert.Throws<InvalidOperationException> (() => Desafio5.countDays ("01-01-2017", "01 01 2016"));
        //     Assert.Equal ("Invalid Date.", ex.Message);
        // }
        // [Fact]
        // public void Test2IfException () {
        //     InvalidOperationException ex = Assert.Throws<InvalidOperationException> (() => Desafio5.countDays ("01,01,2017", "01:01:2016"));
        //     Assert.Equal ("Invalid Date.", ex.Message);
        // }
        [Fact]
        public void Test3IfException () {
            InvalidOperationException ex = Assert.Throws<InvalidOperationException> (() => Desafio5.countDays ("01012017", "01/01/2016"));
            Assert.Equal ("Invalid Date.", ex.Message);
        }
    }
}