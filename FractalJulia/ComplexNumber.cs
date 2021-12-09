using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Complex
{
    public class ComplexNumber
    {
        double r;
        double im;

        public static ComplexNumber Sum(ComplexNumber one, ComplexNumber two)
        {
            double R = one.R + two.R;
            double In = one.Im + two.Im;
            ComplexNumber number = new ComplexNumber(R, In);
            return number;
        }

        public static ComplexNumber Minus(ComplexNumber one, ComplexNumber two)
        {
            double R = one.R - two.R;
            double In = one.Im - two.Im;
            ComplexNumber number = new ComplexNumber(R, In);
            return number;
        }

        public static ComplexNumber Multiply(ComplexNumber one, ComplexNumber two)
        {
            double R;
            
            if((one.Im <= 0 && two.Im <= 0) || (one.Im >= 0 && two.Im >= 0))
                R = one.R * two.R - one.Im * two.Im;
            else
                R = one.R * two.R + (-1*(one.Im * two.Im));


            double In = one.R*two.Im + one.Im*two.R;


            ComplexNumber number = new ComplexNumber(R, In);

            return number;
        }

        public static ComplexNumber Delenie(ComplexNumber one, ComplexNumber two)
        {
            double znam = two.R * two.R + two.Im * two.Im;
            double sopr = two.Im * -1;
            ComplexNumber chislitel = Multiply(one, new ComplexNumber(two.R, sopr));

            ComplexNumber ans = new ComplexNumber(chislitel.R / znam, chislitel.Im / znam);

            return ans;
        }

        public static ComplexNumber Quad(ComplexNumber z)
        {
            return Multiply(z, z);
        }

        public ComplexNumber(double x, double y)
        {
            this.r = x;
            this.im = y;
        }

        public string NumberInString
        {
            
            get {
                if(this.Im>=0)
                    return $"{this.R}+{this.Im}i";
                else
                    return $"{this.R}{this.Im}i";
            }
        }

        public double R {
            set { r = value; }
            get { return r; }
        }

        public double Mod
        {
            get
            {
                return Math.Sqrt(r*r+im*im);
            }
        }


        public double Im
        {
            set { im = value; }
            get { return im; }
        }
    }
}
