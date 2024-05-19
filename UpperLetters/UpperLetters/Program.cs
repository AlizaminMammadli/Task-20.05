namespace UpperLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string words = "Konlu Baliq Isteyen, Quyrugu Suda Gerek";

            string upperLet = UpperCase(words);

            Console.WriteLine(upperLet);
        }
        static string UpperCase (string words) 
        {
            string upperLet = "";
       
        foreach (char c in words)
            {
                
                if (c >= 'A' && c <= 'Z') 
                {
                    upperLet += c;
                }
            }
        return upperLet;
        
        }
    }
}
