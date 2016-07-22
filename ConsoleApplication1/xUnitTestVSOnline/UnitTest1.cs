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
        public void Suma()
        {
            var program = new Program();
            int c = 1;
            int d = 5;

            int actualSum = program.Suma(c, d);
            int actulRozn = program.Roznica(d, c);
            //zmiana www

            Assert.Equal(4, actulRozn);
            Assert.Equal(6, actualSum);
        }
        
         [Fact]
        public void SumaFail()
        {
            var program = new Program();
            int c = 2;
            int d = 5;

            int actualSum = program.Suma(c, d);
           
            

           
            Assert.Equal(6, actualSum);
        }


        [Fact]
        public void Roznica()
        {
            var program = new Program();
            int c = 1;
            int d = 7;


            int actulRozn = program.Roznica(d, c);
            //zmiana

            Assert.Equal(6, actulRozn);

        }



    }
}
