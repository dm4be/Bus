using System;

namespace Bus
{
    public abstract class Route
    {
        protected static int Id = 0;
        public int RouteNumber { get => GetRouteNumber(); }
        public double RouteLength { get => Length(); }
        public DateTime RouteDepartureTime { get => DepartureTime(); }

        public int RouteCountAvailableSeats { get => NumberOfAvailableSeats(); }

        // Протяжённость маршрута - может влиять на "стоимость" билета.
        public abstract double Length();
        // Время отправления по маршруту.
        public abstract DateTime DepartureTime();

        // Количество свободных мест для данного рейса.

        // TODO: 
        // Тут есть маленькая неприятность - для кассы количество свободных мест на рейсе (оставшихся) 
        // существенно, а для запроса на покупку билета - нет. (Надо решить через дополнительный тип или выделение интерфейса)
        public abstract int NumberOfAvailableSeats();

        // Метод для покупки билета - занимает место в автобусе. 
        // Возвращает успешность операции.
        public abstract bool LockSeat();
        public abstract int GetRouteNumber();
    }
}
