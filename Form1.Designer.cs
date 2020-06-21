namespace VP_Proekt_Starbucks_Menu
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDrinks = new System.Windows.Forms.Label();
            this.lblHot = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.order = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pbDessert = new System.Windows.Forms.PictureBox();
            this.pbSand = new System.Windows.Forms.PictureBox();
            this.pbColdDrinks = new System.Windows.Forms.PictureBox();
            this.pbFrapp = new System.Windows.Forms.PictureBox();
            this.pbColdCoffee = new System.Windows.Forms.PictureBox();
            this.pbHotCoffee = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.order.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDessert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColdDrinks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFrapp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColdCoffee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHotCoffee)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTitle.Location = new System.Drawing.Point(205, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(445, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "STARBUCKS DRIVE-THRU MENU";
            // 
            // lblDrinks
            // 
            this.lblDrinks.AutoSize = true;
            this.lblDrinks.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lblDrinks.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDrinks.ForeColor = System.Drawing.Color.Coral;
            this.lblDrinks.Location = new System.Drawing.Point(149, 55);
            this.lblDrinks.Name = "lblDrinks";
            this.lblDrinks.Size = new System.Drawing.Size(83, 31);
            this.lblDrinks.TabIndex = 1;
            this.lblDrinks.Text = "Drinks";
            // 
            // lblHot
            // 
            this.lblHot.AutoSize = true;
            this.lblHot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHot.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblHot.Location = new System.Drawing.Point(34, 103);
            this.lblHot.Name = "lblHot";
            this.lblHot.Size = new System.Drawing.Size(104, 24);
            this.lblHot.TabIndex = 3;
            this.lblHot.Text = "Hot coffees";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(34, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cold coffees";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.LightCoral;
            this.label2.Location = new System.Drawing.Point(223, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Frappuccinos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label3.Location = new System.Drawing.Point(235, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cold drinks";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(516, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "Food";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label5.Location = new System.Drawing.Point(484, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Sandwiches ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(504, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Desserts";
            // 
            // order
            // 
            this.order.Controls.Add(this.btnPay);
            this.order.Controls.Add(this.tbTotal);
            this.order.Controls.Add(this.label7);
            this.order.Controls.Add(this.listBox1);
            this.order.Location = new System.Drawing.Point(637, 78);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(228, 245);
            this.order.TabIndex = 15;
            this.order.TabStop = false;
            this.order.Text = "Total order";
            // 
            // listBox1
            // 
            this.listBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(216, 121);
            this.listBox1.TabIndex = 0;
            // 
            // pbDessert
            // 
            this.pbDessert.Image = global::VP_Proekt_Starbucks_Menu.Properties.Resources.muffin1;
            this.pbDessert.Location = new System.Drawing.Point(429, 326);
            this.pbDessert.Name = "pbDessert";
            this.pbDessert.Size = new System.Drawing.Size(200, 150);
            this.pbDessert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbDessert.TabIndex = 13;
            this.pbDessert.TabStop = false;
            // 
            // pbSand
            // 
            this.pbSand.Image = global::VP_Proekt_Starbucks_Menu.Properties.Resources.sandwitch;
            this.pbSand.Location = new System.Drawing.Point(462, 130);
            this.pbSand.Name = "pbSand";
            this.pbSand.Size = new System.Drawing.Size(150, 150);
            this.pbSand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbSand.TabIndex = 11;
            this.pbSand.TabStop = false;
            // 
            // pbColdDrinks
            // 
            this.pbColdDrinks.Image = global::VP_Proekt_Starbucks_Menu.Properties.Resources.WTN150713_Starbucks_Iced_Tea_Sparkling_Passion_Tango_Tea_Pineapple1;
            this.pbColdDrinks.Location = new System.Drawing.Point(226, 326);
            this.pbColdDrinks.Name = "pbColdDrinks";
            this.pbColdDrinks.Size = new System.Drawing.Size(113, 150);
            this.pbColdDrinks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbColdDrinks.TabIndex = 8;
            this.pbColdDrinks.TabStop = false;
            // 
            // pbFrapp
            // 
            this.pbFrapp.Image = global::VP_Proekt_Starbucks_Menu.Properties.Resources.frappuccino;
            this.pbFrapp.Location = new System.Drawing.Point(211, 130);
            this.pbFrapp.Name = "pbFrapp";
            this.pbFrapp.Size = new System.Drawing.Size(150, 150);
            this.pbFrapp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbFrapp.TabIndex = 7;
            this.pbFrapp.TabStop = false;
            // 
            // pbColdCoffee
            // 
            this.pbColdCoffee.Image = global::VP_Proekt_Starbucks_Menu.Properties.Resources.coldd;
            this.pbColdCoffee.Location = new System.Drawing.Point(12, 333);
            this.pbColdCoffee.Name = "pbColdCoffee";
            this.pbColdCoffee.Size = new System.Drawing.Size(149, 143);
            this.pbColdCoffee.TabIndex = 5;
            this.pbColdCoffee.TabStop = false;
            // 
            // pbHotCoffee
            // 
            this.pbHotCoffee.Image = global::VP_Proekt_Starbucks_Menu.Properties.Resources.hott;
            this.pbHotCoffee.ImageLocation = "";
            this.pbHotCoffee.Location = new System.Drawing.Point(12, 130);
            this.pbHotCoffee.Name = "pbHotCoffee";
            this.pbHotCoffee.Size = new System.Drawing.Size(150, 150);
            this.pbHotCoffee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbHotCoffee.TabIndex = 2;
            this.pbHotCoffee.TabStop = false;
            this.pbHotCoffee.Click += new System.EventHandler(this.pbHotCoffee_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Total price:";
            // 
            // tbTotal
            // 
            this.tbTotal.Enabled = false;
            this.tbTotal.Location = new System.Drawing.Point(60, 154);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(100, 20);
            this.tbTotal.TabIndex = 2;
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(23, 200);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(137, 23);
            this.btnPay.TabIndex = 3;
            this.btnPay.Text = "PAY NOW";
            this.btnPay.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 497);
            this.Controls.Add(this.order);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pbDessert);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbSand);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbColdDrinks);
            this.Controls.Add(this.pbFrapp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbColdCoffee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHot);
            this.Controls.Add(this.pbHotCoffee);
            this.Controls.Add(this.lblDrinks);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.order.ResumeLayout(false);
            this.order.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDessert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColdDrinks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFrapp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColdCoffee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHotCoffee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDrinks;
        private System.Windows.Forms.PictureBox pbHotCoffee;
        private System.Windows.Forms.Label lblHot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbColdCoffee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbFrapp;
        private System.Windows.Forms.PictureBox pbColdDrinks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbSand;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbDessert;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox order;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPay;
    }
}

