using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenDevelopmentt.MathLib
{
    public class Math : IAdd, ISub, IDivision, IMultiplication
    {
        //Add
        public int Add(int x, int y)
        {
            return x + y;
        }
        public double Add(double x, double y)
        {
            return x + y;
        }
        //Subtract

        public int Sub(int x, int y)
        {
            return x - y;
        }
        public double Sub(double x, double y )
        {
            return x - y;
        }
        //Division
        public int Divide(int x, int y)
        {
            try
            {
                return x / y;
            }
            catch(DivideByZeroException e)
            {
                return -999;
            }

        }

        public double Divide(double x, double y)
        {
            return x / y;
        }

        //Multiplication
        public int Multiply(int x, int y)
        {
            return x * y;
        }

        public double Multiply(double x, double y)
        {
            return x * y;
        }
    }
}
