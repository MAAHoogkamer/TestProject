/*
int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result);

decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");

int first = 5;
int second = 7;
string third = "7";
string message = first.ToString() + second.ToString();
string message1 = Convert.ToString(first) + third;
int sum = first + int.Parse(third);
int sum1 = first + Convert.ToInt32(third);
Console.WriteLine(message + message1 + sum + sum1);

int value = (int)1.5m; // casting truncates
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value2);


string value = "657";
int result = 0;
if (int.TryParse(value, out result))
{
   Console.WriteLine($"Measurement: {result}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}

if (result != 0)
   Console.WriteLine($"Measurement (w/ offset): {50 + result}");

using System.Runtime.ExceptionServices;

string[] values = { "12.3", "45", "ABC", "11", "DEF" };
decimal sum = 0;
string chars = "";
for (int i = 0; i < values.Length; i++)
{   
    decimal sum1;
    if (decimal.TryParse(values[i], out sum1))
    {
        sum += sum1;
        //Console.Write("num");
    } else {
        chars += values[i];
        //Console.Write("char");
    }
}
Console.WriteLine($"Message: {chars}");
Console.WriteLine($"Total: {sum}");

string[] values1 = { "12.3", "45", "ABC", "11", "DEF" };

decimal total = 0m;
string message = "";

foreach (var value in values1)
{
    decimal number; // stores the TryParse "out" value
    if (decimal.TryParse(value, out number))
    {
        total += number;
    } else
    {
        message += value;
    }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");

int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

// The Convert class is best for converting the fractional decimal numbers into whole integer numbers
// Convert.ToInt32() rounds up the way you would expect.
int result1 = Convert.ToInt32((decimal)value1 / value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
*/