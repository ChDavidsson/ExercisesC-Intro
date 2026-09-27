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
        
        // Be användaren skriva in två heltal.
        // Konvertera texten till tal med Convert.ToInt32().
        Console.WriteLine("Please provide a number:");
        string number1 = Console.ReadLine()!;
        int nummer1 = Convert.ToInt32(number1);
        Console.WriteLine("Please provide another number:");
        string number2 = Console.ReadLine()!;
        int nummer2 = Convert.ToInt32(number2);
        // Räkna ut summan av talen.
        int total = nummer1 + nummer2;
        int multiplikation = nummer1 * nummer2;
        // Skriv ut resultatet i konsolen.
        Console.WriteLine($"The sum of your numbers is: {total} and multiplicated it is: {multiplikation}");
    }
}
