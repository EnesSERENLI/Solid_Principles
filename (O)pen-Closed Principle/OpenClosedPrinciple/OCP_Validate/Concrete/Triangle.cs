using OCP_Validate.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Validate.Concrete
{
    public class Triangle:Area
    {
        public double BaseWidht { get; set; }
        public double Height { get; set; }

        public override double AreaCalculator()
        {
            Triangle triangle = new Triangle();
            double area = triangle.BaseWidht * triangle.Height / 2;
            return area;
        }
    }
}
