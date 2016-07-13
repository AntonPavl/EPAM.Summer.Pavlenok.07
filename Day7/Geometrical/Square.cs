
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometrical.Abstract;
using Geometrical.Struct;

namespace Geometrical
{
    public class Square : Polygon
    {
        private Point[] points;
        public override Point[] Points{ get{ return points; } set{ points = Points;}}
        public Square(Point[] points)
        {
            this.points = points;
        }
        public override double Perimetre() =>  Range(points[0], points[1])*4;

        public override double Space() => Math.Pow(Range(points[0], points[1]),2);

    }
}
