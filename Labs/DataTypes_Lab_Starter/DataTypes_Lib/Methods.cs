using System;

namespace DataTypes_Lib
{
    public static class Methods
    {
        // write a method to return the product of all numbers from 1 to n inclusive
        public static int Factorial(int n)
        {
            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        public static float Mult(float num1, float num2)
        {
            float value = (float)(decimal)( num1 * num2);
            return (float)Math.Round(value,1);
        }
    }
}
