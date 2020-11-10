using System;
using System.Collections.Generic;

namespace PC_Shop {
    [Serializable]
    public class Serial_Items {
        public List<CPU> CPUs { get; set; }
        public List<Monitor> Monitors { get; set; }

        public Serial_Items(List<CPU> cpus, List<Monitor> monitors) {
            this.CPUs = cpus;
            this.Monitors = monitors;
        }

        public Serial_Items() { }
    }
}
