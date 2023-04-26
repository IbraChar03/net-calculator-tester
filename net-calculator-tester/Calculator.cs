using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_calculator_tester
{
    public class Calculator
    {
        public float Add(float num1,float num2)
        {
            return num1 + num2;
        }
        public float Subtract(float num1, float num2)
        {
            return num1 - num2;
        }
        public float Divide(float num1, float num2)
        {
            return num1 / num2;
        }
        public float Multiply(float num1, float num2)
        {
            return num1 * num2;
        }
        public  double Exponentiation(int num1, int num2)

        {
            if (num1 == 0)
                num1 = 1;

            else if (num2 == 0)
                num2 = 1;
            double elevamento = 1;
            double numBase = (double)num1;
            if (num2 < 0)
            {
                numBase = 1.0 / numBase;
                num2 = num2 * -1;
                for (int i = 0; i < num2; i++)
                {
                    elevamento *= numBase;
                }
            }
            else
            {
                for (int i = 0; i < num2; i++)
                {
                    elevamento *= numBase;
                }
            }



            return elevamento;
        }
    }
}
