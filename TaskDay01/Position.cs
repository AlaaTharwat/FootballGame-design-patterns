using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }



        public override string ToString()
        {
            return $"X is {X} , Y is {Y} , Z is {Z}";
        }
    }
}
