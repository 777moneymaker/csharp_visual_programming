using System;

namespace PC_Shop {
    [Serializable]
    public class CPU {
        public string Model { get; set; }
        public double Price { get; set; }


        public CPU(string model, double price) {
            this.Model = model;
            this.Price = price;
        }

        public CPU() { }

        public override string ToString() {
            return this.Model;
        }

    }
}
