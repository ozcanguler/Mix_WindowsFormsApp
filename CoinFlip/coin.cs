﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlip
{
    class coin
    {    
        public bool isHeads { get; set; }     

        public coin(bool h)
        {
            this.isHeads = h;
        }

        public void flipCoin(Random r)
        {
            //Random r = new Random();
            if (r.Next(10) > 5)
            {
                this.isHeads = true;                   
            }
            else
            {
                this.isHeads = false;
          
            }
        }
       
    }
}
