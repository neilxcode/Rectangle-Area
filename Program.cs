using System;

namespace rectangle
{
class CalculateArea
    {
        static int Area(int x, int y)
        {
            return x * y;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Width: ");
            int intWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Length: ");
            int intLength = Convert.ToInt32(Console.ReadLine());

            int RectangleArea = Area(intWidth, intLength);

            Console.WriteLine("The area of the rectangle is: {0}", RectangleArea);
        }

    }
}
