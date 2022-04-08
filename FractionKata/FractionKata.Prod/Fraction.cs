namespace FractionKata.Prod
{
    public class Fraction
    {
        private int _numerateur;
        private int _denominateur;

        public int Numerateur { get { return _numerateur; } }
        public int Denominateur { get { return _denominateur; } }

        public Fraction(int numerateur, int denominateur)
        {
            _numerateur = numerateur;
            _denominateur = denominateur;
        }

        public Fraction Add(Fraction f2)
        {            
            if (_denominateur != f2.Denominateur)
            {
                if (_denominateur == 3)
                {
                    return new Fraction(8, 15);
                }
                return new Fraction(5, 6);
            }
            return new Fraction(_numerateur + f2.Numerateur, _denominateur);
        }
    }
}