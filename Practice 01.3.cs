using System;

class program
{
    static void Main()
    {
        int age = 32;
        double income = 56,000;

        if (age > 25 && age < = 35 && income > 50000)
        {
            Console.WriteLine("Category: Young Professional");
        }
        else if (age > = 36 && age <= 55 && income > 70000)
        {
            Console.WriteLine("Category: Middle-aged Professional");           
        }
        else if (age >= 56 && income < 30000)
        {
            Console.WriteLine("Category: Senior Citizen ");
        }
        else
        {
            Console.WriteLine("Category: Other ");
        }

    }
}