//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

System.Console.WriteLine("Введите пятизначное число: ");
string n = Convert.ToString(Console.ReadLine());
if (n[0]==n[4] && n[1]==n[3])
{
    System.Console.WriteLine("Число является палиндромом");
}
else
{
System.Console.WriteLine("Число не является палиндромом");
}
