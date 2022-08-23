using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Motorcylce : Vehicle
    {
        public bool HasSideCart { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("This is the Abstract Method for Motorcycles");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("This is the Virtual Method for Motorcycles");
        }
    }
}
