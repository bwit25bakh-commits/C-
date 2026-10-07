// Console.Write("Enter your name: ");
// string? name=Console.ReadLine();
// Console.Write("Enter your age: ");
// int age = Convert.ToInt32(Console.ReadLine());
// if(age>=18)
// {
//     Console.WriteLine($"Hello {name}, old.");
// }
// else
// {
//     Console.WriteLine($"Hello {name}, young.");
// }

Console.Write("Enter First Number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Operator (+, -, *, /): ");
string? op = Console.ReadLine();

Console.Write("Enter Second Number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (op == "+")
{
    Console.WriteLine($"Result: {num1 + num2}");
}
else if (op == "-")
{
    Console.WriteLine($"Result: {num1 - num2}");
}
else if (op == "*")
{
    Console.WriteLine($"Result: {num1 * num2}");
}
else if (op == "/")
{
    if (num2 != 0)
    {
        Console.WriteLine($"Result: {num1 / num2}");
    }
    else
    {
        Console.WriteLine("Error: Division by zero is not allowed.");
    }
}
else
{
    Console.WriteLine("Invalid operator. Please use +, -, *, or /.");
}
