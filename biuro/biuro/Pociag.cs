using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace biuro
{
    class Pociag : SrodekLokomocji
    {
        private int dlugoscTrasy;

        public override void ObliczCene()
        {
            if (this.dlugoscTrasy > 100)
                base.cenaBiletu = dlugoscTrasy * 1.43;
            else 
                base.cenaBiletu = 62;
        }

         public Pociag (int dlugoscTrasy, int iloscMiejsc) 
         {
             base.iloscMiejsc = iloscMiejsc;
             this.dlugoscTrasy = dlugoscTrasy;
             this.ObliczCene();
         }
        }
    }
