//Console.BackgroundColor = ConsoleColor.Magenta;
//Console.BackgroundColor = ConsoleColor.Blue;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("TIME TO CALCULATE");
        Console.WriteLine(" ");
        Console.WriteLine("  ____________________ ");
        Console.WriteLine("  |      SEIKO       | ");
        Console.WriteLine("  |  _____________   | ");
        Console.WriteLine("  | |  1 + 1 = 11 |  | ");
        Console.WriteLine("  |  -------------   | ");
        Console.WriteLine("  |                  | ");
        Console.WriteLine("  | |7| |8| |9|  |+| | ");
        Console.WriteLine("  | |4| |5| |6|  |-| | ");
        Console.WriteLine("  | |1| |2| |3|  |x| | ");
        Console.WriteLine("  | |.| |0| |=|  |/| | ");
        Console.WriteLine("  |__________________| ");
        Console.WriteLine(" ");

        bool t = true;
        
        while (t)
        {

            Console.WriteLine("Which operation would you like to do??");
            Console.WriteLine("A - Addition");
            Console.WriteLine("S - Subtraction");
            Console.WriteLine("M - Multiplication");
            Console.WriteLine("D - Division");
            Console.WriteLine("Q - To quit");
            bool t1 = true;
            string op = Console.ReadLine().Trim();
            while (t1 == true)
            {
                if (Checker(op) == 0)
                {
                    Console.Write("Please enter a valid command: ");
                    op = Console.ReadLine().Trim();
                }
                else 
                {
                    t1= false;
                
                }

            }

            Option(op);
            Console.Write("Do you want to Calculate again?? Press Y or N ");
            string yn = Console.ReadLine().Trim();
            if (yn.ToUpper() == "N")
            {
                Environment.Exit(0);
            }
            while (yn.ToUpper() != "Y")
            {
                Console.WriteLine("Command Error, Please type in Y or N: ");
                yn = Console.ReadLine().Trim();
            }
        }


        void Option(string o)
        {
            int x = 0;
            int y = 0;

            if (o.ToUpper() == "Q")
            {
                Environment.Exit(0);

            }
            Console.Write("Enter your first number: ");
            x = Converter(Console.ReadLine());
            Console.Write("Enter your second number: ");
            y = Converter(Console.ReadLine());
            Console.WriteLine(answ(o, x, y) + " = " + Operate(o, x, y));
        }

        int Converter(string s)
        {

            try
            {
                return int.Parse(s);
            }
            catch (Exception e)
            {
                Console.WriteLine("Value Error!!!!");
                return 0;
            }

        }

        int Operate(string o, int x, int y)
        {
            switch (o.ToUpper())
            {
                case "A":
                    return x + y;
                case "S":
                    return x - y;
                case "M":
                    return x * y;
                case "D":
                    return x / y;
                default:
                    return 0;
            }
        }

        int Checker(string o)
        {
            switch (o.ToUpper())
            {
                case "A":
                    return 1;
                case "S":
                    return 2;
                case "M":
                    return 3;
                case "D":
                    return 4;
                default:
                    return 0;
            }
        }

        string answ(string o, int x, int y)
        {
            switch (o.ToUpper())
            {
                case "A":
                    return $"{x} + {y}";
                case "S":
                    return $"{x} - {y}";
                case "M":
                    return $"{x} * {y}";
                case "D":
                    return $"{x} / {y}";
                default:
                    return " ";
            }
        }
    }
}