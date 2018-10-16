namespace cashRegister
{
    partial class cashRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cashRegister));
            this.jerseyPrice = new System.Windows.Forms.Label();
            this.shoesPrice = new System.Windows.Forms.Label();
            this.headbandPrice = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.subTotal = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.subtotalOutputLabel = new System.Windows.Forms.Label();
            this.taxOutputLabel = new System.Windows.Forms.Label();
            this.totalOutputLabel = new System.Windows.Forms.Label();
            this.calculateChange = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // jerseyPrice
            // 
            this.jerseyPrice.AutoSize = true;
            this.jerseyPrice.Location = new System.Drawing.Point(22, 27);
            this.jerseyPrice.Name = "jerseyPrice";
            this.jerseyPrice.Size = new System.Drawing.Size(45, 13);
            this.jerseyPrice.TabIndex = 0;
            this.jerseyPrice.Text = "Jerseys ";
            // 
            // shoesPrice
            // 
            this.shoesPrice.AutoSize = true;
            this.shoesPrice.Location = new System.Drawing.Point(22, 63);
            this.shoesPrice.Name = "shoesPrice";
            this.shoesPrice.Size = new System.Drawing.Size(40, 13);
            this.shoesPrice.TabIndex = 1;
            this.shoesPrice.Text = "Shoes ";
            // 
            // headbandPrice
            // 
            this.headbandPrice.AutoSize = true;
            this.headbandPrice.Location = new System.Drawing.Point(22, 99);
            this.headbandPrice.Name = "headbandPrice";
            this.headbandPrice.Size = new System.Drawing.Size(65, 13);
            this.headbandPrice.TabIndex = 2;
            this.headbandPrice.Text = "Headbands ";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(41, 135);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(118, 33);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(93, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(94, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(93, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(94, 96);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(93, 20);
            this.textBox3.TabIndex = 6;
            // 
            // subTotal
            // 
            this.subTotal.AutoSize = true;
            this.subTotal.Location = new System.Drawing.Point(22, 198);
            this.subTotal.Name = "subTotal";
            this.subTotal.Size = new System.Drawing.Size(53, 13);
            this.subTotal.TabIndex = 7;
            this.subTotal.Text = "Sub Total";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(22, 231);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(25, 13);
            this.taxLabel.TabIndex = 8;
            this.taxLabel.Text = "Tax";
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
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Location = new System.Drawing.Point(22, 305);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(53, 13);
            this.tenderedLabel.TabIndex = 10;
            this.tenderedLabel.Text = "Tendered";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(123, 302);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(115, 20);
            this.textBox4.TabIndex = 11;
            // 
            // subtotalOutputLabel
            // 
            this.subtotalOutputLabel.AutoSize = true;
            this.subtotalOutputLabel.BackColor = System.Drawing.Color.Transparent;
            this.subtotalOutputLabel.Location = new System.Drawing.Point(87, 198);
            this.subtotalOutputLabel.Name = "subtotalOutputLabel";
            this.subtotalOutputLabel.Size = new System.Drawing.Size(0, 13);
            this.subtotalOutputLabel.TabIndex = 12;
            // 
            // taxOutputLabel
            // 
            this.taxOutputLabel.AutoSize = true;
            this.taxOutputLabel.Location = new System.Drawing.Point(62, 231);
            this.taxOutputLabel.Name = "taxOutputLabel";
            this.taxOutputLabel.Size = new System.Drawing.Size(0, 13);
            this.taxOutputLabel.TabIndex = 13;
            // 
            // totalOutputLabel
            // 
            this.totalOutputLabel.AutoSize = true;
            this.totalOutputLabel.Location = new System.Drawing.Point(62, 263);
            this.totalOutputLabel.Name = "totalOutputLabel";
            this.totalOutputLabel.Size = new System.Drawing.Size(0, 13);
            this.totalOutputLabel.TabIndex = 14;
            // 
            // calculateChange
            // 
            this.calculateChange.Location = new System.Drawing.Point(25, 338);
            this.calculateChange.Name = "calculateChange";
            this.calculateChange.Size = new System.Drawing.Size(213, 34);
            this.calculateChange.TabIndex = 15;
            this.calculateChange.Text = "Calculate Change";
            this.calculateChange.UseVisualStyleBackColor = true;
            this.calculateChange.Click += new System.EventHandler(this.calculateChange_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Location = new System.Drawing.Point(23, 389);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(44, 13);
            this.changeLabel.TabIndex = 16;
            this.changeLabel.Text = "Change";
            // 
            // changeOutput
            // 
            this.changeOutput.AutoSize = true;
            this.changeOutput.Location = new System.Drawing.Point(75, 389);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(0, 13);
            this.changeOutput.TabIndex = 17;
            // 
            // cashRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.calculateChange);
            this.Controls.Add(this.totalOutputLabel);
            this.Controls.Add(this.taxOutputLabel);
            this.Controls.Add(this.subtotalOutputLabel);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.total);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subTotal);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.headbandPrice);
            this.Controls.Add(this.shoesPrice);
            this.Controls.Add(this.jerseyPrice);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cashRegister";
            this.Text = "Cash Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label jerseyPrice;
        private System.Windows.Forms.Label shoesPrice;
        private System.Windows.Forms.Label headbandPrice;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label subTotal;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label subtotalOutputLabel;
        private System.Windows.Forms.Label taxOutputLabel;
        private System.Windows.Forms.Label totalOutputLabel;
        private System.Windows.Forms.Button calculateChange;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label changeOutput;
    }
}

