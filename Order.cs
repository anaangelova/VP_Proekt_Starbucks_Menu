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
        public string golemina { get; set; }
        
        public Order(string stavka="",string golemina="",int kolichina=0, float cena=0)
        {
            this.stavka = stavka;
            this.kolichina = kolichina;
            this.cena = cena;
            this.golemina = golemina;
        }
        public override string ToString()
        {
            return string.Format("{0} {1} x{2} quantity, total: ${3:0.00}", stavka,golemina, kolichina, cena*kolichina);

        }
    }
}
