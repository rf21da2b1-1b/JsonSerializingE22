using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonLib.model
{
    public class Car
    {
        public String Brand { get; set; }
        public String Model { get; set; }
        public String Color { get; set; }
        public int Mileage { get; set; }

        public Car():this("","","",-1)
        {

        }

        public Car(String brand, String model, String color, int mileAge)
        {
            Brand = brand;
            Model = model;
            Color = color;
            Mileage = mileAge;
        }

        public override string ToString()
        {
            return $"Brand={Brand}, Model={Model}, Color={Color}, MileAge={Mileage}";
        }
    }
}
