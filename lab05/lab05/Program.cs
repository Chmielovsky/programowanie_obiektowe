using System;

namespace lab05
{
    public delegate void Print();
    public delegate int Max(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {

           

            /* lambda
             
            Max max = (int a, int b) =>
            {
                if (a > b)
                {
                    return a;
                }
                else return b;
            };
            */

            //funkcja anonimowa (chyba) to samo co u góry czyli delegaty
            Max max = delegate (int a, int b)
            {
                if (a > b)
                {
                    return a;
                }
                else return b;
            };


            Console.WriteLine(max(3, 5));

            /*
            Print print2 = delegate ()
            {
                Console.WriteLine("anon deleg");
            };

            print2();
            */

            Printer printer = new Printer();

            printer.print = () =>
             {
                 Console.WriteLine("wiadomosc");
             };

            

        }
    }

    class Printer
    {
        public Print print;
        public void Print()
        {
            if (this.print != null)
                this.print();
        }
    }

    class Zajecia
    {
        public event EventHandler wiadomosc;

        public void PrzekazWiadomosc()
        {
            if (this.wiadomosc != null)
                this.wiadomosc(this, new EventArgs());

        }
    }


}
