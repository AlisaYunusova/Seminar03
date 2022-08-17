using System;

class Program
{
    static void SelectRace()
    {
        Console.WriteLine("Выберите расу: ");

        string[] namesRace = { "Люди", "Эльфы", "Орки", "Гномы" };

        for (int i = 0; i < namesRace.Length - 1; i++)
        {
            Console.Write((i + 1) + "-" + namesRace[i] + ",");
        }
        Console.WriteLine(namesRace.Length + " - " + namesRace[namesRace.Length - 1] + ".");
        int IndexRace = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ваша раса" + "-" + namesRace[IndexRace - 1]);
    }
    static void SelectClass()
    {
        Console.WriteLine("Выберите класс: ");
        string[] namesClass = { "Вор", "Маг", "Врачеватель", "Воин" };
        for (int i = 0; i < namesClass.Length - 1; i++)
        {
            Console.Write((i + 1) + "-" + namesClass[i] + ",");
        }
        {
            Console.WriteLine(namesClass.Length + " - " + namesClass[namesClass.Length - 1] + ".");
        }
        int IndexClass = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ваша класс" + "-" + namesClass[IndexClass - 1]);
    }
    static void Main(string[] args)
    {
        SelectRace();
        SelectClass();
    }
}

