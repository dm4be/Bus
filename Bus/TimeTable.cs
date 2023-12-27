using System;
using System.Collections.Generic;

namespace Bus
{
    public class TimeTable
    {
        private List<Route> routes;
        public TimeTable(List<Route> routes)
        {
            this.routes = routes;
        }
        // Инициализация генератора случайных чисел
        private Random random = new Random();

        public Route GetRandomRoute()
        {
            if (routes == null || routes.Count == 0)
            {
                throw new ArgumentException("Список не должен быть пустым", nameof(routes));
            }

            // Получение случайного индекса
            int randomIndex = random.Next(0, routes.Count);

            // Возвращение случайного элемента
            return routes[randomIndex];
        }

        public List<SuburbanRoute> GetAllSuburbanRoutes()
        { 
            List<SuburbanRoute> suburbanRoutes = new List<SuburbanRoute>();
            foreach (Route route in routes) 
            {
                if (route is SuburbanRoute)
                {
                    suburbanRoutes.Add((SuburbanRoute)route);
                }
            }

            return suburbanRoutes;
        }

        internal void AddRoute(Route route)
        {
            routes.Add(route);
        }
    }
}