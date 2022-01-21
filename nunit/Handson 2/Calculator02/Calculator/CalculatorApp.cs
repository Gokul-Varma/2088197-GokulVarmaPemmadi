using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator02
{
    interface IMathLibrary
    {
        int Add(int a, int b);
        int Substract(int a, int b);
        int Multiply(int a, int b);
        double Division(double a, double b);
    }
    public class CalculatorApp: IMathLibrary
    {

        int result;
        public int Add(int firstNo, int secondNo)
        {
            int result=   firstNo + secondNo;
            return result;
        }

        public int Substract(int firstNo, int secondNo)
        {
            int result= firstNo - secondNo;
            return result;
        }
        public int Multiply(int firstNo, int secondNo)
        {
            int result= firstNo * secondNo;
            return result;
        }
        public double Division(double firstNo, double secondNo)
        {
            int result = Convert.ToInt32(firstNo / secondNo);
            return result;
        }
        public double Division1(double firstNo,double secondNo)
        {
            if (secondNo == 0)
            {
                throw new ArgumentException("Second number cant be Zero");
            }
            return Convert.ToDouble(firstNo / secondNo); 
        }

        public void AllClear()
        {
             result = 0;
        }

        public double GetResult
        {
            get { return result; }
        }
    }
}