using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometrical.Abstract;
using Geometrical.Struct;

namespace Geometrical
{
    public class Circle : Ellipse
    {
        public Circle(Point center,int radius)
        {
            Center = center;
            Radius = radius;
        }
        public override Point Center { get; }

        public override int Radius{ get; }

        public override double Space() => Math.Pow(Radius, 2) * Math.PI;

        public override double Perimetre() => 2 * Radius * Math.PI;

    }
}
