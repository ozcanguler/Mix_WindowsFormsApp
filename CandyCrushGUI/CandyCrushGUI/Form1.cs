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
        int i = 0, j = 0, z = 0;
        List<string> list = new List<string>();
        int c = 0;
        int p1, p2;
        public Form1()
        {
            InitializeComponent();
            populateGrid();

            buttonCopy();
        }
        public void populateGrid()
        {
            int x, y;
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
                    //if (z == 0)
                    //{
                    btnGrid[r, c].Click += gridbutton_Click;
                    //}
                    //assign the same event handler to every button in the panel.
                    //if(z==1)
                    // {
                    //     btnGrid[r, c].Click += gridbutton1_Click;
                    // }

                    //add the button to the panel.
                    panel1.Controls.Add(btnGrid[r, c]);
                    //change the location of the button to its proper x y coordinates.
                    btnGrid[r, c].Location = new Point(r * myButton.btn_size, c * myButton.btn_size);       //butonları satır ve sütun numaralarına göre yeri belirlenir.


                }
            }
            //buttonCopy();
        }
        public void buttonCopy()
        {

            string ss;
            char[] charsToTrim = { 'C', 'o', 'l', 'o', 'r', '[', ' ', ']' };


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    ss = btnGrid[i, j].BackColor.ToString();
                    ss = ss.Trim(charsToTrim);
                    list.Add(ss);
                    //MessageBox.Show(btnGrid[i, j].BackColor.ToString());

                    //btnGrid[0, 0].BackColor = Color.FromName("" + ss);

                }
            }
            foreach (var item in list)
            {
                listBox1.Items.Add(item);
            }
            //btnGrid[0, 0].BackColor = Color.FromName("" + list[1]);
            //MessageBox.Show(btnGrid[0,0].BackColor.ToString());


            //MessageBox.Show(list[1].ToString());
            //ss = btnGrid[0, 1].BackColor.ToString();
            //ss = ss.Trim(charsToTrim);
            //btnGrid[0, 0].BackColor = Color.FromName(""+ss);

        }
        public void buttonpaste()
        {
            for (int a = 0; a < rows; a++)
            {
                for (int b = 0; b < cols; b++)
                {

                    btnGrid[a, b].BackColor = Color.FromName("" + list[c]);
                    c++;
                    z = 1;
                }
            }

        }

        private void colorbutton_click(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            currColor = button.BackColor;
            pictureBox1.BackColor = currColor;

        }

        private void gridbutton_Click(object sender, EventArgs e)
        {
            if (z == 0)
            {
                i++;
                myButton button = (myButton)sender;
                origColor = button.BackColor;
                floodFill(button.row, button.col);
                label2.Text = i.ToString();

                isFinish(rows - 1, cols - 1);
            }

            else
            {

                j++;
                myButton button = (myButton)sender;
                origColor = button.BackColor;
                floodFill(button.row, button.col);
                label5.Text = j.ToString();

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

        }
        //private void gridbutton1_Click(object sender, EventArgs e)
        //{

        //    j++;
        //    myButton button = (myButton)sender;
        //    origColor = button.BackColor;
        //    floodFill(button.row, button.col);
        //    label5.Text = j.ToString();

        //    isFinish(rows - 1, cols - 1);


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
            label5.Text = "0";
            i = 0;
            c = 0;
            j = 0;
            z = 0;

            listBox1.Items.Clear();
            populateGrid();
            //buttonCopy();
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
                if (z == 0)
                {
                    MessageBox.Show("Player 1. Game is over");
                }
                else
                {
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            btnGrid[i, j].Enabled = false;
                        }
                    }

                    MessageBox.Show("Player 2. Game is over");

                    p1 = Convert.ToInt32(label2.Text);
                    p2 = Convert.ToInt32(label5.Text);
                    if (p1 < p2)
                    {
                        MessageBox.Show("Player 1 Win");

                    }
                    else if (p2 < p1)
                    {
                        MessageBox.Show("Player 2 Win");

                    }
                    else
                    {
                        MessageBox.Show("It's Draw");

                    }

                }

                c = 0;
                buttonpaste();
                //z = 1;
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



        /*  original method
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
                        buttonpaste();
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
                */


    }
}