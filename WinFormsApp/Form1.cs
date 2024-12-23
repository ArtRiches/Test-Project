using System.Diagnostics;
using System.Globalization;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {

        public static void CalcPrices(decimal inputPriceWithNDS, decimal procNDS, out decimal correctedPriceWithNDS, out decimal correctedPriceWithoutNDS)
        {
            NumberFormatInfo style = new NumberFormatInfo() { NumberDecimalSeparator = "." };

            decimal minusStart = Math.Round(inputPriceWithNDS / (1 + procNDS / 100), 2, MidpointRounding.AwayFromZero);
            decimal plusStart = minusStart;

            decimal minusCorrectedPriceWithNDS;
            decimal plusCorrectedPriceWithNDS;

            while (true)
            {
                
                minusCorrectedPriceWithNDS = minusStart * (1 + procNDS / 100);

                
                if (minusCorrectedPriceWithNDS.ToString(style).Split('.')[1].TrimEnd('0').Length <= 2)
                {
                    break;
                }
                else { minusStart -= 0.01m; };

                if (minusStart <= 0) { break; }
            };

          
            while (true)
            {
               
                plusCorrectedPriceWithNDS = plusStart * (1 + procNDS / 100);

               
                if (plusCorrectedPriceWithNDS.ToString(style).Split('.')[1].TrimEnd('0').Length <= 2)
                {
                    break;
                }
                else { plusStart += 0.01m; };

                

            };

            minusCorrectedPriceWithNDS = Math.Round(minusStart * (1 + procNDS / 100), 2, MidpointRounding.AwayFromZero);
            plusCorrectedPriceWithNDS = Math.Round(plusStart * (1 + procNDS / 100), 2, MidpointRounding.AwayFromZero);

            if (minusStart == 0) {
                correctedPriceWithoutNDS = plusStart;
                correctedPriceWithNDS = plusCorrectedPriceWithNDS;
            } else
            {
                if (Math.Abs(inputPriceWithNDS - plusCorrectedPriceWithNDS) < Math.Abs(inputPriceWithNDS - minusCorrectedPriceWithNDS))
                {
                    correctedPriceWithoutNDS = plusStart;
                    correctedPriceWithNDS = plusCorrectedPriceWithNDS;
                }
                else
                {
                    correctedPriceWithoutNDS = minusStart;
                    correctedPriceWithNDS = minusCorrectedPriceWithNDS;
                }
            }
        }



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NumberFormatInfo style = new NumberFormatInfo() { NumberDecimalSeparator = "." };

            decimal inputPriceWithNDS = decimal.Parse(this.inputPriceWithNDS.Text, style);
            decimal procNDS = decimal.Parse(this.ProcNDS.Text, style);

            decimal correctedPriceWithNDS, correctedPriceWithoutNDS;
            CalcPrices(inputPriceWithNDS, procNDS, out correctedPriceWithNDS, out correctedPriceWithoutNDS);

            label4.Text = correctedPriceWithNDS.ToString(style);
            label5.Text = correctedPriceWithoutNDS.ToString(style);
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
