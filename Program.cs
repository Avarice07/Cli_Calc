// See https://aka.ms/new-console-template for more information
//Console.BackgroundColor = ConsoleColor.Magenta;
//Console.BackgroundColor = ConsoleColor.Blue;

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
Console.WriteLine("Which operation would you like to do??");
Console.WriteLine("A - Addition");
Console.WriteLine("S - Subtraction");
Console.WriteLine("M - Multiplication");
Console.WriteLine("D - Division");
Console.WriteLine("Q - To quit");

char op = Console.ReadKey(true).KeyChar;

Option(op);


void Option(char o)
{
    int x = 0;
    int y = 0;

    if (o == 'Q') 
    {
        Environment.Exit(0);
    
    }
    Console.Write("Enter your first number: ");
    x = int.Parse(Console.ReadLine());
    Console.Write("Enter your second number:");
    y = int.Parse(Console.ReadLine());
    Console.WriteLine(answ(o, x, y)+" = "+Operate(o, x, y));




}

int Operate(char o, int x, int y)
{
    switch (o)
    {
        case 'A':
            return x + y;
        case 'S':
            return x - y;
        case 'M':
            return x * y;
        case 'D':
            return x / y;
        default:
            return 0;
    }
}

string answ(char o, int x, int y)
{
    switch (o)
    {
        case 'A':
            return $"{x} + {y}";
        case 'S':
            return $"{x} - {y}";
        case 'M':
            return $"{x} * {y}";
        case 'D':
            return $"{x} / {y}";
        default:
            return " ";
    }
}