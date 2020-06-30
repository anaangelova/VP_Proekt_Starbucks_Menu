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
        public Form1 form1 { get; set; }
        public HotCoffees()
        {
            InitializeComponent();
            narachka = new List<Order>();
            cbSizeCapp.SelectedIndex = 0;
            cbSizeEsp.SelectedIndex = 0;
            cbSizeLatte.SelectedIndex = 0;
            form1 = new Form1();

        }

        private bool btnCoffeeC = false;
        private bool btnCappuccinoC = false;
        private bool btnLatteC = false;
       
        private void lblPrLatte_Click(object sender, EventArgs e)
        {

        }

        private void btnEspresso_Click(object sender, EventArgs e)
        {
            btnCoffeeC = true;

            string notification = "You successfully ordered " + lblEspresso.Text + " " + cbSizeEsp.SelectedItem.ToString() + "! Quantity: " + nudEspresso.Value.ToString();
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            string caption = "Order successful!";
            MessageBox.Show(notification, caption, buttons);
        }

        private void btnCappuccino_Click(object sender, EventArgs e)
        {
            btnCappuccinoC = true;

            string notification = "You successfully ordered " + lblCappuccino.Text + " " + cbSizeCapp.SelectedItem.ToString() + "! Quantity: " + nudCappuccino.Value.ToString();
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            string caption = "Order successful!";
            MessageBox.Show(notification, caption, buttons);
        }

        private void btnLatte_Click(object sender, EventArgs e)
        {
            btnLatteC = true;
            string notification = "";
            string caption = "";
            if (comboBox1.SelectedIndex != -1)
            {
                notification = "You successfully ordered " + lblLatte.Text + " " + cbSizeLatte.SelectedItem.ToString() + " " + comboBox1.SelectedItem.ToString() + "! Quantity: " + nudLatte.Value.ToString();
                caption = "Order successful!";
            }
            else
            {
                notification = "You need to pick a flavour!";
                caption = "Order not successful!";
            }

            MessageBoxButtons buttons = MessageBoxButtons.OK;

            MessageBox.Show(notification, caption, buttons);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (btnCappuccinoC)
            {
                float price = float.Parse(lblPriceCap.Text);
                narachka.Add(new Order(lblCappuccino.Text, cbSizeCapp.SelectedItem.ToString(), (int)nudCappuccino.Value, price));


            }
            if (btnCoffeeC)
            {
                float price = float.Parse(lblPriceEsp.Text);
                narachka.Add(new Order(lblEspresso.Text, cbSizeEsp.SelectedItem.ToString(), (int)nudEspresso.Value, price));

            }

            if (changed && btnLatteC)
            {
                comboBox1_SelectedIndexChanged(sender, e);
            }
            this.Close();
        }


        bool changed = false;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            changed = true;
            float price = float.Parse(lblPrLatte.Text);
            narachka.Add(new Order(lblLatte.Text + " " + comboBox1.SelectedItem.ToString(), cbSizeLatte.SelectedItem.ToString(), (int)nudLatte.Value, price));
            btnLatteC = false;
            changed = false;
        }

        private void cbSizeEsp_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbSizeEsp.SelectedIndex == 0)
            {
                lblPriceEsp.Text = "2,50";
            }
            else if (cbSizeEsp.SelectedIndex == 1)
            {
                lblPriceEsp.Text = "3,20";
            }
            else if (cbSizeEsp.SelectedIndex == 2)
            {
                lblPriceEsp.Text = "3,90";
            }
            else lblPriceEsp.Text = "";
        }

        private void cbSizeCapp_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbSizeCapp.SelectedIndex == 0)
            {
                lblPriceCap.Text = "3,10";
            }
            else if (cbSizeCapp.SelectedIndex == 1)
            {
                lblPriceCap.Text = "4,10";
            }
            else if (cbSizeCapp.SelectedIndex == 2)
            {
                lblPriceCap.Text = "4,90";
            }
            else lblPriceCap.Text = "";
        }

        private void cbSizeLatte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSizeLatte.SelectedIndex == 0)
            {
                lblPrLatte.Text = "3,40";
            }
            else if (cbSizeLatte.SelectedIndex == 1)
            {
                lblPrLatte.Text = "4,30";
            }
            else if (cbSizeLatte.SelectedIndex == 2)
            {
                lblPrLatte.Text = "5,10";
            }
            else lblPrLatte.Text = "";
        }
    }
}
