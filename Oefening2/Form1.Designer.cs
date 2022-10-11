namespace Oefening2
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
            this.Koe = new System.Windows.Forms.CheckBox();
            this.Slang = new System.Windows.Forms.CheckBox();
            this.Varken = new System.Windows.Forms.CheckBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Koe
            // 
            this.Koe.AutoSize = true;
            this.Koe.Location = new System.Drawing.Point(29, 37);
            this.Koe.Name = "Koe";
            this.Koe.Size = new System.Drawing.Size(46, 19);
            this.Koe.TabIndex = 0;
            this.Koe.Text = "Koe";
            this.Koe.UseVisualStyleBackColor = true;
            // 
            // Slang
            // 
            this.Slang.AutoSize = true;
            this.Slang.Location = new System.Drawing.Point(29, 62);
            this.Slang.Name = "Slang";
            this.Slang.Size = new System.Drawing.Size(55, 19);
            this.Slang.TabIndex = 1;
            this.Slang.Text = "Slang";
            this.Slang.UseVisualStyleBackColor = true;
            // 
            // Varken
            // 
            this.Varken.AutoSize = true;
            this.Varken.Location = new System.Drawing.Point(29, 87);
            this.Varken.Name = "Varken";
            this.Varken.Size = new System.Drawing.Size(61, 19);
            this.Varken.TabIndex = 2;
            this.Varken.Text = "Varken";
            this.Varken.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(110, 130);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "Laat horen";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 200);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.Varken);
            this.Controls.Add(this.Slang);
            this.Controls.Add(this.Koe);
            this.Name = "Form1";
            this.Text = "DierApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox Koe;
        private CheckBox Slang;
        private CheckBox Varken;
        private Button btn1;
    }
}