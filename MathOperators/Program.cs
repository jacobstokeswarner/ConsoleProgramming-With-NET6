// See https://aka.ms/new-console-template for more information

// Basic Assignment Operator

int num = 5; // assignment

// Arithmetic Operators

decimal num1 = 11;
decimal num2 = 12;

Console.WriteLine($"Addition: {num1} + {num2} = {num1 + num2}");
Console.WriteLine($"Subtraction: {num1} - {num2} = {num1 - num2}");
Console.WriteLine($"Multiplication: {num1} \u00D7 {num2} = {num1 * num2}");
Console.WriteLine($"Division: {num1} \u00F7 {num2} = {num1 / num2}");
Console.WriteLine($"Modulus: {num1} % {num2} = {num1 % num2}");

num1 = num1 + 4; // increasing value of num1

Console.WriteLine();

Console.WriteLine($"Addition: {num1} + {num2} = {num1 + num2}");
Console.WriteLine($"Subtraction: {num1} - {num2} = {num1 - num2}");
Console.WriteLine($"Multiplication: {num1} \u00D7 {num2} = {num1 * num2}");
Console.WriteLine($"Division: {num1} \u00F7 {num2} = {num1 / num2}");
Console.WriteLine($"Modulus: {num1} % {num2} = {num1 % num2}");

// Compound Assignment Operators
num1 += 4; // num1 = num1 + 4;
Console.WriteLine(num1);// 19
num1 -= 4; // num1 = num1 - 4;
Console.WriteLine(num1); // 15
num1 *= 4; // num1 = num1 * 4;
Console.WriteLine(num1); // 60
num1 /= 4; // num1 = num1 / 4;
Console.WriteLine(num1); // 15
num1 %= 4; // num1 = num1 % 4;
Console.WriteLine(num1); // 3