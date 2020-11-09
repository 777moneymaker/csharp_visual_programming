using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_Shop {
    public class Computer {
        private CPU cpu;
        private Disk disk;
        private double price;


        public Computer(CPU cpu, Disk disk) {
            this.cpu = cpu;
            this.disk = disk;
            this.price = this.disk.PRICE + this.cpu.PRICE;
        }

        /*
        Block of setters.
        Don't change!
        */
        public CPU CPU {
            get => this.cpu;
            set => this.cpu = value;
        }

        public Disk DISK {
            get => this.disk;
            set => this.disk = value;
        }

        public double PRICE {
            get => this.price;
            set => this.price = value;
        }
    }
}
