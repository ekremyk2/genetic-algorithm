using System;

namespace GeneticsAlgoritm
{
    public struct Gene
    {
        private static Random rnd = new Random();
        private double minCap;
        private double maxCap;
        private double val;

        public Gene(double min, double max)
        {
            this.minCap = min;
            this.maxCap = max;
            this.val = (maxCap - minCap) * rnd.NextDouble() + minCap;
        }

        public Gene(double val)
        {
            minCap = -10;
            maxCap = 10;
            this.val = val;
        }

        public Gene(double min, double max, double val)
        {
            this.minCap = min;
            this.maxCap = max;
            this.val = val;
        }

        public void SetVal()
        {
            this.val = (maxCap - minCap) * rnd.NextDouble() + minCap;
        }

        public double GetVal()
        {
            return this.val;
        }

        public void SetMinMax(double min, double max)
        {
            this.minCap = min;
            this.maxCap = max;
        }

        public Gene Clone()
        {
            return new Gene(this.minCap, this.maxCap, this.val);
        }
    }
}