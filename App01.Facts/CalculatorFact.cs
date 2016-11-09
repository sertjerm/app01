using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace App01.Facts
{
    public class CalculatorFact
    {
        public class AddMethod:IDisposable //--------->Setup
        {
            private Calculator c;
            private readonly ITestOutputHelper _output;

            //public AddMethod()
            //{
            //    c = new Calculator();
            //}

            //setup
            public AddMethod(ITestOutputHelper output)
            {
                c = new Calculator();
                _output = output;
            }

            //Theory with MemberData Test
            [Theory]
            [InlineData("1", "1", "2")]
            //[MemberData("OneDigitInputs",10)]
            public void OneDigit(string v1, string v2, string expected)
            {
                var result = c.Add(v1, v2);
                _output.WriteLine("{0}+{1}={2}", v1, v2, result);
               // _output.WriteLine($"{v1}+{v2}={result}"); // csharp 6
                Assert.Equal(expected, result);
            }

            public static IEnumerable<Object[]> OneDigitInputs(int count)
            {
                for (int i = 0; i < count; i++)
                {
                    yield return new object[]{
                        i.ToString(),i.ToString(),i.ToString()
                    };
                }
            }

            [Fact]
            public  void OnlyDigitCharacterIsAllowed(){
               var ex=  Assert.Throws<ArgumentException>(() =>
                {
                    c.Add("1a", "2b");
                });
                Assert.Equal("value1",ex.ParamName);
            }


            [Fact]
            public void NegativeValues()
            {
                //arrange
              //  var c = new Calculator();

                //act
                var result = c.Add("-5", "8");


                //assert
                Assert.Equal("3", result);
            }

            public void Dispose()  //------------>teardown
            {
                c = null;
                //throw new NotImplementedException();
            }
        }
    }
}
