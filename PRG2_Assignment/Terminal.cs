﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG2_Assignment
{
    class Terminal
    {
        public string TerminalName { get; set; }
        public Dictionary<string, Airline> Airlines { get; set; } = new Dictionary<string, Airline>();
        public Dictionary<string, Flight> Flights { get; set; } = new Dictionary<string, Flight>();
        public Dictionary<string, BoardingGate> BoardingGates { get; set; } = new Dictionary<string, BoardingGate>();
        public Dictionary<string, double> GateFees { get; set; } = new Dictionary<string, double>();

        public Terminal() { }
        public Terminal(string terminalName)
        {
            TerminalName = terminalName;
        }


        public bool AddAirline(Airline airline)
        {
            Airlines[airline.Name] = airline;
            return true;
        }

        public bool AddBoardingGate(BoardingGate gate)
        {
            BoardingGates[gate.GateName] = gate;
            return true;
        }

        public Airline GetAirlineFromFlight(Flight flight)
        {
            return 
        }

        public void PrintAirlineFees()
        {

        }

        public override string ToString()
        {
            return "";
        }
    }
}
