using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Bed
{
    public class Area
    {
        //Burada yeni bir geometrik şekil eklenmek istendiğinde kod değişmek zorunda kalacaktır.
        public double CalculateArea(GeometricShape shape)
        {
            GeometricDimesion dimension = new GeometricDimesion();
            double area = 0;
            switch (shape)
            {
                case GeometricShape.Rectangle:
                    area = dimension.Widht*dimension.Height;
                    break;
                case GeometricShape.Triangle:
                    area = dimension.Widht * dimension.Height / 2;
                    break;
                case GeometricShape.Circle:
                    area = dimension.Radius*dimension.Radius*Math.PI;
                    break;
            }
            return area;
        }
    }
}
