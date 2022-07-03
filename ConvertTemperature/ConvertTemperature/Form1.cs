using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertTemperature
{
    public partial class Form1 : Form
    {
        float say;
        char ftemp;
        char ltemp;
        
        
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Btn_convert_Click(object sender, EventArgs e)
        {
            say = float.Parse(txtbox_fnum.Text);
            if (rad_cel.Checked == true)
            {
                ftemp = 'c';
            }
            if (rad_fah.Checked == true)
            {
                ftemp = 'f';
            }
            if (rad_kel.Checked == true)
            {
                ftemp = 'k';
            }
            if (rad_tocel.Checked == true)
            {
                ltemp = 'c';
            }
            if (rad_tofah.Checked == true)
            {
                ltemp = 'f';
            }
            if (rad_tokel.Checked == true)
            {
                ltemp = 'k';
            }
            temperature temperature = new temperature(say, ftemp);

           
                switch (ltemp)
                {
                    case 'c': txtbox_lnum.Text = temperature.ToCelcius().ToString(); break;
                    case 'f': txtbox_lnum.Text = temperature.toFahrenheight().ToString(); break;
                    case 'k': txtbox_lnum.Text = temperature.ToKelvin().ToString(); break;

                }
            
        }
    }
}
