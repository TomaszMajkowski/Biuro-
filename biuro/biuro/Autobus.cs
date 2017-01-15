using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace biuro
{
    class Autobus : SrodekLokomocji
    {
        public Autobus(int iloscMiejsc)
        {
            base.iloscMiejsc = iloscMiejsc;
            base.ObliczCene();
        }

        public override string ToString() //metoda zwracająca informacje o produkcie
        {
            return "Autobus: " + "Ilosc miejsc " + iloscMiejsc + " Cena biletu " + cenaBiletu;
        }
    }
}
