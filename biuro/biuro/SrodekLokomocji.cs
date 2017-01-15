using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace biuro
{
    abstract class SrodekLokomocji
    {
        protected int iloscMiejsc;
        protected double cenaBiletu;

        public SrodekLokomocji()
        {
        }

        public virtual void ObliczCene()
        {
            this.cenaBiletu = this.iloscMiejsc * 3;
        }

        public double Cena()
        {
            return this.cenaBiletu;
        }
    }
}
