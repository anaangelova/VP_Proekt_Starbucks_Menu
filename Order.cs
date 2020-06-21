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
        public string kolichina { get; set; }
        
        public Order(string stavka="",string kolichina="")
        {
            this.stavka = stavka;
            this.kolichina = kolichina;
        }
        public override string ToString()
        {
            return string.Format("{0} x{1} quantity", stavka, kolichina);

        }
    }
}
