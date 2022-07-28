using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CandyCrushGUI

{   //Flood fill Algorithm
    public partial class Form1 : Form
    {
        private myButton[,] btnGrid;
        private Color currColor, origColor;
        private int rows, cols;
        int i = 0;
        public Form1()
        {
            InitializeComponent();
            populateGrid();
        }
        public void populateGrid()
        {
            //calculate the number of rows and cols based on the panel size and the button size.
            cols = panel1.Height / myButton.btn_size;
            rows = panel1.Width / myButton.btn_size;
            // new 2D array of buttons.
            btnGrid = new myButton[rows, cols];

            //create a new button at each row and col location.
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    btnGrid[r, c] = new myButton();
                    btnGrid[r, c].row = r;
                    btnGrid[r, c].col = c;

                    //assign the same event handler to every button in the panel.
                    btnGrid[r, c].Click += gridbutton_Click;

                    //add the button to the panel.
                    panel1.Controls.Add(btnGrid[r, c]);
                    //change the location of the button to its proper x y coordinates.
                    btnGrid[r, c].Location = new Point(r * myButton.btn_size, c * myButton.btn_size);
                }
            }
        }

        private void gridbutton_Click(object sender, EventArgs e)
        {
            i++;
            myButton button = (myButton)sender;
            origColor = button.BackColor;
            floodFill(button.row, button.col);
            label2.Text = i.ToString();

            isFinish(rows - 1, cols - 1);
        }

        //if(currColor== btnGrid[0, 0].BackColor&& currColor == btnGrid[0, 1].BackColor && currColor == btnGrid[0, 2].BackColor
        //   && currColor == btnGrid[1, 0].BackColor && currColor == btnGrid[1, 1].BackColor && currColor == btnGrid[1, 2].BackColor
        //   && currColor == btnGrid[2, 0].BackColor && currColor == btnGrid[2, 1].BackColor && currColor == btnGrid[2, 2].BackColor
        //   && currColor == btnGrid[3, 0].BackColor && currColor == btnGrid[3, 1].BackColor && currColor == btnGrid[3, 2].BackColor
        //   )
        //{
        //    MessageBox.Show("bittti");
        //}


        //if(btnGrid[i, j].BackColor != currColor)
        //{
        //    i=0;j = 0;
        //}

        //if (btnGrid[z, k].BackColor == currColor && k + 1 == cols && z+1 != rows)
        //{
        //    if (z == rows - 1 && k == cols - 1)
        //    {
        //        MessageBox.Show("You win");
        //    }
        //    z++;
        //    if (z == rows - 1 && k == cols - 1)
        //    {
        //        MessageBox.Show("You win");
        //    }
        //}



        private void floodFill(int r, int c)
        {
            if (isValid(r, c) && btnGrid[r, c].BackColor.Equals(origColor))
            {
                // change the current cell clicked
                btnGrid[r, c].BackColor = currColor;

                //apply to the cell to the east (r+1)

                floodFill(r + 1, c);

                //apply to the west (r-1)

                floodFill(r - 1, c);

                //apply to the north (c-1)

                floodFill(r, c - 1);

                //apply to the south (c+1)

                floodFill(r, c + 1);
            }

        }

        private void Btn_rst_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            label2.Text = "0";
            i = 0;
            populateGrid();
        }

        private void colorbutton_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currColor = button.BackColor;
            pictureBox1.BackColor = currColor;
        }

        private bool isValid(int r, int c)
        {
            if (r >= 0 && r < rows && c >= 0 && c < cols)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void isFinish(int a, int b)
        {

            if (b == -1)
            {
                a--;
                b = cols - 1;
                isFinish(a, b);
            }
            else if (a < 0)
            {
                MessageBox.Show("Congratulations. Game is over");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        btnGrid[i, j].Enabled = false;
                    }
                }
            }
            else if (b < 0)
            {
                a--;
                b = cols - 1;
                isFinish(a, b);
            }
            else if (b > -1 && btnGrid[a, b].BackColor == currColor)
            {
                //if (a == 0 && b == 0 )
                //{
                //    MessageBox.Show("oyun bitti");
                //}
                b--;

                isFinish(a, b);

            }

        }
    }
}
