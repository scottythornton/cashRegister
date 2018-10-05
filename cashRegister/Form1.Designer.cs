namespace cashRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.burger = new System.Windows.Forms.Label();
            this.fries = new System.Windows.Forms.Label();
            this.drinks = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.subTotal = new System.Windows.Forms.Label();
            this.tax = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // burger
            // 
            this.burger.AutoSize = true;
            this.burger.Location = new System.Drawing.Point(22, 27);
            this.burger.Name = "burger";
            this.burger.Size = new System.Drawing.Size(95, 13);
            this.burger.TabIndex = 0;
            this.burger.Text = "Number of Burgers";
            // 
            // fries
            // 
            this.fries.AutoSize = true;
            this.fries.Location = new System.Drawing.Point(22, 63);
            this.fries.Name = "fries";
            this.fries.Size = new System.Drawing.Size(81, 13);
            this.fries.TabIndex = 1;
            this.fries.Text = "Number of Fries";
            // 
            // drinks
            // 
            this.drinks.AutoSize = true;
            this.drinks.Location = new System.Drawing.Point(22, 99);
            this.drinks.Name = "drinks";
            this.drinks.Size = new System.Drawing.Size(89, 13);
            this.drinks.TabIndex = 2;
            this.drinks.Text = "Number of Drinks";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(41, 135);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(118, 33);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(93, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(123, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(93, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(123, 96);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(93, 20);
            this.textBox3.TabIndex = 6;
            // 
            // subTotal
            // 
            this.subTotal.AutoSize = true;
            this.subTotal.Location = new System.Drawing.Point(22, 197);
            this.subTotal.Name = "subTotal";
            this.subTotal.Size = new System.Drawing.Size(53, 13);
            this.subTotal.TabIndex = 7;
            this.subTotal.Text = "Sub Total";
            // 
            // tax
            // 
            this.tax.AutoSize = true;
            this.tax.Location = new System.Drawing.Point(22, 231);
            this.tax.Name = "tax";
            this.tax.Size = new System.Drawing.Size(25, 13);
            this.tax.TabIndex = 8;
            this.tax.Text = "Tax";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(22, 263);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(31, 13);
            this.total.TabIndex = 9;
            this.total.Text = "Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.total);
            this.Controls.Add(this.tax);
            this.Controls.Add(this.subTotal);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.drinks);
            this.Controls.Add(this.fries);
            this.Controls.Add(this.burger);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cash Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label burger;
        private System.Windows.Forms.Label fries;
        private System.Windows.Forms.Label drinks;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label subTotal;
        private System.Windows.Forms.Label tax;
        private System.Windows.Forms.Label total;
    }
}

