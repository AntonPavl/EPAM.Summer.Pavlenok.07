
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
        public override Point[] Points{ get; }
        public Square(Point[] points)
        {
            Points= points;
        }
        public override double Perimetre() =>  Range(Points[0], Points[1])*4;

        public override double Space() => Math.Pow(Range(Points[0], Points[1]),2);

    }
}
