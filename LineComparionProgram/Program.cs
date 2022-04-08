using System;
namespace LineComparionProgram
{
    class Program
    {
        public static void Main(String[] args)
        {

            LineComparion line1 = new LineComparion(2, 5, 6, 8);
            double l1 = line1.calculateLength();
            LineComparion line2 = new LineComparion(2, 5, 6, 8);
            double l2 = line2.calculateLength();
            if (l1.CompareTo(l2)==0)
            {
                Console.WriteLine("Both Lines are equals ");
            }
            else
            {
                Console.WriteLine("Both Lines are not equals ");
            }
        }
    }
}