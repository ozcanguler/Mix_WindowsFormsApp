namespace CargoShip
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.track_MotorCycles = new System.Windows.Forms.TrackBar();
            this.track_trucks = new System.Windows.Forms.TrackBar();
            this.track_cars = new System.Windows.Forms.TrackBar();
            this.track_trainCars = new System.Windows.Forms.TrackBar();
            this.lbl_CycleCount = new System.Windows.Forms.Label();
            this.lbl_TruckCount = new System.Windows.Forms.Label();
            this.lbl_CarCount = new System.Windows.Forms.Label();
            this.lbl_TrainCarsCount = new System.Windows.Forms.Label();
            this.lbl_motorCycles = new System.Windows.Forms.Label();
            this.lbl_cars = new System.Windows.Forms.Label();
            this.lbl_trucks = new System.Windows.Forms.Label();
            this.lbl_TrainCars = new System.Windows.Forms.Label();
            this.btn_newShip = new System.Windows.Forms.Button();
            this.lbl_ShipLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_MotorCycles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_trucks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_cars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_trainCars)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CargoShip.Properties.Resources.cargoship;
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(165, 24);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(600, 117);
            this.progressBar1.TabIndex = 1;
            // 
            // track_MotorCycles
            // 
            this.track_MotorCycles.Location = new System.Drawing.Point(57, 266);
            this.track_MotorCycles.Name = "track_MotorCycles";
            this.track_MotorCycles.Size = new System.Drawing.Size(162, 45);
            this.track_MotorCycles.TabIndex = 2;
            this.track_MotorCycles.Scroll += new System.EventHandler(this.Track_MotorCycles_Scroll);
            // 
            // track_trucks
            // 
            this.track_trucks.Location = new System.Drawing.Point(430, 266);
            this.track_trucks.Name = "track_trucks";
            this.track_trucks.Size = new System.Drawing.Size(162, 45);
            this.track_trucks.TabIndex = 3;
            this.track_trucks.Scroll += new System.EventHandler(this.Track_trucks_Scroll);
            // 
            // track_cars
            // 
            this.track_cars.Location = new System.Drawing.Point(57, 372);
            this.track_cars.Name = "track_cars";
            this.track_cars.Size = new System.Drawing.Size(162, 45);
            this.track_cars.TabIndex = 4;
            this.track_cars.Scroll += new System.EventHandler(this.Track_cars_Scroll);
            // 
            // track_trainCars
            // 
            this.track_trainCars.Location = new System.Drawing.Point(430, 372);
            this.track_trainCars.Name = "track_trainCars";
            this.track_trainCars.Size = new System.Drawing.Size(162, 45);
            this.track_trainCars.TabIndex = 5;
            this.track_trainCars.Scroll += new System.EventHandler(this.Track_trainCars_Scroll);
            // 
            // lbl_CycleCount
            // 
            this.lbl_CycleCount.AutoSize = true;
            this.lbl_CycleCount.Location = new System.Drawing.Point(71, 250);
            this.lbl_CycleCount.Name = "lbl_CycleCount";
            this.lbl_CycleCount.Size = new System.Drawing.Size(35, 13);
            this.lbl_CycleCount.TabIndex = 6;
            this.lbl_CycleCount.Text = "label1";
            // 
            // lbl_TruckCount
            // 
            this.lbl_TruckCount.AutoSize = true;
            this.lbl_TruckCount.Location = new System.Drawing.Point(445, 250);
            this.lbl_TruckCount.Name = "lbl_TruckCount";
            this.lbl_TruckCount.Size = new System.Drawing.Size(35, 13);
            this.lbl_TruckCount.TabIndex = 7;
            this.lbl_TruckCount.Text = "label2";
            // 
            // lbl_CarCount
            // 
            this.lbl_CarCount.AutoSize = true;
            this.lbl_CarCount.Location = new System.Drawing.Point(71, 356);
            this.lbl_CarCount.Name = "lbl_CarCount";
            this.lbl_CarCount.Size = new System.Drawing.Size(35, 13);
            this.lbl_CarCount.TabIndex = 8;
            this.lbl_CarCount.Text = "label3";
            // 
            // lbl_TrainCarsCount
            // 
            this.lbl_TrainCarsCount.AutoSize = true;
            this.lbl_TrainCarsCount.Location = new System.Drawing.Point(445, 356);
            this.lbl_TrainCarsCount.Name = "lbl_TrainCarsCount";
            this.lbl_TrainCarsCount.Size = new System.Drawing.Size(35, 13);
            this.lbl_TrainCarsCount.TabIndex = 9;
            this.lbl_TrainCarsCount.Text = "label4";
            // 
            // lbl_motorCycles
            // 
            this.lbl_motorCycles.AutoSize = true;
            this.lbl_motorCycles.Location = new System.Drawing.Point(71, 304);
            this.lbl_motorCycles.Name = "lbl_motorCycles";
            this.lbl_motorCycles.Size = new System.Drawing.Size(108, 13);
            this.lbl_motorCycles.TabIndex = 10;
            this.lbl_motorCycles.Text = "Motor Cycles (3 units)";
            // 
            // lbl_cars
            // 
            this.lbl_cars.AutoSize = true;
            this.lbl_cars.Location = new System.Drawing.Point(71, 404);
            this.lbl_cars.Name = "lbl_cars";
            this.lbl_cars.Size = new System.Drawing.Size(68, 13);
            this.lbl_cars.TabIndex = 11;
            this.lbl_cars.Text = "Cars (5 units)";
            // 
            // lbl_trucks
            // 
            this.lbl_trucks.AutoSize = true;
            this.lbl_trucks.Location = new System.Drawing.Point(445, 304);
            this.lbl_trucks.Name = "lbl_trucks";
            this.lbl_trucks.Size = new System.Drawing.Size(86, 13);
            this.lbl_trucks.TabIndex = 12;
            this.lbl_trucks.Text = "Trucks (11 units)";
            // 
            // lbl_TrainCars
            // 
            this.lbl_TrainCars.AutoSize = true;
            this.lbl_TrainCars.Location = new System.Drawing.Point(445, 404);
            this.lbl_TrainCars.Name = "lbl_TrainCars";
            this.lbl_TrainCars.Size = new System.Drawing.Size(101, 13);
            this.lbl_TrainCars.TabIndex = 13;
            this.lbl_TrainCars.Text = "Train Cars (17 units)";
            // 
            // btn_newShip
            // 
            this.btn_newShip.Location = new System.Drawing.Point(129, 447);
            this.btn_newShip.Name = "btn_newShip";
            this.btn_newShip.Size = new System.Drawing.Size(75, 23);
            this.btn_newShip.TabIndex = 14;
            this.btn_newShip.Text = "New Ship";
            this.btn_newShip.UseVisualStyleBackColor = true;
            this.btn_newShip.Click += new System.EventHandler(this.btn_newShip_Click);
            // 
            // lbl_ShipLabel
            // 
            this.lbl_ShipLabel.AutoSize = true;
            this.lbl_ShipLabel.Location = new System.Drawing.Point(113, 154);
            this.lbl_ShipLabel.Name = "lbl_ShipLabel";
            this.lbl_ShipLabel.Size = new System.Drawing.Size(35, 13);
            this.lbl_ShipLabel.TabIndex = 15;
            this.lbl_ShipLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.lbl_ShipLabel);
            this.Controls.Add(this.btn_newShip);
            this.Controls.Add(this.lbl_TrainCars);
            this.Controls.Add(this.lbl_trucks);
            this.Controls.Add(this.lbl_cars);
            this.Controls.Add(this.lbl_motorCycles);
            this.Controls.Add(this.lbl_TrainCarsCount);
            this.Controls.Add(this.lbl_CarCount);
            this.Controls.Add(this.lbl_TruckCount);
            this.Controls.Add(this.lbl_CycleCount);
            this.Controls.Add(this.track_trainCars);
            this.Controls.Add(this.track_cars);
            this.Controls.Add(this.track_trucks);
            this.Controls.Add(this.track_MotorCycles);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Load the Ship";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_MotorCycles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_trucks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_cars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_trainCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TrackBar track_MotorCycles;
        private System.Windows.Forms.TrackBar track_trucks;
        private System.Windows.Forms.TrackBar track_cars;
        private System.Windows.Forms.TrackBar track_trainCars;
        private System.Windows.Forms.Label lbl_CycleCount;
        private System.Windows.Forms.Label lbl_TruckCount;
        private System.Windows.Forms.Label lbl_CarCount;
        private System.Windows.Forms.Label lbl_TrainCarsCount;
        private System.Windows.Forms.Label lbl_motorCycles;
        private System.Windows.Forms.Label lbl_cars;
        private System.Windows.Forms.Label lbl_trucks;
        private System.Windows.Forms.Label lbl_TrainCars;
        private System.Windows.Forms.Button btn_newShip;
        private System.Windows.Forms.Label lbl_ShipLabel;
    }
}

