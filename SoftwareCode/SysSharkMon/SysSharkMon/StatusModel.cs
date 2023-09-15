using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysSharkMon
{
    public class StatusModel
    {
        public int cpuLoad { get; set; } = 0;
        public int gpuLoad { get; set; } = 0;
        public int ramLoad { get; set; } = 0;
        public int cpuTemp { get; set; } = 0;
        public int gpuTemp { get; set; } = 0;
    }
}
