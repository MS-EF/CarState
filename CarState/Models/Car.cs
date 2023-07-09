using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarState.Models
{
    public class Car
    {
        public int Id { get; set; }
        public EngineState Engine { get; set; }
        public BackupState Backup { get; set; }
    }
}
