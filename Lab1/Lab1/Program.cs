using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class ulamek
    {
        private int licznik;
        private int mianownik;

        /// <summary>
        /// konstrukotr domyślny
        /// </summary>
        public ulamek()
        {
            licznik = 1;
        }


        /// <summary>
        /// konstruktor z dwoma argumentami
        /// </summary>

        public ulamek(int l, int m)
        {
            licznik = l;
            mianownik = m;
        }

        /// <summary>
        /// konstruktor kopiujący (1 argument).
        /// </summary>

        public ulamek(ulamek previousUlamek)
        {
            licznik = previousUlamek.licznik;
        }


        /// <summary>
        /// metoda string
        /// </summary>
        public override string ToString()
        {
            return base.ToString();
        }


    }
    public readonly struct Fraction
    {
        private readonly int num;
        private readonly int den;

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.", nameof(denominator));
            }
            num = numerator;
            den = denominator;
        }

        public static Fraction operator +(Fraction a) => a;
        public static Fraction operator -(Fraction a) => new Fraction(-a.num, a.den);

        public static Fraction operator +(Fraction a, Fraction b)
            => new Fraction(a.num * b.den + b.num * a.den, a.den * b.den);

        public static Fraction operator -(Fraction a, Fraction b)
            => a + (-b);

        public static Fraction operator *(Fraction a, Fraction b)
            => new Fraction(a.num * b.num, a.den * b.den);

        public static Fraction operator /(Fraction a, Fraction b)
        {
            if (b.num == 0)
            {
                throw new DivideByZeroException();
            }
            return new Fraction(a.num * b.den, a.den * b.num);
        }

        public override string ToString() => $"{num} / {den}";
    }
}
