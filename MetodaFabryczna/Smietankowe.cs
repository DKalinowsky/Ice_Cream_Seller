using System;
using System.Collections.Generic;
using System.Text;

namespace MetodaFabryczna
{
    public class Smietankowe: Lody
    {
        public bool wafle;
        public string polewa;
        public bool posypkaCzekoladowa;
        
        public Smietankowe(int _cena, string _smak, bool _wafle, string _polewa, bool _posypkaCzekoladowa) : base(_cena, _smak)
        {
            wafle = _wafle;
            polewa = _polewa;
            posypkaCzekoladowa = _posypkaCzekoladowa;
        }

        public override string Opis()
        {
            string opis = string.Empty;
            if (wafle == true) opis = opis + " podawane w waflu ";
            if (posypkaCzekoladowa == true) opis = opis + " wraz z posypką czekoladową ";
            return ("Lody śmietankowe w cenie: " + cena + " PLN, o smaku: " + smak + opis + " + polewa " + polewa);

        }
    }
}
