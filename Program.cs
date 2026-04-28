namespace Math.Logic.Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int16 _i16min = Int16.MinValue;
            while (_i16min < Int16.MaxValue)  // while (_i16min <= Int16.MaxValue) Deadloop
            {
                if (_i16min % 2 == 0)
                {
                    Console.WriteLine(_i16min + " gerade");
                }
                else
                {
                    Console.WriteLine(_i16min + " ungerade");
                }
                _i16min++;
            }
        }
    }
}

/* Int16 _i16 = Int16.MaxValue;
        Console.WriteLine($"int16_max = {_i16}");
        Console.WriteLine(_i16 % 1);
        _i16++;
        Console.WriteLine($"Int16 + 1 = {_i16}");
        _i16++;
        Console.WriteLine($"Int16 + 2 = {_i16}");
        _i16++;
        Console.WriteLine($"Int16 +3 = {_i16}");
       */