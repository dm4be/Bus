
using System;

namespace Bus
{
   public class SuburbanRoute : Route
    {
        private DateTime departureTime;
        private double routeLength;
        private IBus bus;
        private int availableSeats;
        public int routeNumber;

        public SuburbanRoute(int RouteNumber, DateTime departureTime, IBus bus, double length)
        {
            routeNumber = RouteNumber;
            this.departureTime = departureTime;
            this.routeLength = length;
            this.bus = bus;

            // При открытии рейса все места свободны.
            availableSeats = bus.AmountOfSeats();
        }

        public SuburbanRoute(DateTime departureTime, IBus bus, double length)
        {
            routeNumber = Route.Id++;
            this.departureTime = departureTime;
            this.routeLength = length;
            this.bus = bus;

            // При открытии рейса все места свободны.
            availableSeats = bus.AmountOfSeats();
        }

        override public DateTime DepartureTime()
        {
            return departureTime;
        }

        public IBus GetBus()
        {
            return bus;
        }

        public override int GetRouteNumber()
        {
            return routeNumber;
        }

        override public double Length()
        {
            return routeLength;
        }

        override public bool LockSeat()
        {
            //if (availableSeats > 0)
            //{
            // Если билеты кончились, а запросы на этот рейс продолжают идти, то тут будет накапливаться отрицательное значение - 
            // число недостающих для нормальной работы автовокзала билетов.
                this.availableSeats--;
                return true;
            //}

            //return false;
        }

        override public int NumberOfAvailableSeats()
        {
            return availableSeats;
        }
    }
}