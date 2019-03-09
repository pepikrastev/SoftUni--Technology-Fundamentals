namespace _09._Padawan_Equipment
{
    using System;

    class StartUp
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double students = double.Parse(Console.ReadLine());
            double lightsabers = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            double sabersCount = lightsabers * Math.Ceiling(students * 1.1);

            double robesCount = students;

            double beltsCount = Math.Ceiling(students - students / 6);

            double totalPrice = sabersCount + robesCount * robesPrice + beltsCount * beltsPrice;

            if (totalPrice <= money)
            {

                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {totalPrice - money:f2}lv more.");
            }
        }
    }
}
