using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometrical.Abstract;
using Geometrical.Struct;

namespace Geometrical
{
    public class Rectangle : Polygon
    {
        public override Point[] Points { get; }
        public Rectangle(Point[] points)
        {
            Points = points;
        }
        public override double Perimetre()
        {
            double result = 0;
            result += Range(Points[0], Points[1]);
            result += Range(Points[1], Points[2]);
            return result*2;
        }
        public override double Space()
        {
            double result = 0;
            result += Range(Points[0], Points[1]);
            result *= Range(Points[1], Points[2]);
            return result;
        }
    }
}
