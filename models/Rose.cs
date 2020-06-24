using System;
using System.Collections.Generic;

namespace flowershop
{
    public class Rose : IMothersDay, IBirthday, IGetWell
    {
        public string color { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public double cost { get; set; }
        public int petalcount { get; set; }
        public string waterschedule { get; set; }
        public bool thorny { get; set; }
        public bool fragrant { get; set; }
        public double stemlength { get; set; }

        public override string ToString()
        {
            return $"A fancial {color} rose with {petalcount} petals.";
        }
    }
}