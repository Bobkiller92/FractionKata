using FractionKata.Prod;
using NUnit.Framework;

namespace FractionKata.Test
{
    public class FractionTest
    {        
        [Test]
        public void AdditionShouldReturnZero()
        {
            Fraction f1 = new Fraction(0, 1);
            Fraction f2 = new Fraction(0, 1);

            Fraction result = f1.Add(f2);

            Assert.AreEqual(0, result.Numerateur);
        }
    }
}