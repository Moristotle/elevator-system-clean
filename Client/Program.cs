namespace Client;
using Application.Features;
// Entry point for the program
// TODO: Add the invocation of the different
public class Program
{

    public static void Main(string[] args)
    {


        // See https://aka.ms/new-console-template for more information
        List<string> list = new List<string>();
        // how to add to list
        /*
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Please enter floor");
            list.Add(Console.ReadLine());
        }
        */
        Console.WriteLine("Please enter floor(s)");
        Console.ReadLine();
        for (int i = 0; i < args.Length; i++)
        {
            switch (args[i])
            {
                case "-internal":
                    List<string> list2 = new List<string>();
                    for (int x = 1; x < args.Length; x++)
                    {
                        list2.Add(args[x]);
                    }
                    list.AddRange(list2);
                    break;
                case "-external":
                    list.Add(args[i + 1]);
                    break;
                default:
                    break;
            }
        }
        Console.WriteLine(string.Join(" ", list));
        Console.WriteLine("seperator");
        Console.WriteLine(string.Join(" ", args));

    }




}
