using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace biuro
{
    class Podroz : IZarzadzaj , IData
    {
        private DateTime dataPodrozy;
        private List<SrodekLokomocji> planPodrozy = new List<SrodekLokomocji>();
        private double koszt = 0;

        public void DodajAutobus(int iloscMiejsc) //metoda dodająca wagon osobowy do składu pociągu
        {
            planPodrozy.Add(new Autobus(iloscMiejsc));
            koszt += planPodrozy[planPodrozy.Count].Cena();
        }

        public void DodajPociag(int iloscMiejsc, int długoscTrasy) //metoda dodająca wagon osobowy do składu pociągu
        {
            planPodrozy.Add(new Pociag(iloscMiejsc, długoscTrasy));
            koszt += planPodrozy[planPodrozy.Count].Cena();
        }

        public void UsunOstatni()
        {
            planPodrozy.RemoveAt(planPodrozy.Count - 1);
            koszt += planPodrozy[planPodrozy.Count - 1].Cena();
        }   
        public void Wyczysc()
        {
            planPodrozy.Clear();
            koszt = 0;
        }

        public void UstawDate(DateTime data)
        {
            this.dataPodrozy = data;
        }

        public bool SprawdzDate()
        {
            return (dataPodrozy > DateTime.Now) ? true : false;
        }

        public override string ToString()
        {
            string temp = "";
            foreach (Object obj in planPodrozy)
            {
                temp += obj.ToString() + "\n";
            }
            if (temp == "")
            return "Brak elementów w planie podrozy";
            return temp;
        }

    }
}
