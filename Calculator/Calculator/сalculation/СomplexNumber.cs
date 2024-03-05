using System;

namespace Calculation
{
    internal class СomplexNumber
    {
        private double RealPart;
        private double ImaginaryPart;
        private int DecimalPlaces;

        public СomplexNumber() :this(0, 0, 0) { }

        public СomplexNumber(double realPart, double imaginaryPart, int decimalPlaces)
        {
            RealPart = realPart;
            ImaginaryPart = imaginaryPart;
            DecimalPlaces = decimalPlaces;
        }

        public void Add(double realPart, double imaginaryPart, int decimalPlaces)
        {
            RealPart = realPart;
            ImaginaryPart = imaginaryPart;
            DecimalPlaces = decimalPlaces;
        }

        public void Clear()
        {
            RealPart = 0;
            ImaginaryPart = 0;
            DecimalPlaces = 0;
        }

        public override string ToString()
        {
            if (ImaginaryPart > 0) return $"{Math.Round(RealPart, DecimalPlaces)} + i{Math.Round(ImaginaryPart, DecimalPlaces)}";
            return $"{Math.Round(RealPart, DecimalPlaces)} - i{Math.Round(Math.Abs(ImaginaryPart), DecimalPlaces)}";
        }
    }
}