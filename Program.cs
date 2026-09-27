namespace ExercisesC_Intro;

class Program
{
    static void Main(string[] args)
    {
        // Be användaren skriva in sitt namn.
        Console.WriteLine("Please provide your name:");
        string input = Console.ReadLine()!;
        
        // Skriv sedan ut ett meddelande som säger "Hej [namn]!"
        Console.WriteLine($"Hej {input}!");

        // Be användaren skriva hur gammal de är.
        Console.WriteLine("How old are you?");
        string input2 = Console.ReadLine()!;
        int age = Convert.ToInt32(input2);
        // Använd en const variabel för innevarande år.
        const int Year = 2026;
        int Born = Year - age;
        // Beräkna sedan vilket år de är födda.
        Console.WriteLine($"Okay, so you are born {Born}?");
        
        // Be användaren skriva:
        // Ett heltal
        Console.WriteLine("Write an integer:");
        string integer = Console.ReadLine()!;
        int heltal = Convert.ToInt32(integer);

        // Ett decimaltal
        Console.WriteLine("Write a decimal number:");
        string deciNumber = Console.ReadLine()!;
        double deciTal = Convert.ToDouble(deciNumber);

        // Ett värde som är true eller false
        Console.WriteLine("Write true or false:");
        string truefalse = Console.ReadLine()!;
        bool minBool = Convert.ToBoolean(truefalse);

        // Skriv sedan ut all information igen på en rad.
        Console.WriteLine($"You wrote: {heltal}, {deciTal} and {minBool}");

    }
}
