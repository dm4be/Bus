using System;
using System.Collections.Generic;

namespace Bus
{
    public class MainModule
    {
        public event EventHandler SimulationStepCompleted;

        private readonly PassengerFlowController passengerGenerator;
        private readonly TicketProcessor ticketProcessor;


        public MainModule(
            PassengerFlowController passengerGenerator,
            TicketProcessor ticketProcessor,
            Config cfg)
        {
            this.passengerGenerator = passengerGenerator;
            this.ticketProcessor = ticketProcessor;
            CurrentSimulationTime = cfg.StartTime;
            FinishTime = cfg.EndTime;
            SimulationTimeScale = cfg.SimulationTimeScale;
        }


        private double SimulationTimeScale;
        private DateTime currentSimulationTime;
        private DateTime FinishTime;
        private int acc = 0;

        public DateTime CurrentSimulationTime { get => currentSimulationTime; set => currentSimulationTime = value; }

        public void SimulationStep(TimeSpan realTimeElapsed)
        {
            Console.WriteLine("Called SimStep");
            TimeSpan simulatedTimeElapsed = TimeSpan.FromSeconds(realTimeElapsed.TotalSeconds * SimulationTimeScale);
            CurrentSimulationTime += simulatedTimeElapsed;
            if (CurrentSimulationTime >= FinishTime)
            {
                return;
            }

            passengerGenerator.Update(simulatedTimeElapsed);
            ticketProcessor.Update(simulatedTimeElapsed);

            List<Request> newReqs = passengerGenerator.GenerateRequests();
            acc += newReqs.Count;
            List<Request> statuses = ticketProcessor.HandleRequests(newReqs);

            Console.WriteLine("==============================================================================");
            Console.WriteLine("Generated requests " + acc);

            foreach (Request reqstatus in statuses)
            {
                Console.WriteLine(reqstatus.ToString());
            }
            Console.WriteLine("==============================================================================");
        }

        public List<BoxOffice> GetListOfBoxOffices()
        {
            return ticketProcessor.GetBoxOffices();
        }
    }
}
