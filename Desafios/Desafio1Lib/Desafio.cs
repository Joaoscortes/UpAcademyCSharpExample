using System;

namespace Desafio1Lib
{
    public class Desafio
    {
        private int count;
        private int countMult3;
        private int countMult5;

        public Desafio(int count) {
            this.count = count;
        }

        public void run() {
            for (int i = 1; i <= this.count; i++) {
                if (i % 5 == 0) { this.countMult5++; }
                if (i % 3 == 0) { this.countMult3++; }
            }
        }

        public int getBig3Count() {
            return this.countMult3;
        }

        public int getBig5Count() {
            return this.countMult5;
        }
    }
}
