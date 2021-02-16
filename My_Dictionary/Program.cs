using System;

namespace My_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<<<<< Plakalar ve Iller >>>>>");
            Console.WriteLine(" ");

            My_Dictionary<int, string> license_Plate = new My_Dictionary<int, string>();
            license_Plate.Add(14, " Bolu");
            license_Plate.Add(06, " Ankara");
            license_Plate.Add(34, " Istanbul");
            license_Plate.Add(07, " Antalya");
            license_Plate.Add(35, " Izmir");

            license_Plate.List();
            Console.WriteLine(" ");
            Console.WriteLine(">>>>> Liste Toplamı <<<<<");
            Console.WriteLine(license_Plate.Count());
        }
    }
}
