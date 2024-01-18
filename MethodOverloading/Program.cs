namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(6, 6));
            Console.WriteLine(Add(2.1m, 1.7m));
            Console.WriteLine(Add(1,0,true));
            
        }
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
        public static string Add(int x, int y, bool isTrue)
        {

            if (isTrue == true && (x + y) > 1)
            {
                return $"{x + y} dollars";
            }
            else if (isTrue == true && (x + y) == 1)
            {
                return $"{x + y} dollar";

            }
            else
            {
                return $"{x + y} dollars";
            }
        }

    }
}
