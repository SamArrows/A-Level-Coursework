using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolynomialQuiz
{
    abstract class MathsMethods
    {
        protected double Sum(double a, double b)
        {
            return a + b;
        }
        protected int NCR(int N, int R)
        {
            return Factorial(N) / (Factorial(R) * Factorial(N - R));
        }
        protected double Sec(double num)
        {
            return 1 / Math.Cos(num);
        }
        protected double Csc(double num)
        {
            return 1 / Math.Sin(num);
        }
        protected double Cot(double num)
        {
            return 1 / Math.Tan(num);
        }
        protected double AngleConversion(double angle, bool type)
        {
            if(type == true)
            {
                //convert from radians to degrees
                return angle / (Math.PI / 180);
            }
            else
            {
                //convert from degrees to radians
                return angle * (Math.PI / 180);
            }
        }
        protected int Factorial(int value)
        {
            if (value == 0)
            {
                return 1;
            }
            else
            {
                return value * Factorial(value - 1);
            }
        }
    }
}


