using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InvestmentCalculatorService
{
    public class Point
    {
        public int x {get; set;}
        public double y { get; set; }

        Point(int x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }
}