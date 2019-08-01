
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDrivenDevelopmentt.MathLib;

namespace TestDrivenDevelopment.MathLib.Tests
{
    [TestClass]
    public class MathTests
    {

        // Add

        [TestMethod]
        public void Add()
        {
            int x = 6;
            int y = 7;
            IAdd adder = new Math();
            Assert.AreEqual(adder.Add(x, y), 13);

        }

        [TestMethod]
        public void AddNegativeValues()
        {
            int x = -5;
            int y = -5;
            IAdd adder = new Math();
            Assert.AreEqual(adder.Add(x, y), -10);
        }

        [TestMethod]
        public void AddNegativeValueToZero()
        {
            int x = -5;
            int y = 0;
            IAdd adder = new Math();
            Assert.AreEqual(adder.Add(x, y), -5);

        }
        [TestMethod]
        public void AddPossitiveValueToZero()
        {
            int x = 5;
            int y = 0;
            IAdd adder = new Math();
            Assert.AreEqual(adder.Add(x, y), 5);
        }
        [TestMethod]
        public void AddNegativeAndPositiveValue()
        {
            int x = 5;
            int y = -12;
            IAdd adder = new Math();
            Assert.AreEqual(adder.Add(x, y), -7);
        }
        [TestMethod]
        public void AddNegativeAndPositiveValue_ResultPositive()
        {
            int x = 6;
            int y = -2;
            IAdd adder = new Math();
            Assert.AreEqual(adder.Add(x, y), 4);
        }

        [TestMethod]
        public void AddDouble()
        {
            double x = 2.5;
            double y = 2.5;
            IAdd adder = new Math();
            Assert.AreEqual(adder.Add(x,y),5);
        }

        [TestMethod]
        public void AddNegativeDouble()
        {
            double x = -3.4;
            double y = -2.1;
            IAdd add = new Math();
            Assert.AreEqual(add.Add(x, y), -5.5);
        }
        [TestMethod]
        public void AddDoubleNegativeAndPositiveValue_ResultZero()
        {
            double x = 3.2;
            double y = -3.2;
            IAdd add = new Math();
            Assert.AreEqual(add.Add(x, y), 0);
        }
        [TestMethod]
        public void AddDoubleNegativeAndPositiveValue_ResultPossitive()
        {
            double x = 4.2;
            double y = -3.2;
            IAdd add = new Math();
            Assert.AreEqual(add.Add(x, y), 1);
        }

        // Subtract

        [TestMethod]
        public void Subtract()
        {
            int x = 8;
            int y = 5;
            ISub subtractor = new Math();
            Assert.AreEqual(subtractor.Sub(x, y), 3);
        }
        [TestMethod]
        public void SubtractNegativeValue()
        {
            int x = -4;
            int y = -9;
            ISub subtractor = new Math();
            Assert.AreEqual(subtractor.Sub(x, y), 5);
        }

        [TestMethod]
        public void SubtractNegativeAndPositiveValue()
        {
            int x = -5;
            int y = 2;
            ISub subtractor = new Math();
            Assert.AreEqual(subtractor.Sub(x, y), -7);
        }
        [TestMethod]
        public void SubtractZeroPostivie_ResultNegative()
        {
            int x = 0;
            int y = 2;
            ISub subtractor = new Math();
            Assert.AreEqual(subtractor.Sub(x, y), -2);
        }
        [TestMethod]
        public void SubtractZeroNegativeValue()
        {
            int x = 0;
            int y = -2;
            ISub subtractor = new Math();
            Assert.AreEqual(subtractor.Sub(x, y), 2);
        }
        [TestMethod] // Doesn't pass 
        public void SubtractDoublePositiveValues()
        {
            double x = 5.44;
            double y = 2.5;
            ISub subtractor = new Math();
            Assert.AreEqual(subtractor.Sub(x, y), 2.94);
        }

        [TestMethod]
        public void SubtractDoublePositiveValues_ResultNegativeValue()
        {
            double x = 2.4;
            double y = 7.22;
            ISub subtractor = new Math();
            Assert.AreEqual(subtractor.Sub(x, y), -4.82);
        }

        [TestMethod]

        public void SubtractDoubleNegativeValues()
        {
            double x = -3.52;
            double y = -2.52;
            ISub subtractor = new Math();
            Assert.AreEqual(subtractor.Sub((int)x, (int)y), -1);
        }

        [TestMethod]
        public void SubtractDoubleFromZeroNegativeValue()
        {
            double x = 0;
            double y = -2.52;
            ISub subtractor = new Math();
            Assert.AreEqual(subtractor.Sub(x, y), 2.52);
        }
        [TestMethod]
        public void SubtractDoubleFromZeroPossitiveValue()
        {
            double x = 0;
            double y = 2.52;
            ISub subtractor = new Math();
            Assert.AreEqual(subtractor.Sub(x, y), -2.52);
        }
        [TestMethod]
        public void SubtractDoubleNegativeValue_ResultZero()
        {
            double x = -2.52;
            double y = -2.52;
            ISub subtractor = new Math();
            Assert.AreEqual(subtractor.Sub(x, y), 0);
        }

        // Division

        [TestMethod]
        public void Divide()
        {
            int x = 10;
            int y = 5;
            IDivision divide = new Math();
            Assert.AreEqual(divide.Divide(x, y), 2);
        }
        [TestMethod]
        public void DivideNegativeValue()
        {
            int x = -10;
            int y = -2;
            IDivision divide = new Math();
            Assert.AreEqual(divide.Divide(x, y), 5);
        }

        [TestMethod]
        public void DivideNegativeAndPositiveValue()
        {
            int x = -15;
            int y = 5;
            IDivision divide = new Math();
            Assert.AreEqual(divide.Divide(x, y), -3);
        }

        [TestMethod]
        public void DivideNegativeAndPositiveValue_ResultDouble()
        {
            int x = -15;
            int y = 4;
            IDivision divide = new Math();
            Assert.AreEqual(divide.Divide((double)x, (double)y), -3.75);
        }
        [TestMethod]
        public void DivideByZero()
        {
            int x = 0;
            int y = 3;
            IDivision divide = new Math();
            Assert.AreEqual(divide.Divide(x,y), 0);
        }
        [TestMethod]
        public void DividePositiveDoubleByZero()
        {
            int x = 0;
            double y = 3.55;
            IDivision divide = new Math();
            Assert.AreEqual(divide.Divide(x, y), 0);

        }
        [TestMethod]
        public void DividePositiveDoubleByInt_ResultInt()
        {
            int x = 14;
            double y = 3.5;
            IDivision divide = new Math();
            Assert.AreEqual(divide.Divide(x, y), 4);
        }
        [TestMethod]
        public void DividePositiveValueByOne()
        {
            int x = 14;
            double y = 1;
            IDivision divide = new Math();
            Assert.AreEqual(divide.Divide(x, y), 14);
        }
        [TestMethod]
        public void DivideNegativeValueByOne()
        {
            int x = -14;
            double y = 1;
            IDivision divide = new Math();
            Assert.AreEqual(divide.Divide(x, y), -14);
        }

        //Multiplication

        [TestMethod]
        public void MultiplicationPositiveValues()
        {
            int x = 14;
            int y = 2;
            IMultiplication multiply = new Math();
            Assert.AreEqual(multiply.Multiply(x, y), 28);
        }

        [TestMethod]
        public void MultiplicationNegativeValues()
        {
            int x = -14;
            int y = -2;
            IMultiplication multiply = new Math();
            Assert.AreEqual(multiply.Multiply(x, y), 28);
        }
        [TestMethod]
        public void MultiplicationNegativeAndPositiveValues()
        {
            int x = -14;
            int y = 2;
            IMultiplication multiply = new Math();
            Assert.AreEqual(multiply.Multiply(x, y), -28);
        }
        [TestMethod]
        public void MultiplicationByZeroNegativeValue()
        {
            int x = -14;
            int y = 0;
            IMultiplication multiply = new Math();
            Assert.AreEqual(multiply.Multiply(x, y), 0);
        }
        [TestMethod]
        public void MultiplicationByZeroPositiveValue()
        {
            int x = 14;
            int y = 0;
            IMultiplication multiply = new Math();
            Assert.AreEqual(multiply.Multiply(x, y), 0);
        }
        [TestMethod]
        public void MultiplicationByOneDoublePositiveValue()
        {
            double x = 14.2;
            double y = 1.0;
            IMultiplication multiply = new Math();
            Assert.AreEqual(multiply.Multiply(x, y), 14.2);
        }

        [TestMethod]
        public void MultiplicationByOneDoubleNegativeValuethod()
        {
            double x = 14.2;
            double y = -1.0;
            IMultiplication multiply = new Math();
            Assert.AreEqual(multiply.Multiply(x, y), -14.2);
        }
    }
}
