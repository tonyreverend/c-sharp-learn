using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    /*[TestFixture]
    class UnitTests
    {
        Calculator.Calculator calc;

        [SetUp]
        public void Init()
        {
            calc = new Calculator.Calculator();
        }

        [Test]
        public void CalculatorSumTest()
        {
            var result = calc.Sum(15.67, 22.33);
            Assert.That(result, Is.EqualTo(38));
        }

        [Test]
        public void CalculatorSubTest()
        {
            var result = calc.Sub(37.98, 15.18);
            Assert.That(result, Is.EqualTo(22.8));
        }

        [Test]
        public void CalculatorMultiTest()
        {
            var result = calc.Multi(5.6, 5.0);
            Assert.That(result, Is.EqualTo(28));
        }

        [Test]
        public void CalculatorDivTest()
        {
            var result = calc.Div(10.0, 2.5);
            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public void CalculatorSaveSumResultTest()
        {
            var result = calc.Sum(15.67, 22.33);
            calc.Save(result);
            Assert.That(calc.ReturnResult(), Is.EqualTo(38));
        }

        [Test]
        public void CalculatorSaveSubResultTest()
        {
            var result = calc.Sub(37.98, 15.18);
            calc.Save(result);
            Assert.That(calc.ReturnResult(), Is.EqualTo(22.8));
        }

        [Test]
        public void CalculatorSaveMultiResultTest()
        {
            var result = calc.Multi(5.6, 5.0);
            calc.Save(result);
            Assert.That(calc.ReturnResult(), Is.EqualTo(28));
        }

        [Test]
        public void CalculatorSaveDivResultTest()
        {
            var result = calc.Div(10.0, 2.5);
            calc.Save(result);
            Assert.That(calc.ReturnResult(), Is.EqualTo(4));
        }

        [TearDown]
        public void Cleanup()
        {
        }
    }*/
}
