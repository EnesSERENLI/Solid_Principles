using OCP_Validate.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Validate.Concrete
{
    public class Circle : Area
    {
        public double Radius { get; set; }
        public override double AreaCalculator()
        {
            Circle circle = new Circle();
            double area = circle.Radius*circle.Radius*Math.PI;
            return area;
        }
    }
}
