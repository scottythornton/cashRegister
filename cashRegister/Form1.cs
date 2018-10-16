using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cashRegister
{
    public partial class cashRegister : Form
    {

        const double jerseyprice = 70.00;
        const double shoesprice = 150.00;
        const double headbandprice = 10.00;
        const double tax = 0.13;
        int numberOfJerseys;
        int numberOfShoes;
        int numberOfHeadbands;
        double subtotal;
        double totalprice;
        double taxtotal;
        double tendered;
        double change;



        public cashRegister()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            numberOfJerseys = Convert.ToInt16(textBox1.Text);
            numberOfShoes = Convert.ToInt16(textBox2.Text);
            numberOfHeadbands = Convert.ToInt16(textBox3.Text);
            subtotal = numberOfJerseys * jerseyprice + numberOfShoes * shoesprice + numberOfHeadbands * headbandprice;
            taxtotal = subtotal * tax;
            totalprice = subtotal + taxtotal;
            

            subtotalOutputLabel.Text = subtotal.ToString("C");
            taxOutputLabel.Text = taxtotal.ToString("C");
            totalOutputLabel.Text = totalprice.ToString("C");
        }

        private void calculateChange_Click(object sender, EventArgs e)
        {
            tendered = Convert.ToDouble(textBox4.Text);
            change = tendered - totalprice;
            changeOutput.Text = change.ToString("C");

            Graphics g = this.CreateGraphics();
            SolidBrush brush = new SolidBrush(Color.Black);
            Pen drawPen = new Pen(Color.Black, 4);
            Font drawFont = new Font("Arial", 16, FontStyle.Bold);

            g.DrawRectangle(drawPen, 260, 30, 450, 400);

            g.DrawString("Jersey  x" + numberOfJerseys, drawFont, brush, 275, 40);
            g.DrawString("Shoes x" + numberOfShoes, drawFont, brush, 275, 70);
            g.DrawString("Headbands x" + numberOfHeadbands, drawFont, brush, 275, 100);
            g.DrawString("Sub Total " + subtotal.ToString("C"), drawFont, brush, 275, 160);
            g.DrawString("Tax " + taxtotal.ToString("C"), drawFont, brush, 275, 190);
            g.DrawString("Total " + totalprice.ToString("C"), drawFont, brush, 275, 220);
            g.DrawString("Tendered " + tendered.ToString("C"), drawFont, brush, 275, 280);
            g.DrawString("Change " + change.ToString("C"), drawFont, brush, 275, 310);
            g.DrawString("Have a Nice Day!", drawFont, brush, 275, 370);



        }

       
    }
}
  