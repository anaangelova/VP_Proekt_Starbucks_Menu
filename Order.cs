using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace VP_Proekt_Starbucks_Menu
{
    public class Order
    {
        public string stavka { get; set; }
        public int kolichina { get; set; }
        public float cena { get; set; }
        
        public Order(string stavka="",int kolichina=0, float cena=0)
        {
            this.stavka = stavka;
            this.kolichina = kolichina;
            this.cena = cena;
        }
        public override string ToString()
        {
            return string.Format("{0} x{1} quantity - ${2:0.00} total", stavka, kolichina, cena*kolichina);

        }
    }
}
