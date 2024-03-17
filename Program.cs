namespace Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            
            double[] numbers = new double[10];

            Console.WriteLine("Please enter a number between 1 - 100");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter another number between 1 - 100");
            double y = double.Parse(Console.ReadLine());



            // Lambda Expressions
            // Add 2 numbers
            var sum = (double x, double y) => x + y;
            // Multiply 2 numbers
            var result = (double x, double y) =>  x * y;
            // Lambda Statements
            // Find the larger number
            var largerValue = (double x, double y) =>
            {
                if (x > y)
                    return x;
                else
                    return y;
            };

            // Using lambda expressions and statements
            
                Console.WriteLine($"Numbers you are using: {x}  and  {y}");
                Console.WriteLine($"The sum is: {sum(x, y)}");
                Console.WriteLine($"The product is: {result(x, y)}");
                Console.WriteLine($"The larger value is: {largerValue(x, y)}");
                Console.WriteLine();
            

        }
    }
}