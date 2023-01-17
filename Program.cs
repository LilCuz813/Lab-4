Console.WriteLine("Student Database");

string[] names = { "Justin Jones", "Ethan Thomas", "Belle Baxley", "Allison Jones", "John Glandon",
    "Michael Blackburn", "Christopher Washington", "Earle Fox", "Joshua Carolin", "Mourad Alfadil",
    "Tee Sotomi", "Wilfredo Pacheco", "Jun Kim", "Jason Garrison", "Cam Dixon", "Josh Strathres" };

string[] towns = { "Columbus", "Urbana", "Haleiwa", "Grand Rapids", "Detroit",
    "Warren", "Detroit", "Saline", "Westland", "Detroit",
    "Chicago", "Canton", "Lubbock", "Chelsea", "South Lyon", "Oxford" };

string[] foods = { "Baja Blast", "Hot Wings", "french fries", "Pad Ke Mao", "Stir fry",
    "Anpan", "Egg roll", "Pizza", "Naleśniki", "Fried Rice",
    "Pasta", "Quesadilla", "noodles", "Chewing Tobacco", "Coney Dogs", "Pizza" };

while (true)
{
    Console.WriteLine("Please enter number from 1 - 16 for studemt name: ");
    int name = int.Parse(Console.ReadLine());
    if(name > 0 && name <= names.Length - 0)
    {
        Console.WriteLine("Student " + name + " is " + names[name - 1]);

        while (true)
        {
            Console.WriteLine("Please enter hometown or favorite food: ");
            string choice = (Console.ReadLine().ToLower().Trim());


            if (choice == "hometown" || choice == "town")
            {
                Console.WriteLine(names[name - 1] + " is from " + towns[name - 1]);
                break;
            }
            else if (choice == "favorite food" || choice == "food")
            {
                Console.WriteLine(names[name - 1] + " favorite food is " + foods[name - 1]);
                break;
            }
            else
            {
                Console.WriteLine("Invaild input. Please try again");
            }

        }
    }
    else
    {
        Console.WriteLine("Invaild input. Please enter number from 1-16");
        continue;
    }
    Console.WriteLine("Would you like to start over? y/n");
    string choice2 = Console.ReadLine().ToLower().Trim();

    if(choice2 == "yes" || choice2 == "y")
    {
        continue;
    }
    else if(choice2 == "no" || choice2 == "n")
    {
        Console.WriteLine("Thank you. Goodbye!");
        break;
    }
}
Console.ReadLine();





