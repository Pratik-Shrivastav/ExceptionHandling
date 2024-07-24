public class Program
{
    static void DoMoreStuff()
    {
        int number1 = 1;
        int number2 = 0;
        Console.WriteLine(number1 / number2);
    }
    static void DoStuff()
    {
        DoMoreStuff();
        Console.WriteLine("Inside Do Stuff");
    }
    static void Main(string[] args)
    {
        DoStuff();
        Console.WriteLine("Inside Main");
    }
}