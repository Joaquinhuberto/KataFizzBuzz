using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestKataFIzzBuzz 

{
    [TestClass]
    public class UnitTest1
    {

        Random random = new Random();

        [TestMethod]
        public void Fizz()
        {
            for (var x = 1; x <= 1000; x++)
            {
                if ((x % 3 == 0) && (x % 5 != 0))
                {
                    Assert.AreEqual("Fizz", KataFizzBuzz.KataFizzBuzz.fizzBuzz(x));
                }
            }

        }

        [TestMethod]
        public void Buzz()
        {
            for (var x = 1; x <= 1000; x++)
            {
                if ((x % 3 != 0) && (x % 5 == 0))
                {
                    Assert.AreEqual("Buzz", KataFizzBuzz.KataFizzBuzz.fizzBuzz(x));
                }
            }
        }

        [TestMethod]
        public void FizzBuzz()
        {
          
            for (var x = 1; x <= 1000; x++) {
                if ((x % 3 == 0) && (x % 5 == 0))
                {
                    Assert.AreEqual("FizzBuzz", KataFizzBuzz.KataFizzBuzz.fizzBuzz(x));
                }
            }

        }

        [TestMethod]
        public void Number()
        {
 
            for (var x = 1; x <= 1000; x++)
            {
                if ((x % 3 != 0) && (x % 5 != 0))
                {
                    Assert.AreEqual(x.ToString(), KataFizzBuzz.KataFizzBuzz.fizzBuzz(x));
                }
            }

        } 
    }
}
