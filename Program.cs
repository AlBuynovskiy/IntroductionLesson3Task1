// See https://aka.ms/new-console-template for more information
/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Задание должно быть выполнено в методе. В методе но должно быть вывода в консоль. Не использовать String!
*/

Console.WriteLine("Введите пятизначное число: ");
string? number = Console.ReadLine();

void CheckingNumber(string number)
{
  if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine($"Введенное число: {number} - палиндром.");
  }
  else Console.WriteLine($"Введенное число: {number} - не палиндром.");
 }
  
if (number!.Length == 5){
  CheckingNumber(number);
}
else Console.WriteLine($"Вы ввеkи не пятизначное число.");