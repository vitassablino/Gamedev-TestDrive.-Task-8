using System;

internal class Program
{
    static void Main(string[] args)
    {
        uint grandmasAmount;
        uint waitMinutesTotal;
        uint waitMinutesOneGrandma = 10;
        uint waitHours;
        uint waitMinutes;
        uint minutesperHour = 60;

        Console.WriteLine("Сколько бабушек вы видите перед собой?\t");
        grandmasAmount = Convert.ToUInt16(Console.ReadLine());
        waitMinutesTotal = waitMinutesOneGrandma + waitMinutesOneGrandma * grandmasAmount;
        //учёт того, что один посетитель уже в кабинете
        waitHours = waitMinutesTotal / minutesperHour;
        waitMinutes = waitMinutesTotal % minutesperHour;
        Console.Write($"Вам необходимо ждать ");

        if (waitHours > 0)
        {
            Console.Write($"{waitHours} час(-ов) ");
        }

        if (waitMinutes > 0)
        {
            Console.WriteLine($"{waitMinutes} минут");
        }
    }
}
