namespace Math.Logic.Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3;              // hier wird dem Buchstaben a der Wert 0 zugewiesen
            int b = 10;              // ein Integer kann nur aus Ganzzahlen bestehen
            double db = 5.5;        // Der Datentyp double besteht aus zwei Integer.
            double bb = 6.6;        // 
            string st = "Text1234"; // Der Datentyp string besteht aus Zeichen. Beispiel die Texteingabe des Nutzers.
                                    // Die Variablen mit denen ich arbeiten werde sind jetzt definiert
            int c = a + b;          // c erhält den Wert 13
            bool boo1 = true;       // Booleanische Ausdrücke sind die kleinsten Ausdrücke, da nur 0 oder 1 sind.
            bool boo2 = false;      // Bei der if Abfrage werden 2 oder mehrere werte verglichen.
            if (a + b == 13)        // a + b ist 13 somit == true
            {
                Console.WriteLine("a + b == 13");
            }
            if (a + b != 13)        // a+b ist nicht gleich 13, true
            {
                Console.WriteLine("a + b != 13");
            }
            if (a == 13 || b == 13)     // || // Wenn a ODER b wahr ist
            {
                Console.WriteLine("a oder b ist 13");
            }
            if (a == 13! | b == 13)      // !| XOR operator heiß wenn NUR eines der Werte wahr ist
            {
                Console.WriteLine("Nur a oder b ist 13");
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
