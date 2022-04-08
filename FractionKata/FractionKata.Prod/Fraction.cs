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
            int numerateur, denominateur;

            if (_denominateur != f2.Denominateur)
            {
                numerateur = _numerateur * f2.Denominateur + _denominateur * f2.Numerateur;
                denominateur = _denominateur * f2.Denominateur;                
            }
            else
            {
                numerateur = _numerateur + f2.Numerateur;
                denominateur = _denominateur;
            }
            int pgcd = GetPgcd(numerateur, denominateur);
            return new Fraction(numerateur / pgcd, denominateur / pgcd);
        }

        private int GetPgcd(int a, int b)
        {
            return b == 0 ? a : GetPgcd(b, a % b);
        }
    }
}