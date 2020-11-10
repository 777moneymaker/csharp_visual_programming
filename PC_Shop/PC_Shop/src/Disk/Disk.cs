using System;

namespace PC_Shop {
    [Serializable]
    public class Disk {
        public string Model { get; set; }
        public double Price { get; set; }

        public Disk(string model, double price) {
            this.Model = model;
            this.Price = price;
        }

        public Disk() { }

        public override string ToString() {
            return this.Model;
        }
    }
}
