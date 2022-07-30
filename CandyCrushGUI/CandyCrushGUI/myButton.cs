using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CandyCrushGUI
{
    class myButton:Button
    {
        public static Color[] myColors = { Color.Red, Color.Pink, Color.White, Color.Magenta, Color.Blue, Color.Black, Color.Green, Color.Yellow };
        static Random rnd = new Random();
        public static int btn_size = 125;
        public int row { get; set; }
        public int col { get; set; }

        public myButton()
        {
            Width = Height = btn_size;
            int initColor = rnd.Next() % myColors.Length;
            this.BackColor = myColors[initColor];
        }
    }
}
