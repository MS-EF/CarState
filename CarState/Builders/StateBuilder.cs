using CarState.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarState.Builders
{
    public class StateBuilder
    {
        private Car _car;
        private WorkShop _workShop;
        public StateBuilder WithCar(Car car)
        {
            _car = car;
            return this;
        }
        public StateBuilder WithWorkShop(WorkShop workShop)
        {
            _workShop = workShop;
            return this;
        }

        public Car Build()
        {
            bool hasThief = _workShop.HasThiefWorker(_workShop.Workers);
            return new Car
            {
                Id = _car.Id,
                Backup = hasThief ? _car.Backup = BackupState.None : _car.Backup,
                Engine = hasThief ? _car.Engine = EngineState.Broken : _car.Engine = EngineState.Fix,
            };
        }
    }
}
