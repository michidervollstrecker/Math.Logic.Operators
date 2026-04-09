namespace Math.Logic.Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (Int16 min16 = Int16.MinValue; min16 < Int16.MaxValue;)
            {
                min16++;
                Console.WriteLine(min16);
                if (min16 == Int16.MaxValue)
                {
                    Console.WriteLine("int16_Max " + min16);

                    Console.WriteLine(("int16_Max +1 " + min16++));
                }
            }
            Console.WriteLine(Int16.MaxValue);
            Console.WriteLine(Int16.MinValue);
        }
    }
}
