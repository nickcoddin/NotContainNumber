
public class Program
{
    public static void Main(string[] args)
    {
        int[] array = { 9, 15, 7, 4, 3, 5, 1, 2, 7 };
        int result = NotContains(array);
        Console.WriteLine(result);
    }

    public static int NotContains(int[] array)
    {
        int minNumber = 1;

        while (array.Contains(minNumber))
        {
            minNumber++;
        }

        return minNumber;
    }
}
