using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ulamek nowy = new Ulamek();

            Console.WriteLine(nowy);

            Ulamek drugi = new Ulamek(1, 3);

            Console.WriteLine(nowy + drugi);

            Console.WriteLine(nowy.Equals(drugi));

            Ulamek[] Ulamki = new Ulamek[]
            {
                new Ulamek(3,5),
                new Ulamek(1, 2),
                new Ulamek(-10,50),
                new Ulamek(1,1),
            };

            //ulamki przed sortowaniem
            for (int i = 0; i < Ulamki.Length; i++)
            {
                Console.WriteLine(Ulamki[i].ToString());
            }

            Array.Sort(Ulamki);

            //ulamki po sortowaniem
            Console.WriteLine("ulamki po sortowaniu");
            for (int i = 0; i < Ulamki.Length; i++)
            {
                Console.WriteLine(Ulamki[i].ToString());
            }


            Console.WriteLine(drugi.RoundUp());
        }

        public class Ulamek : IEquatable<Ulamek>, IComparable<Ulamek>
        {
            private int licznik { get; }
            private int mianownik { get; }

            //konstruktor domyślny
            public Ulamek()
            {
                licznik = 1;
                mianownik = 2;
            }

            //konstruktor z dwoma argumentami
            public Ulamek(int licznik, int mianownik)
            {
                this.licznik = licznik;
                this.mianownik = mianownik;
            }

            //konstruktor kopiujacy
            public Ulamek(Ulamek PreviousUlamek)
            {
                licznik = PreviousUlamek.licznik;
                mianownik = PreviousUlamek.mianownik;
            }

            //toString
            public override string ToString()
            {
                return $"Ulamek:{this.licznik}/{this.mianownik} ";
            }


            public bool Equals(Ulamek other)
            {
                if (other == this) return true;
                if (other == null) return false;

                return licznik == other.licznik && mianownik == other.mianownik;
            }

            public int CompareTo(Ulamek other)
            {
                if (other == null) return -1;
                if (other == this) return 0;

                if (((double)this.licznik / (double)this.mianownik) > ((double)other.licznik / (double)other.mianownik)) return +1;
                if (((double)this.licznik / (double)this.mianownik) < ((double)other.licznik / (double)other.mianownik)) return -1;
                if (((double)this.licznik / (double)this.mianownik) == ((double)other.licznik / (double)other.mianownik)) return 0;
                return 0;
            }

            //przeciążenie operatorów
            public static Ulamek operator +(Ulamek x1, Ulamek x2) => new Ulamek(x1.licznik * x2.mianownik + x2.licznik * x1.mianownik, x1.mianownik * x2.mianownik);
            public static Ulamek operator -(Ulamek x1, Ulamek x2) => new Ulamek(x1.licznik * x2.mianownik - x2.licznik * x1.mianownik, x1.mianownik * x2.mianownik);
            public static Ulamek operator /(Ulamek x1, Ulamek x2) => new Ulamek(x2.licznik * x2.mianownik, x1.mianownik * x2.licznik);
            public static Ulamek operator *(Ulamek x1, Ulamek x2) => new Ulamek(x1.licznik * x2.licznik, x1.mianownik * x2.mianownik);


            public double RoundUp()
            {
                return Math.Ceiling((double)licznik / (double)mianownik);
            }

        }
    }
}
