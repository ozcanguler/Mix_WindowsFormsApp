﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        Board game = new Board();
        Button[] buttons = new Button[9];
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
            game = new Board();
            buttons[0] = button1;
            buttons[1] = button2;
            buttons[2] = button3;
            buttons[3] = button4;
            buttons[4] = button5;
            buttons[5] = button6;
            buttons[6] = button7;
            buttons[7] = button8;
            buttons[8] = button9;

            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Click += handleButtonClick;
                buttons[i].Tag = i;
            }
        }

      
        private void handleButtonClick(object sender, EventArgs e)
        {


            Button clickedButton = (Button)sender;
           // MessageBox.Show("button " + clickedButton.Tag + " was clicked");

            int gameSquareNumber = (int)clickedButton.Tag;
            game.Grid[gameSquareNumber] = 1;
            updateBoard();

            if (game.isBoardFull() == true)
            {
                MessageBox.Show("The board is full");
                disableAllbuttons();
            }
            else if (game.checkForWinner() == 1)
            {
                MessageBox.Show("Player human wins!");
                disableAllbuttons();
            }
            else
            {
                computerChoose();
            }
            
        }

        private void disableAllbuttons()
        {
            foreach (var item in buttons)
            {
                item.Enabled = false;
                item.BackColor = Color.Transparent;
                item.Text = "";
            }
        }

        private void computerChoose()
        {
            int computerTurn = r.Next(9);
            //MessageBox.Show(computerTurn.ToString());
            while (computerTurn==-1||game.Grid[computerTurn]!=0)
            {
                computerTurn = r.Next(9);
                //MessageBox.Show(computerTurn.ToString());
            }
            game.Grid[computerTurn] = 2;
            updateBoard();

            if (game.isBoardFull() == true)
            {
                MessageBox.Show("The board is full");
                disableAllbuttons();
            }
            else if (game.checkForWinner() == 2)
            {
                MessageBox.Show("Player computer wins!");
                disableAllbuttons();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateBoard();
        }

        private void updateBoard()
        {
            for (int i = 0; i < game.Grid.Length; i++)
            {
                if (game.Grid[i] == 0)
                {
                    buttons[i].Text = "";
                    buttons[i].Enabled = true;
                }
                else if (game.Grid[i] == 1)
                {
                    buttons[i].Text = "X";
                    buttons[i].Enabled = false;
                    buttons[i].BackColor = Color.Red;
                }
                else if (game.Grid[i] == 2)
                {
                    buttons[i].Text = "O";
                    buttons[i].Enabled = false;
                    buttons[i].BackColor = Color.Green;
                }
            }
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            game = new Board();
            enableAllButtons();
        }

        private void enableAllButtons()
        {
            foreach (var item in buttons)
            {
                item.Enabled = true;
            }
            updateBoard();
        }
    }
}
