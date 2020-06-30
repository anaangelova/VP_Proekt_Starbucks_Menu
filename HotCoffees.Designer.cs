namespace VP_Proekt_Starbucks_Menu
{
    partial class HotCoffees
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
            this.lblEspresso = new System.Windows.Forms.Label();
            this.lblCappuccino = new System.Windows.Forms.Label();
            this.lblLatte = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.btnEspresso = new System.Windows.Forms.Button();
            this.lblPriceEsp = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbSizeEsp = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.nudEspresso = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCappuccino = new System.Windows.Forms.Button();
            this.lblPriceCap = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbSizeCapp = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.nudCappuccino = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLatte = new System.Windows.Forms.Button();
            this.lblPrLatte = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSizeLatte = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.nudLatte = new System.Windows.Forms.NumericUpDown();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEspresso)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCappuccino)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLatte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEspresso
            // 
            this.lblEspresso.AutoSize = true;
            this.lblEspresso.Font = new System.Drawing.Font("Permanent Marker", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspresso.ForeColor = System.Drawing.Color.Sienna;
            this.lblEspresso.Location = new System.Drawing.Point(69, 14);
            this.lblEspresso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEspresso.Name = "lblEspresso";
            this.lblEspresso.Size = new System.Drawing.Size(117, 35);
            this.lblEspresso.TabIndex = 0;
            this.lblEspresso.Text = "Espresso";
            // 
            // lblCappuccino
            // 
            this.lblCappuccino.AutoSize = true;
            this.lblCappuccino.Font = new System.Drawing.Font("Permanent Marker", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCappuccino.ForeColor = System.Drawing.Color.Sienna;
            this.lblCappuccino.Location = new System.Drawing.Point(50, 13);
            this.lblCappuccino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCappuccino.Name = "lblCappuccino";
            this.lblCappuccino.Size = new System.Drawing.Size(145, 35);
            this.lblCappuccino.TabIndex = 4;
            this.lblCappuccino.Text = "Cappuccino";
            // 
            // lblLatte
            // 
            this.lblLatte.AutoSize = true;
            this.lblLatte.Font = new System.Drawing.Font("Permanent Marker", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLatte.ForeColor = System.Drawing.Color.Sienna;
            this.lblLatte.Location = new System.Drawing.Point(79, 11);
            this.lblLatte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLatte.Name = "lblLatte";
            this.lblLatte.Size = new System.Drawing.Size(81, 35);
            this.lblLatte.TabIndex = 9;
            this.lblLatte.Text = "Latte";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 256);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Flavour:";
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Vanilla",
            "Chocolate",
            "Hazelnut",
            "Pumpkin Spice"});
            this.comboBox1.Location = new System.Drawing.Point(85, 253);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 24);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(202, 506);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(477, 37);
            this.btnClose.TabIndex = 31;
            this.btnClose.Text = "Finish";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnEspresso);
            this.panel1.Controls.Add(this.lblPriceEsp);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.cbSizeEsp);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.nudEspresso);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblEspresso);
            this.panel1.Location = new System.Drawing.Point(39, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 466);
            this.panel1.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(71, 390);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "$";
            // 
            // btnEspresso
            // 
            this.btnEspresso.BackColor = System.Drawing.Color.LightGray;
            this.btnEspresso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEspresso.Location = new System.Drawing.Point(121, 415);
            this.btnEspresso.Name = "btnEspresso";
            this.btnEspresso.Size = new System.Drawing.Size(102, 34);
            this.btnEspresso.TabIndex = 10;
            this.btnEspresso.Text = "Add Order";
            this.btnEspresso.UseVisualStyleBackColor = false;
            this.btnEspresso.Click += new System.EventHandler(this.btnEspresso_Click);
            // 
            // lblPriceEsp
            // 
            this.lblPriceEsp.AutoSize = true;
            this.lblPriceEsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceEsp.Location = new System.Drawing.Point(96, 390);
            this.lblPriceEsp.Name = "lblPriceEsp";
            this.lblPriceEsp.Size = new System.Drawing.Size(44, 20);
            this.lblPriceEsp.TabIndex = 9;
            this.lblPriceEsp.Text = "2.20";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(21, 392);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 18);
            this.label12.TabIndex = 8;
            this.label12.Text = "Price: ";
            // 
            // cbSizeEsp
            // 
            this.cbSizeEsp.FormattingEnabled = true;
            this.cbSizeEsp.Items.AddRange(new object[] {
            "Tall",
            "Grande",
            "Venti"});
            this.cbSizeEsp.Location = new System.Drawing.Point(24, 348);
            this.cbSizeEsp.Name = "cbSizeEsp";
            this.cbSizeEsp.Size = new System.Drawing.Size(171, 24);
            this.cbSizeEsp.TabIndex = 7;
            this.cbSizeEsp.SelectedIndexChanged += new System.EventHandler(this.cbSizeEsp_SelectedIndexChanged_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(21, 327);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 18);
            this.label13.TabIndex = 6;
            this.label13.Text = "Size:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(21, 281);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 18);
            this.label14.TabIndex = 5;
            this.label14.Text = "Quantity:";
            // 
            // nudEspresso
            // 
            this.nudEspresso.Location = new System.Drawing.Point(24, 302);
            this.nudEspresso.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudEspresso.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEspresso.Name = "nudEspresso";
            this.nudEspresso.Size = new System.Drawing.Size(171, 22);
            this.nudEspresso.TabIndex = 4;
            this.nudEspresso.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnCappuccino);
            this.panel2.Controls.Add(this.lblPriceCap);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.cbSizeCapp);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.nudCappuccino);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.lblCappuccino);
            this.panel2.Location = new System.Drawing.Point(320, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 466);
            this.panel2.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "$";
            // 
            // btnCappuccino
            // 
            this.btnCappuccino.BackColor = System.Drawing.Color.LightGray;
            this.btnCappuccino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCappuccino.Location = new System.Drawing.Point(121, 415);
            this.btnCappuccino.Name = "btnCappuccino";
            this.btnCappuccino.Size = new System.Drawing.Size(102, 34);
            this.btnCappuccino.TabIndex = 10;
            this.btnCappuccino.Text = "Add Order";
            this.btnCappuccino.UseVisualStyleBackColor = false;
            this.btnCappuccino.Click += new System.EventHandler(this.btnCappuccino_Click);
            // 
            // lblPriceCap
            // 
            this.lblPriceCap.AutoSize = true;
            this.lblPriceCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceCap.Location = new System.Drawing.Point(96, 390);
            this.lblPriceCap.Name = "lblPriceCap";
            this.lblPriceCap.Size = new System.Drawing.Size(44, 20);
            this.lblPriceCap.TabIndex = 9;
            this.lblPriceCap.Text = "3.40";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 392);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "Price: ";
            // 
            // cbSizeCapp
            // 
            this.cbSizeCapp.FormattingEnabled = true;
            this.cbSizeCapp.Items.AddRange(new object[] {
            "Tall",
            "Grande",
            "Venti"});
            this.cbSizeCapp.Location = new System.Drawing.Point(24, 348);
            this.cbSizeCapp.Name = "cbSizeCapp";
            this.cbSizeCapp.Size = new System.Drawing.Size(171, 24);
            this.cbSizeCapp.TabIndex = 7;
            this.cbSizeCapp.SelectedIndexChanged += new System.EventHandler(this.cbSizeCapp_SelectedIndexChanged_1);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(21, 327);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 18);
            this.label15.TabIndex = 6;
            this.label15.Text = "Size:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(21, 281);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 18);
            this.label16.TabIndex = 5;
            this.label16.Text = "Quantity:";
            // 
            // nudCappuccino
            // 
            this.nudCappuccino.Location = new System.Drawing.Point(24, 302);
            this.nudCappuccino.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudCappuccino.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCappuccino.Name = "nudCappuccino";
            this.nudCappuccino.Size = new System.Drawing.Size(171, 22);
            this.nudCappuccino.TabIndex = 4;
            this.nudCappuccino.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnLatte);
            this.panel3.Controls.Add(this.lblPrLatte);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.cbSizeLatte);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.nudLatte);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.lblLatte);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(601, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(236, 466);
            this.panel3.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "$";
            // 
            // btnLatte
            // 
            this.btnLatte.BackColor = System.Drawing.Color.LightGray;
            this.btnLatte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLatte.Location = new System.Drawing.Point(121, 415);
            this.btnLatte.Name = "btnLatte";
            this.btnLatte.Size = new System.Drawing.Size(102, 34);
            this.btnLatte.TabIndex = 10;
            this.btnLatte.Text = "Add Order";
            this.btnLatte.UseVisualStyleBackColor = false;
            this.btnLatte.Click += new System.EventHandler(this.btnLatte_Click);
            // 
            // lblPrLatte
            // 
            this.lblPrLatte.AutoSize = true;
            this.lblPrLatte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrLatte.Location = new System.Drawing.Point(96, 390);
            this.lblPrLatte.Name = "lblPrLatte";
            this.lblPrLatte.Size = new System.Drawing.Size(44, 20);
            this.lblPrLatte.TabIndex = 9;
            this.lblPrLatte.Text = "4.20";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Price: ";
            // 
            // cbSizeLatte
            // 
            this.cbSizeLatte.FormattingEnabled = true;
            this.cbSizeLatte.Items.AddRange(new object[] {
            "Tall",
            "Grande",
            "Venti"});
            this.cbSizeLatte.Location = new System.Drawing.Point(24, 348);
            this.cbSizeLatte.Name = "cbSizeLatte";
            this.cbSizeLatte.Size = new System.Drawing.Size(171, 24);
            this.cbSizeLatte.TabIndex = 7;
            this.cbSizeLatte.SelectedIndexChanged += new System.EventHandler(this.cbSizeLatte_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 18);
            this.label9.TabIndex = 6;
            this.label9.Text = "Size:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(21, 281);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 18);
            this.label17.TabIndex = 5;
            this.label17.Text = "Quantity:";
            // 
            // nudLatte
            // 
            this.nudLatte.Location = new System.Drawing.Point(24, 302);
            this.nudLatte.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudLatte.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLatte.Name = "nudLatte";
            this.nudLatte.Size = new System.Drawing.Size(171, 22);
            this.nudLatte.TabIndex = 4;
            this.nudLatte.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::VP_Proekt_Starbucks_Menu.Properties.Resources.LatteCaffe3;
            this.pictureBox3.Location = new System.Drawing.Point(24, 49);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(190, 190);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::VP_Proekt_Starbucks_Menu.Properties.Resources.CaffeCappuccino;
            this.pictureBox2.Location = new System.Drawing.Point(24, 59);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(190, 201);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VP_Proekt_Starbucks_Menu.Properties.Resources.EspressoShots;
            this.pictureBox1.Location = new System.Drawing.Point(24, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // HotCoffees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(875, 564);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HotCoffees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HotCoffees";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEspresso)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCappuccino)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLatte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEspresso;
        private System.Windows.Forms.Label lblCappuccino;
        private System.Windows.Forms.Label lblLatte;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnEspresso;
        private System.Windows.Forms.Label lblPriceEsp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbSizeEsp;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown nudEspresso;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCappuccino;
        private System.Windows.Forms.Label lblPriceCap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbSizeCapp;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown nudCappuccino;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLatte;
        private System.Windows.Forms.Label lblPrLatte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSizeLatte;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown nudLatte;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}