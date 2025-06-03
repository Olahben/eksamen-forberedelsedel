// A:
int integer = 10;
string textstring = "Hello, World!";

Console.WriteLine("A: Integer: " + integer);
Console.WriteLine("A: Text: " + textstring);


// B:
Random random = new Random();

int number = random.Next(-50, 50);
if (number == 0)
    Console.WriteLine("B: Number is zero");
else if (number < 0)
    Console.WriteLine("B: Number is negative: " + number);
else
    Console.WriteLine("B: Number is positive: " + number);

// C:
static void Multiply(int a, int b)
{
    Console.WriteLine("C: Result: " + (a * b));
}

Multiply(5, 10);

// D:
static void Divide(int a, int b)
{
    try
    {
        var result = a / b;
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("D: Cannot divide by zero.");
        return;
    }
}
Divide(10, 0);


// E:  
Console.WriteLine("E: Enter your age as an int:");
string input = Console.ReadLine();
if (int.TryParse(input, out int age))
{
    Console.WriteLine($"E: Your age is {age}");
}
else
{
    Console.WriteLine("E: Invalid input. Please enter a valid integer.");
}

Console.WriteLine("E: Enter your name:");
string name = Console.ReadLine();
if (!string.IsNullOrEmpty(name))
{
    Console.WriteLine($"E: Name is {name}");
}
else
{
    Console.WriteLine("E: Name cannot be empty.");
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
Console.WriteLine("F: Length of the list: " + length);

Console.WriteLine("F: Numbers in the list:");
numbers.ForEach(n => Console.WriteLine("F: Number: " + n));
