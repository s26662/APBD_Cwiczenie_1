class Program
{
    public static void Main(string[] args)
    {
        //Zadanie 2
        // See https://aka.ms/new-console-template for more information
        Console.WriteLine("Modyfikacja 3");
        
        //Zadanie 4
        int[] numbers = { 10, 25, 3, 99, 42 };
        Console.WriteLine("Maksymalna w wartość: " + findMax(numbers));
    }
    
    //Zadanie 3
    public static double averege(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0) return 0;
        return numbers.Average();
    }

    public static int findMax(int[] numbers)
    {
        int maxN = numbers[0];
        foreach (int num in numbers)
        {
            if (num > maxN)
            {
                maxN = num;
            }
        }
        return maxN;
    }


}




