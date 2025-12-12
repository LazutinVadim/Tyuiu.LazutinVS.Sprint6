using Tyuiu.LazutinVS.Sprint6.Task6.V6.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        string path = Console.ReadLine();

        DataService ds = new DataService();

        try
        {
            string result = ds.CollectTextFromFile(path);



            Console.WriteLine("\nСлова содержащие 'b' или 'B':");
            Console.WriteLine(result);

        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nОшибка: {ex.Message}");
        }
    }
}