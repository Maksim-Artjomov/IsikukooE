using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<string> idCodeList = new List<string>();

        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-------------------");
            Console.WriteLine("Valige tegevus :");
            Console.WriteLine("1. Isikukoodi lisamine");
            Console.WriteLine("2. Isikukoodide vaatamine");
            Console.WriteLine("3. Välju");
            Console.WriteLine("-------------------");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("-------------------");
                    Console.WriteLine("Sisesta isikukood:");
                    string idCode = Console.ReadLine();
                    IdCode id = new IdCode(idCode);

                    if (id.IsValid())
                    {
                        idCodeList.Add(idCode);
                        Console.WriteLine("Isikukood lisati edukalt.");
                        Console.WriteLine("Sugu: " + id.GetGender());
                        DateTime? birthDate = id.GetBirthDate();
                        if (birthDate.HasValue)
                        {
                            Console.WriteLine("sunnipaev: " + birthDate.Value.ToShortDateString());
                        }
                    }
                    else
                    {
                        Console.WriteLine("Vigane sinikakood. Sisesta palun õige hesikukood");
                    }
                    break;
                case "2":
                    Console.WriteLine("-------------------");
                    Console.WriteLine("Isikukoodide nimekiri:");

                    foreach (var code in idCodeList)
                    {
                        Console.WriteLine(code);
                    }
                    break;
                case "3":
                    Environment.Exit(0);

                    break;
                default:
                    Console.WriteLine("Te sisestasite puuduva arvu. Sisesta palun üks number 1 kuni 3.");
                    break;
            }

            Console.ResetColor();
            Console.ReadLine();
        }
    }
}