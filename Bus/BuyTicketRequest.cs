namespace Bus
{
    public class BuyTicketRequest : Request
    {
        private Route route;
        protected bool isHandled;
        protected HandleError error;
        protected double baseCost = 4;
        public BuyTicketRequest(Route route)
        {
            this.route = route;
            route.LockSeat();
        }
        public double GetCost()
        {
            return baseCost;
        }

        public Request Handle(bool success, HandleError error)
        {
            this.isHandled = success;
            this.error = error;
            return this;
        }

        public bool IsHandled()
        {
            return isHandled;
        }

        public HandleError GetError()
        {
            return error;
        }
    }
}
