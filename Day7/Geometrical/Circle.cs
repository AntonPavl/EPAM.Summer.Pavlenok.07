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
        private Point center;

        public override Point Center
        {
            get
            {
                return center;
            }

            set
            {
                center = value;
            }
        }

        private int radius;

        public override int Radius
        {
            get
            {
                return radius;
            }

            set
            {
                radius = value;
            }
        }


        public override double Space() => Math.Pow(radius, 2) * Math.PI;

        public override double Perimetre() => 2 * radius * Math.PI;

    }
}
