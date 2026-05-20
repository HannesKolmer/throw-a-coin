string BenutzerEingabe = string.Empty;
int Münzwurf = new Random().Next(1, 3);
string generatedMünzwurf = "";
string playAgain = string.Empty;

while (true)
{
    if (Münzwurf == 1)
    {
        generatedMünzwurf = "k";
    }
    else if (Münzwurf == 2)
    {
        generatedMünzwurf = "z";
    }
    Console.WriteLine("Kopf oder Zahl? (K/Z)");
    BenutzerEingabe = Console.ReadLine().ToLower();
    if (BenutzerEingabe == generatedMünzwurf)
    {
        Console.WriteLine("du hast gewonnen!!");
        Console.WriteLine("Möchtest du nochmal spielen? (J/N)");
        playAgain = Console.ReadLine().ToUpper();
        if (playAgain == "J")
        {
            Münzwurf = new Random().Next(1, 3);
            continue;
        }
        break;
    }
    else
    {
        Console.WriteLine("Versuche es erneut!!");
        Münzwurf = new Random().Next(1, 3);
    }
}