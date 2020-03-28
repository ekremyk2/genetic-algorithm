using System;
using System.Collections.Generic;

namespace GeneticsAlgoritm
{
    public class Chromosome
    {
        public List<Gene> GeneList=new List<Gene>();
        private double penalty;
        private double fitness;
        private Random rnd = new Random();

        public Chromosome(/*double penalty*/)
        {
            newChromosome();
            setFitness();
            //this.penalty = penalty;
        }

        public void newChromosome()
        {
            for (int i = 0; i < 2; i++)
            {
                GeneList.Add(generateGene());
            }
        }

        public Gene getGene(int index)
        {
            return GeneList[index];
        }

        public Gene generateGene()
        {
            return new Gene(rnd.Next(5), rnd.Next(5));
        }

        public void addNewGenes(Gene x1)
        {
            GeneList.Add(x1);
        }

        public void removeGeneAt(int index)
        {
            GeneList.RemoveAt(index);
        }

        public void clearGenes()
        {
            GeneList.Clear();
        }

        public Chromosome Clone()
        {
            return this;
        }

        public List<Gene> getList()
        {
            return GeneList;
        }

        public void setFitness()
        {
            this.fitness = function;
        }

        public double getFitness()
        {
            return fitness;
        }

        public double function
        {
            get
            {
                return Math.Pow((Math.Abs(Math.Sin(GeneList[0].GetVal()) * Math.Sin(GeneList[1].GetVal()) * Math.Exp(Math.Abs(100 - (Math.Sqrt(Math.Pow(GeneList[0].GetVal(), 2) + Math.Pow(GeneList[1].GetVal(), 2)) / Math.PI)))) + 1), 0.1) * -0.0001;
            }
        }

        public static Chromosome CrossoverChromosome(Chromosome c1, Chromosome c2)
        {
            Chromosome newC = new Chromosome();
            newC.clearGenes();
            Random r = new Random();
            int rand = r.Next(0, 1);
            newC.addNewGenes(c1.getGene(rand));
            for (int i = 0; i < c1.GeneList.Count; i++)
            {
                if (i == rand)
                {
                    continue;
                }
                newC.addNewGenes(c2.getGene(i));
                if (newC.GeneList.Count == c2.GeneList.Count)
                {
                    break;
                }
            }

            return newC;
        }

        public void MutateChromosome()
        {
            int r = rnd.Next(1, 2);
            removeGeneAt(r);
            addNewGenes(generateGene());
        }
    }
}