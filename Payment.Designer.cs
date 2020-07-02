namespace VP_Proekt_Starbucks_Menu
{
    partial class Payment
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCash = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCreditCard = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCash = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMsgCash = new System.Windows.Forms.Label();
            this.btnFinishPayment = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCreditCard = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(113, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "YOUR TOTAL ORDER IS:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotal.Location = new System.Drawing.Point(218, 38);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(76, 25);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(196, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "$";
            // 
            // btnCash
            // 
            this.btnCash.Location = new System.Drawing.Point(55, 96);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(153, 23);
            this.btnCash.TabIndex = 3;
            this.btnCash.Text = "CASH";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 6;
            // 
            // btnCreditCard
            // 
            this.btnCreditCard.Location = new System.Drawing.Point(273, 96);
            this.btnCreditCard.Name = "btnCreditCard";
            this.btnCreditCard.Size = new System.Drawing.Size(153, 23);
            this.btnCreditCard.TabIndex = 7;
            this.btnCreditCard.Text = "CREDIT CARD";
            this.btnCreditCard.UseVisualStyleBackColor = true;
            this.btnCreditCard.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(19, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Enter cash:";
            // 
            // tbCash
            // 
            this.tbCash.Enabled = false;
            this.tbCash.Location = new System.Drawing.Point(26, 162);
            this.tbCash.Name = "tbCash";
            this.tbCash.Size = new System.Drawing.Size(100, 20);
            this.tbCash.TabIndex = 9;
            this.tbCash.TextChanged += new System.EventHandler(this.tbCash_TextChanged);
            this.tbCash.Enter += new System.EventHandler(this.tbCash_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "$";
            // 
            // lblMsgCash
            // 
            this.lblMsgCash.AutoSize = true;
            this.lblMsgCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMsgCash.Location = new System.Drawing.Point(2, 185);
            this.lblMsgCash.Name = "lblMsgCash";
            this.lblMsgCash.Size = new System.Drawing.Size(51, 20);
            this.lblMsgCash.TabIndex = 11;
            this.lblMsgCash.Text = "label7";
            this.lblMsgCash.Visible = false;
            // 
            // btnFinishPayment
            // 
            this.btnFinishPayment.Enabled = false;
            this.btnFinishPayment.Location = new System.Drawing.Point(71, 283);
            this.btnFinishPayment.Name = "btnFinishPayment";
            this.btnFinishPayment.Size = new System.Drawing.Size(345, 23);
            this.btnFinishPayment.TabIndex = 12;
            this.btnFinishPayment.Text = "OK";
            this.btnFinishPayment.UseVisualStyleBackColor = true;
            this.btnFinishPayment.Click += new System.EventHandler(this.btnFinishPayment_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(243, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Enter credit card #:";
            // 
            // tbCreditCard
            // 
            this.tbCreditCard.Enabled = false;
            this.tbCreditCard.Location = new System.Drawing.Point(247, 163);
            this.tbCreditCard.Name = "tbCreditCard";
            this.tbCreditCard.Size = new System.Drawing.Size(179, 20);
            this.tbCreditCard.TabIndex = 14;
            this.tbCreditCard.TextChanged += new System.EventHandler(this.tbCreditCard_TextChanged);
            this.tbCreditCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCreditCard_KeyPress);
            this.tbCreditCard.Validating += new System.ComponentModel.CancelEventHandler(this.tbCreditCard_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(247, 219);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(243, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Enter CVV:";
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 318);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbCreditCard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFinishPayment);
            this.Controls.Add(this.lblMsgCash);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbCash);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCreditCard);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Name = "Payment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCreditCard;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCash;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMsgCash;
        private System.Windows.Forms.Button btnFinishPayment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCreditCard;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}