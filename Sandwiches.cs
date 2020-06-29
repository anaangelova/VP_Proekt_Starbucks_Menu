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
    public partial class Sandwiches : Form
    {
        public List<Order> narachka { get; set; }

        public Sandwiches()
        {
            InitializeComponent();
            narachka = new List<Order>();
        }

        private bool btnTM = false;
        private bool btnI = false;
        private bool btnBa = false;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btnDragon_Click(object sender, EventArgs e)
        {
            btnTM = true;

            string notification = "You successfully ordered " + lblTM.Text + "! Quantity: " + nudTM.Value.ToString();
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            string caption = "Order successful!";
            MessageBox.Show(notification, caption, buttons);
        }

        private void btnImpossible_Click(object sender, EventArgs e)
        {
            btnI = true;

            string notification = "You successfully ordered " + lblImpossible.Text + "! Quantity: " + nudImpossible.Value.ToString();
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            string caption = "Order successful!";
            MessageBox.Show(notification, caption, buttons);
        }

        private void btnBacon_Click(object sender, EventArgs e)
        {
            btnBa = true;

            string notification = "You successfully ordered " + lblBacon.Text + "! Quantity: " + nudBacon.Value.ToString();
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            string caption = "Order successful!";
            MessageBox.Show(notification, caption, buttons);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (btnTM)
            {
                float price = float.Parse(lblPriceTM.Text);
                narachka.Add(new Order(lblTM.Text, "", (int)nudTM.Value, price));
            }
            if (btnI)
            {
                float price = float.Parse(lblPriceImpossible.Text);
                narachka.Add(new Order(lblImpossible.Text, "", (int)nudImpossible.Value, price));
            }
            if (btnBa)
            {
                float price = float.Parse(lblPriceBacon.Text);
                narachka.Add(new Order(lblBacon.Text, "", (int)nudBacon.Value, price));
            }
            this.Close();
        }
    }
}
