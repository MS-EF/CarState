using CarState.Models;

namespace CarState.Builders
{
    public record WorkShopFactory
    {
        private IList<Worker> _workers = new List<Worker>();

        public WorkShop Create(int id)
        {
            if (id == 1)
                _workers.Add(new Worker { IsThief = true, Id = 1, WorkShopId = id });

            if (id == 2)
                _workers.Add(new Worker { IsThief = false, Id = 1, WorkShopId = id });

            return new WorkShop() { Id = id, Workers = _workers };

        }
    }
}
