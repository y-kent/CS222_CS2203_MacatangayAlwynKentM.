using System;

Console.Write("Enter amount in USD: ");
double USD = double.Parse(Console.ReadLine());

Console.Write("Enter exchange rate from USD to EUR: ");
double Rate = double.Parse(Console.ReadLine());

double Euro = USD * Rate;

Console.WriteLine("Amount in EUR: {0:F2}", Euro);