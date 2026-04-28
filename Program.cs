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

            if (a == 13 && b == 13)
            {
                Console.WriteLine(" a ist 13 und b ist 13");
            } // Wenn a && UND b 13 ist

            // Jetzt kommt null und ??
            // Nochmal zum Anfang a hat den Wert 3 zugewiesen bekommen und nimmt somit Platz im Arbeitsspeicher ein.
            // NULL heißt dass der Platz im Speicher nicht beschrieben ist
            // Angenommen du fragst ein Textfeld ab und dieses Textfeld geht davon aus, dass der Nutzer eine Eingabe machen wird,
            // somit hat das Textfeld bereits einen Platz im Arbeitsspeicher reserviert.
            // NULL bedeutet dass kein Platz im Arbeitsspeicher reserviert ist.
            // Das ?? Bedeutet, dass wenn der Nutzer ein Textfeld ausfüllen soll 
            // und der Nutzer hat aber keinen Wert eingetragen, wird es aber trotzdem nicht zu einem Error kommen, 
            // da die Variable vom UserInput ?? ist somit auch wahr ist wenn der Nutzer keinen Wert eingibt.


            string n = null; // n wird hier als string deklariert und hat den Wert null ist also Empty.
            string up = Console.ReadLine();
            string? up2 = up + up;      // Das ? macht, dass es keinen Fehler ausgibt, wenn der Wert nicht korrekt zugewiesen ist.
            Console.WriteLine(up2);

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