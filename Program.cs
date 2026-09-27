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
        

    }
}
