using System;

namespace MetodaFabryczna
{
    class Program
    {
        static void Main(string[] args)
        {
            FabrykaPierwsza fabrykaPierwsza = new FabrykaPierwsza();
            FabrykaDruga fabrykaDruga = new FabrykaDruga();
            SprzedawcaLodow sprzedawcaLodow = new SprzedawcaLodow(fabrykaPierwsza);
            Console.WriteLine(sprzedawcaLodow.ReklamujSpecjalnoscDnia(DzienTygodnia.Poniedziałek));
            Console.WriteLine(sprzedawcaLodow.ReklamujSpecjalnoscDnia(DzienTygodnia.Wtorek));
            Console.WriteLine(sprzedawcaLodow.ReklamujSpecjalnoscDnia(DzienTygodnia.Środa));
            sprzedawcaLodow = new SprzedawcaLodow(fabrykaDruga);
            Console.WriteLine(sprzedawcaLodow.ReklamujSpecjalnoscDnia(DzienTygodnia.Czwartek));
            Console.WriteLine(sprzedawcaLodow.ReklamujSpecjalnoscDnia(DzienTygodnia.Piątek));
            
        }
    }
}
