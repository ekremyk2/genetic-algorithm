using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace GeneticAlgorithmLib
{
    internal class Generation
    {
        private double pSize; //Popülasyon Boyutu
        private double cSize; //Çaprazlama Boyutu
        private double mPerc; //Mutasyon Oranı
        private double exclu; //Seçkinlik
        private double pParam; //Penaltı Parametreleri

        public double _pSize
        {
            get { return pSize; }
            set { pSize = value; }
        }
        public double _cSize
        {
            get { return cSize; }
            set { cSize = value; }
        }
        public double _mPerc
        {
            get { return mPerc; }
            set { mPerc = value; }
        }
        public double _exclu
        {
            get { return exclu; }
            set { exclu = value; }
        }
        public double _pParam
        {
            get { return pParam; }
            set { pParam = value; }
        }

        public Generation(double pSize, double cSize, double mPerc, double exclu, double pParam)
        {
            this.pSize = pSize;
            this.cSize = cSize;
            this.mPerc = mPerc;
            this.exclu = exclu;
            this.pParam = pParam;
        }

        private List<Chromosome> ChromosomeList = new List<Chromosome>();
        private List<Chromosome> ChromosomeEliteList = new List<Chromosome>();
        internal Chromosome bestChromosome;
        Random r = new Random();
        public void generateGeneration()
        {

            
        }

        internal Chromosome SelectFiness()
        {
            List<double> tmpFunc = new List<double>();
            foreach (Chromosome c in ChromosomeList)
            {
                foreach (Gene x in c.GeneList)
                {
                    tmpFunc.Add(x.value);
                    double tmp = Function.function(tmpFunc);
                    if (-10 <= tmp && 10 >= tmp) 
                    {
                        return c;
                    }
                }
            }

            return null;
        }

        public void bindFiness()
        {
            bestChromosome = SelectFiness();
        }

        public Chromosome MutateByChance()
        {
            foreach (Chromosome c in ChromosomeList)
            {
                foreach (Gene x in c.GeneList)
                {
                    if (r.NextDouble() > mPerc)
                    {
                        x.SetValue();
                        
                    }
                }
            }

            return null;
        }
    }

    internal class Chromosome
    {
        internal List<Gene> GeneList = new List<Gene>();
        internal double pParam;
        Random r1 = new Random();
        Random r2 = new Random();
        
        public void generateChromosome()
        {
            for (int i = 0; i < 1; i++)
            {
                GeneList.Add(new Gene(r1.NextDouble(),r2.NextDouble()));
            }
        }

        public Chromosome(double p)
        {
            generateChromosome();
            this.pParam = p;
        }

        public Chromosome(Chromosome x)
        {
            x = this;
        }
    }
    internal struct Gene
    {
        //public static int GeneNumber = 5;
        //public static int ConstraintNumber = 6;
        static Random r = new Random();
        public double minimum;
        public double maximum;
        public double value;

        public Gene(double l, double u)
        {
            this.minimum = l;
            this.maximum = u;
            this.value = (maximum - minimum) * r.NextDouble() + minimum;
        }

        public void SetValue()
        {
            this.value = (maximum - minimum) * r.NextDouble() + minimum;
        }
    }

    public static class Function
    {
        public static double function(List<double> x)
        {
            return Math.Pow((Math.Abs(Math.Sin(x[0]) * Math.Sin(x[1]) * Math.Exp(Math.Abs(100-(Math.Sqrt(Math.Pow(x[0],2) + Math.Pow(x[1],2))/Math.PI))))+1),0.1) * -0.0001;
        }
    }
}