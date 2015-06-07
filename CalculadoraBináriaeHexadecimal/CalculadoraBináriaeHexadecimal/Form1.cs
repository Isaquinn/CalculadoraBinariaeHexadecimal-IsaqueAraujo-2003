using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraBináriaeHexadecimal
{
    public partial class Form1 : Form
    {
        int x, y, result, x2, y2, result2;

        bool telinha;
        string operate;
        string operate2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (telinha == true)
            {

                Calculo.Text = Calculo.Text + "0";

                telinha = false;
            }
            else if (telinha == false)
            {
                Calculo.Text = Calculo.Text + "0";

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (telinha == true)
            {

                Calculo.Text = Calculo.Text + "1";

                telinha = false;
            }
            else if (telinha == false)
            {
                Calculo.Text = Calculo.Text + "1";

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Resultado.Text = Convert.ToInt64(Calculo.Text, 2).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string foda = Convert.ToInt64(Calculo.Text, 2).ToString();
            int decValue = Convert.ToInt32(foda);
            string HexValue = decValue.ToString("X");
            Resultado.Text = HexValue;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            operate = "+";
            x = Convert.ToInt32(Calculo.Text, 2);
            Calculo.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            operate = "-";
            x = Convert.ToInt32(Calculo.Text, 2);
            Calculo.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            operate = "*";
            x = Convert.ToInt32(Calculo.Text, 2);
            Calculo.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            operate = "/";
            x = Convert.ToInt32(Calculo.Text, 2);
            Calculo.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            y = Convert.ToInt32(Calculo.Text, 2);
            switch (operate)
            {
                case "+":
                    result = x + y;

                    break;

                case "-":
                    result = x - y;
                    break;

                case "*":
                    result = x * y;
                    break;

                case "/":
                    result = x / 2;
                    break;
            }


            int decimalNumber = int.Parse(result.ToString());
            int remainder;
            string result2 = string.Empty;
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                result2 = remainder.ToString() + result2;
            }
            Resultado.Text = result2;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int tamanho = Calculo.Text.Length - 1;
            if (tamanho >= 0)
            {
                Calculo.Text = Calculo.Text.Substring(0, tamanho);
            }
            Resultado.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Calculo.Text = "";
            Resultado.Text = "";
            x = 0;
            y = 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (telinha == true)
            {

                calculo2.Text = calculo2.Text + "7";

                telinha = false;
            }
            else if (telinha == false)
            {
                calculo2.Text = calculo2.Text + "7";

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (telinha == true)
            {

                calculo2.Text = calculo2.Text + "8";

                telinha = false;
            }
            else if (telinha == false)
            {
                calculo2.Text = calculo2.Text + "8";

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (telinha == true)
            {

                calculo2.Text = calculo2.Text + "9";

                telinha = false;
            }
            else if (telinha == false)
            {
                calculo2.Text = calculo2.Text + "9";

            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (telinha == true)
            {

                calculo2.Text = calculo2.Text + "4";

                telinha = false;
            }
            else if (telinha == false)
            {
                calculo2.Text = calculo2.Text + "4";

            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (telinha == true)
            {

                calculo2.Text = calculo2.Text + "5";

                telinha = false;
            }
            else if (telinha == false)
            {
                calculo2.Text = calculo2.Text + "5";

            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (telinha == true)
            {

                calculo2.Text = calculo2.Text + "6";

                telinha = false;
            }
            else if (telinha == false)
            {
                calculo2.Text = calculo2.Text + "6";

            }

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (telinha == true)
            {

                calculo2.Text = calculo2.Text + "1";

                telinha = false;
            }
            else if (telinha == false)
            {
                calculo2.Text = calculo2.Text + "1";

            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (telinha == true)
            {

                calculo2.Text = calculo2.Text + "2";

                telinha = false;
            }
            else if (telinha == false)
            {
                calculo2.Text = calculo2.Text + "2";

            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (telinha == true)
            {

                calculo2.Text = calculo2.Text + "3";

                telinha = false;
            }
            else if (telinha == false)
            {
                calculo2.Text = calculo2.Text + "3";

            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (telinha == true)
            {

                calculo2.Text = calculo2.Text + "0";

                telinha = false;
            }
            else if (telinha == false)
            {
                calculo2.Text = calculo2.Text + "0";

            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (telinha == true)
            {

                calculo2.Text = calculo2.Text + "A";

                telinha = false;
            }
            else if (telinha == false)
            {
                calculo2.Text = calculo2.Text + "A";

            }

        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (telinha == true)
            {

                calculo2.Text = calculo2.Text + "B";

                telinha = false;
            }
            else if (telinha == false)
            {
                calculo2.Text = calculo2.Text + "B";

            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (telinha == true)
            {

                calculo2.Text = calculo2.Text + "C";

                telinha = false;
            }
            else if (telinha == false)
            {
                calculo2.Text = calculo2.Text + "C";

            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (telinha == true)
            {

                calculo2.Text = calculo2.Text + "D";

                telinha = false;
            }
            else if (telinha == false)
            {
                calculo2.Text = calculo2.Text + "D";

            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (telinha == true)
            {

                calculo2.Text = calculo2.Text + "E";

                telinha = false;
            }
            else if (telinha == false)
            {
                calculo2.Text = calculo2.Text + "E";

            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (telinha == true)
            {

                calculo2.Text = calculo2.Text + "F";

                telinha = false;
            }
            else if (telinha == false)
            {
                calculo2.Text = calculo2.Text + "F";

            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            operate2 = "++";
            x2 = Convert.ToInt32(calculo2.Text, 16);
            calculo2.Clear();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            operate2 = "--";
            x2 = Convert.ToInt32(calculo2.Text, 16);
            calculo2.Clear();

        }

        private void button33_Click(object sender, EventArgs e)
        {
            operate2 = "**";
            x2 = Convert.ToInt32(calculo2.Text, 16);
            calculo2.Clear();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            operate2 = "//";
            x2 = Convert.ToInt32(calculo2.Text, 16);
            calculo2.Clear();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            y2 = Convert.ToInt32(calculo2.Text, 16);
            switch (operate2)
            {
                case "++":
                    result2 = x2 + y2;
                    

                    break;

                case "--":
                    result2 = x2 - y2;
                    break;

                case "**":
                    result2 = x2 * y2;
                    break;

                case "//":
                    result2 = x2 / y2;
                    break;
            }
            int decValue2 = Convert.ToInt32(result2);
            string HexValue2 = decValue2.ToString("X");
            
            Resultado2.Text = HexValue2.ToString();
           
        }

        private void button35_Click(object sender, EventArgs e)
        {
            string hexString3 = calculo2.Text;
            int decValue3 = Convert.ToInt32(hexString3, 16);
            Resultado2.Text = decValue3.ToString();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            string hexString4 = calculo2.Text;
            int decValue4 = Convert.ToInt32(hexString4, 16);
            //Resultado.Text = decValue.ToString();
            int decimalNumber = int.Parse(decValue4.ToString());
            int remainder;
            string result3 = string.Empty;
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                result3 = remainder.ToString() + result3;
            }
            Resultado2.Text = result3;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            int tamanho = calculo2.Text.Length - 1;
            if (tamanho >= 0)
            {
                calculo2.Text = calculo2.Text.Substring(0, tamanho);
            }
            Resultado2.Text = "";
        }

        private void button30_Click(object sender, EventArgs e)
        {
            calculo2.Text = "";
            Resultado2.Text = "";
            x2 = 0;
            y2 = 0;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            string coco = textBox1.Text;
            int decimalNumber = int.Parse(coco.ToString());
            int remainder;
            string result3 = string.Empty;
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                result3 = remainder.ToString() + result3;
            }
            textBox2.Text = result3;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            int decValue = Convert.ToInt32(textBox1.Text);
            string HexValue = decValue.ToString("X");
            textBox2.Text = HexValue;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            int tamanho = textBox1.Text.Length - 1;
            if (tamanho >= 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, tamanho);
            }
            textBox2.Text = "";

        }

        private void button40_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            

        }

      

    }
}
