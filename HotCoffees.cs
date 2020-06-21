using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Proekt_Starbucks_Menu
{
    public partial class HotCoffees : Form
    {
       
        public Order narachka { get; set; }
        public HotCoffees()
        {
            InitializeComponent();
        }
        private bool btnCoffeeC = false;
        private bool btnCappuccinoC = false;
        private bool btnLatteC = false;
        private void btnHotCoffee_Click(object sender, EventArgs e)
        {
            btnCoffeeC = true;
           // narachka = new Order(lblEspresso.Text, nudEspresso.Value.ToString());
           
        }


        private void btnCappuccino_Click(object sender, EventArgs e)
        {
            btnCappuccinoC = true;
           // narachka = new Order(lblCappuccino.Text, nudCappuccino.Value.ToString());
        }

        private void btnLatte_Click(object sender, EventArgs e)
        {
            btnLatteC = true;
            /*narachka = new Order(lblLatte.Text, nudLatte.Value.ToString());*/
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(btnCappuccinoC)
            {
                narachka = new Order(lblCappuccino.Text, nudCappuccino.Value.ToString());
            }
            if (btnCoffeeC)
            {
                narachka= new Order(lblEspresso.Text, nudEspresso.Value.ToString());
            }
            if(btnLatteC)
            {
                    narachka = new Order(lblLatte.Text, nudLatte.Value.ToString());
            }
            this.Close();
        }
    }
}
