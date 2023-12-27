using System;
using System.Collections.Generic;

namespace Bus
{
    public class RoutesGenerator
    {
        private static Random random = new Random();
        public static List<Route> GenerateRandomRoutes(DateTime startDate, DateTime endDate, int numberOfRoutes)
        {
            List<Route> routes = new List<Route>();

            for (int i = 0; i < numberOfRoutes; i++)
            {
                DateTime randomDepartureTime = GenerateRandomDateTime(startDate, endDate);
                IBus randomBus = new SuburbanBus();
                double randomLength = random.NextDouble() * 100;

                SuburbanRoute randomRoute = new SuburbanRoute(randomDepartureTime, randomBus, randomLength);
                routes.Add(randomRoute);

                // Пример вывода информации о созданных маршрутах
                Console.WriteLine($"Route {i + 1}:");
                Console.WriteLine($"Departure Time: {randomRoute.DepartureTime()}");
                Console.WriteLine($"Bus: {randomRoute.GetBus()}");
                Console.WriteLine($"Route Length: {randomRoute.Length()} km");
                Console.WriteLine($"Available Seats: {randomRoute.NumberOfAvailableSeats()}");
                Console.WriteLine();
            }

            return routes;
        }

        public static DateTime GenerateRandomDateTime(DateTime startDate, DateTime endDate)
        {
            Console.WriteLine(startDate);
            Console.WriteLine(endDate);

            int range = (int)Math.Ceiling((endDate - startDate).TotalMinutes);
            Console.WriteLine("Range: " + range);

            // Генерация случайного числа дней в диапазоне
            int randomMinutes = random.Next(range);
            Console.WriteLine("RAndom minutes: " + randomMinutes);
            // Генерация случайного времени в диапазоне от 00:00:00 до 23:59:59
            TimeSpan randomTime = TimeSpan.FromMinutes(randomMinutes);

            // Комбинирование даты и времени
            return startDate.Add(randomTime);
        }
    }
}