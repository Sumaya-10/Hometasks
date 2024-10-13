namespace methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Area(5);
            Area(4, 5);
            Area(2, 3, 4);
            Area(2, 3, 4, 1);
            Name("Sumaya");
            Name("Mammadova", "Sumaya");
            Name("Mammadova", "Sumaya", "Niyazi");
            MyMetod(2);
            Metoda(2,3);
        }
        //Çevrənin sahəsi - S = p*r² (p=3)
        static void Area(int radius)
        {
            int p = 3;
            int s = p * radius * radius;
            Console.WriteLine("Cevrenin sahesi-S = " + " " + s);
        }
        //Düzbucaqlının sahəsi - S = a*b
        static void Area(int a, int b)
        {
            int s = a * b;
            Console.WriteLine("Duzbucaqlinin sahesi-S = " + " " + s);
        }
        //Düzbucaqlı paralelpipedin tam təhlükəsizliyinin sahəsi -S=2(a* b+a* c+b* c)
        static void Area(int en, int uzunluq, int hundurluk)
        {
            int s = en * uzunluq + en * hundurluk + uzunluq * hundurluk;
            Console.WriteLine("Duzbucaqli paralelpipedin tam tehlukesizliyinin sahesi -S = " + " " + s);
        }
        //p=(a+b+c)/2
        static void Area(int a, int b, int c, int d)
        {
            int s = (a + b + c) / 2 * d;
            Console.WriteLine("p=(a+b+c)/2 = " + " " + s);
        }
        //a taski
        static void Metoda(int a, int b, double d)
        {
            d = a * b;
            Console.WriteLine(d);
        }

        //b taski
        static void MyMetod(int a)
        {
            int b = a * a;
            Console.WriteLine("Ededin kvadrati;" + " " + b);
        }



        //c taski
        static void Name(string name)
        {
            Console.WriteLine("Name :" + " " + name);
        }
        static void Name(string surname, string name)
        {
            Console.WriteLine("Surame " + " " + "Name :" + " " + surname + " " + name);
        }
        static void Name(string surname, string name, string fathername)
        {
            Console.WriteLine("Surame " + " " + "Name " + "Fathername :" + " " + surname[0] + "." + " " + name + " " + fathername);
        }
    }
}

