/*
string[] studentName;
int index;
studentName = new string[] { "john", "brandon", "diego", "ren", "yukikaze" };

index = 0; // set the initial value

while (index < studentName.Length)
    // here you check the condition
{ // important bit
    Console.WriteLine(studentName[index]);
    index = index + 1; // the iteration 
}

// down here is if you want to put everything in one line
for (int i = 0; i < studentName.Length; i = i + 1) ;
{
    Console.WriteLine(studentName[index]);
}

int number;
int[] numbers;
int [] weather;
weather = 
    new int[] {70,56,80,95,100,-20,-15};
//            0,  1, 2, 3, 4,   5,  6

int i;
i = 0;
while (i < weather.Length)
{
    if (weather[i] == 70)
    {
        Console.WriteLine("We found it!");
        Console.WriteLine("Day #" + i + "is 70";
        break; //stop early
    }

    i = i + 1;
    
}
// after break it skips everything and goes here

string[] studentName;
string[] letterGrade; //a,b, etc..
double[] percenetage;

string[] className; //intro to..
string[] classNumber; // game 230
int[] studentsenrolled;

//variable called student
//contains: name, lettergrade, percentage;

struct Student
{
    string name;
    string letterGrade;
    double percentage;
}

Student student1;
student1 = new Student("brandon", "A", 98)
{
    name = "brandon"
    
}
string firstName;
string lastName;

(string first, string last, int age) name;
//means name is equal to two strings

name.first = "Wynona";
name.last = "Nguyen";
name.age = 18;

name = new (string, string, int)[25];

class Address
{
    string street;
    string state;
    int aptnumber; 
}
// 1 bytes = 8 bits
// 2 ^ 8= 256 possible bits

 int - 4 bytes long = 32 bits long, means it can store up to a maximum of 4.3 million
 double - 8 bytes long = 64 bits long
 bool

// 64 bit integer
long myLongNumber;
// 16 bit integer
short myShortNumber;
// 32 bit integer
int myNumber;
// just means a long and a short number by bits

// 8 bit integer
byte myByte;
 
  SI units
 
 kilo = 1024 bytes
 mega = 1024 kb
 giga = 1024 mb
 tera = 1024 gb
 
 
 string MyString = "hi.";
 string myString2 = "once upon a midnight dreary"
 
 int index = 0;

 while (index < myString2.Length)
 {
     // write out each letter
     Console.Write(myString2[index]);
     Thread.Sleep(100);
     index = index + 1; //go to the next letter
 }
 
 string myString = "hi"
 
 myString[2] = "!"; // <- not allowed
 myString = "some new bit of text";
 
 //strings are immutable
 
 int a;
 int b;
 
 a = 10;
 b = 99;
 
 // swap a and b, so that a = 99, b = 10

 int c;

c = a;
a = b;
b = c;
 
 Console.WriteLine("A is now" + a);
 Console.WriteLine("B is now" + b);
 
 int[] numbers = [123, 5, 0, -10, 7];
 
 //using a while loop, find the biggest and smallest number in the array
 // hint: 
 
/* int i = 0;

 while (i < numbers.Length)
 {
     int currentNumber = numbers[i];
     //do something
     i = i + 1; 
 }
 // int biggest and int smallest
 ------------------------------------------------------
 
 // sum the numbers in the array
 
int sum;

 sum = numbers[0] + numbers[1] + numbers[3] + numbers[4] +numbers[5];

Console.WriteLine("Sum equals" + sum);

 string myName = "Wynona";
 int index = 0;
 while (index < myName.Length)
 {
     Console.WriteLine(myName[index]);
     
     //ALL OF THESE ARE THE SAME:
     index = index + 1;
     index = += 1;
     index++;
     index--;
     
 }
 
 // integers:
 /*
  math operators
 + - * /
 assignment operators
  = -= += /=
  equality operators
  == !=
  comparison operators
  < > <= >=
  a !< b //invalid
  !(a < b) // valid
  
  unary:
  !true
  a++
  
  a = 5;
  a++;
  // a is now 6.
  
  order of operations
  P/MD/AS
  Parentheses > Multiplication & Division >
  Addition and Subtraction
  
  conversion
  int var2;
  var2 = (int)10.8; // var2 turns into 10
  byte -> short -> int -> long -> float -> doulbe
  all of these can happen automatically ^^
  to go backwards the other way around, you must tell the computer directly
  

Console.WriteLine("What is your full name?");

string fullName;
fullName = Console.ReadLine();

string trimmedFullName;
trimmedFullName = fullName.Trim();
// removes all the spaces before and after the text, not the inside

string firstName;
string lastName;
string middleName;

string[] fullNameAsParts;
fullNameAsParts = fullName.Split(' ');

firstName = fullNameAsParts[0];
middleName = fullNameAsParts[1];t
Console.WriteLine(firstName);
Console.WriteLine(lastName);

    //ignore every letter
    //once we reach a space, split the name 
    
    */
    
//split trim and white space on tues    

//escape characters, aka the backslash, tells the computer that if you're in a string,
// you are trying to type a quotation mark. First backslash means to treat the next character as a character 
// /n moves the text after it onto a new line. /t does a tab/indent
// $ symbol makes eveerything less chunky
/*
// $ example
string s;
int a = 5;
int b = 7;
int result;
result = a + b;

s = $"{a} + {b} = {result}";
Console.WriteLine(s);

// three quotations in a row makes a raw string. It also appears exactly how you type it out in code.

string s2; 

s2 = """
    Hello
    there
    """;
Console.WriteLine(s2);    

//addition program

int c;
int d;

a = 5;
b = 7;

int resulto;
resulto = a - b;
*/
/*
//Making  function signature

string Highlight(string textToHighlight)
{
    string highlightedText;
    string magenta = "\x1b[1;35m";
    string reset = "\x1b[1;39m";
    highlightedText = magenta + textToHighlight + reset;
    return highlightedText;
}

string text = Highlight("Hello!!");
Console.WriteLine("Hello!!");

//making an exponent function
// function signature
int Power(int x, int exponent)
{
int x;
int exponent;

x = 3;
exponent = 5;
int i = 0;
int product;
product = 1;

while (i < exponent)
{
    product = product * x;
    i++;
}

return product;
}


string GameboyWrite(string output)
{
    foreach (char currentChar in output)
    {
        Console.Write(currentChar);
    }
}

*/
//absolute value function

/*
int abs2(int number)
{
    return Math.Abs(number);
}

Console.WriteLine(abs2(number:-233425));
// warped functions

bool isEven(int number)
{
    return number % 2 == 0;
}

bool isOdd(int number)
{
    return number % 2 != 0;
}
int[] numbers = new int[] { 1, 2,3,4,5,6,7,8,9,10};
bool[] traits = new bool[numbers.Length];

int i = 0;
while (i < numbers.Length)
{
    bool trait = numbers[i] % 2 == 0;
    Console.WriteLine(numbers[i] + " : " + trait);
    i++;
}

foreach (bool trait in traits)
{
    Console.WriteLine(trait);
}

// int, bool, and char are value types
// array and string are reference types

StreamReader reader = new StreamReader();

StreamWriter writer = new StreamWriter(path: "/file.txt");

// tuesday we talked about the debugger 
//thurs we talk about stream reader and stream writer


writer.WriteLine("Hello!!!!");
writer.Close();

StreamReader reader = new StreamReader(insertfilehere);
string line;

while (true)
{
    line = reader.ReadLine();
    if (line == null)
    {
        break;

    }
    Console.WriteLine(line);
    
}
// making a thingamajig read a file

//try catch functions

try
{
    int[] myArray = new[] { 1, 6, 23, 8, 0 };
    myArray[10] = 4;
}

catch (Exception myException) //if there was an error, this runs
{
    Console.WriteLine("Something bad has happened!");
}
Console.WriteLine("Hello");

// if you write Exception for catches, it will catch every exception.
//for homework

Console.WriteLine("Where is the file?");
string filepath = Console.ReadLine();

bool isFilePathValid = false;

while (isFilePathValid == false)
{
    Console.WriteLine("Where is the darn file!!");
    string filepath = Console.ReadLine();
    try
    {


        StreamReader reader = new StreamReader(insert file here);
        isFilePathValid = true;

        string firstLine;
        firstLine = reader.ReadLine();
        Console.WriteLine(firstLine);

        reader.Close();
    }

    catch (Exception e)
    {
        Console.WriteLine("I think you mispelled the file name.");
    }
}
Console.WriteLine("Good Bye!");

// the finally function always runs at the end


//Finite State Machines or Flow Charts
// Traffic Lights

string state;
state = "mini";
string item = "none";

/* possible pworeups:
mushroom
fire flower
feather
nothing
shell

/* possible states:
    mini mario
    super mario
    fire mario
    cape mario

while (true)// we jus tgot a power-up, what do we do?
{
    if (state == "mini")
    {
         if (item == "mushroom")
    else if (state == "super")
    {
    }
    else if (state = "fire")
}
//C# Standard Library
// This function takes two numbers and average them, returning the result.

// only put public when there are more than one classes in one solution(document thing)
class MyMath
{


    static int average(int a, int b)
    {
        return (a + b) / 2;
    }

   static int add(int a, int b)
    {
        return a + b;
    }

    public double pi = 3.14;
    public double e = 2;

    static double average(double a, double b)
    {
        return (a + b) / 2;
    }

    static double average(string a, string b)
    {
        double aAsDouble;
        double bAsDouble;
        aAsDouble = double.Parse(a);
        bAsDouble = double.Parse(b);

        return (aAsDouble + bAsDouble) / 2;
    }
    static void Main()
    {
        double result = MyMath.average("3.5", "5.0");
        Console.WriteLine(result);
    }

    static void Main()
    {
        string greeting;
        greeting = "Nice to meet you, Brandon!";

        greeting.Split();' ',;
    }
}

string[] Split(char separator)
string[] split(string separator)
string[] Split(char[] separator)

class Console
{
    static public string ReadLine()
    {
        
    }

    static public void WriteLine(string output)
    {
        
    }

    static public void Write(string output)
    {
         
    }
}


// enumerators

enum Color
{
    green,
    red,
    yellow
}
//makes a new type of variable
*/



Console.WriteLine("What would you like to do?");
string command;
string input; 
string additionalInfo;
command = Console.ReadLine();
input = Console.ReadLine();
input = input.ToLower();


string[] splitInput;
splitInput = input.Split(" ");
command = splitInput[0];


void MoveInChooseDirection(string additionalInfo)
{
    if (additionalInfo == "west")
    {
        Console.WriteLine("You went west");
    }
    else if (additionalInfo == "east")
    {
        Console.WriteLine("You went east");
    }
    else if (additionalInfo == "north")
    {
        Console.WriteLine("You went north");
    }
    else if (additionalInfo == "south")
    {
        Console.WriteLine("You went south");
    }
    else
    {
        Console.WriteLine("idk what u doin man");
    }
}
try
{

    additionalInfo = splitInput[1];

    if (command == "move")
    {
        // now we are handling movement in a direction
        MoveInChooseDirection(additionalInfo);
    {
        Console.WriteLine("You took something");
    }
    else if (command == "use")
    {
        Console.WriteLine("You used something");
    }
    else
    {
        Console.WriteLine("I dont understand.");
    }
}

catch (Exception e)
    {
        command = input;
        if (command == "move")
        {
            Console.WriteLine("Where do you want to move");
            additionalInfo = Console.ReadLine();
        }
        else if (command == "take")
        {
            Console.WriteLine("What do you want to take?");
            additionalInfo = Console.ReadLine();
        }
        else if (command == "use")
        {
            Console.WriteLine("What do you want to use?");
            additionalInfo = Console.ReadLine();

        }
        else
        {
            Console.WriteLine("I don't understand");
        }
    }



