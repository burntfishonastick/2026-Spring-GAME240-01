Console.WriteLine("This calculator can perform Addition, Subtraction, Multiplication, or Division. ");

Console.WriteLine("What is your first number?");
double firstnumber;
firstnumber = double.Parse (Console.ReadLine());

Console.WriteLine("What is your second number?");
double secondnumber;
secondnumber = double.Parse (Console.ReadLine());

Console.WriteLine("What operation would you like to perform?");
string operation;
operation = Console.ReadLine();
double answer;

if (operation == "addition")
{
    // add the two numbers
    
    answer = firstnumber + secondnumber;
    Console.WriteLine(firstnumber + " + " + secondnumber + " = " + answer);
}

else if (operation == "subtraction")
{
    
    answer = firstnumber - secondnumber;
    Console.WriteLine(firstnumber + " - " + secondnumber + " = " + answer);
}

else if (operation == "multiplication")
{
    answer = firstnumber * secondnumber;
    Console.WriteLine(firstnumber + " * " + secondnumber + " = " + answer);
}

else if (operation == "division")
{
    if (secondnumber == 0)
    {
        Console.WriteLine("Division by zero is not possible.");  
    }
    else
    {
        answer = firstnumber / secondnumber;
        Console.WriteLine(firstnumber + " / " + secondnumber + " = " + answer);
    }
}
else
{
    Console.WriteLine("You did not provide a proper operation");
}
