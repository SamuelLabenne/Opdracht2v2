namespace Oefening3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bx_usd = new System.Windows.Forms.TextBox();
            this.bx_pound = new System.Windows.Forms.TextBox();
            this.bx_eur = new System.Windows.Forms.TextBox();
            this.bx_yen = new System.Windows.Forms.TextBox();
            this.bx_rupees = new System.Windows.Forms.TextBox();
            this.bx_franken = new System.Windows.Forms.TextBox();
            this.btn_convert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "U.S.Dollars";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "British Pounds";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Euro\'s";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Japanse Yen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Indiaanse Rupees";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Zwitserse Franken";
            // 
            // bx_usd
            // 
            this.bx_usd.Location = new System.Drawing.Point(203, 61);
            this.bx_usd.Name = "bx_usd";
            this.bx_usd.Size = new System.Drawing.Size(100, 23);
            this.bx_usd.TabIndex = 6;
            // 
            // bx_pound
            // 
            this.bx_pound.Location = new System.Drawing.Point(203, 96);
            this.bx_pound.Name = "bx_pound";
            this.bx_pound.Size = new System.Drawing.Size(100, 23);
            this.bx_pound.TabIndex = 7;
            // 
            // bx_eur
            // 
            this.bx_eur.Location = new System.Drawing.Point(203, 132);
            this.bx_eur.Name = "bx_eur";
            this.bx_eur.Size = new System.Drawing.Size(100, 23);
            this.bx_eur.TabIndex = 8;
            // 
            // bx_yen
            // 
            this.bx_yen.Location = new System.Drawing.Point(203, 165);
            this.bx_yen.Name = "bx_yen";
            this.bx_yen.Size = new System.Drawing.Size(100, 23);
            this.bx_yen.TabIndex = 9;
            // 
            // bx_rupees
            // 
            this.bx_rupees.Location = new System.Drawing.Point(203, 199);
            this.bx_rupees.Name = "bx_rupees";
            this.bx_rupees.Size = new System.Drawing.Size(100, 23);
            this.bx_rupees.TabIndex = 10;
            // 
            // bx_franken
            // 
            this.bx_franken.Location = new System.Drawing.Point(203, 235);
            this.bx_franken.Name = "bx_franken";
            this.bx_franken.Size = new System.Drawing.Size(100, 23);
            this.bx_franken.TabIndex = 11;
            // 
            // btn_convert
            // 
            this.btn_convert.Location = new System.Drawing.Point(182, 296);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(156, 32);
            this.btn_convert.TabIndex = 12;
            this.btn_convert.Text = "Convert";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 370);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.bx_franken);
            this.Controls.Add(this.bx_rupees);
            this.Controls.Add(this.bx_yen);
            this.Controls.Add(this.bx_eur);
            this.Controls.Add(this.bx_pound);
            this.Controls.Add(this.bx_usd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CurrencyConverter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox bx_usd;
        private TextBox bx_pound;
        private TextBox bx_eur;
        private TextBox bx_yen;
        private TextBox bx_rupees;
        private TextBox bx_franken;
        private Button btn_convert;
    }
}