using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace biuro
{
    interface IZarzadzaj
    {
        void DodajAutobus(int iloscMiejsc);
        void DodajPociag(int iloscMiejsc, int długoscTrasy);
        void UsunOstatni();
        void Wyczysc();
    }
}
