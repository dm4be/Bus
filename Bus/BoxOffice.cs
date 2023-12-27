using Microsoft.VisualBasic;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Bus
{
    public class BoxOffice : Handler
    {
        private DateTime startTime;
        private DateTime currentTime;
        private TimeSpan delta;

        private int id;
        private string name;

        private int handledRequestsAmount = 0;
        private Queue<Request> requests = new Queue<Request>();
        private double pointsForWork = 0.0;
        private double basePointsPerMinute = 1;

        private double averageQueueLength = 0.0;

        private List<BreakTime> breakTimes = new List<BreakTime>();

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int HandledRequestsAmount { get => handledRequestsAmount; set => handledRequestsAmount = value; }
        public double AverageQueueLength { get => averageQueueLength; set => averageQueueLength = value; }
        public int CurrentQueueLength { get => QueuedRequests(); }
        public string HandlerStatus { get => (IsOnBreak() ? "На перерыве" : "Работает"); }

        private DateTime endTime;
        public BoxOffice(DateTime startTime, DateTime endTime, int uniqueId, string name)
        {
            this.Id = uniqueId;
            this.Name = name;
            this.startTime = startTime;
            this.endTime = endTime;
            this.currentTime = startTime;

            initBreakTimes();
        }
        private void initBreakTimes()
        {
            // Берем случайное время из первых суток.
            Console.WriteLine("Start time in break generator:" + startTime);
            Console.WriteLine("End time in break generator:" + endTime);
            DateTime firstBreak = RoutesGenerator.GenerateRandomDateTime(startTime, startTime.AddHours(3));
            Console.WriteLine("First break generator:" + firstBreak);
            for (DateTime current = firstBreak; current < endTime; current = current.AddHours(3))
            {
                // Регистритуем получасовой перерыв. 
                var b = new BreakTime(current, current.AddMinutes(30));
                breakTimes.Add(b);
                Console.WriteLine("Add cashier break =========================================");
                Console.WriteLine(b.StartTime);
                Console.WriteLine(b.EndTime);
            }
        }

        public void AddRequestToHandle(Request req)
        {
            requests.Enqueue(req);
            totalQueued++;
        }

        private int totalQueued = 0;

        int totalSteps = 0;
        public List<Request> HandleRequests()
        {
            List<Request> handledRequests = new List<Request>();
            List<Request> requestsToRemove = new List<Request>();
            AverageQueueLength = (double)totalQueued / totalSteps;

            foreach (Request r in requests)
            {
                // Проверяем, находится ли кассир в перерыве
                if (!IsOnBreak())
                {
                    Request handledRequest = HandleRequest(r);
                    handledRequests.Add(handledRequest);

                    // Если запрос был обработан
                    if (handledRequest.IsHandled())
                    {
                        handledRequestsAmount++;
                        // Добавляем запрос в список для удаления
                        requestsToRemove.Add(r);
                    }
                    else
                    {
                        // Если какой-либо запрос завершился неудачно,
                        // а на данном этапе это возможно только из-за выработки ресурса кассира -
                        // прерываем обработку запросов.
                        // Все необработанные запросы остались в очереди, 
                        // просто ждем восстановления ресурса при следующем обновлении (Update).
                        return handledRequests;
                    }
                }
                else
                {
                    // Если кассир находится в перерыве, не обрабатываем запросы
                    Console.WriteLine("Cashier is rest");
                    handledRequests.Add(r.Handle(false, HandleError.HandlerIsTakeRest));
                }
            }

            // Удаляем запросы после завершения перебора
            foreach (var requestToRemove in requestsToRemove)
            {
                requests.Dequeue();
            }

            AverageQueueLength = (double)totalQueued / totalSteps;
            return handledRequests;
        }

        private Request HandleRequest(Request req)
        {
            // Расходуем ресурс кассира.
            if (req.GetCost() > pointsForWork)
            {
                return req.Handle(false, HandleError.HandlerIsTakeRest);
            }
            else
            {
                pointsForWork -= req.GetCost();
                return req.Handle(true, HandleError.None);
            }
        }

        public void Update(TimeSpan dt)
        {
            // Обновляем "часы" кассира.
            delta = dt;
            currentTime += dt;
            pointsForWork += dt.TotalMinutes * basePointsPerMinute;
            totalSteps++;
        }

        public int QueuedRequests()
        {
            return requests.Count;
        }

        public int GetHandledRequestsAmount()
        {
            return HandledRequestsAmount;
        }

        public bool IsOnBreak()
        {
            foreach (var breakTime in breakTimes)
            {
                if (breakTime.StartTime <= currentTime && currentTime <= breakTime.EndTime)
                {
                    return true;
                }
            }
            return false;
        }

        public bool isAbaleToAdd()
        {
            return !IsOnBreak();
        }

        private class BreakTime
        {
            public DateTime StartTime { get; }
            public DateTime EndTime { get; }

            public BreakTime(DateTime startTime, DateTime endTime)
            {
                StartTime = startTime;
                EndTime = endTime;
            }
        }
    }
}
