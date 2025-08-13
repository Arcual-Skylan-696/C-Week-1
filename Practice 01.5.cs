using System;

class Program
{
    static void Main()
    {
        const double PI = 3.1416;
        double radius;
        char choice;

        Console.Write("Enter radius: ");
        radius = double.Parse(Console.ReadLine());

        Console.Write("Enter choice (A=Area, P=Perimeter, X=Exit): ");
        choice = char.ToUpper(Console.ReadKey().KeyChar);

        switch (choice)
        {
            case 'A':
                Console.WriteLine("Area = " + (PI * radius * radius));
                break;
            case 'P':
                Console.WriteLine("Perimeter = " + (2 * PI * radius));
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