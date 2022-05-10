﻿List<dynamic[]> personalregister = new List<dynamic[]>();
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
                foreach (dynamic[] personal in personalregister)
                {
                    Console.WriteLine(personal[0] + " " + personal[1] + ", " + personal[2] + "kr");
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
            Console.Write("Förnamn: ");
            string förnamn = Console.ReadLine();
            Console.Write("Efternamn: ");
            string efternamn = Console.ReadLine();
            Console.Write("Lön: ");
            Double.TryParse(Console.ReadLine(), out double lön);
            personalregister.Add(new dynamic[] { förnamn, efternamn, lön });
            break;
        case "3":
            run = false;
            break;
    }
}
