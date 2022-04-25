using OCP_Validate.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Validate.Concrete
{
    public class Rectangle:Area
    {
        public double Widht { get; set; }
        public double Height { get; set; }

        public override double AreaCalculator()
        {
            Rectangle rectangle = new Rectangle();
            double area = rectangle.Widht * rectangle.Height;
            return area;
        }
    }
}
