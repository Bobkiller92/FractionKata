using FractionKata.Prod;
using NUnit.Framework;

namespace FractionKata.Test
{
    public class FractionTest
    {                

        //Business Rules        
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
        public void DifferentDenominateurAdditionShouldReturn5_6()
        {
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(1, 3);

            Fraction result = f1.Add(f2);

            Assert.AreEqual(5, result.Numerateur);
            Assert.AreEqual(6, result.Denominateur);
        }        

        [Test]
        public void DifferentDenominateurAdditionShouldReturn5_12()
        {
            Fraction f1 = new Fraction(1, 4);
            Fraction f2 = new Fraction(1, 6);

            Fraction result = f1.Add(f2);

            Assert.AreEqual(5, result.Numerateur);
            Assert.AreEqual(12, result.Denominateur);
        }       

        //Confirmations examples
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
        public void SameDenominateurAdditionShouldReturn4ForNumerateur()
        {
            Fraction f1 = new Fraction(1, 5);
            Fraction f2 = new Fraction(3, 5);

            Fraction result = f1.Add(f2);

            Assert.AreEqual(4, result.Numerateur);
            Assert.AreEqual(5, result.Denominateur);
        }

        [Test]
        public void DifferentDenominateurAdditionShouldReturn8_15()
        {
            Fraction f1 = new Fraction(1, 3);
            Fraction f2 = new Fraction(1, 5);

            Fraction result = f1.Add(f2);

            Assert.AreEqual(8, result.Numerateur);
            Assert.AreEqual(15, result.Denominateur);
        }

        [Test]
        public void DifferentDenominateurAdditionShouldReturn7_18()
        {
            Fraction f1 = new Fraction(1, 6);
            Fraction f2 = new Fraction(2, 9);

            Fraction result = f1.Add(f2);

            Assert.AreEqual(7, result.Numerateur);
            Assert.AreEqual(18, result.Denominateur);
        }
    }
}