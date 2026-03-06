// Question 1
int one = 1;
while (one <= 5)
{
    Console.WriteLine(one);
    one = one + 1;
}
// Question 2
int hundred = 100;
while (hundred <= 150)
{
    Console.WriteLine(hundred);
    hundred = hundred + 1;
}
// Question 3
int zerotohundred = 0;
while (zerotohundred <= 100)
{
    Console.WriteLine(zerotohundred);
    zerotohundred = zerotohundred + 2;
}
// Question 4
int countdown = 20;

while (countdown >= -20)
{
    Console.WriteLine(countdown);
    countdown = countdown - 1;
}
// Question 5
int bythrees = 1;
while (bythrees <= 100)
{
    Console.WriteLine(bythrees);
    bythrees = bythrees + 3;
} 
// Question 6
int poweroftwo = 1;

while (poweroftwo <= 1024)
{
    Console.WriteLine(poweroftwo);
    poweroftwo = poweroftwo * 2;
}
// Question 7
string response;

do
{
    Console.WriteLine("Do you want the loop to stop?");
    response = Console.ReadLine();

}
while (response != "yes");
{
    Console.WriteLine("ok");
}
// Question 8
bool truefalse = true;
while (true)
{
    Console.WriteLine("True");
    Console.WriteLine("False");
}

//Question 9 
int evenodd = 1;

while (evenodd <= 20)
{
    Console.WriteLine(evenodd + " is odd");
    evenodd = evenodd + 1;
    Console.WriteLine(evenodd + " is even");
    evenodd = evenodd + 1;
}

// Question 10

int wordcount;
string [] words = new string [] {"once","upon", "a", "midnight", "dreary"};
wordcount = 0;
while (wordcount < words.Length)
{
    Console.WriteLine(words[wordcount]);
    wordcount = wordcount + 1;
}