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

        public List<Order> narachka { get; set; }
       
        public HotCoffees()
        {
            InitializeComponent();
            narachka = new List<Order>();
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
                float price = float.Parse(lblPriceCap.Text);
                narachka.Add(new Order(lblCappuccino.Text, (int)nudCappuccino.Value,price));
                
               
            }
            if (btnCoffeeC)
            {
                float price = float.Parse(lblPriceEsp.Text);
                narachka.Add(new Order(lblEspresso.Text, (int)nudEspresso.Value,price));
                
            }
            
            if (changed && btnLatteC)
            {
                comboBox1_SelectedIndexChanged(sender, e);
            }
            this.Close();
        }

        private void lblPrLatte_Click(object sender, EventArgs e)
        {

        }
        bool changed = false;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                changed = true;
                float price = float.Parse(lblPrLatte.Text);
                narachka.Add(new Order(lblLatte.Text + " " + comboBox1.SelectedItem.ToString(), (int)nudLatte.Value, price));
                btnLatteC = false;
                changed = false;
        }
    }
}
