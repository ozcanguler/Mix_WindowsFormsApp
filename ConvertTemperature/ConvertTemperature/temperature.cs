using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertTemperature
{
    class temperature
    {
       public float tempsay { get; set; }
       public char temp { get; set; }

        public temperature(float ctempsay,char ctemp)
        {
            tempsay = ctempsay;
            temp = ctemp;
        }
        float psay = -10000;
        public float ToCelcius()
        {
            switch (temp)
            {
                case 'c':
                    psay = tempsay; break;

                case 'f':
                    psay = (tempsay - 32) * 5 / 9; break;

                case 'k':
                    psay = tempsay - 273; break;
            }
            return psay;
        }
        public float ToKelvin()
        {
            switch (temp)
            {
                case 'k': psay = tempsay; break;
                case 'c': psay = tempsay + 273; break;
                case 'f': psay = (tempsay - 32) * 5 / 9 + 273; break;
            }
            return psay;
        }
        public float toFahrenheight()
        {
           
            switch (temp)
            {
                case 'f': psay = tempsay; break;
                case 'c': psay = tempsay * 9 / 5 + 32; break;
                case 'k': psay = (tempsay - 273) * 9 / 5 + 32; break;
            }
            return psay;
        }
    }
}
