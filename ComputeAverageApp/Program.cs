namespace ComputeAverageApp
{
    internal class ComputeAverageProgram
    {
        static void Main(string[] args)
        {
            double sum = 0;

            Console.WriteLine("Enter 5 grades separated by new line:");
            int i = 0;
            for (i = 1; i <= 5; i++)
            {
                double number = Convert.ToDouble(Console.ReadLine());
                sum += number;
            }

            if (i == 6)
            {
                i--;
            }

            double average = sum / i;

            Console.WriteLine("The average is " + average + " and round off to " + Math.Round(average));
        }
    }
}