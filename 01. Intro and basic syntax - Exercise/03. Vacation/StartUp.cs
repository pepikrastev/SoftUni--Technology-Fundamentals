namespace _03._Vacation
{
    using System;

    class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0.00;
            double freeGroup = 0.00;

            if (day == "Friday")
            {
                if (type == "Students")
                {
                    price = numberOfPeople * 8.45;
                }
                if (type == "Business")
                {
                    price = numberOfPeople * 10.90;
                    freeGroup = 10 * 10.90;
                }
                if (type == "Regular")
                {
                    price = numberOfPeople * 15;
                }
            }

            else if (day == "Saturday")
            {

                if (type == "Students")
                {
                    price = numberOfPeople * 9.8;
                }
                if (type == "Business")
                {
                    price = numberOfPeople * 15.6;
                    freeGroup = 10 * 15.6;
                }
                if (type == "Regular")
                {
                    price = numberOfPeople * 20;
                }
            }

            else if (day == "Sunday")
            {
                if (type == "Students")
                {
                    price = numberOfPeople * 10.46;
                }
                if (type == "Business")
                {
                    price = numberOfPeople * 16;
                    freeGroup = 10 * 16;
                }
                if (type == "Regular")
                {
                    price = numberOfPeople * 22.50;
                }
            }

            if (type == "Students" && numberOfPeople >= 30)
            {
                price -= price * 0.15;
            }
            else if (type == "Business" && numberOfPeople >= 100)
            {
                price = price - freeGroup;
            }
            else if (type == "Regular" && numberOfPeople >= 10 && numberOfPeople <= 20)
            {
                price -= price * 0.05;
            }

            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
