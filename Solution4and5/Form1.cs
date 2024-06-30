using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Solution4and5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        
        private void plus_Click(object sender, EventArgs e)

        {
            //check if it parses to double then add numbers else give message box that input is not number
            double num1, num2;
            if (!double.TryParse(num1textbox.Text, out num1)) MessageBox.Show("Input only numbers");
            if(!double.TryParse(num2textbox.Text, out num2))  MessageBox.Show("Input only numbers"); 

            anslab.Text = (num1 + num2).ToString();



        }

        private void Go_Click_1(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text); //when this button is called it will go to page
        }

        private void minus_Click(object sender, EventArgs e)
        {
            //check if it parses to double then minus numbers else give message box that input is not number
            double num1, num2;
            if (!double.TryParse(num1textbox.Text, out num1)) MessageBox.Show("Input only numbers");
            if (!double.TryParse(num2textbox.Text, out num2)) MessageBox.Show("Input only numbers");

            anslab.Text = (num1 - num2).ToString();
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            //check if it parses to double then multiply numbers else give message box that input is not number
            double num1, num2;
            if (!double.TryParse(num1textbox.Text, out num1)) MessageBox.Show("Input only numbers");
            if (!double.TryParse(num2textbox.Text, out num2)) MessageBox.Show("Input only numbers");

            anslab.Text = (num1 * num2).ToString();

        }

        private void divide_Click(object sender, EventArgs e)
        {
            //check if it parses to double then divide numbers else give message box that input is not number
            double num1, num2;
            if (!double.TryParse(num1textbox.Text, out num1)) MessageBox.Show("Input only numbers");
            if (!double.TryParse(num2textbox.Text, out num2)) MessageBox.Show("Input only numbers");

            anslab.Text = (num1 / num2).ToString();
        }

        private void encytnow_Click(object sender, EventArgs e)
        {
            EncryptReference.ServiceClient endc = new EncryptReference.ServiceClient();

            try { encrypted.Text = endc.Encrypt(plaintxt.Text); } //encrypt plaintext
            catch (Exception ec) { encrypted.Text = ec.Message; } //show exception messeage
            endc.Close();

        }

        private void sndtoreciver_Click(object sender, EventArgs e)
        {
            EncryptReference.ServiceClient endc = new EncryptReference.ServiceClient(); //add the client ref

            try { plaintxtdecrypted.Text = endc.Decrypt(ciphertxt.Text); }  //decrypt ciphertext and show in label
            catch (Exception dc) { plaintxtdecrypted.Text = dc.Message; }   // catch exception and show messege in label
            endc.Close();
        }

       
    }
}
