/*Plot: You work in an office, but you were sleeping and the printer exploded(oh no)
causing the entire office building to collapse, but then you then fall into a secret
area underneath your own office building which coincidentally belongs to a wanted criminal, and he’s proooobably coming home. 

How to win:
Start in the Kitchen
    “move right” to enter the living room
    “move down" to enter the bathroom
    “Take key” to add the key to your inventory
    “move left” to enter the room of cat pictures
OPTIONAL: “take cat pics” to rob the guy idk he’s a wanted criminal he probably doesn’t deserve them
    “move up” to enter Kitchen
    “Use key” to unlock the Bedroom 
    “Use secret exit” to escape 
*/







enum Room
{
    Kitchenwithagiantholeaboveit,
    Bedroom,
    LivingRoom,
    Bathroom,
    RoomofCatPictures,
    Pantry,
}

class GameProgram
{
    private static Room currentRoom = Room.Kitchenwithagiantholeaboveit;
    private static bool hasKey = false;
    private static bool hasCatPics = false;
    private static bool bedroomUnlocked = false;
    private static bool gameRunning = true;

    static void Main()
    {
        Console.WriteLine("You just fell and hit your head on the kitchen floor of this strange house.");
        Console.WriteLine("There is a locked bedroom above you, a pantry to your left, a living room to your right, and a room of cat pictures below you.");
        Console.WriteLine("Oh don't forget that giant hole above you.");

        while (gameRunning)
        {
            Console.WriteLine("What would you like to do?");
            string input = Console.ReadLine().ToLower().Trim();
            string[] parts = input.Split(' ');
            if (parts.Length < 2)
            {
                Console.WriteLine("Please enter a valid command, like \"Move right\"");
                continue;
            }

            switch (currentRoom)
            {
                case Room.Kitchenwithagiantholeaboveit:
                    if (input == "move right")
                    {
                        currentRoom = Room.LivingRoom;
                        DescribeRoom();
                    }
                    else if (input == "use key" && !hasKey)
                    {
                        Console.WriteLine("You do not have a key.");
                    }
                    else if (input == "use key" && hasKey)
                    {
                        bedroomUnlocked = true;
                        Console.WriteLine("You've unlocked the Bedroom door.");
                        hasKey = false;
                    }
                    else if (input == "move left")
                    {
                        currentRoom = Room.Pantry;
                        DescribeRoom();
                    }
                    else if (input == "move down")
                    {
                        currentRoom = Room.RoomofCatPictures;
                        DescribeRoom();
                    }
                    else if (input == "move up")
                    {
                        if (bedroomUnlocked == true)
                        {
                            currentRoom = Room.Bedroom;
                            DescribeRoom();
                        }
                        else
                        {
                            Console.WriteLine("The Bedroom door is locked.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You can't do that.");
                    }

                    break;
                case Room.LivingRoom:
                    if (input == "move down")
                    {
                        currentRoom = Room.Bathroom;
                        DescribeRoom();
                    }
                    else if (input == "move left")
                    {
                        currentRoom = Room.Kitchenwithagiantholeaboveit;
                        DescribeRoom();
                    }
                    else
                    {
                        Console.WriteLine("You can't do that.");
                    }
                    break;
                case Room.Bathroom:
                    if (input == "take key" && !hasKey)
                    {
                        hasKey = true;
                        Console.WriteLine("You picked up the key.");
                    }
                    else if (input == "move left")
                    {
                        currentRoom = Room.RoomofCatPictures;
                        DescribeRoom();
                    }
                    else if (input == "move up")
                    {
                        currentRoom = Room.LivingRoom;
                        DescribeRoom();
                    }
                    else
                    {
                        Console.WriteLine("You can't do that.");
                    }

                    break;
                case Room.RoomofCatPictures:
                    if (input == "take cat pics" && !hasCatPics)
                    {
                        hasCatPics = true;
                        Console.WriteLine("You took the cat pics. The guy isn't gonna miss these.");
                    }
                    else if (input == "move up")
                    {
                        currentRoom = Room.Kitchenwithagiantholeaboveit;
                        DescribeRoom();
                    }
                    else if (input == "move right")
                    {
                        currentRoom = Room.Bathroom;
                        DescribeRoom();
                    }
                    else
                    {
                        Console.WriteLine("You can't do that.");
                    }

                    break;
                case Room.Bedroom:
                    if (input == "use secret exit" && hasCatPics)
                    {
                        Console.WriteLine("You escaped the house! And with the guy's cat pics! Although this one strangely looks like my neighbor's cat. And this one looks like mines. Weird.");
                        gameRunning = false;
                    }
                    else if (input == "use secret exit" && !hasCatPics)
                    {
                        Console.WriteLine("You escaped the house! I suppose this means you don't have to go to work tomorrow.");
                        gameRunning = false;
                    }
                    else if (input == "move down")
                    {
                        currentRoom = Room.Kitchenwithagiantholeaboveit;
                        DescribeRoom();
                    }
                    else
                    {
                        Console.WriteLine("You can't do that.");
                    }

                    break;
                case Room.Pantry:
                    if (input == "move right")
                    {
                        currentRoom = Room.Kitchenwithagiantholeaboveit;
                        DescribeRoom();
                    }
                    else
                    {
                        Console.WriteLine("You can't do that.");
                    }
                    break;
            }
            static void DescribeRoom()
            {
                switch (currentRoom)
                {
                    case Room.Kitchenwithagiantholeaboveit:
                        Console.WriteLine("You're in the Kitchen. You can go left, right, up, or down.");
                        break;
                    case Room.LivingRoom:
                        Console.WriteLine("You're in the Living Room. You can go down or left.");
                        break;
                    case Room.Bathroom:
                        Console.WriteLine("You're in the Bathroom. There's a key here. For some reason. You can go up or left.");
                        break;
                    case Room.RoomofCatPictures:
                        Console.WriteLine("You're in the Room of Cat Pictures. You could steal these if you want. You can also go up or right.");
                        break;
                    case Room.Bedroom: 
                        Console.WriteLine("You are in the Bedroom. There is a secret exit here.");
                        break;
                    case Room.Pantry:
                        Console.WriteLine("You're in the pantry. There's absolutely nothing here. You should leave.");
                        break;
                        
                }

        }
        }
    }
}









