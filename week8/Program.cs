//string[] heroes = { "Harry Potter", "Luke Skywalker", "Lara Croft", "Scooby-Doo" };
//string[] villians = { "Voldemort", "Darth Vader", "Draculla", "Joker", "Sauron" };


string folderPath = @"C:\Users\SpireBlack\Documents\";
string heroFile = "heroes.txt";
string villianFile = "villains.txt";

string[] heroes = File.ReadAllLines(Path.Combine(folderPath,heroFile));
string[] villians = File.ReadAllLines(Path.Combine(folderPath,villianFile));


string[] weapon = { "Magic wand", "Plastic fork", "Banana", "Wooden sword", "Lego brick" };

string hero = GetRandomValueFromArray(heroes);
string heroWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {hero} with {heroWeapon} saves the day!");

string villian = GetRandomValueFromArray(villians);
string villianWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {villian} with {villianWeapon} tries to take over the world!");

static string GetRandomValueFromArray(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    string randomStringFromArray = someArray[randomIndex];
    return randomStringFromArray;
}