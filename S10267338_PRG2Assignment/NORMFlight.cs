﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//==========================================================
// Student Number : S10267338C
// Student Name : Tang Kah Yan
// Partner Name : Wyse Lee Hong Yao
//==========================================================

namespace PRG2_Assignment
{
    class NORMFlight : Flight
    {
        //Constructor
        public NORMFlight(): base() { }
        public NORMFlight(string flightNumber, string origin, string destination, DateTime expectedTime) : base(flightNumber, origin, destination, expectedTime) { }

        //Methods
        public override double CalculateFees()
        {
            double totalFee = 300;
            if (Origin == "SIN")
            {
                totalFee += 800;
            }
            if (Destination == "SIN")
            {
                totalFee += 500;
            }
            return totalFee;
        }

        public override string ToString()
        {
            return $"Fees: ${CalculateFees():F2}";
        }
    }
}