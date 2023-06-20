//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
System.Console.Write("Введите пятизначное число: ");
string? strIn = Console.ReadLine();
string strOut = "";
//Добавлена проверка, чтобы убрать предупреждение о разыменовывании ссылки
if (strIn is not null)
{
    int length = strIn.Length;
    if (length != 5)
    {
        System.Console.WriteLine("Введено не пятизначное число!");
    }
    else
    {
        for (int i = length-1; i >=0; i--)
    {
        strOut = strOut + strIn[i];
    }
    if (strIn == strOut)
    {
        System.Console.WriteLine("Число является полиндромом!");
    }
    else
    {
        System.Console.WriteLine("Число не является полиндромом!");
    }
    }
}
