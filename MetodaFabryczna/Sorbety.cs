using System;
using System.Collections.Generic;
using System.Text;

namespace MetodaFabryczna
{
    public class Sorbety : Lody
    {
        public Sorbety(int _cena, string _smak) : base(_cena, _smak)
        {
         
        }

        public override string Opis()
        {

            return("Lody sorbetowe w cenie: " + cena + " PLN, o smaku: " + smak);

        }

    }
}
