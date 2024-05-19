namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 3;
            int sum = SumOfNumbers(number);
            Console.WriteLine(SumOfNumbers(number));
            SumOfNumbersVoid(number);
        }


        static int SumOfNumbers(int number)
        {
            int sum = 0;

            for (int i = 0; i <= number; i++)
            {
                sum += i;
            }

            return sum;
        }
        static void SumOfNumbersVoid(int number)
        {
            int sum = 0;

            for (int i = 0; i <= number; i++)
            {
                sum += i;
            }
            
            Console.WriteLine(sum);
        }
    }

    


}
