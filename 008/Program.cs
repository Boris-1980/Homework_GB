//  Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет,является ли этот день выходным.


int Number = new Random().Next(1, 8);
string[] Days = { "monday", "tuesday", "wednesday", "thursday", "friday", "saturday", "sunday" };
string Result = "";

if (Number > 5) Result = ($".holiday");
else Result = ($", workday");

Console.WriteLine($"{Number} number day, its  {Days[Number - 1]}{Result}");
