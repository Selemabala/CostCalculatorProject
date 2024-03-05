namespace CostCalculatorProject;

class Program
{
    static void Main(string[] args)
    {
        const int TRIANGLE = 1;
        const int CIRCLE = 2;
        const int RECTANGULAR = 3;
        const double FLOORING_RATE = 20;
        const double LABOUR_COST_PER_HOUR = 86;
        const double HALF_TRIANGLE = 2;
        const double FIRST__LEVEL_OF_DISCOUNT = 0.10;
        const double SECOND__LEVEL_OF_DISCOUNT = 0.15;
        const double THIRD__LEVEL_OF_DISCOUNT = 0.25;
        const double FOURTH__LEVEL_OF_DISCOUNT = 0.50;
        const int LOWER_LABOUR_COST = 100;
        const int MEDIUM_LABOUR_COST = 500;
        const int HIGHER_LABOUR_COST = 900;


        Console.WriteLine("Choose one of the following three shapes");
        Console.WriteLine($"(triangle press {TRIANGLE} circle press {CIRCLE} and  rectangular press {RECTANGULAR}");
        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice != TRIANGLE && choice != CIRCLE && choice != RECTANGULAR)
        {
            Console.WriteLine($"Please  choose between {TRIANGLE}, {CIRCLE} or {RECTANGULAR}");
            return;
        }

        double area = 0;

        if (choice == TRIANGLE)
        {
            Console.WriteLine("Please provide the height in feet ");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please provide the base size in feet");
            int baseSize = Convert.ToInt32(Console.ReadLine());

            area = (baseSize * height) / HALF_TRIANGLE;
        }

        if (choice == CIRCLE)
        {
            Console.WriteLine("Please provide the radius in feet");
            int radius = Convert.ToInt32(Console.ReadLine());

            area = radius * radius * Math.PI;
        }


        if (choice == RECTANGULAR)

        {
            Console.WriteLine("Please provide the width in feet");
            int rec_width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please provide the length in feet");
            int rec_length = Convert.ToInt32(Console.ReadLine());
            area = rec_width * rec_length;
        }

        Console.WriteLine($"From the measurements you provided then the  total area will be {area}");
        double hoursNeeded = area / FLOORING_RATE;
        double laborCost = hoursNeeded * LABOUR_COST_PER_HOUR;
        Console.WriteLine($"Labor cost for installing the flooring will be {laborCost}");

        Console.WriteLine("After understanding your labour cost, here is your discount");

        double discount = 0;

        if (laborCost <= LOWER_LABOUR_COST)
        {
            Console.WriteLine($"Your labour cost was less than {LOWER_LABOUR_COST} and therefore your discount is....");
            discount = laborCost * FIRST__LEVEL_OF_DISCOUNT;
        }

        if (laborCost >= LOWER_LABOUR_COST && laborCost <= MEDIUM_LABOUR_COST)
        {
            Console.WriteLine($"Your labour cost was between {LOWER_LABOUR_COST} and {MEDIUM_LABOUR_COST} therefore your discount is....");
            discount = laborCost * SECOND__LEVEL_OF_DISCOUNT;
        }

        if (laborCost > MEDIUM_LABOUR_COST && laborCost <= HIGHER_LABOUR_COST)
        {
            Console.WriteLine($"Your labour cost was between {MEDIUM_LABOUR_COST} and {HIGHER_LABOUR_COST} therefore your discount is....");
            discount = laborCost * THIRD__LEVEL_OF_DISCOUNT;
        }


        if (laborCost > HIGHER_LABOUR_COST)
        {
            Console.WriteLine("Your labour cost was above {HIGHER_LABOUR_COST} therefore your discount is....");
            discount = laborCost * FOURTH__LEVEL_OF_DISCOUNT;
        }

        double finalPrice = laborCost - discount;
        Math.Round(finalPrice, 2);
        Console.WriteLine($"Discounted Labor cost for installing the flooring will after discount is going be {finalPrice}");
    }

}

