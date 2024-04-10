internal class Program
{
    public static void Main(string[] args)
    {
        var fibonacci = new List<int> { 1, 1 };


        while (fibonacci.Count <= 30)
        {
            var previousNumber1 = fibonacci[fibonacci.Count - 1];
            var previousNumber2 = fibonacci[fibonacci.Count - 2];

            var result = previousNumber1 + previousNumber2;
            fibonacci.Add(result); 
            Console.WriteLine(result);
        }
    }
}