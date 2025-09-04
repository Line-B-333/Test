namespace Testing.ClassLibrary;

//Jacob "Hvorfor virker klassen ikke" - Svar: "Der mangler en main metode"
public class Kunde
{

    public Kunde(string Name, int Age, long Cpr)
    {
        this.Name = Name;
        this.Age = Age;
        this.Cpr = Cpr;
    }
    public string Name { get; set; }

    //Der er en skjult instance variable ligger i back end field
    public int Age { get; set; }

    //Do not use int for CPR, cause 0 disappears
    public long Cpr { get; private set; }

    /// <summary>
    /// A method that takes any number of names and returns them as a single string, separated by commas.
    /// 
    /// By makeing it static it's doesnt belong to an instance of kunde
    /// Which means the method can be used without creating an instance of the Kunde class.
    /// </summary>
    /// <param name="names"></param>
    /// <returns></returns>
    public static string AddAnyNumberOfNames(params string[] names)
    {
        return string.Join(", ", names);
    }

    public static void GreetCustomer(params string[] names)
    {
        if (names.Length == 0)
        {
            Console.WriteLine("Usage: Testing.ConsoleApp.exe <name1> <name2> ... <nameN>");
        }
        else
        {
            foreach (string name in names)
            {
                if (name == "Line")
                {
                    Console.WriteLine($"Welcome back {name}");
                }
                else
                {
                    Console.WriteLine($"Hello, {name}!");
                }
            }
        }
    }


}
