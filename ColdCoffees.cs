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
    public partial class ColdCoffees : Form
    {
        public List<Order> narachka { get; set; }

        public ColdCoffees()
        {
            InitializeComponent();
            narachka = new List<Order>();
            cbBrew.SelectedIndex = 0;
            cbAmericano.SelectedIndex = 0;
            cbFlatWhite.SelectedIndex = 0;
        }

        private bool btnB = false;
        private bool btnA = false;
        private bool btnFW = false;

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void lblPriceBrew_Click(object sender, EventArgs e)
        {

        }
        private void btnBrew_Click_1(object sender, EventArgs e)
        {
            btnB = true;

            string notification = "You successfully ordered " + lblColdBrew.Text + " " + cbBrew.SelectedItem.ToString() + "! Quantity: " + nudBrew.Value.ToString();
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            string caption = "Order successful!";
            MessageBox.Show(notification, caption, buttons);
        }

        private void btnAmericano_Click_1(object sender, EventArgs e)
        {
            btnA = true;

            string notification = "You successfully ordered " + lblAmericano.Text + " " + cbAmericano.SelectedItem.ToString() + "! Quantity: " + nudAmericano.Value.ToString();
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            string caption = "Order successful!";
            MessageBox.Show(notification, caption, buttons);
        }

        private void btnFlatWhite_Click_1(object sender, EventArgs e)
        {
            btnFW = true;

            string notification = "You successfully ordered " + lblFlatWhite.Text + " " + cbFlatWhite.SelectedItem.ToString() + "! Quantity: " + nudFlatWhite.Value.ToString();
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            string caption = "Order successful!";
            MessageBox.Show(notification, caption, buttons);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (btnB)
            {
                float price = float.Parse(lblPriceBrew.Text);
                narachka.Add(new Order(lblColdBrew.Text, cbBrew.SelectedItem.ToString(), (int)nudBrew.Value, price));
            }
            if (btnA)
            {
                float price = float.Parse(lblPriceAmericano.Text);
                narachka.Add(new Order(lblAmericano.Text, cbAmericano.SelectedItem.ToString(), (int)nudAmericano.Value, price));
            }
            if (btnFW)
            {
                float price = float.Parse(lblPriceFlatWhite.Text);
                narachka.Add(new Order(lblFlatWhite.Text, cbFlatWhite.SelectedItem.ToString(), (int)nudFlatWhite.Value, price));
            }
            this.Close();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cbBrew_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBrew.SelectedIndex == 0)
            {
                lblPriceBrew.Text = "2.20";
            }
            else if (cbBrew.SelectedIndex == 1)
            {
                lblPriceBrew.Text = "3.40";
            }
            else if (cbBrew.SelectedIndex == 2)
            {
                lblPriceBrew.Text = "4.70";
            }
            else lblPriceBrew.Text = "";
        }

        private void cbAmericano_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAmericano.SelectedIndex == 0)
            {
                lblPriceAmericano.Text = "2.70";
            }
            else if (cbAmericano.SelectedIndex == 1)
            {
                lblPriceAmericano.Text = "3.60";
            }
            else if (cbAmericano.SelectedIndex == 2)
            {
                lblPriceAmericano.Text = "4.90";
            }
            else lblPriceAmericano.Text = "";
        }

        private void cbFlatWhite_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFlatWhite.SelectedIndex == 0)
            {
                lblPriceFlatWhite.Text = "3.75";
            }
            else if (cbFlatWhite.SelectedIndex == 1)
            {
                lblPriceFlatWhite.Text = "4.90";
            }
            else if (cbFlatWhite.SelectedIndex == 2)
            {
                lblPriceFlatWhite.Text = "5.65";
            }
            else lblPriceFlatWhite.Text = "";
        }
    }
}
