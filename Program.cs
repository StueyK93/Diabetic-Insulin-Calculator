using System;
class Program
{
    static void Main()
    {

        //Diabetic Insulin Calculator


        Console.SetWindowSize(100,30);
        Console.SetBufferSize(100,30);

        Console.Title = "Insulin Calculator";


        Console.WriteLine("What is your blood sugar level?");
        float sugarLevel = (float)Convert.ToDouble(Console.ReadLine());

        Console.WriteLine();


        if (sugarLevel <= 4.4)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("You are having a hypo  ");
            Console.ResetColor();
            Console.WriteLine("- you need to have food or a sugary drink quickly.");
            Console.WriteLine();
        }

        else if (sugarLevel >= 4.5 && sugarLevel <= 8.4)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Your sugar levels are good!");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Are you about to eat? y/n");
            Console.WriteLine();
            string aboutToEat = Console.ReadLine();
            Console.WriteLine();


            if (aboutToEat == "y")
            {
                Console.WriteLine("For every 1 unit of Carbs (10 grams), how much insulin do you take? ");
                float ratio = (float)Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please input number of Carbs eaten in grams: ");
                float carbsEaten = (float)Convert.ToDouble(Console.ReadLine());

                float insulinToTake = (float)((ratio * carbsEaten) / 10f);

                Console.Write($"You need to take ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{insulinToTake}");
                Console.ResetColor();
                Console.WriteLine(" units of insulin for your meal.");


            }

            else if (aboutToEat == "n")
            {

            }
            else if (aboutToEat != "n" || aboutToEat != "y")
            {
                Console.WriteLine("Response not recognised");
            }

        }

        else if (sugarLevel >= 8.5)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Your sugar levels are high");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Are you about to eat? y/n");
            string aboutToEat = Console.ReadLine();

            if (aboutToEat == "y")
            {
                Console.WriteLine();
                Console.WriteLine("For every 1 unit of Carbs (10 grams), how much insulin do you take? ");
                float ratio = (float)Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please input number of Carbs eaten in grams: ");
                float carbsEaten = (float)Convert.ToDouble(Console.ReadLine());

                float insulinToTake = (float)((ratio * carbsEaten) / 10f);

                Console.WriteLine();
                Console.Write($"You need to take ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{insulinToTake}");
                Console.ResetColor();
                Console.WriteLine(" units of insulin for your meal.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Your current blood sugarl level, {sugarLevel}, is over the normal quantity, you will need to adjust for this");
                Console.ResetColor();


            }

            else if (aboutToEat == "n")
            {
                Console.WriteLine();
                Console.Write($"Your blood sugar result is ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{sugarLevel}");
                Console.ResetColor();
                Console.Write(" you may need to take a correct dosage of insulin.");
                Console.WriteLine();
            }
            else if (aboutToEat != "n" || aboutToEat != "y")
            {
                Console.WriteLine("Response not recognised");
            }
        }
    }
}

