using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // StreamReader example
        Console.WriteLine("=== StreamReader Example ===");
        using (StreamReader reader = new StreamReader("C:\\Users\\ville\\Downloads\\examplestream.txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }

        // StreamWriter example
        Console.WriteLine("=== StreamWriter Example ===");
        using (StreamWriter writer = new StreamWriter("C:\\Users\\ville\\Downloads\\log.txt", true))
        {
            string message = "This is my StreamWriter logging details " + DateTime.Now.ToString() + ".";
            writer.WriteLine(message);
            Console.WriteLine(message);
        }
    }
}
