using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_Shop {
    [Serializable]
    public class Monitor {
        private string model;
        private double price;

        public Monitor(string model, double price) {
            this.model = model;
            this.price = price;
        }

        public Monitor() { }

        public override string ToString() {
            return this.model;
        }

        public string MODEL {
            get => this.model;
            set => this.model = value;
        }

        public double PRICE {
            get => this.price;
            set => this.price = value;
        }
    }
}
