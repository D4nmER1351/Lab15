using System;
using System.Collections.Generic;

namespace Lab15
{
    class Program
    {
        static void Main(string[] args)
        {
            var newCook = new Cook();
            var foodList = new List<string>() { "панини", "cалат", "бургер", "нагетсы", "торт"};
            var cntrl = new Control(newCook);
            cntrl.Voice(foodList);
            Console.WriteLine();
            var newCourier = new Courier();
            cntrl.ReControl(newCourier);
            cntrl.Voice(foodList);
        }
    }
}
