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
        private Point[] points;
        public override Point[] Points
        {
            get
            {
                return points;
            }

            set
            {
                points = Points;
            }
        }
        public Triangle(Point[] points)
        {
            this.points = points;
        }
        public override double Perimetre()
        {
            double result = 0;
            
            for (int i = 1; i < points.Length; i++)
            {
                result += Range(points[i], points[i-1]);
            }
            result += Range(points[0], points[2]);
            return result;
        }

        public override double Space()
        {
            return (points[0].X * (points[1].Y - points[2].Y) +
                   points[1].X * (points[2].Y - points[0].Y) +
                   points[2].X * (points[0].Y - points[1].Y))/2;
        }
    }
}
