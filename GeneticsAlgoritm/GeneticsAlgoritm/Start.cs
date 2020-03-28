using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;

namespace GeneticsAlgoritm
{
    public class Start
    {
        private static Random r = new Random();
        private int PS;
        private double PC; //bu yok galiba
        private double PM;
        private int elitism;
        private double penalty;
        private int index;
        private Population pop;
        private Population oldPop;
        private Chart c;
        string l = "Popülasyon Değişimi";
        private List<double> bestList = new List<double>();
        double tmp = 100000000.00000;

        public Chart Chart
        {
            set { c = value; setChart(); }
        }

        public Start(int PS, double PC, double PM, int elitism, double penalty, int index)
        {
            this.PS = PS;
            this.PC = PC;
            this.PM = PM;
            this.elitism = elitism;
            this.penalty = penalty;
            this.index = index;
            pop = new Population(this.PS);
            pop._index = index;
        }

        public void Run(int iterationNumber)
        {
            for (int i = 0; i < iterationNumber; i++)
            {
                OneIteration(i);
            }
        }
        public void OneIteration(int i)
        {
            pop.popToOld();
            pop.popToElite(elitism);
            pop.pairPick();
            pop.cross(PC);
            pop.mutateByChance(PM);
            addBest();
            oldPop = pop;
            draw(i,bestList.Last());
        }

        public void addBest()
        {
            for (int i = 0; i < pop.PopList.Count; i++)
            {
                if (tmp > pop.PopList[i].getFitness())
                {
                    tmp = pop.PopList[i].getFitness();
                }
            }
            bestList.Add(tmp);
        }
        public void setChart()
        {
            c.Series.Clear();
            c.Series.Add(l);
            c.Series[l].ChartType = SeriesChartType.Line;
            c.Series[l].Color = Color.Red;
            c.Series[l].BorderWidth = 2;
            c.Series[l].YValueType = ChartValueType.Double;
        }

        public void draw(int x, double y)
        {
            c.Series[l].Points.Add(new DataPoint(x, y));
        }
    }
}