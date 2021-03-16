using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР0_Проект
{
    class Firma
    {
        private string nazvan = new string(' ', 20);
        private string adres = new string(' ', 20);
        private int god;
        public Firma()
        {
            this.nazvan = "ОДО Глупый программист";
            this.adres = "Октябрьская 57";
            this.god = 2021;
        }
        public Firma(string nazva, string adre, int go)
        {
            this.nazvan = nazva;
            this.adres = adre;
            this.god = go;

        }
        public string Nazvanie
        {
            set
            {
                nazvan = value;
            }
        }
        public string Adres
        {
            set
            {
                adres = value;
            }
        }
        public float GOD
        {
            set
            {
                god = Convert.ToInt32(value);
            }
        }
        public void GetInfo()
        {
            Console.WriteLine("Название -  {0}; адрес - {1}; Год основания - {2}.", nazvan, adres, god);
        }
    }
}
