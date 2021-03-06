﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometrical.Struct;

namespace Geometrical.Abstract
{
    public abstract class Polygon : Figure
    {
        public abstract Point[] Points { get; }       

        protected double Range(Point p1,Point p2)
        {
            return Math.Sqrt(
                Math.Pow(p1.X-p2.X,2) +
                Math.Pow(p1.Y-p2.Y,2)
                );
        }
    }
}
