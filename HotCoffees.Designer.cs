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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCappuccino = new System.Windows.Forms.Button();
            this.lblPriceCap = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbSizeCapp = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.nudCappuccino = new System.Windows.Forms.NumericUpDown();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEspresso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCappuccino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLatte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEspresso
            // 
            this.lblEspresso.AutoSize = true;
            this.lblEspresso.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspresso.ForeColor = System.Drawing.Color.Sienna;
            this.lblEspresso.Location = new System.Drawing.Point(52, 11);
            this.lblEspresso.Name = "lblEspresso";
            this.lblEspresso.Size = new System.Drawing.Size(89, 24);
            this.lblEspresso.TabIndex = 0;
            this.lblEspresso.Text = "Espresso";
            // 
            // lblCappuccino
            // 
            this.lblCappuccino.AutoSize = true;
            this.lblCappuccino.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCappuccino.ForeColor = System.Drawing.Color.Sienna;
            this.lblCappuccino.Location = new System.Drawing.Point(38, 11);
            this.lblCappuccino.Name = "lblCappuccino";
            this.lblCappuccino.Size = new System.Drawing.Size(112, 24);
            this.lblCappuccino.TabIndex = 4;
            this.lblCappuccino.Text = "Cappuccino";
            // 
            // lblLatte
            // 
            this.lblLatte.AutoSize = true;
            this.lblLatte.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLatte.ForeColor = System.Drawing.Color.Sienna;
            this.lblLatte.Location = new System.Drawing.Point(59, 9);
            this.lblLatte.Name = "lblLatte";
            this.lblLatte.Size = new System.Drawing.Size(49, 24);
            this.lblLatte.TabIndex = 9;
            this.lblLatte.Text = "Latte";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
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
            this.comboBox1.Location = new System.Drawing.Point(61, 206);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(103, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(152, 411);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(358, 30);
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
            this.panel1.Location = new System.Drawing.Point(29, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 379);
            this.panel1.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(53, 317);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 17);
            this.label11.TabIndex = 13;
            this.label11.Text = "$";
            // 
            // btnEspresso
            // 
            this.btnEspresso.BackColor = System.Drawing.Color.LightGray;
            this.btnEspresso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEspresso.Location = new System.Drawing.Point(91, 337);
            this.btnEspresso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEspresso.Name = "btnEspresso";
            this.btnEspresso.Size = new System.Drawing.Size(76, 28);
            this.btnEspresso.TabIndex = 10;
            this.btnEspresso.Text = "Add Order";
            this.btnEspresso.UseVisualStyleBackColor = false;
            this.btnEspresso.Click += new System.EventHandler(this.btnEspresso_Click);
            // 
            // lblPriceEsp
            // 
            this.lblPriceEsp.AutoSize = true;
            this.lblPriceEsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceEsp.Location = new System.Drawing.Point(72, 317);
            this.lblPriceEsp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPriceEsp.Name = "lblPriceEsp";
            this.lblPriceEsp.Size = new System.Drawing.Size(40, 17);
            this.lblPriceEsp.TabIndex = 9;
            this.lblPriceEsp.Text = "2,20";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 318);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 15);
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
            this.cbSizeEsp.Location = new System.Drawing.Point(18, 283);
            this.cbSizeEsp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbSizeEsp.Name = "cbSizeEsp";
            this.cbSizeEsp.Size = new System.Drawing.Size(129, 21);
            this.cbSizeEsp.TabIndex = 7;
            this.cbSizeEsp.SelectedIndexChanged += new System.EventHandler(this.cbSizeEsp_SelectedIndexChanged_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 266);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 15);
            this.label13.TabIndex = 6;
            this.label13.Text = "Size:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(16, 228);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 15);
            this.label14.TabIndex = 5;
            this.label14.Text = "Quantity:";
            // 
            // nudEspresso
            // 
            this.nudEspresso.Location = new System.Drawing.Point(18, 245);
            this.nudEspresso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.nudEspresso.Size = new System.Drawing.Size(128, 20);
            this.nudEspresso.TabIndex = 4;
            this.nudEspresso.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VP_Proekt_Starbucks_Menu.Properties.Resources.EspressoShots;
            this.pictureBox1.Location = new System.Drawing.Point(18, 42);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.panel2.Location = new System.Drawing.Point(240, 20);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(177, 379);
            this.panel2.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 317);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "$";
            // 
            // btnCappuccino
            // 
            this.btnCappuccino.BackColor = System.Drawing.Color.LightGray;
            this.btnCappuccino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCappuccino.Location = new System.Drawing.Point(91, 337);
            this.btnCappuccino.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCappuccino.Name = "btnCappuccino";
            this.btnCappuccino.Size = new System.Drawing.Size(76, 28);
            this.btnCappuccino.TabIndex = 10;
            this.btnCappuccino.Text = "Add Order";
            this.btnCappuccino.UseVisualStyleBackColor = false;
            this.btnCappuccino.Click += new System.EventHandler(this.btnCappuccino_Click);
            // 
            // lblPriceCap
            // 
            this.lblPriceCap.AutoSize = true;
            this.lblPriceCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceCap.Location = new System.Drawing.Point(72, 317);
            this.lblPriceCap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPriceCap.Name = "lblPriceCap";
            this.lblPriceCap.Size = new System.Drawing.Size(40, 17);
            this.lblPriceCap.TabIndex = 9;
            this.lblPriceCap.Text = "3,40";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 318);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 15);
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
            this.cbSizeCapp.Location = new System.Drawing.Point(18, 283);
            this.cbSizeCapp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbSizeCapp.Name = "cbSizeCapp";
            this.cbSizeCapp.Size = new System.Drawing.Size(129, 21);
            this.cbSizeCapp.TabIndex = 7;
            this.cbSizeCapp.SelectedIndexChanged += new System.EventHandler(this.cbSizeCapp_SelectedIndexChanged_1);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(16, 266);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 15);
            this.label15.TabIndex = 6;
            this.label15.Text = "Size:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(16, 228);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 15);
            this.label16.TabIndex = 5;
            this.label16.Text = "Quantity:";
            // 
            // nudCappuccino
            // 
            this.nudCappuccino.Location = new System.Drawing.Point(18, 245);
            this.nudCappuccino.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.nudCappuccino.Size = new System.Drawing.Size(128, 20);
            this.nudCappuccino.TabIndex = 4;
            this.nudCappuccino.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::VP_Proekt_Starbucks_Menu.Properties.Resources.CaffeCappuccino;
            this.pictureBox2.Location = new System.Drawing.Point(18, 41);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(142, 163);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
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
            this.panel3.Location = new System.Drawing.Point(451, 20);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(177, 379);
            this.panel3.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 317);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "$";
            // 
            // btnLatte
            // 
            this.btnLatte.BackColor = System.Drawing.Color.LightGray;
            this.btnLatte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLatte.Location = new System.Drawing.Point(91, 337);
            this.btnLatte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLatte.Name = "btnLatte";
            this.btnLatte.Size = new System.Drawing.Size(76, 28);
            this.btnLatte.TabIndex = 10;
            this.btnLatte.Text = "Add Order";
            this.btnLatte.UseVisualStyleBackColor = false;
            this.btnLatte.Click += new System.EventHandler(this.btnLatte_Click);
            // 
            // lblPrLatte
            // 
            this.lblPrLatte.AutoSize = true;
            this.lblPrLatte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrLatte.Location = new System.Drawing.Point(72, 317);
            this.lblPrLatte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrLatte.Name = "lblPrLatte";
            this.lblPrLatte.Size = new System.Drawing.Size(40, 17);
            this.lblPrLatte.TabIndex = 9;
            this.lblPrLatte.Text = "4,20";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 318);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
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
            this.cbSizeLatte.Location = new System.Drawing.Point(16, 283);
            this.cbSizeLatte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbSizeLatte.Name = "cbSizeLatte";
            this.cbSizeLatte.Size = new System.Drawing.Size(129, 21);
            this.cbSizeLatte.TabIndex = 7;
            this.cbSizeLatte.SelectedIndexChanged += new System.EventHandler(this.cbSizeLatte_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 266);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Size:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(14, 228);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 15);
            this.label17.TabIndex = 5;
            this.label17.Text = "Quantity:";
            // 
            // nudLatte
            // 
            this.nudLatte.Location = new System.Drawing.Point(16, 245);
            this.nudLatte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.nudLatte.Size = new System.Drawing.Size(128, 20);
            this.nudLatte.TabIndex = 4;
            this.nudLatte.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::VP_Proekt_Starbucks_Menu.Properties.Resources.LatteCaffe5;
            this.pictureBox3.Location = new System.Drawing.Point(20, 40);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(142, 163);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // HotCoffees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(656, 458);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HotCoffees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HotCoffees";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEspresso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCappuccino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLatte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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