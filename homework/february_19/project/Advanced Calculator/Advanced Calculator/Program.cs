Console.WriteLine("This calculator can perform 5 operations: addition (+), subtraction (-), multiplication (*), and division.");
Console.WriteLine("Please type a mathematical expression, or type \"quit\" to shut down the calculator.");
Console.WriteLine("Please put a space between each character.");
while (true)
{
    string response = Console.ReadLine();
    double firstNumber, secondNumber;

    if (response.ToLower() == "quit")
    {
        Console.WriteLine("Calculator has shut down");
        break;
    }

    string[] splitresponse = response.Split();
    
    if (splitresponse.Length != 3)
    {
        Console.WriteLine("I cannot do that");
    }
    string operation = splitresponse[1];
// IT KEEPS DOING THAT THING I CANT FIGURE IT OUTT :[[[[[[[
    firstNumber = float.Parse(splitresponse[0]);
    secondNumber = float.Parse(splitresponse[2]);
   

    if (operation == "+")
    {
        Console.WriteLine(response + " = " + (firstNumber + secondNumber));
    }
    else if (operation == "-")
    {
        Console.WriteLine(response + " = " + (firstNumber - secondNumber));
    }
    else if (operation == "*")
    {
        Console.WriteLine(response + " = " + (firstNumber * secondNumber));
    }
    else if (operation == "/")
    {
        if (secondNumber != 0)
            Console.WriteLine(response + " = " + (firstNumber / secondNumber));
        else
        {
            Console.WriteLine("I cannot do that.");
        }
    }
    else if (operation == "%")
    {
        if (secondNumber != 0)
            Console.WriteLine(response + " = " + (firstNumber % secondNumber));
        else
        {
            Console.WriteLine("I cannot do that.");
        }
    }
    else
    {
        Console.WriteLine("I cannot do that.");
    }
}