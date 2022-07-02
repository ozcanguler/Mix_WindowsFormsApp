using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargoShip
{
    public partial class Form1 : Form
    {
        Ship ship = new Ship();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Style = ProgressBarStyle.Continuous;
        }

        private void btn_newShip_Click(object sender, EventArgs e)
        {
            ship = new Ship();
            UpdateUI();
        }
        private void UpdateUI() //User Interface
        {
            progressBar1.Maximum = ship.Capacity;
            if (ship.getShipLoad() < ship.Capacity)
            
                progressBar1.Value = ship.getShipLoad();

                lbl_ShipLabel.Text = ship.ToString();
               
            
            lbl_CycleCount.Text = ship.CycleCount.ToString();
            lbl_CarCount.Text = ship.CarCount.ToString();
            lbl_TruckCount.Text = ship.TruckCount.ToString();
            lbl_TrainCarsCount.Text = ship.TrainCarCont.ToString();

            if (ship.overUnder() == 0)
            {
                progressBar1.ForeColor = Color.Green;
            }
            if (ship.overUnder() > 0)
            {
                progressBar1.ForeColor = Color.Yellow;
            }
            if (ship.overUnder() < 0)
            {
                progressBar1.ForeColor = Color.Red;
            }
        }

        private void Track_MotorCycles_Scroll(object sender, EventArgs e)
        {
            ship.CycleCount = track_MotorCycles.Value;
            UpdateUI();
        }

        private void Track_cars_Scroll(object sender, EventArgs e)
        {
            ship.CarCount = track_cars.Value;
            UpdateUI();
        }

        private void Track_trucks_Scroll(object sender, EventArgs e)
        {
            ship.TruckCount = track_trucks.Value;
            UpdateUI();
        }

        private void Track_trainCars_Scroll(object sender, EventArgs e)
        {
            ship.TrainCarCont = track_trainCars.Value;
            UpdateUI();
        }
    }
}
