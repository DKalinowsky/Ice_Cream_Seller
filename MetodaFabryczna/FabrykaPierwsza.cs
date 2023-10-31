using System;
using System.Collections.Generic;
using System.Text;

namespace MetodaFabryczna
{
    public class FabrykaPierwsza: FabrykaLodow
    {
        public override Lody LodySpecjalnoscDnia(DzienTygodnia dzien)
        {
            switch (dzien)
            {
                case DzienTygodnia.Poniedziałek:
                    {
                        return new Sorbety(5, Losowanie(SmakiSorbety()));
                    }
                case DzienTygodnia.Wtorek:
                    {
                        return new Owocowe(4, Losowanie(SmakiOwocowe()), true, Losowanie(SmakiPolewOwocowe()));
                    }
                case DzienTygodnia.Środa:
                    {
                        return new Wloskie(7, Losowanie(SmakiWloskie()), false, false);
                    }
                case DzienTygodnia.Czwartek:
                    {
                        return new Sorbety(4, Losowanie(SmakiSorbety()));
                    }
                case DzienTygodnia.Piątek:
                    {
                        return new Sorbety(8, Losowanie(SmakiSorbety()));
                    }
                case DzienTygodnia.Sobota:
                    {
                        return new Wloskie(9, Losowanie(SmakiWloskie()), true, false);
                    }
                case DzienTygodnia.Niedziela:
                    {
                        return new Smietankowe(6, Losowanie(SmakiSmietankowe()), true, Losowanie(SmakiPolewSmietankowe()), true);
                    }
            }
            throw new System.SystemException("Error 404!");
        }
    }
}
