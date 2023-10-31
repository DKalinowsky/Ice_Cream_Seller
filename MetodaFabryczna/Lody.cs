using System;
using System.Collections.Generic;
using System.Text;

namespace MetodaFabryczna
{
    public abstract class Lody
    {
        public int cena;
        public string smak;
       
        protected Lody(int _cena, string _smak)
        {
            cena = _cena;
            smak = _smak;
            
        }

        public abstract string Opis();

    }
}
