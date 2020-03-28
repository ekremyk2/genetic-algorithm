using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GeneticsAlgoritm
{
    public abstract class PickStyle
    {
        public Random r = new Random();
        public static PickStyle getStyle(int index)
        {
            switch (index)
            {
                case 0:
                    Random rand = new Random();
                    switch (rand.Next(1,3))
                    {
                        case 1:
                            return new Roulet();
                        case 2:
                            return new PRandom();
                        case 3:
                            return new Tournament();
                        default:
                            return null;
                    }
                case 1:
                    return new Roulet();
                case 2:
                    return new PRandom();
                case 4:
                    return new Tournament();
                default: 
                    return null;
            }
        }

        public abstract Chromosome pick(Population pop);
    }

    public class Roulet : PickStyle
    {
        override public Chromosome pick(Population pop)
        {
            List<double> tmpList = new List<double>();
            double totalOutcome = 0;
            for (int i = 0; i < pop.PopList.Count; i++)
            {
                double fitness = pop.PopList[i].getFitness();
                double outcome = Math.Round((1 / fitness), 5);
                totalOutcome += outcome;
                tmpList.Add(outcome);
            }

            double random = getRandom(0,totalOutcome);
            int j = 0;
            double total = 0;
            for (j = 0; j < pop.PopList.Count-1; j++)
            {
                total += tmpList[j];
                if (total > random)
                {
                    break;
                }
            }
            Chromosome pickedC = pop.PopList[j].Clone();
            pop.PopList.RemoveAt(j);//!!!İNCELE!!!
            return pickedC;
        }

        public double getRandom(double min, double max)
        {
            return r.NextDouble() * (max - min) + min;
        }
    }

    public class PRandom : PickStyle
    {
        override public Chromosome pick(Population pop)
        {
            int random = r.Next(0,pop.PopList.Count);
            Chromosome pickedC = pop.PopList[random].Clone();
            pop.PopList.RemoveAt(random);
            return pickedC;
        }
    }

    public class Tournament : PickStyle
    {
        override public Chromosome pick(Population pop)
        {
            int random1 = r.Next(0, pop.PopList.Count);
            int random2 = r.Next(0, pop.PopList.Count);
            double fitness1 = pop.PopList[random1].getFitness();
            double fitness2 = pop.PopList[random2].getFitness();
            Chromosome pickedC;
            if (fitness1 < fitness2)
            {
                pickedC = pop.PopList[random1].Clone();
                pop.PopList.RemoveAt(random1);
                return pickedC;
            }
            else
            {
                pickedC = pop.PopList[random2].Clone();
                pop.PopList.RemoveAt(random2);
                return pickedC;
            }
        }
    }
}