using System;
using System.Collections.Generic;
using System.Text;

namespace MetodaFabryczna
{
    public class Owocowe : Lody
    {
        public bool wafle;
        public string polewa;
        

        public Owocowe(int _cena, string _smak, bool _wafle, string _polewa) : base(_cena, _smak)
        {
            wafle = _wafle;
            polewa = _polewa;
            
        }

        public override string Opis()
        {
            string opis = string.Empty;
            if (wafle == true) opis = opis + " podawane w waflu ";
            return("Lody owocowe w cenie: " + cena + " PLN, o smaku: " + smak + opis + " wraz z polewą: "+ polewa);

        }

    }
}
