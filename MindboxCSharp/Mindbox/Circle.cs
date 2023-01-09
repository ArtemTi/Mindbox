using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox
{
    public class Circle : IFigure
    {
        public double Radius { get; }

        public double Sqare { get; }

        public Circle(double radius)
        {
            if (radius <= 0) throw new ArgumentException("Radius must be positive");

            Radius = radius;
            Sqare = CalculateSquare();
        }

        private double CalculateSquare()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
