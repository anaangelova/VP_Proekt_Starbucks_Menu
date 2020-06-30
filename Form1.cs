﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Proekt_Starbucks_Menu
{

    public partial class Form1 : Form
    {
        public static string SetValueForTb = "";
        


        public Form1()
        {
            InitializeComponent();
            tbTotal.Text = "0";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pbHotCoffee_Click(object sender, EventArgs e)
        {
            
            HotCoffees forma = new HotCoffees();
            forma.ShowDialog();
            
            float price = 0;
            foreach(var el in forma.narachka)
            {
                listBox1.Items.Add(el);
                price += el.cena * el.kolichina;

                
            }
            float old = float.Parse(tbTotal.Text);
            float newTotal = old + price;
            tbTotal.Text =newTotal.ToString();
            
           
           

        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string item = listBox1.SelectedItem.ToString();
                string output=item.Substring(item.IndexOf("$")).Replace("$", "");
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                float oldPrice = float.Parse(tbTotal.Text);
                float newPrice = oldPrice - float.Parse(output);
                tbTotal.Text = newPrice.ToString();

            }

           
        }

        private void pbFrapp_Click(object sender, EventArgs e)
        {
            Frappuchino forma2 = new Frappuchino();
            forma2.ShowDialog();

            float price = 0;
            foreach(var el in forma2.narachka)
            {
                listBox1.Items.Add(el);
                price += el.cena*el.kolichina;
            }
            float old = float.Parse(tbTotal.Text);
            float newTotal = old + price;
            tbTotal.Text =newTotal.ToString();
        }
        private void removeEl()
        {
         
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void pbColdCoffee_Click(object sender, EventArgs e)
        {
            ColdCoffees forma3 = new ColdCoffees();
            forma3.ShowDialog();

            float price = 0;
            foreach (var el in forma3.narachka)
            {
                listBox1.Items.Add(el);
                price += el.cena * el.kolichina;
            }
            float old = float.Parse(tbTotal.Text);
            float newTotal = old + price;
            tbTotal.Text = newTotal.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pbColdDrinks_Click(object sender, EventArgs e)
        {
            ColdDrinks forma4 = new ColdDrinks();
            forma4.ShowDialog();

            float price = 0;
            foreach (var el in forma4.narachka)
            {
                listBox1.Items.Add(el);
                price += el.cena * el.kolichina;
            }
            float old = float.Parse(tbTotal.Text);
            float newTotal = old + price;
            tbTotal.Text = newTotal.ToString();
            
        }

        private void pbSand_Click(object sender, EventArgs e)
        {
            Sandwiches forma5 = new Sandwiches();
            forma5.ShowDialog();

            float price = 0;
            foreach (var el in forma5.narachka)
            {
                listBox1.Items.Add(el);
                price += el.cena * el.kolichina;
            }
            float old = float.Parse(tbTotal.Text);
            float newTotal = old + price;
            tbTotal.Text = newTotal.ToString();
        }

        private void pbDessert_Click(object sender, EventArgs e)
        {
            Bakery forma6 = new Bakery();
            forma6.ShowDialog();

            float price = 0;
            foreach (var el in forma6.narachka)
            {
                listBox1.Items.Add(el);
                price += el.cena * el.kolichina;
            }
            float old = float.Parse(tbTotal.Text);
            float newTotal = old + price;
            tbTotal.Text = newTotal.ToString();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            SetValueForTb = tbTotal.Text;
            Payment pay = new Payment();
            pay.Show();
        }
    }
}
