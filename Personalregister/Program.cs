

List<dynamic[]> personalregister = new List<dynamic[]>();

bool run = true;
while (run)
{
    Console.Clear();
    Console.WriteLine("Personalregister");
    Console.WriteLine("\t1. Skriv ut personalregistret.");
    Console.WriteLine("\t2. Lägg till ny personal");
    Console.WriteLine("\t3. Avsluta");
    Console.WriteLine();
    Console.Write("Val: ");

    switch (Console.ReadLine())
    {
        case "1":
            if (personalregister.Count > 0)
            {
                Console.WriteLine("Skriv ut personalregistret\n");
                foreach (dynamic[] personal in personalregister)
                {
                    Console.WriteLine($"Namn: {personal[0]}, Lön: {personal[1]}kr");
                }
            }
            else
            {
                Console.WriteLine("Det finns inga personal i personalregistret");
            }

            Console.WriteLine("Tryck på Enter för att återgå till menyn.\n");
            Console.ReadLine();

            break;
        case "2":
            Console.WriteLine("\tLägg till ny personal\n");

            string namn;
            do
            {
                Console.Write("\nNamn: ");
                namn = Console.ReadLine();
                if (string.IsNullOrEmpty(namn))
                {
                    Console.WriteLine("Personen behöver ett namn.");
                }
            } while (string.IsNullOrEmpty(namn));

            double lön = 0;
            do
            {
                Console.Write("\nLön: ");
                Double.TryParse(Console.ReadLine(), out lön);
                if (lön <= 0)
                {
                    Console.WriteLine("Personen behöver en lön, endast nummer accepteras.");
                }
            } while (lön <= 0);

            personalregister.Add(new dynamic[] { namn, lön });

            break;
        case "3":
            run = false;
            break;
        default:
            Console.WriteLine("Nagivera menyn genom att trycka in den siffra som motsvarar det du vill utföra.");
            break;
    }
}
