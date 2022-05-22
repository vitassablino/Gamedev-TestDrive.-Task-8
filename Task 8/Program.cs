using System;

internal class Program
{
    static void Main(string[] args)
    {
        uint grandmasAmount;
        uint waitMinTotal;
        uint waitMinOneGrandma = 10;
        uint waitHours;
        uint waitMinutes;

        Console.WriteLine("Сколько бабушек вы видите перед собой?\t");
        grandmasAmount = Convert.ToUInt16(Console.ReadLine());
        waitMinTotal = waitMinOneGrandma + waitMinOneGrandma * grandmasAmount;
        //учёт того, что один посетитель уже в кабинете
        waitHours = waitMinTotal / 60;
        waitMinutes = waitMinTotal % 60;
        Console.Write($"Вам необходимо ждать ");
        if (waitHours > 0)
            Console.Write($"{waitHours} час(-ов) ");
        if (waitMinutes > 0)
            Console.WriteLine($"{waitMinutes} минут");
    }
}
