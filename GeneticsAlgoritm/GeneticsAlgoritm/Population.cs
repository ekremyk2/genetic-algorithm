using System;
using System.Collections.Generic;
using System.Linq;

namespace GeneticsAlgoritm
{
    public class Population
    {
        public List<Chromosome> PopList = new List<Chromosome>();
        public List<Chromosome> ElitePopList = new List<Chromosome>();
        public List<Chromosome> OldPopList = new List<Chromosome>();
        public List<Chromosome> CrossoverList = new List<Chromosome>();
        private Random r = new Random();
        private PickStyle ps;
        private int index;
        public int _index
        {
            get { return index; }
            set { index = value; }
        }
        
        public Population(int pSize)
        {
            GeneratePop(pSize);
            ps = PickStyle.getStyle(this.index);
        }

        public void GeneratePop(double pSize)
        {
            for (int i = 0; i < pSize; i++)
            {
                PopList.Add(new Chromosome());
            }
        }

        public Chromosome bestFitness()
        {
            return PopList.OrderBy(p => p.getFitness()).FirstOrDefault();
            /* double bestf = 0;
             int bestfindex = 0;
             for (int i = 0; i < PopList.Count; i++)
             {
                 if (PopList[i].getFitness() > bestf)
                 {
                     bestf = PopList[i].getFitness();
                     bestfindex = i;
                 }
             }
 
             return PopList[bestfindex];*/
        }

        public void popToElite(int cnt)
        {
            ElitePopList = PopList.OrderBy(p => p.getFitness()).Take(cnt).ToList();
        }

        public void popToOld()
        {
            for (int i = 0; i < PopList.Count; i++)
            {
                OldPopList.Add(PopList[i].Clone());
            }
        }

        public void pairPick()
        {
            for (int i = 0; i < PopList.Count; i++)
            {
                Chromosome tmp = ps.pick(this);
                CrossoverList.Add(tmp);
                PopList.Remove(tmp);
            }
        }

        public void mutateByChance(double probability)
        {
            List<int> indexList = new List<int>();
            for (int i = 0; i < PopList.Count; i++)
            {
                if (r.NextDouble() > probability)
                {
                    indexList.Add(i);
                }
            }

            foreach (int i in indexList)
            {
                PopList[i].MutateChromosome();
            }
        }

        public void cross(double probability)
        {
            double random;
            for (int i = 0; i < PopList.Count; i++)
            {
                random = r.NextDouble();
                if (random < probability)
                {
                    PopList[i] = Chromosome.CrossoverChromosome(PopList[i],CrossoverList[i]);
                    CrossoverList[i] = Chromosome.CrossoverChromosome(CrossoverList[i],PopList[i]);
                }
            }

            foreach (Chromosome c in CrossoverList)
            {
                PopList.Add(c);
            }
            CrossoverList.Clear();
        }
    }
}