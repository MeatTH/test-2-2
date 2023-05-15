using System;

class Program
{
    static void Main(string[] args)
    {
        //drinking();
        treasurer();

    }
    static void drinking()
    {

        float vmax = float.Parse(Console.ReadLine());
        float vdrink = float.Parse(Console.ReadLine());
        float vfill = float.Parse(Console.ReadLine());
        float tdrink = float.Parse(Console.ReadLine());
        float tfill = float.Parse(Console.ReadLine());
        float tday = float.Parse(Console.ReadLine());

        if (tfill * vfill >= vmax - 1)
        {
            vfill = vmax;
        }
        //else ()
    }

    static void treasurer()
    {

        const int RequiredValues = 3;
        double b1, b2, b3;
        double l = 0;

        Console.WriteLine($"Please enter no less than {RequiredValues} positive real numbers.");

        Console.Write("Enter the 1st miscellaneous balance: ");
        b1 = GetPositiveRealNumber();

        Console.Write("Enter the 2nd miscellaneous balance: ");
        b2 = GetPositiveRealNumber();

        Console.Write("Enter the 3rd miscellaneous balance: ");
        b3 = GetPositiveRealNumber();

        while (true)
        {
            Console.Write("Enter a payment amount (enter a negative or zero value to exit): ");
            double payment = Convert.ToDouble(Console.ReadLine());

            if (payment <= 0)
                break;

            if (payment <= b1)
            {
                b1 -= payment;
            }
            else if (payment <= b2)
            {
                b2 -= payment;
            }
            else if (payment <= b3)
            {
                b3 -= payment;
            }
            else
            {
                l += payment;
            }
        }

        Console.WriteLine($"Balance 1: {b1}, Balance 2: {b2}, Balance 3: {b3}");
        Console.WriteLine($"Left: {l}");

        static double GetPositiveRealNumber()
        {
            double number;
            while (!double.TryParse(Console.ReadLine(), out number) || number <= 0)
            {
            Console.WriteLine("Invalid input. Please enter a positive real number.");
            Console.Write("Try again: ");
            }
            return number;
        }
    }
}
    





