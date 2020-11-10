using System;

namespace PC_Shop {
    [Serializable]
    public class Monitor {
        public string Model { get; set; }
        public double Price { get; set; }

        public Monitor(string model, double price) {
            this.Model = model;
            this.Price = price;
        }

        public Monitor() { }

        public override string ToString() {
            return this.Model;
        }
    }
}
