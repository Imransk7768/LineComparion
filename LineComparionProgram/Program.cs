using System;
namespace LineComparionProgram
{
    class Program
    {
        public static void Main(String[] args)
        {

            LineComparion Line1 = new LineComparion(2, 5, 7, 8);
            double l1 = Line1.CalculateLength();
            LineComparion Line2 = new LineComparion(7, 8, 9, 9);
            double l2 = Line2.CalculateLength();
            if (l1.CompareTo(l2) == 0)
            {
                Console.WriteLine("Both Lengths Are Equal.");
            }
            if (l1.CompareTo(l2) > 0)
            {
                Console.WriteLine(" Line-1 Is Greater.");
            }
            else
            {
                Console.WriteLine(" Line-2 Is Greater.");

            }
        }
    }
}