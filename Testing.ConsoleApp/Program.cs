
namespace Testing.ConsoleApp;
using Testing.ClassLibrary;
internal class Program
{
      
    static void Main(string[] args)
    {
        // 12. Using the static method GreetCustomer to greet any number of customers passed as command line arguments
        // This calls the method GreetCustomer and pass the args along
        // Args is an array of strings, which can hold any number of names
        Kunde.GreetCustomer(args);

        //9. Second attempt on making a method to add any number of names and greeting each person
        /**
         
        if (args.Length == 0)
        {
            Console.WriteLine("Usage: Testing.ConsoleApp.exe <name1> <name2> ... <nameN>");
        }
        else
        {
            foreach (string name in args)
            {
                //10. Says welcome back to Line
                if (name == "Line")
                {
                    Console.WriteLine($"Welcome back {name}");
                }
                else
                {
                    Console.WriteLine($"Hello, {name}!");
                }
                    
            }
        }*/

        //9. First attempt on making a method to add any number of names and greeting each person
        //String printKundeNavne = Kunde.AddAnyNumberOfNames("Lars", "Peter", "Hans", "Kurt", "Finn", "Jan", "Bo", "Kim");
        //Console.WriteLine(printKundeNavne);

        /**         
        if (args.Length >= 2)
        {
            string name = args[0];
            int age = int.Parse(args[1]);
            Console.WriteLine($"Hello {name}, you are {age} years old.");
            Kunde kunde = new Kunde(name, age, 1234567890);
            Console.WriteLine($"Kunde created: Name = {kunde.Navn}, Age = {kunde.Age}, CPR = {kunde.Cpr}");
        }
        else
        {
            Console.WriteLine("Please provide at least two arguments: name and age.");
        }*/




        //Console.WriteLine("Please enter name: ");
        //string? name = Console.ReadLine();
        //Console.WriteLine($"Hello {name}, and welcome to c#");
        //Kunde kunde = new Kunde("Lars", 30, 123456-7890);


    }
}
