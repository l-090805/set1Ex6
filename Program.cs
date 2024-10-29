namespace set1Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti lungimea primei laturi: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduceti lungimea celei de a 2 a laturi: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduceti lungimea celei de a 3 a laturi: ");
            double c = Convert.ToDouble(Console.ReadLine());


                if (a < (b + c) && b < (a + c) && c < (a + b))
                {
                    Console.WriteLine("Laturile formeaza un triunghi");
                }
                else
                {
                    Console.WriteLine("Laturile nu formeaza un triunghi");
                }




        }
    }
}
