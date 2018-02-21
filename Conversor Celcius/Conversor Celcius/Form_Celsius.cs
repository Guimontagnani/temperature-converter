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
    public partial class Form_Celsius : Form
    {
        public Form_Celsius()
        {
            InitializeComponent();
        }
        //instantiate class
        Converter Conv = new Converter();
        public string ret;

        //instantiate second form
        Form_Farenheit Far = new Form_Farenheit();

        private void Form_Mais_Load(object sender, EventArgs e)
        {

        }

        //Execute class Converter
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ret = Conv.value(txb_celsius.Text);
                Convert.ToDouble(ret);
            }
            catch
            {
                MessageBox.Show ("Insira um número válido! \nImpossível converter o valor inserido!");
            }
            finally
            {
                txb_farenheit.Text = Convert.ToString(ret);
            }
        }

        //clear values
        private void btn_clear_Click(object sender, EventArgs e)
        {
            txb_celsius.Text = "";
            txb_farenheit.Text = "";
        }

        //change to the other converter
        private void btn_invert_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            Far.ShowDialog();
                        
        }
    }
}
