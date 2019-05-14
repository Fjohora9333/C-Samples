using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zisa_Car_Class
{
    public class Car
    {
        public string Make { get; set; } = "";
        public int Year { get; set; } = 0;
        public int Speed { get; set; } = 0;
        public int MaxSpeed { get; set; } = 0;
        public string Color { get; set; } = "LightBlue";

       
        public Car(string make, int year)
        {
            Make = make;
            Year = year;
            Speed = 0;
            MaxSpeed = 200;
        }
        
        public override string ToString() => $"Make: {Make}; Year:{Year}; Speed:{Speed}; MaxSpeed: {MaxSpeed}";

    }
}
