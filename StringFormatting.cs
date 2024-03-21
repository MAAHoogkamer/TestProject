/*
string first = "Hello";
string second = "World";
Console.WriteLine("{1} {0}!", first, second);
Console.WriteLine("{0} {0} {0}!", first, second);
Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");
decimal price1 = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price1:C} (Save {discount:C})");
// :C formats the tokens as currency

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");
// The N numeric format specifier makes numbers more readable

decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");
// Use the P format specifier to format percentages

decimal price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

yourDiscount += $"A discount of {((price - salePrice)/price):P2}!"; //inserted
Console.WriteLine(yourDiscount);
//String variables can store strings created using formatting techniques.

decimal test = 5947.3245m;
string testWrite = test.ToString();
Console.WriteLine(testWrite);
Console.WriteLine($"Currency :C : {test:C}");
Console.WriteLine($"Currency :C3 : {test:C3}");
Console.WriteLine($"Number :N : {test:N}");
Console.WriteLine($"Number :N4 : {test:N4}");
Console.WriteLine($"Percentage :P : {test:P}");
Console.WriteLine($"Percentage :P5 : {test:P5}");

int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"   Shares: {productShares:N3} Product");
Console.WriteLine($"     Sub Total: {subtotal:C}");
Console.WriteLine($"           Tax: {taxPercentage:P2}");
Console.WriteLine($"     Total Billed: {total:C}");

*/
/*

    Methods that add blank spaces for formatting purposes (PadLeft(), PadRight())
    Methods that compare two strings or facilitate comparison (Trim(), TrimStart(), TrimEnd(), GetHashcode(), the Length property)
    Methods that help you determine what's inside of a string, or even retrieve just a part of the string (Contains(), StartsWith(), EndsWith(), Substring())
    Methods that change the content of the string by replacing, inserting, or removing parts (Replace(), Insert(), Remove())
    Methods that turn a string into an array of strings or characters (Split(), ToCharArray())

string input = "Pad this";
Console.WriteLine(input.PadLeft(12));
Console.WriteLine(input.PadRight(12));
Console.WriteLine(input.PadLeft(12, '-'));
Console.WriteLine(input.PadRight(12, '-'));

string paymentId = "769C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";

var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);
Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formattedLine);

string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here
string message = $"Dear Ms. Barros, \nAs a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n\n";
message += $"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n\n";
message += $"Our new product, {newProduct} offers a return of {newReturn:P}. ";
message += $"Given your current volume, your potential profit would be {newProfit:C}.\n";
Console.WriteLine(message);

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";
// Your logic here
comparisonMessage = currentProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

Console.WriteLine(comparisonMessage);
*/