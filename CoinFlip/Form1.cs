using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinFlip
{
    public partial class Form1 : Form
    {
        coin[] coins = new coin[5];
        int l;
        int s;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //label1.Text = coins[0].isHeads + "," + coins[1].isHeads + "," + coins[2].isHeads + "," + coins[3].isHeads + "," + coins[4].isHeads;
            Random r = new Random();
            label1.Text = "";
            for (int i = 0; i < coins.Length; i++)
            {
                coins[i].flipCoin(r);

                if (i == coins.Length - 1)
                {
                    if (coins[i].isHeads == false)
                    {
                        l++;
                        if (l > s)
                            label1.Text += "Lennister" + "      Win Lennister";
                        else
                        {
                            label1.Text += "Lennister" + "      Win Stark";
                        }
                    }
                    else
                    {
                        s++;
                        if (s > l)
                            label1.Text += "Stark" + "      Win Stark";
                        else
                        {
                            label1.Text += "Stark" + "      Win Lennister";
                        }
                    }
                    //label1.Text += coins[i].isHeads ;

                }
                else
                {
                    if (coins[i].isHeads == false)
                    {
                        l++;
                        label1.Text += "Lennister" + ",";
                    }
                    else
                    {
                        s++;
                        label1.Text += "Stark" + ",";
                    }
                    //label1.Text += coins[i].isHeads + ",";
                }


            }
            pictureBox1.Image = coins[0].isHeads ? Properties.Resources.house_stark : Properties.Resources.house_lannister;
            pictureBox2.Image = coins[1].isHeads ? Properties.Resources.house_stark : Properties.Resources.house_lannister;
            pictureBox3.Image = coins[2].isHeads ? Properties.Resources.house_stark : Properties.Resources.house_lannister;
            pictureBox4.Image = coins[3].isHeads ? Properties.Resources.house_stark : Properties.Resources.house_lannister;
            pictureBox5.Image = coins[4].isHeads ? Properties.Resources.house_stark : Properties.Resources.house_lannister;
            //if (coins[0].isHeads == true)
            //{
            //    pictureBox1.Image = Properties.Resources.house_stark;
            //}
            //else
            //{
            //    pictureBox1.Image = Properties.Resources.house_lannister;
            //}
            //if (coins[1].isHeads == true)
            //{
            //    pictureBox2.Image = Properties.Resources.house_stark;
            //}
            //else
            //{
            //    pictureBox2.Image = Properties.Resources.house_lannister;
            //}
            //if (coins[2].isHeads == true)
            //{
            //    pictureBox3.Image = Properties.Resources.house_stark;
            //}
            //else
            //{
            //    pictureBox3.Image = Properties.Resources.house_lannister;
            //}
            //if (coins[3].isHeads == true)
            //{
            //    pictureBox4.Image = Properties.Resources.house_stark;
            //}
            //else
            //{
            //    pictureBox4.Image = Properties.Resources.house_lannister;
            //}
            //if (coins[4].isHeads == true)
            //{
            //    pictureBox5.Image = Properties.Resources.house_stark;
            //}
            //else
            //{
            //    pictureBox5.Image = Properties.Resources.house_lannister;
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //coins[0] = new coin(true);
            //coins[1] = new coin(true);
            //coins[2] = new coin(true);
            //coins[3] = new coin(true);
            //coins[4] = new coin(true);
            for (int i = 0; i < coins.Length; i++)
            {
                coins[i] = new coin(false);
            }
        }
    }
}
