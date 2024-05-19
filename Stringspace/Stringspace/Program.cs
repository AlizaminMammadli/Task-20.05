namespace Stringspace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Code Academy PB201";
            string result = StringSpace(name);
            Console.WriteLine(result);




        }
        static string StringSpace(string name)
        {
            string result = "";

            foreach (char c in name)
            {
                if (c != ' ')
                    result += c;
            }
            return result;
        }

    }
}
