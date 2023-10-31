using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace MetodaFabryczna
{
    public abstract class FabrykaLodow
    {
        protected Random random;
        protected FabrykaLodow()
        {
            random = new Random();
        }
        public abstract Lody LodySpecjalnoscDnia(DzienTygodnia dzien);
        protected string[] SmakiSmietankowe()
        {
            return new string[] { "smietankowym" };
        }

        protected string[] SmakiPolewSmietankowe()
        {
            return new string[] { "czekoladową", "ze słonego karmelu", "z pianek", "z bitej śmietany" };
        }

        protected string[] SmakiWloskie()
        {
            return new string[] { "smietankowym", "czekoladowym" };
        }

        protected string[] SmakiSorbety()
        {
            return new string[] { "truskawkowym", "jagodowym", "malinowym" };
        }

        protected string[] SmakiOwocowe()
        {
            return new string[] { "truskawkowym", "malinowym" };
        }

        protected string[] SmakiPolewOwocowe()
        {
            return new string[] { "czekoladową", "śmietankową" };
        }
        
        protected string Losowanie(string[] doLosowania)
        {
            int index = random.Next(doLosowania.Count());
            return doLosowania[index];
        }
    }
}
