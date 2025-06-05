// A:
int integer = 10;
string textstring = "Hei, Verden!";

Console.WriteLine("A: Heltall sin datatype er: " + integer.GetType().ToString());
Console.WriteLine("A: Tekststrengen sin datatype er: " + textstring.GetType().ToString());


// B:
Random random = new Random();

int number = random.Next(-50, 50);
if (number == 0)
    Console.WriteLine("B: Tallet er null");
else if (number < 0)
    Console.WriteLine("B: Tallet er negativt: " + number);
else
    Console.WriteLine("B: Tallet er positivt: " + number);

// C:
static double Multiply(int a, int b)
{
    return a * b;
}

Console.WriteLine($"Resultatet av multiplikasjonen er {Multiply(5, 10)}");

// D:
static void Divide(int a, int b)
{
    try
    {
        var result = a / b;
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("D: Kan ikke dele på 0.");
        return;
    }
}
Divide(10, 0);


// E:  
Console.WriteLine("E: Skriv inn alderen din som et heltall:");
string input = Console.ReadLine();
if (int.TryParse(input, out int age))
{
    Console.WriteLine($"E: Alderen din er {age}");
}
else
{
    Console.WriteLine("E: Ugyldig inndata, kunne ikke hente ut et heltall.");
}

Console.WriteLine("E: Skriv inn ditt navn:");
string name = Console.ReadLine();
if (!string.IsNullOrEmpty(name))
{
    Console.WriteLine($"E: Navnet ditt er {name}");
}
else
{
    Console.WriteLine("E: Navnet er tomt.");
}

string output = $"Hei {name}, du er {age} år gammel.";
Console.WriteLine("E: " + output);

// F:
List<int> numbers = new();
numbers.Add(1);
numbers.Add(2);
numbers.Add(3);

numbers.RemoveAt(numbers.Count - 1); // Remove last element
int length = numbers.Count;
Console.WriteLine("F: Lengden av listen: " + length);

Console.WriteLine("F: Tall i listen:");
numbers.ForEach(n => Console.WriteLine("F: Tall: " + n));
