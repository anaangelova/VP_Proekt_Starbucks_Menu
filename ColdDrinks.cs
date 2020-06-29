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
    public partial class ColdDrinks : Form
    {
        public List<Order> narachka { get; set; }

        public ColdDrinks()
        {
            InitializeComponent();
            narachka = new List<Order>();
            cbPineapple.SelectedIndex = 0;
            cbDragon.SelectedIndex = 0;
            cbLemonade.SelectedIndex = 0;
        }

        private bool btnP = false;
        private bool btnD = false;
        private bool btnL = false;
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnP = true;

            string notification = "You successfully ordered " + lblPineappleMatcha.Text + " " + cbPineapple.SelectedItem.ToString() + "! Quantity: " + nudPineapple.Value.ToString();
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            string caption = "Order successful!";
            MessageBox.Show(notification, caption, buttons);
        }

        private void btnDragon_Click(object sender, EventArgs e)
        {
            btnD = true;

            string notification = "You successfully ordered " + lblDragonDrink.Text + " " + cbDragon.SelectedItem.ToString() + "! Quantity: " + nudDragon.Value.ToString();
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            string caption = "Order successful!";
            MessageBox.Show(notification, caption, buttons);

        }

        private void btnLemonade_Click(object sender, EventArgs e)
        {
            btnL = true;

            string notification = "You successfully ordered " + lblLemonade.Text + " " + cbLemonade.SelectedItem.ToString() + "! Quantity: " + nudLemonade.Value.ToString();
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            string caption = "Order successful!";
            MessageBox.Show(notification, caption, buttons);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (btnP)
            {
                float price = float.Parse(lblPricePineapple.Text);
                narachka.Add(new Order(lblPineappleMatcha.Text, cbPineapple.SelectedItem.ToString(), (int)nudPineapple.Value, price));
            }
            if (btnD)
            {
                float price = float.Parse(lblPriceDragon.Text);
                narachka.Add(new Order(lblDragonDrink.Text, cbDragon.SelectedItem.ToString(), (int)nudDragon.Value, price));
            }
            if (btnL)
            {
                float price = float.Parse(lblPriceLemonade.Text);
                narachka.Add(new Order(lblLemonade.Text, cbLemonade.SelectedItem.ToString(), (int)nudLemonade.Value, price));
            }
            this.Close();
        }

        private void cbPineapple_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPineapple.SelectedIndex == 0)
            {
                lblPricePineapple.Text = "3.50";
            }
            else if (cbPineapple.SelectedIndex == 1)
            {
                lblPricePineapple.Text = "4.20";
            }
            else if (cbPineapple.SelectedIndex == 2)
            {
                lblPricePineapple.Text = "5.20";
            }
            else lblPricePineapple.Text = "";

        }

        private void cbDragon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDragon.SelectedIndex == 0)
            {
                lblPriceDragon.Text = "3.70";
            }
            else if (cbDragon.SelectedIndex == 1)
            {
                lblPriceDragon.Text = "4.65";
            }
            else if (cbDragon.SelectedIndex == 2)
            {
                lblPriceDragon.Text = "5.00";
            }
            else lblPriceDragon.Text = "";

        }

        private void cbLemonade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLemonade.SelectedIndex == 0)
            {
                lblPriceLemonade.Text = "2.90";
            }
            else if (cbLemonade.SelectedIndex == 1)
            {
                lblLemonade.Text = "3.55";
            }
            else if (cbLemonade.SelectedIndex == 2)
            {
                lblPriceLemonade.Text = "4.30";
            }
            else lblPriceLemonade.Text = "";

        }
    }
}
