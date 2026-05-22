string specialsfile;
string logsfile;

//specials
while (true)
{
    Console.WriteLine("What filepath contains today's specials?");
    specialsfile = Console.ReadLine();
    try
    {
        if (File.Exists(specialsfile))
        {
        }
        break;
        //replace with the streamreader
    }
    catch (Exception e)
    {
        Console.WriteLine("File does not exist, please try again");
    }
}

// logs

while (true)
{
    Console.WriteLine("What filepath contains the logs?");
    logsfile = Console.ReadLine();
    try
    {
        if (File.Exists(logsfile))
        {
        }
        break;
    }
    catch
    {
        Console.WriteLine("File does not exist, please try again");
    }
}

Console.WriteLine("Where will the results be saved?");
string resultsfile = Console.ReadLine();

string specialsName;
using (StreamReader specialsreader = new StreamReader(specialsfile))
{
    string specialsLine = specialsreader.ReadLine().Trim().ToLower();
    string[] specialsinparts = specialsLine.Split(":");
    specialsName = specialsinparts[1].Trim();
}
int specialsamount = 0;
int totalfish = 0;
string specialsName2;
string[] logs = File.ReadAllLines(logsfile);

foreach (string data in logs)
{
    string trimmeddata = data.Trim().ToLower();
    string[] parts = trimmeddata.Split(' ');
    string fishName = parts[1];
    specialsName2 = parts[1];
    if (fishName == specialsName2)
    {
        specialsamount++;
    }
}

string results;

using (StreamWriter writer = new StreamWriter(resultsfile))
{
    writer.WriteLine($"Today's special is {specialsName}");
    writer.WriteLine($"Total {specialsName} caught: {specialsamount}");
    writer.WriteLine($"Total fish caught {totalfish}");
}

