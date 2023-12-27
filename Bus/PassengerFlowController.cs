using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Bus
{
    public class PassengerFlowController
    {

        private List<TimeRangeIntensity> dailyTimeRangeIntensity = new List<TimeRangeIntensity>
        {
            new TimeRangeIntensity(new DateTime(1, 1, 1, 0, 0, 0), new DateTime(1, 1, 1, 6, 0, 0),      0.05 ),
            new TimeRangeIntensity(new DateTime(1, 1, 1, 6, 0, 0), new DateTime(1, 1, 1, 9, 0, 0),      0.2 ),
            new TimeRangeIntensity(new DateTime(1, 1, 1, 9, 0, 0), new DateTime(1, 1, 1, 12, 0, 0),     0.13 ),
            new TimeRangeIntensity(new DateTime(1, 1, 1, 12, 0, 0), new DateTime(1, 1, 1, 15, 0, 0),    0.12 ),
            new TimeRangeIntensity(new DateTime(1, 1, 1, 15, 0, 0), new DateTime(1, 1, 1, 18, 0, 0),    0.3 ),
            new TimeRangeIntensity(new DateTime(1, 1, 1, 18, 0, 0), new DateTime(1, 1, 1, 21, 0, 0),    0.1 ),
            new TimeRangeIntensity(new DateTime(1, 1, 1, 21, 0, 0), new DateTime(1, 1, 2, 0, 0, 0),     0.1 ),
        };

        private TimeTable timetable;
        private List<TimeRangeIntensity> timeSpanIntensity = new List<TimeRangeIntensity>();
        public PassengerFlowController(TimeTable timetable, DateTime startTime, DateTime finishTime, int exptectedPassFlowCapacity)
        {
            time = startTime;
            totalFlowCapacity = exptectedPassFlowCapacity;
            double realPassFlowCapacity = timetable.GetAllSuburbanRoutes().Sum(route => route.NumberOfAvailableSeats());
            while (realPassFlowCapacity < exptectedPassFlowCapacity)
            {
                Route routeToCopy = timetable.GetRandomRoute();
                SuburbanRoute newRoute = new SuburbanRoute(routeToCopy.RouteNumber,  routeToCopy.RouteDepartureTime, new SuburbanBus(), routeToCopy.Length());
                timetable.AddRoute(newRoute);
                realPassFlowCapacity = timetable.GetAllSuburbanRoutes().Sum(route => route.NumberOfAvailableSeats());
                Console.WriteLine("Real capacity: " + realPassFlowCapacity);
            }

            for (DateTime currentDay = startTime.Date; currentDay < finishTime;)
            {
                foreach (TimeRangeIntensity intense in dailyTimeRangeIntensity)
                {
                    TimeSpan interval = intense.EndTime - intense.StartTime;
                    timeSpanIntensity.Add(new TimeRangeIntensity(currentDay, currentDay + interval, intense.Intensity));
                    currentDay = currentDay + interval;
                }
            }

            foreach (TimeRangeIntensity intense in timeSpanIntensity)
            {
                Console.WriteLine("intensity for================== ");
                Console.WriteLine(intense.StartTime);
                Console.WriteLine(intense.EndTime);
                Console.WriteLine(intense.Intensity);
            }

            this.timetable = timetable;
        }

        private DateTime time;
        private TimeSpan delta = new TimeSpan();
        // TODO: set random.
        private int totalFlowCapacity;
        public void Update(TimeSpan dt)
        {
            delta = dt;
            time = time.Add(dt);
            Console.WriteLine("Current Passenger Flow Controlelr Time: " + time.ToString());
        }

        public List<Request> GenerateRequests()
        {
            List<Request> requests = new List<Request>();
            // Вычисляем плотность потока в текущее время симуляции.
            double passToGenerate = Math.Floor(CalcFlowSolidity());

            for (int i = 0; i < passToGenerate; i++)
            {
                requests.Add(new BuyTicketRequest(timetable.GetRandomRoute()));
            }

            // После генерации всех целых пассажиров оставляем в аккумуляторе только дробную часть.
            passToCreate -= Math.Floor(passToCreate);
            return requests;
        }
        private double passToCreate = 0.0;
        private double CalcFlowSolidity()
        {
            // Ищем ближайшее предшествующее время в списке
            TimeRangeIntensity intensityRange = timeSpanIntensity
                .Where(info => info.IsInPeriod(time))
                .FirstOrDefault();

            TimeSpan intervalLength = (intensityRange.EndTime - intensityRange.StartTime);
            double intervalLengthInDeltas = intervalLength.TotalSeconds / delta.TotalSeconds;

            // Базовая интенсивность и скорость генерации при равноверном течении потока. 
            double baseIntensity = delta.TotalMinutes / TimeSpan.FromHours(24).TotalMinutes;
            double reqsPerDelta = baseIntensity * totalFlowCapacity;

            // Console.WriteLine("base intensity and base rpd: " + baseIntensity + " " + reqsPerDelta);
            // Если нашли, используем интенсивность этого времени для вычисления количества запросов
            if (intensityRange != null)
            {
                double intensity = intensityRange.Intensity;

                // Собираем доли ожидающих генерации людей (дело в том, что
                // статистически при некоторых паарметрах за, например, 10 минут
                // работы автовокзала должно приходить 15 пассажиров,
                // тогда за 1 минуту ожидается 1.5 пассажира,
                // если мы будем генерировать всегда 1 или 2 (ближайшее округление) вместо 1.5,
                // то потеряем в точности моделирования. Будем копить доли и по мере накопления
                // целых пассажиров отдавать их).

                passToCreate += reqsPerDelta * (intensity / baseIntensity / intervalLengthInDeltas);

                // Console.WriteLine("real rpd: " + passToCreate);

                return passToCreate;
            }

            // Если не нашли, возвращаем некоторое значение по умолчанию
            return passToCreate;
        }
    }

    class TimeRangeIntensity
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public double Intensity { get; set; }

        public TimeRangeIntensity(DateTime startTime, DateTime endTime, double intensity)
        {
            StartTime = startTime;
            EndTime = endTime;
            Intensity = intensity;
        }

        public bool IsInPeriod(DateTime time)
        {
            return StartTime <= time && time <= EndTime;
        }
    }
}
