using System.Collections.Generic;
using System;

namespace Bus
{
    public class TicketProcessor
    {

        // Очередь с приоритетом.
        // Наиболее приоритетные те элементы, у которых параметр приоритизации наименьший.
        // В данной предметной области параметр приоритизации - длина очеререди у обработчика (кассы).
        PriorityQueue<Handler, int> handlers = new PriorityQueue<Handler, int>();

        private DateTime startTime;
        private DateTime currentTime;
        private TimeSpan delta;
        public TicketProcessor(DateTime startTime, DateTime endTime, int boxOfficesAmount)
        {
            this.startTime = startTime;
            this.currentTime = startTime;

            for (int i = 0; i < boxOfficesAmount; i++)
            {
                // Каждая касса в самом начале работы обладает нулевым (наивысшим) приоритетом, так как 
                // не содержит запросы в очереди.
                handlers.Enqueue(new BoxOffice(startTime, endTime, i, "Cashier_" + i.ToString()), 0);
            }
        }
        public void Update(TimeSpan dt)
        {
            delta = dt;
            currentTime += dt;
            Console.WriteLine("Ticket processor current simulation time:" + currentTime.ToString());
            // При синхронизации всего модуля прокидываем синхронизацию в каждый подконтрольный обработчик.
            foreach (Handler h in handlers)
            {
                h.Update(dt);
            }
        }

        public List<Request> HandleRequests(List<Request> reqs)
        {
            List<Request> statuses = new List<Request>();

            DistributeRequests(reqs);

            // Создаем новую очередь, сохраняя обработчиков
            PriorityQueue<Handler, int> newHandlers = new PriorityQueue<Handler, int>();

            while (!handlers.IsEmpty())
            {
                try
                {
                    var h = handlers.Dequeue();
                    statuses.AddRange(h.HandleRequests());
                    newHandlers.Enqueue(h, h.QueuedRequests());
                }
                catch (Exception ex)
                {
                    // логируем
                    Console.WriteLine(ex.Message);
                }
            }

            // Заменяем существующую очередь новой
            handlers = newHandlers;

            reqs.Clear();

            return statuses;
        }

        private void DistributeRequests(List<Request> reqs)
        {
            List<Handler> sleepingHandlers = new List<Handler>();
            for (int i = 0; i < reqs.Count; i++)
            {
                // Выбираем кратчайшую очередь
                try
                {
                    Handler handler = handlers.Dequeue();
                    if (handler.isAbaleToAdd())
                    {
                        // Ставим очередной запрос в эту очередь
                        handler.AddRequestToHandle(reqs[i]);
                        // Возвращаем обработчик в очередь обработчиков с обновленным приоритетом.
                        handlers.Enqueue(handler, handler.QueuedRequests());
                    }
                    else
                    {
                        sleepingHandlers.Add(handler);
                    }
                }
                catch (Exception ex) 
                {
                    Console.WriteLine(ex.Message);
                }
            }

            // Возвращаем всех проигнорированных в силу их недоступности обработчиков.
            foreach (var handler in sleepingHandlers)
            {
                handlers.Enqueue(handler, handler.QueuedRequests());
            }
        }

        public List<BoxOffice> GetBoxOffices()
        {
            List<BoxOffice> ret = new List<BoxOffice>();

            foreach (BoxOffice h in handlers)
            {
                ret.Add(h);
            }

            return ret;
        }
    }
}
