using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestKataFIzzBuzz

{
    [TestClass]
    public class TestFizzBuzz
    {

        [TestMethod]
        public void FizzBuzz()
        {
            for (var x = 1; x <= 1000; x++)
            {
                if (x % 15 == 0)
                {
                    Assert.AreEqual("FizzBuzz", KataFizzBuzz.KataFizzBuzz.fizzBuzz(x));
                }else if (x % 3 == 0)
                {
                    Assert.AreEqual("Fizz", KataFizzBuzz.KataFizzBuzz.fizzBuzz(x));
                }else if (x % 5 == 0)
                {
                    Assert.AreEqual("Buzz", KataFizzBuzz.KataFizzBuzz.fizzBuzz(x));
                }
                else
                {
                    Assert.AreEqual(x.ToString(), KataFizzBuzz.KataFizzBuzz.fizzBuzz(x));
                }
            }
        }
    }
}
