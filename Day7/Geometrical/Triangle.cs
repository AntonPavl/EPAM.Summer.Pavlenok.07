using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometrical.Abstract;
using Geometrical.Struct;

namespace Geometrical
{
    public class Triangle : Polygon
    {
        public override Point[] Points{ get;}
        public Triangle(Point[] points)
        {
            Points = points;
        }
        public override double Perimetre()
        {
            double result = 0;
            
            for (int i = 1; i < Points.Length; i++)
            {
                result += Range(Points[i], Points[i-1]);
            }
            result += Range(Points[0], Points[2]);
            return result;
        }

        public override double Space()
        {
            return (Points[0].X * (Points[1].Y - Points[2].Y) +
                   Points[1].X * (Points[2].Y - Points[0].Y) +
                   Points[2].X * (Points[0].Y - Points[1].Y))/2;
        }
    }
}
