namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            int sum = a + b;
            int subtract = a - b;
            int product = a * b;
            int quotient = a / b;
            int remainder = a % b;


            Console.WriteLine($"{a}+{b} is {sum}");
            Console.WriteLine($"{a}-{b} is {subtract}");
            Console.WriteLine($"{a}*{b} is {product}");
            Console.WriteLine($"{a}/{b} is {quotient}");
            Console.WriteLine($"{a}%{b} is remainder {remainder}");

            Console.WriteLine("Please enter the radius");
            double userInput = int.Parse(Console.ReadLine());
            Console.WriteLine(AreaOfCircle(userInput));

        }

        public static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);

        }

    }
}
