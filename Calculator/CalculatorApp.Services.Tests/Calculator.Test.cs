using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorApp.Services.Tests
{
    [TestClass]
    public class CalculatorTest
    {
       Calculator _calc; 

       public CalculatorTest()
       {
           _calc = new Calculator();
       }

       [TestMethod]
       public void ShouldAddTwoNumbers()
       {
           int res = _calc.Add(5,3); 
           Assert.AreEqual(res, 8); 
       } 
       [TestMethod]
       public void ShouldSuptractTwoNumbers()
       {
           int res = _calc.Subtract(5,2);
           Assert.AreEqual(res, 3);
       }
        [TestMethod]
        public void ShouldDivideTwoNumbers()
        {
            int res = _calc.Divide(5,5);
            Assert.AreEqual(res, 1);
        }
       
 
    }
}
