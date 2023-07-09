using CarState.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarState.Builders
{
    public record CarBuilder
    {
        private EngineState _engine;
        private BackupState _backup;

        public CarBuilder WithEngine(EngineState engine)
        {
            _engine = engine;
            return this;
        }
        public CarBuilder WithBakup(BackupState backup)
        {
            this._backup = backup;
            return this;
        }

        public Car Build(int id)
        {
            return new Car { Id = id, Backup = _backup, Engine = _engine };
        }
    }
}
