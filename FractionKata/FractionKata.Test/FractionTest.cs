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

        [Test]
        public void SameDenominateurAdditionShouldReturnOneForNumerateur()
        {
            Fraction f1 = new Fraction(1, 1);
            Fraction f2 = new Fraction(0, 1);

            Fraction result = f1.Add(f2);

            Assert.AreEqual(1, result.Numerateur);
            Assert.AreEqual(1, result.Denominateur);
        }

        [Test]
        public void SameDenominateurAdditionShouldReturnTwoForNumerateur()
        {
            Fraction f1 = new Fraction(2, 3);
            Fraction f2 = new Fraction(0, 3);

            Fraction result = f1.Add(f2);

            Assert.AreEqual(2, result.Numerateur);
            Assert.AreEqual(3, result.Denominateur);
        }

        [Test]
        public void SameDenominateurAdditionShouldReturn3ForNumerateur()
        {
            Fraction f1 = new Fraction(2, 5);
            Fraction f2 = new Fraction(1, 5);

            Fraction result = f1.Add(f2);

            Assert.AreEqual(3, result.Numerateur);
            Assert.AreEqual(5, result.Denominateur);
        }

        [Test]
        public void SameDenominateurAdditionShouldReturn4ForNumerateur()
        {
            Fraction f1 = new Fraction(1, 5);
            Fraction f2 = new Fraction(3, 5);

            Fraction result = f1.Add(f2);

            Assert.AreEqual(4, result.Numerateur);
            Assert.AreEqual(5, result.Denominateur);
        }
    }
}