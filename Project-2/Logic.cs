using System;
namespace Project2
{
    public class Logic
    {
        double posX;
        double posY;
        double scale;
        uint max;


        public Logic()
        {

        }

        public uint GetF(double x, double y)
        {
            double a = 0;
            double b = 0;

            uint f;

            for (f = 1; f <= max; f++)
            {
                double distSquared = a * a + b * b;

                if (distSquared > 4) // no need to take square root on distSquared here since (Math.sqrt(distSquared) > 2) is equal to (distSquared > 4)
                {
                    break;
                }

                double tempA;
                double tempB;

                tempA = a * a - b * b + x;
                tempB = 2 * a * b + y;

                a = tempA;
                b = tempB;
            }

            return f;
        }


    }
}