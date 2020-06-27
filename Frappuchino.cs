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
    public partial class Frappuchino : Form
    {
        public List<Order> narachka { get; set; }
        
        
        public Frappuchino()
        {
            InitializeComponent();
            narachka = new List<Order>();
            cbSizeCaramel.SelectedIndex = 0;
            cbSizeChocolate.SelectedIndex = 0;
            cbSizeSmores.SelectedIndex = 0;
        }
        private bool btnChoco = false;
        private bool btnCaramel = false;
        private bool btnSmores = false;

        private void btnOrderChoco_Click(object sender, EventArgs e)
        {
            btnChoco = true;

            string notification = "You successfully ordered " + lblChocolate.Text + " " + cbSizeChocolate.SelectedItem.ToString() + "! Quantity: " + nudChocolate.Value.ToString();
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            string caption = "Order successful!";
            MessageBox.Show(notification, caption, buttons);
            
        }

        private void btnOrderSmores_Click(object sender, EventArgs e)
        {
            btnSmores = true;

            string notification = "You successfully ordered " + lblSmores.Text + " " + cbSizeSmores.SelectedItem.ToString() + "! Quantity: " + nudSmores.Value.ToString();
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            string caption = "Order successful!";
            MessageBox.Show(notification, caption, buttons);
        }

        private void btnOrderCaramel_Click(object sender, EventArgs e)
        {
            btnCaramel = true;

            string notification = "You successfully ordered " + lblCaramel.Text + " " + cbSizeCaramel.SelectedItem.ToString() + "! Quantity: " + nudCaramel.Value.ToString();
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            string caption = "Order successful!";
            MessageBox.Show(notification, caption, buttons);
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if(btnChoco)
            {
                float price = float.Parse(lblPriceChocolate.Text);
                narachka.Add(new Order(lblChocolate.Text, cbSizeChocolate.SelectedItem.ToString(), (int)nudChocolate.Value, price));
            }
            if (btnCaramel)
            {
                float price = float.Parse(lblPriceCaramel.Text);
                narachka.Add(new Order(lblCaramel.Text, cbSizeCaramel.SelectedItem.ToString(), (int)nudCaramel.Value, price));
            }
            if (btnSmores)
            {
                float price = float.Parse(lblPriceSmores.Text);
                narachka.Add(new Order(lblSmores.Text, cbSizeSmores.SelectedItem.ToString(), (int)nudSmores.Value, price));
            }
            this.Close();
        }

        private void cbSizeChocolate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSizeChocolate.SelectedIndex == 0)
            {
                lblPriceChocolate.Text = "3.80";
            }
            else if (cbSizeChocolate.SelectedIndex == 1)
            {
                lblPriceChocolate.Text = "4.60";
            }
            else if (cbSizeChocolate.SelectedIndex == 2)
            {
                lblPriceChocolate.Text = "5.50";
            }
            else lblPriceChocolate.Text = "";
        }

        private void cbSizeSmores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSizeSmores.SelectedIndex == 0)
            {
                lblPriceSmores.Text = "4.30";
            }
            else if (cbSizeSmores.SelectedIndex == 1)
            {
                lblPriceSmores.Text = "5.60";
            }
            else if (cbSizeSmores.SelectedIndex == 2)
            {
                lblPriceSmores.Text = "6.40";
            }
            else lblPriceSmores.Text = "";
        }

        private void cbSizeCaramel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSizeCaramel.SelectedIndex == 0)
            {
                lblPriceCaramel.Text = "3.90";
            }
            else if (cbSizeCaramel.SelectedIndex == 1)
            {
                lblPriceCaramel.Text = "4.70";
            }
            else if (cbSizeCaramel.SelectedIndex == 2)
            {
                lblPriceCaramel.Text = "5.60";
            }
            else lblPriceCaramel.Text = "";

        }

        private void pbChocolate_Click(object sender, EventArgs e)
        {

        }
    }
}
