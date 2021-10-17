using NUnit.Framework;
using System;

namespace CF_module_16_7.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Additional_MustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Additional(5,10) == 15);
        }
        [Test]
        public void Substraction_MustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Subtraction(50, 10) == 40);
        }
        [Test]
        public void Miltiplication_MustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Miltiplication(10, 6) == 60);
        }
        [Test]
        public void Division_MustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Division(10, 2) == 5);
        }
        [Test]
        public void Division_MustThrowException()
        {
            var calculator = new Calculator();
            Assert.Throws < DivideByZeroException > (() => calculator.Division(30, 0));
        }
    }
}
