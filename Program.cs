using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop1 = new Laptop();
            laptop1.LaptopBrand = "Dell";
            laptop1.LaptopInch = 15.6;
            laptop1.LaptopColour = "White";

            Laptop laptop2 = new Laptop();
            laptop2.LaptopBrand = "Apple";
            laptop2.LaptopInch = 14;
            laptop2.LaptopColour = "Space Grey";

            Laptop laptop3 = new Laptop();
            laptop3.LaptopBrand = "HP";
            laptop3.LaptopInch = 17;
            laptop3.LaptopColour = "Black";

            Laptop[] laptops = new Laptop[] { laptop1, laptop2, laptop3 };

            //for
            for (int i = 0; i < laptops.Length; i++)
            {
                Console.WriteLine(laptops[i].LaptopBrand);
            }

            //foreach
            foreach (var laptop in laptops)
            {
                Console.WriteLine(laptop.LaptopBrand + ", " + laptop.LaptopColour);
            }

            int j = 0;

            //while
            while (j < laptops.Length)
            {
                Console.WriteLine(laptops[j].LaptopInch);
                j++;
            }

            Console.ReadKey();
        }

        class Laptop
        {
            public string LaptopBrand { get; set; }
            public double LaptopInch { get; set; }
            public string LaptopColour { get; set; }
        }
    }
}
