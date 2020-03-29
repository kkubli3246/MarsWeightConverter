using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarsWeightConverter
{
    public partial class Exercise3 : Form
    {
         
        public Exercise3()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Convert_Click(object sender, EventArgs e)
        {
            string earthWeight = tb_earthWeight.Text;
            double result = convertWeight(Convert.ToDouble(earthWeight));

            //Math.Truncate to Limit the Deouble to 3 decimal places without rounding
            result = Math.Truncate(result * 1000) / 1000;
            tb_marsWeight.Text = result.ToString();
        }

        /*
         * covertWeight uses formula to convert earth weight to mars weight
         */
        private double convertWeight(double earthWeight) {
            return earthWeight * (3.7208 / 9.8067);

        }
    }
}
