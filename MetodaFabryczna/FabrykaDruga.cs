using System;
using System.Collections.Generic;
using System.Text;

namespace MetodaFabryczna
{
    public class FabrykaDruga: FabrykaLodow
    {
        public override Lody LodySpecjalnoscDnia(DzienTygodnia dzien)
        {
            switch (dzien)
            {
                case DzienTygodnia.Poniedziałek:
                    {
                        return new Owocowe(10, Losowanie(SmakiOwocowe()), true, Losowanie(SmakiPolewOwocowe()));
                    }
                case DzienTygodnia.Wtorek:
                    {
                        return new Smietankowe(11, Losowanie(SmakiSmietankowe()), true, Losowanie(SmakiPolewSmietankowe()), true);
                    }
                case DzienTygodnia.Środa:
                    {
                        return new Owocowe(15, Losowanie(SmakiOwocowe()), true, Losowanie(SmakiPolewOwocowe()));
                    }
                case DzienTygodnia.Czwartek:
                    {
                        return new Smietankowe(12, Losowanie(SmakiSmietankowe()), true, Losowanie(SmakiPolewSmietankowe()), true);
                    }
                case DzienTygodnia.Piątek:
                    {
                        return new Owocowe(11, Losowanie(SmakiOwocowe()), true, Losowanie(SmakiPolewOwocowe()));
                    }
                case DzienTygodnia.Sobota:
                    {
                        return new Smietankowe(19, Losowanie(SmakiSmietankowe()), false, Losowanie(SmakiPolewSmietankowe()), true);
                    }
                case DzienTygodnia.Niedziela:
                    {
                        return new Wloskie(18, Losowanie(SmakiWloskie()), true, true);

                    }
            }
            throw new System.SystemException("Error 404!");
        }
    }
}
