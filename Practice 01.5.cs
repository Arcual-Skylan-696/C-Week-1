using System;

class Program
{
    static void Main()
    {
        const double PI = 3.1416;
        double r;
        char ch;

        Console.Write("Enter radius: ");
        r = double.Parse(Console.ReadLine());

        Console.Write("Enter choice (A = Area, P = Perimeter, X = Exit): ");
        ch = char.ToUpper(Console.ReadKey().KeyChar);

        Console.WriteLine();  
        switch (ch)
        {
            case 'A':
                Console.WriteLine("Area = " + (PI * r * r));
                break;

            case 'P':
                Console.WriteLine("Perimeter = " + (2 * PI * r));
                break;

            case 'X':
                Console.WriteLine("Exiting program...");
                break;

            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}
