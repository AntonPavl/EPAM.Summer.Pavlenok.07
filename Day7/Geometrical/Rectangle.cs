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
        private Point[] points;
        public override Point[] Points { get { return points; } set { points = Points; } }
        public Rectangle(Point[] points)
        {
            this.points = points;
        }
        public override double Perimetre()
        {
            double result = 0;
            result += Range(points[0], points[1]);
            result += Range(points[1], points[2]);
            return result*2;
        }
        public override double Space()
        {
            double result = 0;
            result += Range(points[0], points[1]);
            result *= Range(points[1], points[2]);
            return result;
        }
    }
}
