using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PC_Shop {
    [Serializable]
    public class Serial_Items {
        public List<CPU> cpus;
        public List<Monitor> monitors;

        public Serial_Items(List<CPU> cpus, List<Monitor> monitors) {
            this.cpus = cpus;
            this.monitors = monitors;
        }

        public Serial_Items() { }
    }
}
