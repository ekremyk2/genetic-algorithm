using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace GeneticsAlgoritm
{
    public class ChartDraw
    {
        public void Draw(List<double> list, Chart chart, string line, Color color)
        {
            chart.Series.Add(line);
            for (int i = 1; i < list.Count; i++)
            {
                chart.Series[line].Points.Add(new DataPoint(i, list[i]));
            }

            chart.Series[line].ChartType = SeriesChartType.Line;
            chart.Series[line].Color = color;
            chart.Series[line].BorderWidth = 2;
            chart.Series[line].YValueType = ChartValueType.Double;
        }
    }
}