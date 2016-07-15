using System;
using System.Linq;
using Xunit;
using System.Collections.Generic;
using ProjectVSonline;

namespace UnitTestProject1
{
    public class UnitTest1
    {


        [Fact]
        public void TestMethod1()
        {
            var program = new Program();
            int c = 1;
            int d = 5;

            int actualSum = program.Suma(c, d);
            int actulRozn = program.Roznica(d, c);
            //zmiana 

            Assert.Equal(4, actulRozn);
            Assert.Equal(6, actualSum);
        }
    }
}
