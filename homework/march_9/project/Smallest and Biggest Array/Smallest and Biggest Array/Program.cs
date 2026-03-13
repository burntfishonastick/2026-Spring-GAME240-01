int[] numbers = { 16, 48, 9, 2, 10};

int smallestNum = numbers[0];
int biggestNum = numbers[0];
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] < smallestNum)
    {
        smallestNum = numbers[i];
    }

    if (numbers[i] > biggestNum)
    {
        biggestNum = numbers[i];
    }
}

Console.WriteLine( "The smallest number is " + smallestNum + " and the biggest number is " + biggestNum + ".");