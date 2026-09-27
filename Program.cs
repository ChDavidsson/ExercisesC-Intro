namespace ExercisesC_Intro;

class Program
{
    static void Main(string[] args)
    {
        // Be användaren skriva in sitt namn.
        Console.WriteLine("Please provide your name:");
        string input = Console.ReadLine()!;

        Console.WriteLine($"Hej {input}!");
        
        // Skriv sedan ut ett meddelande som säger "Hej [namn]!"
    }
}
