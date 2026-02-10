using System;

Console.Write("Enter principal amount: ");
double Principal = double.Parse(Console.ReadLine());
Console.Write("Enter rate of interest: ");
double Rate = double.Parse(Console.ReadLine());
Console.Write("Enter time in years: ");
int Time = int.Parse(Console.ReadLine());
double SimpleInterest = (Principal * Rate * Time) / 100;

Console.WriteLine("Simple Interest: {0:F2}", SimpleInterest);