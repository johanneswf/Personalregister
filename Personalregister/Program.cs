using Personalregister;

List<Personal> personalregister = new List<Personal>();
bool run = true;
while (run)
{
    Console.Clear();
    Console.WriteLine("Välj ett alternativ nedan:");
    Console.WriteLine("1. Skriv ut personalregistret.");
    Console.WriteLine("2. Lägg till ny personal");
    Console.WriteLine("3. Avsluta");
    switch (Console.ReadLine())
    {
        case "1":
            Console.Clear();
            if (personalregister.Count > 0)
            {
                Console.WriteLine("Skriv ut personalregistret\n");
                foreach (var personal in personalregister)
                {
                    Console.WriteLine($"{personal.Förnamn} {personal.Efternamn}, {personal.Lön}kr");
                }
            }
            else
            {
                Console.WriteLine("Det finns inga personal i personalregistret\n");
            }
            Console.WriteLine("Tryck på Enter för att återgå till menyn.\n");
            Console.ReadLine();
            break;
        case "2":
            Console.Clear();
            Console.WriteLine("Lägg till ny personal\n");
            Personal nyPersonal = new Personal();
            nyPersonal.Förnamn = ValideraSträng("Förnamn: ", "Personen behöver ett förnamn.");
            nyPersonal.Efternamn = ValideraSträng("Efternamn: ", "Personen behöver ett efternamn.");
            nyPersonal.Lön = ValideraDubbel("Lön: ", "Personen jobbar inte gratis.");
            personalregister.Add(nyPersonal);
            break;
        case "3":
            run = false;
            break;
    }
}

static string ValideraSträng(string buffer, string felmeddelande)
{
    string valid;
    do
    {
        Console.Write(buffer);
        valid = Console.ReadLine();
        if (valid == "")
            Console.WriteLine(felmeddelande);
    } while (valid == "");
    return valid;
}
static double ValideraDubbel(string buffer, string felmeddelande)
{
    double valid;
    do
    {
        Console.Write(buffer);
        Double.TryParse(Console.ReadLine(), out valid);
        if (valid == 0)
            Console.WriteLine(felmeddelande);
    } while (valid == 0);
    return valid;
}