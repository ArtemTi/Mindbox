using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox
{
    public class Triangle : IFigure
    {
        public double FirstSide { get; }

        public double SecondSide { get; }

        public double ThirdSide { get; }

        public double Sqare { get; }

        public bool RightTriangle { get; }

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0) throw new ArgumentException("All triangle side must be positive");
            if (IsTriangleCanExist(firstSide, secondSide, thirdSide) == false) throw new ArgumentException($"Triangle with sides {firstSide}, {secondSide}, {thirdSide} cannot exist");

            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
            RightTriangle = IsRightTriangle();
            Sqare = CalculateSqare();
        }

        private bool IsTriangleCanExist(double firstSide, double secondSide, double thirdSide)
        {
            var firstSideCheck = firstSide < secondSide + thirdSide;
            var secondSideCheck = secondSide < firstSide + thirdSide;
            var thirdSideCheck = thirdSide < firstSide + secondSide;

            return firstSideCheck && secondSideCheck && thirdSideCheck;
        }

        private bool IsRightTriangle()
        {
            if (FirstSide > SecondSide && FirstSide > ThirdSide) return FirstSide * FirstSide == SecondSide * SecondSide + ThirdSide * ThirdSide;
            if (SecondSide > FirstSide && SecondSide > ThirdSide) return SecondSide * SecondSide == FirstSide * FirstSide + ThirdSide * ThirdSide;
            if (ThirdSide > FirstSide && ThirdSide > SecondSide) return ThirdSide * ThirdSide == FirstSide * FirstSide + SecondSide * SecondSide;

            return false;
        }

        private double CalculateSqare()
        {
            var semiPerimetr = (FirstSide + SecondSide + ThirdSide) / 2;

            return Math.Sqrt(semiPerimetr * (semiPerimetr - FirstSide) * (semiPerimetr - SecondSide) * (semiPerimetr - ThirdSide));
        }
    }
}
