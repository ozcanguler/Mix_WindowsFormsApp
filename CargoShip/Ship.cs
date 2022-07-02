using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoShip
{
    class Ship
    {
        const int CYCLE_WEIGHT=3;
        const int CAR_WEIGHT=5;
        const int TRUCK_WEIGHT=11;
        const int TRAIN_WEIGHT=17;
        const int MAX_WEIGHT = 10;

        public int Capacity { get; set; }
        public int CycleCount { get; set; }
        public int TruckCount { get; set; }
        public int TrainCarCont { get; set; }
        public int CarCount { get; set; }

        Random r = new Random();
        public int getShipLoad()
        {
            return CYCLE_WEIGHT * CycleCount + CAR_WEIGHT * CarCount + TRUCK_WEIGHT * TruckCount + TRAIN_WEIGHT * TrainCarCont;
        }
        public Ship()
        {
            CycleCount = 0;
            TruckCount = 0;
            TrainCarCont = 0;
            CarCount = 0;

            Capacity = r.Next(MAX_WEIGHT) * CYCLE_WEIGHT + r.Next(MAX_WEIGHT) * CAR_WEIGHT + r.Next(MAX_WEIGHT) * TRUCK_WEIGHT + r.Next(MAX_WEIGHT) * TRAIN_WEIGHT;
        }
        public int overUnder()
        {
            return Capacity - getShipLoad();
        }
        public override string ToString()
        {
            return "Capacity: = " + Capacity + ", CurrentLoad = " + getShipLoad();
        }
    }
}
