using System;
using System.Collections.Generic;
using System.Text;

namespace MetodaFabryczna
{
    public class Wloskie: Lody
    {
        public bool wafle;
        public bool posypkaCzekoladowa;

        public Wloskie(int _cena, string _smak, bool _wafle, bool _posypkaCzekoladowa) : base(_cena, _smak)
        {
            wafle = _wafle;
            posypkaCzekoladowa = _posypkaCzekoladowa;
        }
        
        public override string Opis()
        {
            string opis = string.Empty;
            if (wafle == true) opis = opis + " podowane w waflu ";
            if (posypkaCzekoladowa == true) opis = opis + " oraz z posypką czekoladową ";
            return("Lody włoskie w cenie: " + cena + " PLN, o smaku: " + smak + opis) ;

        }

    }
}
