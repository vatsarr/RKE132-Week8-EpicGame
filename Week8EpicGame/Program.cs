
//string[] heroes = { "Harry Potter", "Batman", "Superman", "Hermione" };
//string[] villains = { "Voldemort", "Joker", "Sauron", "Darth Vader" };
string[] weapons = { "gun", "magic wand", "lightsaber", "banana", "sword" };

string folderPath = @"C:\Users\Risto\source\data";
string heroFile = "heroes.txt";
string villainFile = "villains.txt";

string[] heroes = File.ReadAllLines(Path.Combine(folderPath, heroFile));
string[] villains = File.ReadAllLines(Path.Combine(folderPath, villainFile));

string hero = GetRandomValueFromArray(heroes);
string heroWeapon = GetRandomValueFromArray(weapons);
string villain = GetRandomValueFromArray(villains);
string villainWeapons = GetRandomValueFromArray(weapons);

Console.WriteLine($"{hero} saves the day using a {heroWeapon}.");
Console.WriteLine($"{villain} takes over the world using a {villainWeapons}.");


static string GetRandomValueFromArray(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    string randomStringFromArray = someArray[randomIndex];
    return randomStringFromArray;
}