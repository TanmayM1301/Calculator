double num1 = 0, num2 = 0;
Console.WriteLine("Console Calculator in C#\r");
Console.WriteLine("\n");
{
    string value;
    string user;
    Console.WriteLine("You are a user or a developer?");
    user= Console.ReadLine();
    do
    {
        Console.WriteLine("Type a number");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Type 2nd number");
        num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Select an option from the following list");
        Console.WriteLine("\ta-Add");
        Console.WriteLine("\tb-Subtract");
        Console.WriteLine("\tc-Multiply");
        Console.WriteLine("\td-Divide");
        Console.WriteLine("\te-Modulo");
        Console.Write("Your option ?");

        switch (Console.ReadLine())
        {
            case "a":
                Console.WriteLine("Your Result\n" + (num1 + num2));
                break;
            case "b":
                Console.WriteLine("Your Result\n" + (num1 - num2));
                break;
            case "c":
                Console.WriteLine("Your Result\n" + (num1 * num2));
                break;
            case "d":
                try
                {
                    Console.WriteLine(num1/num2);
                }
                catch (DivideByZeroException e)
                {
                    if (user == "u")
                    {
                        Console.WriteLine("The divisor should not be zero");
                    }
                    else
                    {
                        Console.WriteLine(e);
                    }
                }
                break;
            case "e":
                Console.WriteLine("Your Result\n" + (num1 % num2));
                break;
        }
        Console.Write("Do you want to continue(y/n):");
        value = Console.ReadLine();
    } while (value == "y" || value == "Y");
}