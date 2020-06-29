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
    public partial class Bakery : Form
    {
        public List<Order> narachka { get; set; }
        public Bakery()
        {
            InitializeComponent();
            narachka = new List<Order>();
        }

        private bool btnM = false;
        private bool btnC = false;
        private bool btnV = false;

        private void btnMuffin_Click(object sender, EventArgs e)
        {
            btnM = true;

            string notification = "You successfully ordered " + lblMuffin.Text + "! Quantity: " + nudMuffin.Value.ToString();
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            string caption = "Order successful!";
            MessageBox.Show(notification, caption, buttons);
        }

        private void btnCroissant_Click(object sender, EventArgs e)
        {
            btnC = true;

            string notification = "You successfully ordered " + lblCroissant.Text + "! Quantity: " + nudCroissant.Value.ToString();
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            string caption = "Order successful!";
            MessageBox.Show(notification, caption, buttons);
        }

        private void btnBagel_Click(object sender, EventArgs e)
        {
            btnV = true;

            string notification = "You successfully ordered " + lblBagel.Text + "! Quantity: " + nudBagel.Value.ToString();
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            string caption = "Order successful!";
            MessageBox.Show(notification, caption, buttons);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (btnM)
            {
                float price = float.Parse(lblPriceMuffin.Text);
                narachka.Add(new Order(lblMuffin.Text, "", (int)nudMuffin.Value, price));
            }
            if (btnC)
            {
                float price = float.Parse(lblPriceCroissant.Text);
                narachka.Add(new Order(lblCroissant.Text, "", (int)nudCroissant.Value, price));
            }
            if (btnV)
            {
                float price = float.Parse(lblPriceBagel.Text);
                narachka.Add(new Order(lblBagel.Text, "", (int)nudBagel.Value, price));
            }
            this.Close();
        }
    }
}
