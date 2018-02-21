using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor_Celcius
{
    public partial class Form_Farenheit : Form

    {
        public Form_Farenheit()
        {
            InitializeComponent();
        }
        //instantiate class
        confar Conv = new confar();
        public string ret;

        //Change to other converter
        private void btn_invert_Click(object sender, EventArgs e)
        {  
            this.Hide();
            Form_Celsius F2 = new Form_Celsius();
            F2.ShowDialog();
            this.Close();
        }

        private void Form_Farenheit_Load(object sender, EventArgs e)
        {

        }

        //execute conversion
        private void btn_convert_Click(object sender, EventArgs e)
        {
            try
            {
                ret = Conv.value2(txb_farenheit.Text);
                Convert.ToDouble(ret);
            }
            catch
            {
                MessageBox.Show ("Insira um número válido! \nImpossível converter o valor inserido!");
            }
            finally
            {
                txb_celsius.Text = Convert.ToString(ret);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txb_farenheit.Text = "";
            txb_celsius.Text = "";
        }

        private void btn_clear_Click_1(object sender, EventArgs e)
        {
            txb_farenheit.Text = "";
            txb_celsius.Text = "";
        }                  
    }
}
