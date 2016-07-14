using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometrical.Struct;

namespace Geometrical.Abstract
{
    public abstract class Ellipse:Figure
    {
        public abstract int Radius { get; }
        public abstract Point Center { get; }
    }
}
