using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_Shop {
    [Serializable]
    public class Disk {
        private string model;
        private double price;

        public Disk(string model, double price) {
            this.model = model;
            this.price = price;
        }

        public Disk() { }

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
