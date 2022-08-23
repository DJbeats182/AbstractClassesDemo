using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal abstract class Vehicle
    {
        public int Year { get; set; } = 2022;
        public string Make { get; set; } = "Toyota";
        public string Model { get; set; } = "4 Runner";
        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            string ten =  "dkf"; // place holder
        }
    }
}
