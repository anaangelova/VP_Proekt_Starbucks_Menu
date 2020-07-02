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
    public partial class Payment : Form
    {
        
        public Payment()
        {
            InitializeComponent();
            
        }
        private void Payment_Load(object sender, EventArgs e)
        {
            
        }

        private void Payment_Load_1(object sender, EventArgs e)
        {
            lblTotal.Text = Form1.SetValueForTb;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbCash.Enabled = true;
            tbCreditCard.Enabled = false;
            btnFinishPayment.Enabled = false;
            textBox1.Enabled = false;



        }

        private void tbCash_Enter(object sender, EventArgs e)
        {
           

        }

        private void tbCash_TextChanged(object sender, EventArgs e)
        {
            float cash = 0;
            float.TryParse(tbCash.Text, out cash);
            float price = 0;
            float.TryParse(lblTotal.Text, out price);
            if (cash < price)
            {
                lblMsgCash.Text = "Not enough money!";
                btnFinishPayment.Enabled = false;
            }
            else
            {
                float change = cash - price;
                lblMsgCash.Text = "Your change is $ " + change;
                btnFinishPayment.Enabled = true;
            }
            lblMsgCash.Visible = true;
        }

        private void btnFinishPayment_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Form1"].Close();

        }

        private void tbCreditCard_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbCreditCard.Enabled = true;
            tbCash.Enabled = false;
            btnFinishPayment.Enabled = false;
            textBox1.Enabled = true;

        }

        private void tbCreditCard_TextChanged(object sender, EventArgs e)
        {
            if (tbCreditCard.Text == string.Empty)
            {
                errorProvider1.SetError(tbCreditCard, "empty");
            }
            if (tbCreditCard.Text.Length != 16)
            {

                errorProvider1.SetError(tbCreditCard, "Credit card length must be 16 digits!");
                btnFinishPayment.Enabled = false;
            }
            else
            {
                errorProvider1.SetError(tbCreditCard, string.Empty);
                if (textBox1.Text.Length == 3)
                {
                    btnFinishPayment.Enabled = true;
                }
            }
        }

        private void tbCreditCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                errorProvider2.SetError(textBox1, "empty");
            }
            if (textBox1.Text.Length != 3)
            {

                errorProvider2.SetError(textBox1, "CVV must be 3 digits!");
                btnFinishPayment.Enabled = false;
            }
            else
            {
                errorProvider2.SetError(textBox1, string.Empty);
                if (tbCreditCard.Text.Length == 16)
                {
                    btnFinishPayment.Enabled = true;

                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
    }
}
