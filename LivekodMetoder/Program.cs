
void ÖvningTre()
{
    // Skriv ett program som frågar användaren efter ett tal.
    // Det ska skriva ut om talet är mindre än 100, lika med 100 eller större.

    //+Fråga användaren efter ett tal
    Console.WriteLine("Skriv in ett tal");
    //+ Ta emot ett tal från användaren
    string input = Console.ReadLine();
    //! Byta datatyp från text till tal
    int number = int.Parse(input);
    //+ Om talet är mindre än 100'
    if (number < 100)
    {
        //+	Skriv ut att det är mindre än 100
        Console.WriteLine("Talet är mindre än 100");
    }
    //+ Annars om talet är lika med 100
    else if (number == 100)
    {
        //+	Skriv ut att det är 100
        Console.WriteLine("Talet är lika med 100");
    }
    //+ Annars
    else
    {
        //	Skriv ut att det är större än 100
        Console.WriteLine("Talet är st örre än 100");
    }
}

void ÖvningFem()
{
    // Skriv ett program som upprepade gånger frågar användaren efter ett tal ända till man skriver något som inte är ett tal
    // (t.ex bara trycker enter).
    // Efter varje inmatning ska summan av alla tal som matats in skrivas ut, innan nästa inmatning efterfrågas.
    // Innan programmet avslutas ska man även skriva ut medelvärde av de inmatade talen.

    int sum = 0;
    int counter = 0;
    bool keepGoing = true;

    //+Så länge KEEPGOING är sann
    while (keepGoing == true)
    {
        //+ 	Läs in en text från konsolen
        string input = Console.ReadLine();
        bool isAnumber = true;

        if (input != "")
        {
            isAnumber = CanParseTextToNumber(input);
        }
        else
        {
            isAnumber = false;
        }

        //+	Om texten inte går att konvertera till ett tal
        if (!isAnumber)
        {
            //+		Sätt KEEPGOING till falskt
            keepGoing = false;
        }
        //+	Annars
        else
        {
            //+		Konvertera texten till ett tal
            int number = int.Parse(input);
            //+		Lägg till ett på räknaren
            counter += 1;
            //+		Addera talet till summan
            sum += number;
            //+		Skriv ut summan
            Console.WriteLine(sum);
        }
    }
    //+ Skriv ut summan
    Console.WriteLine(sum);
    //+ Räkna ut medelvärdet genom att dividera summan med räknaren
    double avg = (double)sum / (double)counter;
    //+ Skriv ut medelvärdet
    Console.WriteLine(avg);

    //int number = 0;
    //bool couldParse = int.TryParse("hej", out number);
    //Console.WriteLine(couldParse);
    //Console.WriteLine(number);

    bool isANumber = char.IsDigit('6');

    bool CanParseTextToNumber(string text)
    {
        char[] numbers = new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        bool isAnumber = true;

        foreach (char character in text)
        {
            foreach (char digit in numbers)
            {
                if (digit != character)
                {
                    isAnumber = false;
                }
                else
                {
                    isAnumber = true;
                    break;
                }
            }

            if (isAnumber != true)
            {
                break;
            }
        }

        return isAnumber;
    }
}

void DemoForegroundColor()
{
    var stars = "**********************************";

    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(stars);
    Console.SetCursorPosition(35, 1);
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write(stars);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.SetCursorPosition(70, 2);
    Console.Write(stars);
    Console.ResetColor();


    Console.ReadKey();
}

void SplitString()
{
    string greeting = "Hej och välkommen!";

    string[] words = greeting.Split();

    Console.WriteLine(words[2]);
}
