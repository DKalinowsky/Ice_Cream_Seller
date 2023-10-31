using System;
using System.Collections.Generic;
using System.Text;

namespace MetodaFabryczna
{
    public class SprzedawcaLodow
    {
        private FabrykaLodow fabrykaLodow;
        public string ReklamujSpecjalnoscDnia(DzienTygodnia dzien)
        {
            return "Dzisiaj jest: "+ dzien+ "\n"+"W tym dniu naszą specjalnością są:\n"+ fabrykaLodow.LodySpecjalnoscDnia(dzien).Opis();

        }
        public SprzedawcaLodow(FabrykaLodow _fabrykaLodow)
        {
            fabrykaLodow = _fabrykaLodow;
        }
         
    }
}
